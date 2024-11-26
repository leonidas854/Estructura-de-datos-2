using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    public class MovimientoInventario
    {
        public int ID_Movimiento { get; set; }
        public int ID_Producto { get; set; }
        public int ID_Local { get; set; }
        public string Tipo_Movimiento { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public int ID_Usuario { get; set; }
        public string Comentarios { get; set; }

        public MovimientoInventario(int iD_Movimiento, int iD_Producto, int iD_Local, string tipo_Movimiento, int cantidad, DateTime fecha, int iD_Usuario, string comentarios)
        {
            ID_Movimiento = iD_Movimiento;
            ID_Producto = iD_Producto;
            ID_Local = iD_Local;
            Tipo_Movimiento = tipo_Movimiento;
            Cantidad = cantidad;
            Fecha = fecha;
            ID_Usuario = iD_Usuario;
            Comentarios = comentarios;
        }
    }

}
