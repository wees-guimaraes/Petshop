using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Petshop {
    public partial class formServico : Form {


        public formServico() {
            InitializeComponent();
        }


        Controller control = new Controller();

        private void BtIncServ_Click(object sender, EventArgs e) {
            if (txtDescrServ.Text == "") {
                MessageBox.Show("Informe a descrição do serviço");
            } else {
                Controller control = new Controller();
                try {


                    control.registrarServico(txtDescrServ.Text, double.Parse(txtValorServ.Text));
                    if (control.getMensagem() != "") {
                        MessageBox.Show(control.getMensagem());
                    } else {
                        txtDescrServ.Text = "";
                        txtValorServ.Text = "";
                        txtIdServ.Text = "";

                        MessageBox.Show("Serviço registrado com sucesso!");
                        dataGridViewServ.DataSource = control.exibirServicos();
                    }

                } catch (Exception) {
                    MessageBox.Show("Informe o Valor");
                }
            }

        }

        private void BtConsServ_Click(object sender, EventArgs e) {

            Controller control = new Controller();

            if (dataGridViewServ.Visible == false) {
                label5.Visible = true;
                this.dataGridViewServ.Visible = true;

            }

            if (txtConsServ.Text == "")

                try {
                    dataGridViewServ.DataSource = control.exibirServicos();

                } catch (Exception erro) {
                    MessageBox.Show("Erro ao consultar" + erro);

                }

            else {

                try {
                    dataGridViewServ.DataSource = control.buscarServico(txtConsServ.Text);

                } catch (Exception erro) {
                    MessageBox.Show("Erro ao consultar " + erro);

                }


            }



        }

        private void dataGridViewServ_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                DataGridViewRow row = this.dataGridViewServ.Rows[e.RowIndex];

                if (e.ColumnIndex != dataGridViewServ.Columns["EditarServ"].Index) {
                    txtDescrServ.Text = row.Cells["Serv"].Value.ToString();
                    txtValorServ.Text = row.Cells["ValorServ"].Value.ToString();
                }




                //Excluir

                if (e.ColumnIndex == dataGridViewServ.Columns["ExcluirServ"].Index) {

                    txtIdServ.Text = row.Cells["IDServ"].Value.ToString();
                    txtDescrServ.Text = row.Cells["Serv"].Value.ToString();
                    txtValorServ.Text = row.Cells["ValorServ"].Value.ToString();

                    Controller control = new Controller();
                    control.deletarServico(int.Parse(txtIdServ.Text));
                    dataGridViewServ.DataSource = control.exibirServicos();

                    txtDescrServ.Text = "";
                    txtValorServ.Text = "";
                    txtIdServ.Text = "";

                    MessageBox.Show("Serviço excluído com sucesso!");

                }

                //Editar

                if (e.ColumnIndex == dataGridViewServ.Columns["EditarServ"].Index) {


                    txtIdServ.Text = row.Cells["IDServ"].Value.ToString();


                    Controller control = new Controller();
                    try {


                        control.editarServico(txtDescrServ.Text, double.Parse(txtValorServ.Text), int.Parse(txtIdServ.Text));
                        dataGridViewServ.DataSource = control.exibirServicos();

                        txtDescrServ.Text = "";
                        txtValorServ.Text = "";
                        txtIdServ.Text = "";

                        MessageBox.Show("Serviço alterado com sucesso!");
                    } catch (Exception) {
                        MessageBox.Show("Informe o valor");
                    }

                }

            } catch (Exception) {
            }


        }

    }

}
