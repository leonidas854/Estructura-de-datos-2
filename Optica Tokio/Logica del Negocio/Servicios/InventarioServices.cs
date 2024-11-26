using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Servicios
{
    public class InventarioServices
    {
        public static ArbolRN<int, InventarioLocal> inventarioArbol = new ArbolRN<int, InventarioLocal>();

     
        public void AgregarInventario(InventarioLocal inventario)
        {
            if (inventarioArbol.Contiene(inventario.ID_Inventario))
            {
                throw new InvalidOperationException("El inventario con este ID ya existe.");
            }
            inventarioArbol.Insertar(inventario.ID_Inventario, inventario);
        }

      
        public InventarioLocal ObtenerInventarioPorId(int idInventario)
        {
            return inventarioArbol.GetValorPorLlave(idInventario) ?? throw new KeyNotFoundException("El inventario no existe.");
        }

    
        public void EliminarInventarioPorId(int idInventario)
        {
            if (!inventarioArbol.Contiene(idInventario))
            {
                throw new InvalidOperationException("El inventario no existe.");
            }
            inventarioArbol.Eliminar(idInventario);
        }

   
        public void EditarInventario(int idInventario, int nuevaCantidad, DateTime nuevaFechaActualizacion)
        {
            var inventario = ObtenerInventarioPorId(idInventario);
            if (inventario != null)
            {
                inventario.Cantidad = nuevaCantidad;
                inventario.Fecha_Ultima_Actualizacion = nuevaFechaActualizacion;
                inventarioArbol.Insertar(idInventario, inventario); // Actualizar el nodo en el árbol
            }
            else
            {
                throw new InvalidOperationException("El inventario no existe.");
            }
        }

 
        public IEnumerable<InventarioLocal> ListarInventariosAmplitud()
        {
            return inventarioArbol.RecorridoAmplitud();
        }

        // Método para obtener todos los inventarios en un recorrido por profundidad
        public IEnumerable<InventarioLocal> ListarInventariosProfundidad()
        {
            return inventarioArbol.RecorridoPorProfundidad();
        }
    }
}
