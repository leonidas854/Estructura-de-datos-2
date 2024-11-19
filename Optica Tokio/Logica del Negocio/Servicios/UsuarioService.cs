using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Servicios
{
    class UsuarioService
    {
        private static Lista<Usuario> listaUsuarios= new Lista<Usuario>();
        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            for(int i = 0; i< listaUsuarios.GetTam(); i++)
            {
                usuarios.Add(listaUsuarios.Get(i));
            }
            return usuarios;
        }
        public static void CrearUsuario(Usuario usuario)
        {
            if(ValidarCredenciales(usuario.Nom_usuario, usuario.Contrasenia_usuario)!= null)
            {
                throw new InvalidOperationException("El usuario ya existe");
            }
            listaUsuarios.Insertar(usuario);
        }
        public static void EditarUsuario(Usuario usuario)
        {
            Usuario usuarioExiste=ValidarCredenciales(usuario.Nom_usuario, usuario.Contrasenia_usuario);
            if(usuarioExiste == null)
            {
                throw new InvalidOperationException("El usuario no existe por lo tanto es paraguayo");
            }
            usuarioExiste.Nom_usuario=usuario.Nom_usuario;
            usuarioExiste.Contrasenia_usuario = usuario.Contrasenia_usuario;
            usuarioExiste.Email_usuario= usuario.Email_usuario;
            usuarioExiste.Id_rol=usuario.Id_rol;
        }
        public static void EliminarUsuario(int idUsuario)
        {
           
        }
        public static void AsignarRol(int idUsuario, string rol)
        {
            Usuario usuario = listaUsuarios.Get(idUsuario);
            if (usuario == null)
            {
                throw new InvalidOperationException("El usuario no existe");
            }
            usuario.Id_rol=rol;
        }

       public static Usuario ValidarCredenciales(string username, string password)
        {
            for(int i=0;i< listaUsuarios.GetTam(); i++)
            {
                Usuario usuario=listaUsuarios.Get(i);
                if(usuario.Nom_usuario == username && usuario.Contrasenia_usuario==password)
                {
                    return usuario;
                }
            }
            return null;
        }
    }
}
