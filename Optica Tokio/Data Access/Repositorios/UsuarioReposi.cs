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
    public class UsuarioReposi:BaseRepository
    {
        public Lista<Usuario> CargarUsuarios()
        {
            var listaUsuarios = new Lista<Usuario>();
            string query = "SELECT * FROM usuarios";

            try
            {
                var rolPredeterminado = ObtenerRolPredeterminado();
                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var usuario = new Usuario(
                            reader.GetInt32(0), // ID_Usuario
                            reader.GetString(1), // Nombre_Usuario
                            reader.GetString(2), // Contraseña
                            reader.GetString(3), // Correo
                            reader.IsDBNull(4) ? rolPredeterminado : reader.GetInt32(4), // ID_Rol
                            reader.GetDateTime(5), // Fecha_Creacion
                            reader["foto"] as byte[] // Foto
                        );
                        listaUsuarios.Insertar(usuario);
                    }
                }
            }
            finally
            {
                CerrarConexion();
            }

            return listaUsuarios;
        }
        private int ObtenerRolPredeterminado()
        {
       
            return 1; 
        }


        public void GuardarUsuarios(Lista<Usuario> listaUsuarios)
        {
            string query = "INSERT INTO usuarios (id_usuario, nombre_usuario, contrasena, correo, id_rol, fecha_creacion, foto) " +
                           "VALUES (@ID, @Nombre, @Contrasena, @Correo, @Rol, @Fecha, @Foto)";
            try
            {
                AbrirConexion();
                foreach (var usuario in listaUsuarios)
                {
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("ID", usuario.ID_Usuario);
                        command.Parameters.AddWithValue("Nombre", usuario.Nombre_Usuario);
                        command.Parameters.AddWithValue("Contrasena", usuario.Contrasena);
                        command.Parameters.AddWithValue("Correo", usuario.Correo);
                        command.Parameters.AddWithValue("Rol", usuario.ID_Rol);
                        command.Parameters.AddWithValue("Fecha", usuario.Fecha_Creacion);
                        command.Parameters.AddWithValue("Foto", usuario.Foto == null ? (object)DBNull.Value : usuario.Foto);
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
            string query = "DELETE FROM usuarios";
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
