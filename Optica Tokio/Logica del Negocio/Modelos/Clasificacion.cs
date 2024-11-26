using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    public class Clasificacion
    {
        public int ID_Clasificacion { get; set; }
        public string Nombre_Clasificacion { get; set; }

        public Clasificacion(int iD_Clasificacion, string nombre_Clasificacion)
        {
            ID_Clasificacion = iD_Clasificacion;
            Nombre_Clasificacion = nombre_Clasificacion;
        }
    }

}
