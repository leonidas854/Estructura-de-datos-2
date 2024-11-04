using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    class Inventacio_Local
    {
        string id_invent;
        string id_prod;
        string id_local;
        string cantidad_invent;
        string fecha_act_invent;
        Inventacio_Local enlace_inventario;

        public Inventacio_Local(string id_invent, string id_prod, string id_local, string cantidad_invent, string fecha_act_invent)
        {
            this.id_invent = id_invent;
            this.id_prod = id_prod;
            this.id_local = id_local;
            this.cantidad_invent = cantidad_invent;
            this.fecha_act_invent = fecha_act_invent;
            this.enlace_inventario = null;
        }

        public string Id_invent { get => id_invent; set => id_invent = value; }
        public string Id_prod { get => id_prod; set => id_prod = value; }
        public string Id_local { get => id_local; set => id_local = value; }
        public string Cantidad_invent { get => cantidad_invent; set => cantidad_invent = value; }
        public string Fecha_act_invent { get => fecha_act_invent; set => fecha_act_invent = value; }
        internal Inventacio_Local Enlace_inventario { get => enlace_inventario; set => enlace_inventario = value; }
    }
}
