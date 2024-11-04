using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    class Permisos_Rol
    {
        string id_rol;
        string id_controlador;
        string permiso;
        Permisos_Rol enlace_permisos;

        public Permisos_Rol(string id_rol, string id_controlador, string permiso)
        {
            this.id_rol = id_rol;
            this.id_controlador = id_controlador;
            this.permiso = permiso;
            this.enlace_permisos = null;
        }

        public string Id_rol { get => id_rol; set => id_rol = value; }
        public string Id_controlador { get => id_controlador; set => id_controlador = value; }
        public string Permiso { get => permiso; set => permiso = value; }
        internal Permisos_Rol Enlace_permisos { get => enlace_permisos; set => enlace_permisos = value; }
    }
}
