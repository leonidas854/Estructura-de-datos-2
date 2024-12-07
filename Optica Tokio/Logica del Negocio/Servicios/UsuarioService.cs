using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Servicios
{
    public class UsuarioService
    {
       public static Lista<Usuario> listaUsuarios = new Lista<Usuario>();


        public static List<Usuario> ListarUsuarios()
        {
            if (listaUsuarios == null || listaUsuarios.GetTam() == 0)
            {
                throw new InvalidOperationException("No hay usuarios disponibles.");
            }

            List<Usuario> usuarios = new List<Usuario>();
            for (int i = 0; i < listaUsuarios.GetTam(); i++)
            {
                usuarios.Add(listaUsuarios.Get(i));
            }
            return usuarios;
        }


        public static void CrearUsuario(Usuario usuario)
        {
            if (ValidarCredenciales(usuario.Nombre_Usuario, usuario.Contrasena) != null)
            {
                throw new InvalidOperationException("El usuario ya existe.");
            }
            listaUsuarios.Insertar(usuario);
        }

    
        public static void EditarUsuario(Usuario usuario)
        {
            Usuario usuarioExistente = BuscarUsuarioPorId(usuario.ID_Usuario);
            if (usuarioExistente == null)
            {
                throw new InvalidOperationException("El usuario no existe.");
            }
            usuarioExistente.Nombre_Usuario = usuario.Nombre_Usuario;
            usuarioExistente.Contrasena = usuario.Contrasena;
            usuarioExistente.Correo = usuario.Correo;
            usuarioExistente.ID_Rol = usuario.ID_Rol;
            usuarioExistente.Foto = usuario.Foto;
        }

      
        public static void EliminarUsuario(int idUsuario)
        {
            Usuario usuario = BuscarUsuarioPorId(idUsuario);
            if (usuario == null)
            {
                throw new InvalidOperationException("El usuario no existe.");
            }
            listaUsuarios.Eliminar(usuario);
        }

     
        public static void AsignarRol(int idUsuario, int idRol)
        {
            Usuario usuario = BuscarUsuarioPorId(idUsuario);
            if (usuario == null)
            {
                throw new InvalidOperationException("El usuario no existe.");
            }
            usuario.ID_Rol = idRol;
        }

      
        public static Usuario ValidarCredenciales(string username, string password)
        {
            for (int i = 0; i < listaUsuarios.GetTam(); i++)
            {
                Usuario usuario = listaUsuarios.Get(i);
                if (usuario.Nombre_Usuario == username && usuario.Contrasena == password)
                {
                    return usuario;
                }
            }
            return null;
        }

     
        private static Usuario BuscarUsuarioPorId(int idUsuario)
        {
            for (int i = 0; i < listaUsuarios.GetTam(); i++)
            {
                Usuario usuario = listaUsuarios.Get(i);
                if (usuario.ID_Usuario == idUsuario)
                {
                    return usuario;
                }
            }
            return null;
        }
    }
}
