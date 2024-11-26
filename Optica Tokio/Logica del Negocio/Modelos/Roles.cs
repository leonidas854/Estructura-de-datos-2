using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    public class Rol
    {
        public int ID_Rol { get; set; }
        public string Nombre_Rol { get; set; }
        public string Descripcion { get; set; }

        public Rol(int iD_Rol, string nombre_Rol, string descripcion)
        {
            ID_Rol = iD_Rol;
            Nombre_Rol = nombre_Rol;
            Descripcion = descripcion;
        }
    }

}
