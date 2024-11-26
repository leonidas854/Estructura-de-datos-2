using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    public class Producto
    {
        public int ID_Producto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad_Total { get; set; }
        public decimal Precio_Costo { get; set; }
        public int ID_Proveedor { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public byte[] Foto { get; set; }
        public decimal Peso { get; set; }
        public decimal Ancho { get; set; }
        public decimal Alto { get; set; }
        public decimal Grosor { get; set; }
        public int ID_Clasificacion { get; set; }

        public Producto(int iD_Producto, string nombre, string descripcion, int cantidad_Total, decimal precio_Costo, int iD_Proveedor, DateTime fecha_Registro, byte[] foto, decimal peso, decimal ancho, decimal alto, decimal grosor, int iD_Clasificacion)
        {
            ID_Producto = iD_Producto;
            Nombre = nombre;
            Descripcion = descripcion;
            Cantidad_Total = cantidad_Total;
            Precio_Costo = precio_Costo;
            ID_Proveedor = iD_Proveedor;
            Fecha_Registro = fecha_Registro;
            Foto = foto;
            Peso = peso;
            Ancho = ancho;
            Alto = alto;
            Grosor = grosor;
            ID_Clasificacion = iD_Clasificacion;
        }

    }

}
