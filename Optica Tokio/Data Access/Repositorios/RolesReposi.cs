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
    public class RolesReposi:BaseRepository
    {
        public Lista<Rol> CargarRoles()
        {
            var listaRoles = new Lista<Rol>();
            string query = "SELECT * FROM roles";

            try
            {
                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var rol = new Rol(
                            reader.GetInt32(0), // ID_Rol
                            reader.GetString(1), // Nombre_Rol
                            reader.GetString(2)  // Descripción
                        );
                        listaRoles.Insertar(rol);
                    }
                }
            }
            finally
            {
                CerrarConexion();
            }

            return listaRoles;
        }

        public void GuardarRoles(Lista<Rol> listaRoles)
        {
            string query = "INSERT INTO roles (id_rol, nombre_rol, descripcion) " +
                           "VALUES (@ID, @Nombre, @Descripcion)";
            try
            {
                AbrirConexion();
                foreach (var rol in listaRoles)
                {
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("ID", rol.ID_Rol);
                        command.Parameters.AddWithValue("Nombre", rol.Nombre_Rol);
                        command.Parameters.AddWithValue("Descripcion", rol.Descripcion);
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
            string query = "DELETE FROM roles";
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
