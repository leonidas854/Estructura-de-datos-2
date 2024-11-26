using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    public class PermisoRol
    {
        public int ID_Rol { get; set; }
        public int ID_Controlador { get; set; }
        public string Permiso { get; set; }

        public PermisoRol(int iD_Rol, int iD_Controlador, string permiso)
        {
            ID_Rol = iD_Rol;
            ID_Controlador = iD_Controlador;
            Permiso = permiso;
        }
    }

}
