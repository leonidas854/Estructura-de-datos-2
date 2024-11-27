using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Servicios
{
   class ProductosServices
    {
     
    public static ArbolRN<int, Producto> arbolProductos = new ArbolRN<int, Producto>();

        
        public static void AgregarProducto(Producto producto)
        {
            if (producto == null)
            {
                throw new ArgumentNullException(nameof(producto), "El producto no puede ser nulo.");
            }

            if (!arbolProductos.Contiene(producto.ID_Producto))
            {
                arbolProductos.Insertar(producto.ID_Producto, producto);
            }
            else
            {
                throw new InvalidOperationException($"El producto con ID {producto.ID_Producto} ya existe.");
            }
        }

       
        public static IEnumerable<Producto> ObtenerProductos()
        {
            return arbolProductos.RecorridoAmplitud();
        }

      
        public static Producto BuscarProductoPorId(int id)
        {
            var producto = arbolProductos.GetValorPorLlave(id);
            if (producto == null)
            {
                throw new KeyNotFoundException($"No se encontró ningún producto con ID {id}.");
            }
            return producto;
        }

      
        public static bool EliminarProductoPorId(int id)
        {
            if (arbolProductos.Contiene(id))
            {
                arbolProductos.Eliminar(id);
                return true;
            }
            return false;
        }

       
        public static void EditarProducto(int id, string nuevoNombre, string nuevaDescripcion, int nuevaCantidadTotal, decimal nuevoPrecioCosto)
        {
            var producto = BuscarProductoPorId(id);
            if (producto != null)
            {
                producto.Nombre = nuevoNombre ?? throw new ArgumentNullException(nameof(nuevoNombre));
                producto.Descripcion = nuevaDescripcion ?? throw new ArgumentNullException(nameof(nuevaDescripcion));
                producto.Cantidad_Total = nuevaCantidadTotal;
                producto.Precio_Costo = nuevoPrecioCosto;
            }
            else
            {
                throw new InvalidOperationException($"No se encontró ningún producto con ID {id} para editar.");
            }
        }
    }
}
