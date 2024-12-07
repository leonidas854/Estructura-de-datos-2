using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public int ID_Rol { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public byte[] Foto { get; set; }

        public Usuario(int iD_Usuario, string nombre_Usuario, string contrasena, string correo, int iD_Rol, DateTime fecha_Creacion, byte[] foto)
        {
            ID_Usuario = iD_Usuario;
            Nombre_Usuario = nombre_Usuario;
            Contrasena = contrasena;
            Correo = correo;
            ID_Rol = iD_Rol;
            Fecha_Creacion = fecha_Creacion;
            Foto = foto;
        }
        public Usuario() { }
    }

}
