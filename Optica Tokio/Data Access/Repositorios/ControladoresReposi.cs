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
    public class ControladoresReposi :BaseRepository
    {
        public Lista<Controlador> CargarControladores()
        {
            var listaControladores = new Lista<Controlador>();
            string query = "SELECT * FROM controladores";

            try
            {
                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var controlador = new Controlador(
                            reader.GetInt32(0), // ID_Controlador
                            reader.GetString(1), // Nombre_Controlador
                            reader.GetString(2)  // Descripción
                        );
                        listaControladores.Insertar(controlador);
                    }
                }
            }
            finally
            {
                CerrarConexion();
            }

            return listaControladores;
        }

        public void GuardarControladores(Lista<Controlador> listaControladores)
        {
            string query = "INSERT INTO controladores (id_controlador, nombre_controlador, descripcion) " +
                           "VALUES (@ID, @Nombre, @Descripcion)";
            try
            {
                AbrirConexion();
                foreach (var controlador in listaControladores)
                {
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("ID", controlador.ID_Controlador);
                        command.Parameters.AddWithValue("Nombre", controlador.Nombre_Controlador);
                        command.Parameters.AddWithValue("Descripcion", controlador.Descripcion);
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
            string query = "DELETE FROM controladores";
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
