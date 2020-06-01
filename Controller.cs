using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Collections;

namespace Petshop {
    public class Controller : InterfaceConsulta {

        //Atributos:
        private String nome;
        private double valor;
        private String query;
        private String mensagem = "";
        private DataTable dtService = new DataTable();



        //Acessores:

        public DataTable getDtService() {
            return this.dtService;
        }
        public void setDtService(DataTable dtService) {
            this.dtService = dtService;
        }

        public String getNome() {
            return this.nome;
        }

        public void setNome(String nome) {
            this.nome = nome;
        }

        public String getMensagem() {
            return this.mensagem;
        }

        public void setMensagem(String mensagem) {
            this.mensagem = mensagem;
        }

        public double getValor() {
            return this.valor;
        }

        public void setValor(double valor) {
            this.valor = valor;
        }



        //Objetos:
        MySqlCommand cmd = new MySqlCommand();
        Conexao conexao = new Conexao();
        public DataSet ds = new DataSet();
        MySqlDataAdapter dataAdapter;
        DataTable table = new DataTable();







        //**********          Métodos                  ******************//




        //Exibir Tabela
        public void exibirTabela(long cpf) {
            try {

                MySqlCommand cmd = new MySqlCommand("Select * from cliente WHERE CPF = @CPF", conexao.conectar());
                cmd.Parameters.AddWithValue("@CPF", cpf);

                MySqlDataReader consulta = cmd.ExecuteReader();

                if (consulta.Read()) {
                    setNome(consulta["nomeCli"].ToString());

                }
            } catch (MySqlException e) {
                throw e;
            }

        }

        //Listar Animais
        public DataTable listarAnimais(long CPF) {
            DataTable dt = new DataTable();

            query = "select a.nomeAni " +
            "from cliente c join animalxcliente dono " +
            "on c.cpf = dono.cpf " +
            "join animal a " +
            "on dono.idAni = a.idAni " +
            "where c.cpf = " + CPF + " ;";
            cmd = new MySqlCommand(query, conexao.conectar());

            MySqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            DataRow row = dt.NewRow();
            row["nomeAni"] = "Selecione o animal";
            dt.Rows.InsertAt(row, 0);

            conexao.desconectar();

            return dt;
        }


        //Listar Serviços

        public DataTable listarServico() {
            DataTable dt = new DataTable();

            query = "select descr, idServ from servico where flag = 'Ativo';";
            cmd = new MySqlCommand(query, conexao.conectar());

            MySqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            DataRow row = dt.NewRow();
            row["descr"] = "Selecione o serviço";
            dt.Rows.InsertAt(row, 0);
            conexao.desconectar();

            return dt;
        }

        //Consultar Valor

        public void consultaValor(String servico) {
            try {
                query = "select valorServ from servico where descr = '" + servico + "' and flag = 'Ativo';";
                cmd = new MySqlCommand(query, conexao.conectar());

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) {
                    setValor(double.Parse(reader["valorServ"].ToString()));

                }
                conexao.desconectar();
            } catch (MySqlException e) {
                throw e;
            }


        }

        //Inserir Serviço

        public Boolean registrarServico(String descr, double valorServ) {

            try {

                if (valorServ <= 0 || valorServ >= 500.0) {
                    mensagem = "Valor inválido";
                    return false;
                }

            ////////////////////////////////////////////////

            int idAnterior;
            int idPosterior;

            query = "select Max(idServ) id from Servico;";

            cmd = new MySqlCommand(query, conexao.conectar());
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            idAnterior = int.Parse(reader["id"].ToString());


                ////////////////////////////////////////////////

            cmd.CommandText = "INSERT INTO servico (descr, valorServ, flag) values (@descr, @valorServ, @flag)";
            cmd.Parameters.AddWithValue("@descr", descr);
            cmd.Parameters.AddWithValue("@valorServ", valorServ);
            cmd.Parameters.AddWithValue("@flag", "Ativo");
            cmd.Connection = conexao.conectar();
            cmd.ExecuteNonQuery();


                ////////////////////////

                query = "select Max(idServ) idServ from Servico;";

            cmd = new MySqlCommand(query, conexao.conectar());
            MySqlDataReader reader2 = cmd.ExecuteReader();
            reader2.Read();


            idPosterior = int.Parse(reader2["idServ"].ToString());


                conexao.desconectar();
                idAnterior++;

                if (idPosterior == idAnterior) return true;

                else {
                    setMensagem("Foi encontrado uma falha no teste.");
                    return false;

                }


            } catch (MySqlException e) {
                setMensagem("Falha de conexão com o banco: \n" + e);
                return false;
                

            }

            

        }



