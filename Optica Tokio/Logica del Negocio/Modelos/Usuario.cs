using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    class Usuario
    {
        string id_usuario;
        string nom_usuario;
        string contrasenia_usuario;
        string email_usuario;
        string id_rol;
        string fecha_creacion;
        string foto;
        Usuario enlace_usuario;

        public Usuario(string id_usuario, string nom_usuario, string contrasenia_usuario, string email_usuario, string id_rol, string fecha_creacion, string foto)
        {
            this.id_usuario = id_usuario;
            this.nom_usuario = nom_usuario;
            this.contrasenia_usuario = contrasenia_usuario;
            this.email_usuario = email_usuario;
            this.id_rol = id_rol;
            this.fecha_creacion = fecha_creacion;
            this.foto = foto;
            this.enlace_usuario = null;
        }

        public string Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nom_usuario { get => nom_usuario; set => nom_usuario = value; }
        public string Contrasenia_usuario { get => contrasenia_usuario; set => contrasenia_usuario = value; }
        public string Email_usuario { get => email_usuario; set => email_usuario = value; }
        public string Id_rol { get => id_rol; set => id_rol = value; }
        public string Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public string Foto { get => foto; set => foto = value; }
        internal Usuario Enlace_usuario { get => enlace_usuario; set => enlace_usuario = value; }
    }
}
