using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio
{
    internal class Nodo_mov_inventario
    {
        int id_movimiento;
        int id_prod;
        int id_local;
        int id_usuario;
        string tipo_mov;
        string cantidad_movida;
        DateTime fecha_mov;
        Nodo_mov_inventario enlace_mov;

        public Nodo_mov_inventario(int id_movimiento, int id_prod, int id_local, int id_usuario, string tipo_mov, string cantidad_movida, DateTime fecha_mov)
        {
            this.id_movimiento = id_movimiento;
            this.id_prod = id_prod;
            this.id_local = id_local;
            this.id_usuario = id_usuario;
            this.tipo_mov = tipo_mov;
            this.cantidad_movida = cantidad_movida;
            this.fecha_mov = fecha_mov;
            this.enlace_mov = null;
        }

        public int Id_movimiento { get => id_movimiento; set => id_movimiento = value; }
        public int Id_prod { get => id_prod; set => id_prod = value; }
        public int Id_local { get => id_local; set => id_local = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Tipo_mov { get => tipo_mov; set => tipo_mov = value; }
        public string Cantidad_movida { get => cantidad_movida; set => cantidad_movida = value; }
        public DateTime Fecha_mov { get => fecha_mov; set => fecha_mov = value; }
        internal Nodo_mov_inventario Enlace_mov { get => enlace_mov; set => enlace_mov = value; }
    }
}
