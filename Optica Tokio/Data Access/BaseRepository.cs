using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Configuration;
using System.Windows.Forms;

namespace Optica_Tokio.Static
{
    public abstract class BaseRepository
    {
        static string servidor = "localhost";
        static string bd = "db_optica";
        static string usuario = "postgres";

        static string password = "124875369";

        //static string password = "Andoresux128@";

        static int puerto = 5432;

        string cadena = $"server={servidor};port={puerto};user id={usuario};password={password};database={bd};";

        protected NpgsqlConnection connection;



            public BaseRepository()
            {

                string connectionString = cadena;
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new Exception("La cadena de conexión no está configurada.");
                }
            //MessageBox.Show(cadena);
                connection = new NpgsqlConnection(connectionString);
            }

        protected void AbrirConexion()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al abrir la conexión: " + ex.Message);
            }
        }

        protected void CerrarConexion()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexión: " + ex.Message);
            }
        }

        public void EjecutarConsulta(string query)
        {
            try
            {
                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }



        public NpgsqlConnection ObtenerConexion()
        {
            return connection;
        }
    }
    }


