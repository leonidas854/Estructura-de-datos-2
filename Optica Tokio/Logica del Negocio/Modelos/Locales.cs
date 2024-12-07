using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    public class Local
    {
        public int ID_Local { get; set; }
        public string Nombre_Local { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Responsable { get; set; }

        public Local(int iD_Local, string nombre_Local, string direccion, string telefono, string responsable)
        {
            ID_Local = iD_Local;
            Nombre_Local = nombre_Local;
            Direccion = direccion;
            Telefono = telefono;
            Responsable = responsable;
        }
        public Local() { }

    }

}
