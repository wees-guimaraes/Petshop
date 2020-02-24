using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;

namespace Petshop {
    public class Conexao {


        //Método para conectar.

        public MySqlConnection conector;





        public MySqlConnection conectar() {
            try {
                conector = new MySqlConnection("Persist Security Info=True; " +
                                                       "server=localhost;" +
                                                       "database=petshop_pi;" +
                                                       "uid=root;");
                                                       



                if (conector.State == System.Data.ConnectionState.Closed) {
                    conector.Open();
                }
                return conector;


            } catch (MySqlException e) {
                throw e;
            }



        }
        //desconectar
        public MySqlConnection desconectar() {
            if (conector.State == System.Data.ConnectionState.Open) {
                conector.Close();

            }
            return conector;
        }

    }
}
