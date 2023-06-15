using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace AdminEmpleados.DB
{
    internal class conexionDB
    {   
        SqlConnection conexion = new SqlConnection();

        static String servidor = "localhost";
        static String DB = "pruebaDB";
        static String usuario = "postgres";
        static String passw = "postgres";
        static String puerto = "5432";

        String cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + passw + ";" + "database=" + DB + ";";


        public SqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;

                //String query = "INSERT INTO departamento (iddepto, nomdepto) VALUES('125','Nariño') ";


                conexion.Open();
                //NpgsqlCommand comando = new NpgsqlCommand("INSERT INTO departamento (iddepto, nomdepto) VALUES('125','Nariño') ");

                //comando.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Bien");
            }
            catch(NpgsqlException e) {
                MessageBox.Show("paila");
            }

            return conexion;
            
        }






    }
}
