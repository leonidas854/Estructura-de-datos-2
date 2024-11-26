using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    public class InventarioLocal
    {
        public int ID_Inventario { get; set; }
        public int ID_Producto { get; set; }
        public int ID_Local { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha_Ultima_Actualizacion { get; set; }

        public InventarioLocal(int iD_Inventario, int iD_Producto, int iD_Local, int cantidad, DateTime fecha_Ultima_Actualizacion)
        {
            ID_Inventario = iD_Inventario;
            ID_Producto = iD_Producto;
            ID_Local = iD_Local;
            Cantidad = cantidad;
            Fecha_Ultima_Actualizacion = fecha_Ultima_Actualizacion;
        }
    }

}
