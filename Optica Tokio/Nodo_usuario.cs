using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio
{
    internal class Nodo_usuario
    {
        int id_usuario;
        string nom_usuario;
        string contrasenia_usuario;
        string email_usuario;
        int id_rol;
        DateTime fecha_creacion;
        byte foto;
        Nodo_usuario enlace_usuario;

        public Nodo_usuario(int id_usuario, string nom_usuario, string contrasenia_usuario, string email_usuario, int id_rol, DateTime fecha_creacion, byte foto)
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

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nom_usuario { get => nom_usuario; set => nom_usuario = value; }
        public string Contrasenia_usuario { get => contrasenia_usuario; set => contrasenia_usuario = value; }
        public string Email_usuario { get => email_usuario; set => email_usuario = value; }
        public int Id_rol { get => id_rol; set => id_rol = value; }
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public byte Foto { get => foto; set => foto = value; }
        internal Nodo_usuario Enlace_usuario { get => enlace_usuario; set => enlace_usuario = value; }
    }
}
