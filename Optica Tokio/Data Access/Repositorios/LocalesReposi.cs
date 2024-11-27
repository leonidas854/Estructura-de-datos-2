using Npgsql;
using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using Optica_Tokio.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Data_Access.Repositorios
{
   public class LocalesReposi:BaseRepository
    {
        public Lista<Local> CargarLocales()
        {
            var listaLocales = new Lista<Local>();
            string query = "SELECT * FROM locales";

            try
            {
                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var local = new Local(
                            reader.GetInt32(0), // ID_Local
                            reader.GetString(1), // Nombre_Local
                            reader.GetString(2), // Dirección
                            reader.GetString(3), // Teléfono
                            reader.GetString(4)  // Responsable
                        );
                        listaLocales.Insertar(local);
                    }
                }
            }
            finally
            {
                CerrarConexion();
            }

            return listaLocales;
        }

        public void GuardarLocales(Lista<Local> listaLocales)
        {
            string query = "INSERT INTO locales (id_local, nombre_local, direccion, telefono, responsable) " +
                           "VALUES (@ID, @Nombre, @Direccion, @Telefono, @Responsable)";
            try
            {
                AbrirConexion();
                foreach (var local in listaLocales)
                {
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("ID", local.ID_Local);
                        command.Parameters.AddWithValue("Nombre", local.Nombre_Local);
                        command.Parameters.AddWithValue("Direccion", local.Direccion);
                        command.Parameters.AddWithValue("Telefono", local.Telefono);
                        command.Parameters.AddWithValue("Responsable", local.Responsable);
                        command.ExecuteNonQuery();
                    }
                }
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void LimpiarTabla()
        {
            string query = "DELETE FROM locales";
            try
            {
                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}

