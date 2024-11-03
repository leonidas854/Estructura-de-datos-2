using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio
{
    internal class Nodo_inventario_local
    {
        int id_invent;
        int id_prod;
        int id_local;
        int cantidad_invent;
        DateTime fecha_act_invent;
        Nodo_inventario_local enlace_inventario;

        public Nodo_inventario_local(int id_invent, int id_prod, int id_local, int cantidad_invent, DateTime fecha_act_invent)
        {
            this.id_invent = id_invent;
            this.id_prod = id_prod;
            this.id_local = id_local;
            this.cantidad_invent = cantidad_invent;
            this.fecha_act_invent = fecha_act_invent;
            this.enlace_inventario = null;
        }

        public int Id_invent { get => id_invent; set => id_invent = value; }
        public int Id_prod { get => id_prod; set => id_prod = value; }
        public int Id_local { get => id_local; set => id_local = value; }
        public int Cantidad_invent { get => cantidad_invent; set => cantidad_invent = value; }
        public DateTime Fecha_act_invent { get => fecha_act_invent; set => fecha_act_invent = value; }
        internal Nodo_inventario_local Enlace_inventario { get => enlace_inventario; set => enlace_inventario = value; }
    }
}
