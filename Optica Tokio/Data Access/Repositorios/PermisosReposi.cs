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
    public class PermisosReposi:BaseRepository
    {
        public Lista<PermisoRol> CargarPermisos()
        {
            var listaPermisos = new Lista<PermisoRol>();
            string query = "SELECT * FROM permisos_rol";

            try
            {
                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var permiso = new PermisoRol(
                            reader.GetInt32(0), // ID_Rol
                            reader.GetInt32(1), // ID_Controlador
                            reader.GetString(2)  // Permiso
                        );
                        listaPermisos.Insertar(permiso);
                    }
                }
            }
            finally
            {
                CerrarConexion();
            }

            return listaPermisos;
        }

        public void GuardarPermisos(Lista<PermisoRol> listaPermisos)
        {
            string query = "INSERT INTO permisos_rol (id_rol, id_controlador, permiso) " +
                           "VALUES (@ID_Rol, @ID_Controlador, @Permiso)";
            try
            {
                AbrirConexion();
                foreach (var permiso in listaPermisos)
                {
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("ID_Rol", permiso.ID_Rol);
                        command.Parameters.AddWithValue("ID_Controlador", permiso.ID_Controlador);
                        command.Parameters.AddWithValue("Permiso", permiso.Permiso);
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
            string query = "DELETE FROM permisos_rol";
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
