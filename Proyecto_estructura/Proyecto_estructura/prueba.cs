using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Proyecto_estructura
{
    class prueba
    {
        NpgsqlConnection conn = new NpgsqlConnection();
        static String servidor= "localhost";
        static String bd="Prueba";
        static String usuario= "postgres";
        static String password="124875369";
        static String puerto = "5432";

        String cadena = "server=" + servidor +";"+ "port=" + puerto+";"+ "user id=" + usuario +";" + " password=" + password+";"+ "database="+bd + ";" ;

        public NpgsqlConnection Establecido()
        {
            try
            {
                conn.ConnectionString = cadena;
                conn.Open();
                MessageBox.Show("Se conecto");

            }
            catch (NpgsqlException)
            {
                MessageBox.Show("No se conecta");
            }
            return conn;
        }
    }
}