        //Exibir Serviços
        public Boolean exibirServicos() {
            

            try {
                dataAdapter = new MySqlDataAdapter("SELECT * FROM servico where flag = 'Ativo' ORDER BY descr", 
                    conexao.conectar());

                dataAdapter.Fill(getDtService());


                return true;

            } catch (MySqlException e) {
                setMensagem("Falha de conexão" + e);
                throw e;

            }

        }


        //Buscar Serviços

        public DataTable buscarServico(String descr) {
            cmd.Connection = conexao.conectar();
            DataTable dt = new DataTable();

            try {
                cmd.Parameters.AddWithValue("@descr", descr);
                cmd.CommandText = "SELECT * FROM servico WHERE descr LIKE @descr '%'";
                dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);

                return dt;


            } catch (MySqlException e) {
                setMensagem("Falha de conexão" + e);
                throw e;

            }

        }


        //Deletar Serviços

        public Boolean deletarServico(int id) {
            try {

                int idAnterior, validador;

                query = "select idServ from Servico WHERE idServ = '" + id + "';";

                cmd = new MySqlCommand(query, conexao.conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                idAnterior = int.Parse(reader["idServ"].ToString());

                cmd.Connection = conexao.conectar();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandText = "update servico set flag = 'Excluído' where idServ = @id;";
                cmd.ExecuteNonQuery();
                cmd.Connection = conexao.desconectar();
                setMensagem("Comando realizado com Sucesso!");

                query = "select COUNT(idServ) qtd FROM Servico WHERE idServ = '" + idAnterior + "' and flag = 'Excluído';";

                cmd = new MySqlCommand(query, conexao.conectar());
                MySqlDataReader reader2 = cmd.ExecuteReader();
                reader2.Read();

                validador = int.Parse(reader2["qtd"].ToString());

                if (validador > 0) return true;

                else return false;


            }
            catch (MySqlException) {
                MessageBox.Show("Não é possível excluir serviço");
                return false;

            }

        }


        //Editar Serviços

        public Boolean editarServico(String descAnterior, String descr, double valorServ, int id) {
            try {

                if (valorServ <= 0 || valorServ >= 500.0) {
                    mensagem = "Valor inválido";
                    return false;
                }

                Conexao conexao = new Conexao();

                string descrAnterior;
                string descrPosterior;
                double valorAnterior;
                double valorPosterior;
                int idServ;

                query = "select s.idServ, s.descr, s.valorServ from servico s where s.descr = '" + descAnterior + "' and s.flag = 'Ativo'; ";
                cmd = new MySqlCommand(query, conexao.conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                idServ = int.Parse(reader["idServ"].ToString());
                descrAnterior = reader["descr"].ToString();
                valorAnterior = double.Parse(reader["valorServ"].ToString());
                
                ////////////

                cmd.CommandText = "UPDATE servico SET descr = @descr, valorServ = @valorServ WHERE idServ = @id";

                cmd.Parameters.AddWithValue("@descr", descr);
                cmd.Parameters.AddWithValue("@valorServ", valorServ);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();

                query = "select s.descr, s.valorServ from servico s where s.idServ = " + idServ + ";";

                cmd = new MySqlCommand(query, conexao.conectar());
                MySqlDataReader reader2 = cmd.ExecuteReader();
                reader2.Read();

                descrPosterior = reader2["descr"].ToString();
                valorPosterior = double.Parse(reader2["valorServ"].ToString());

                if (descrAnterior != descrPosterior || valorAnterior != valorPosterior){
                    conexao.desconectar();
                    return true;
                }

                else
                {
                    conexao.desconectar();
                    return false;
                }

                
               } catch (MySqlException e) {
                setMensagem("Falha de conexão");
                throw e;

            }

        }

        public int retornaUltimoId() {
            int ultimoId;
            Conexao conexao = new Conexao();
            query = "Select Max(idServ) id from Servico;";
            cmd = new MySqlCommand(query, conexao.conectar());
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            ultimoId = int.Parse(reader["id"].ToString());
            return ultimoId;
        }

        public void limpaBanco() {
            Conexao conexao = new Conexao();
            query = "UPDATE servico SET flag = 'Excluído' WHERE descr LIKE '%Teste%' OR descr LIKE '%Serviço%' OR descr LIKE '%Editando%'";
            cmd = new MySqlCommand(query, conexao.conectar());
            cmd.ExecuteNonQuery();


        }

        //Gerar  OS

        public void gerarOS(long CPF, int idAni, String[] servicos, double valorTotal) {
            //Inserção
            try {
                DateTime data = new DateTime();
                data = DateTime.Now;
                String dataConvertida;
                dataConvertida = data.ToString("yyyy/MM/dd");
                int OS = 0;

                String valorTotalConvertido = valorTotal.ToString("N", CultureInfo.CreateSpecificCulture("en-US"));

                try {


                    query = "INSERT INTO OS VALUES(default, '" + dataConvertida + "', " + CPF + ", " + idAni + ", " + valorTotalConvertido + ");";


                    cmd = new MySqlCommand(query, conexao.conectar());
                    cmd.ExecuteNonQuery();
                    conexao.desconectar();

                } catch (MySqlException e) {
                    MessageBox.Show("Erro de banco \n" + e);
                }

                //Consulta
                query = "SELECT max(idOS) idOS from OS;";
                cmd = new MySqlCommand(query, conexao.conectar());
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                OS = int.Parse(reader["idOS"].ToString());


                setMensagem("Gerado OS com sucesso. \nSua OS é: " + OS.ToString());
                conexao.desconectar();

                // Inserir Itens na OS
                inserirItem(OS, servicos);
            } catch (Exception) {
                MessageBox.Show("Não há nenhum cliente ou serviço selecionado");
            }


        }

        //Consultar id do animal

        public int consultaIdAnimal(long CPF, String nomeAnimal) {

            int idAnimal;

            query = "select a.idAni " +
                     "from Animal a " +
                     "join animalxcliente dono " +
                     "on a.idAni = dono.idAni " +
                     "join cliente c " +
                     "on c.CPF = dono.CPF " +
                     "where c.CPF = " + CPF + " AND a.nomeAni = '" + nomeAnimal + "';";

            cmd = new MySqlCommand(query, conexao.conectar());
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            idAnimal = int.Parse(reader["idAni"].ToString());

            return idAnimal;
        }

        //Inserir Itens

        public void inserirItem(int idOS, String[] servicos) {
            int i = 0;
            try {
                for (i = 0; i < servicos.Length; i++) {
                    query = "insert into Item " +
                                            "values(" + idOS + ", (select idServ from servico where descr = '" + servicos[i] + "'and flag = 'Ativo')," +
                                            " (select valorServ from servico where descr = '" + servicos[i] + "' and flag = 'Ativo'));";
                    cmd = new MySqlCommand(query, conexao.conectar());
                    cmd.ExecuteNonQuery();
                    conexao.desconectar();
                }
            } catch (Exception) {
                MessageBox.Show("Serviço " + servicos[i] + " está repetido, não será inserido na OS");
            }
        }


        //Consultar OS

        public ArrayList consultarOS(int OS) {
            table = new DataTable();
            ArrayList resultado = new ArrayList();

            query = "select os.dataOS, c.nomeCli, c.CPF, a.nomeAni, a.cor, a.porte, os.valorTotal " +
                "from os " +
                "join cliente c " +
                "on os.CPF = c.CPF " +
                "join animal a " +
                "on os.idAni = a.idAni " +
                "join item i " +
                "on os.idOS = i.idOS " +
                "join servico s " +
                "on s.idServ = i.idServ " +
                "where os.idOS = " + OS + ";";

            try {
                dataAdapter = new MySqlDataAdapter(query, conexao.conectar());
                dataAdapter.Fill(table);

                for (int i = 0; i <= 6; i++) {
                    resultado.Add(table.Rows[0][i].ToString());
                }
                return resultado;
            } catch (Exception) {

                return null;
            }

        }

        //Consultar OS por CPF

        public ArrayList consultarOSporCPF(long cpf) {
            try {
                query = "select idOS from os where CPF = " + cpf + ";";
                table = new DataTable();
                dataAdapter = new MySqlDataAdapter(query, conexao.conectar());
                dataAdapter.Fill(table);
                ArrayList resultado = new ArrayList();
                int contador = table.Rows.Count;
                for (int i = 0; i < contador; i++) {
                    resultado.Add(table.Rows[i][0].ToString());

                }
                if (resultado[0] == "") {
                    return null;
                }
                return resultado;

            } catch (Exception) {
                return null;
            }
        }

        // não implementado
        public ArrayList consultarOS(String dataInicio, String dataFim) {
            DataTable table = new DataTable();
            ArrayList resultado = new ArrayList();

            query = "select os.dataOS, c.nomeCli, c.CPF, a.nomeAni, a.cor, a.porte, os.valorTotal " +
                "from os " +
                "join cliente c " +
                "on os.CPF = c.CPF " +
                "join animal a " +
                "on os.idAni = a.idAni " +
                "join item i " +
                "on os.idOS = i.idOS " +
                "join servico s " +
                "on s.idServ = i.idServ " +
                "where os.idOS = " + dataInicio + ";";
            DataSet dataSet = new DataSet();
            dataAdapter = new MySqlDataAdapter(query, conexao.conectar());
            dataAdapter.Fill(table);

            for (int i = 0; i <= 6; i++) {
                resultado.Add(table.Rows[0][i].ToString());
            }
            return resultado;
        }

        //consultar servicos por OS

        public DataTable consultaServicosPorOS(int OS) {
            table = new DataTable();

            query = "select s.descr Serviço, i.valorItem Valor " +
                "from os " +
                "join item i " +
                "on os.idOS = i.idOS " +
                "join servico s " +
                "on i.idServ = s.idServ " +
                "where os.idOS = " + OS + ";";
            dataAdapter = new MySqlDataAdapter(query, conexao.conectar());
            dataAdapter.Fill(table);


            return table;
        }

        // deletar OS

        public void deletarOS(int OS) {
            try {
                query = "delete from os where idOS = " + OS + ";";
                cmd = new MySqlCommand(query, conexao.conectar());
                cmd.ExecuteNonQuery();
                setMensagem("OS: " + OS + " deletada com sucesso.");

            } catch (Exception e) {
                setMensagem("Erro ao executar o comando! \n\n" + e);
            }
        }


        // PI - Semestre 4

        public bool TestID() {

            int idAnterior;
            int idPosterior;

            query = "select idServ from Servico;";

            cmd = new MySqlCommand(query, conexao.conectar());
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            idAnterior = int.Parse(reader["idServ"].ToString());


            query = "select Max(idServ) from Servico;";

            cmd = new MySqlCommand(query, conexao.conectar());
            MySqlDataReader reader2 = cmd.ExecuteReader();
            reader.Read();

            idPosterior = int.Parse(reader2["idServ"].ToString());

            if (idPosterior > idAnterior) return true;

            else return false;

        }







    } //class
}// namespace
