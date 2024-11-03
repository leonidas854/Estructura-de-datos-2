using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio
{
    internal class Nodo_permisos_rol
    {
        int id_rol;
        int id_controlador;
        string permiso;
        Nodo_permisos_rol enlace_permisos;

        public Nodo_permisos_rol(int id_rol, int id_controlador, string permiso)
        {
            this.id_rol = id_rol;
            this.id_controlador = id_controlador;
            this.permiso = permiso;
            this.enlace_permisos = null;
        }

        public int Id_rol { get => id_rol; set => id_rol = value; }
        public int Id_controlador { get => id_controlador; set => id_controlador = value; }
        public string Permiso { get => permiso; set => permiso = value; }
        internal Nodo_permisos_rol Enlace_permisos { get => enlace_permisos; set => enlace_permisos = value; }
    }
}
