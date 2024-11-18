using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Configuration;

namespace Optica_Tokio.Static
{
    class coneccion
    {
        private NpgsqlConnection connection;

        public coneccion()
        {
            string connectionString = ConfigurationManager.AppSettings["PostgresConnection"];
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new Exception("La cadena de conexión no está configurada.");
            }
            connection = new NpgsqlConnection(connectionString);
        }

        public void AbrirConexion()
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

        public void CerrarConexion()
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
                using (var command = new NpgsqlCommand(query, connection))
                {
                    AbrirConexion();
                    command.ExecuteNonQuery();
                    CerrarConexion();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la consulta: " + ex.Message);
            }
        }


        public NpgsqlConnection ObtenerConexion()
        {
            return connection;
        }
    }
}

