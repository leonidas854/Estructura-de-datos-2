using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    public class Controlador
    {
        public int ID_Controlador { get; set; }
        public string Nombre_Controlador { get; set; }
        public string Descripcion { get; set; }

        public Controlador(int iD_Controlador, string nombre_Controlador, string descripcion)
        {
            ID_Controlador = iD_Controlador;
            Nombre_Controlador = nombre_Controlador;
            Descripcion = descripcion;
        }
    }

}
