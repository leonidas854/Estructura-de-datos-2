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
    public class ClasificacionReposi:BaseRepository
    {
        public Lista<Clasificacion> CargarClasificaciones()
        {
            var listaClasificaciones = new Lista<Clasificacion>();
            string query = "SELECT * FROM clasificacion";

            try
            {
                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var clasificacion = new Clasificacion(
                            reader.GetInt32(0), // ID_Clasificacion
                            reader.GetString(1)  // Nombre_Clasificacion
                        );
                        listaClasificaciones.Insertar(clasificacion);
                    }
                }
            }
            finally
            {
                CerrarConexion();
            }

            return listaClasificaciones;
        }

        public void GuardarClasificaciones(Lista<Clasificacion> listaClasificaciones)
        {
            string query = "INSERT INTO clasificacion (id_clasificacion, nombre_clasificacion) " +
                           "VALUES (@ID, @Nombre)";
            try
            {
                AbrirConexion();
                foreach (var clasificacion in listaClasificaciones)
                {
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("ID", clasificacion.ID_Clasificacion);
                        command.Parameters.AddWithValue("Nombre", clasificacion.Nombre_Clasificacion);
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
            string query = "DELETE FROM clasificacion";
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
