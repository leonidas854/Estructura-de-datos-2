using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    class Movimiento_Inventario
    {
        string id_movimiento;
        string id_prod;
        string id_local;
        string id_usuario;
        string tipo_mov;
        string cantidad_movida;
        DateTime fecha_mov;
        Movimiento_Inventario enlace_mov;

        public Movimiento_Inventario(string id_movimiento, string id_prod, string id_local, string id_usuario, string tipo_mov, string cantidad_movida, DateTime fecha_mov)
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

        public string Id_movimiento { get => id_movimiento; set => id_movimiento = value; }
        public string Id_prod { get => id_prod; set => id_prod = value; }
        public string Id_local { get => id_local; set => id_local = value; }
        public string Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Tipo_mov { get => tipo_mov; set => tipo_mov = value; }
        public string Cantidad_movida { get => cantidad_movida; set => cantidad_movida = value; }
        public DateTime Fecha_mov { get => fecha_mov; set => fecha_mov = value; }
        internal Movimiento_Inventario Enlace_mov { get => enlace_mov; set => enlace_mov = value; }
    }
}
