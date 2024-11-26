using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Servicios
{
    public class MovimientoServices
    {
        public static Cola<MovimientoInventario> movimientos = new Cola<MovimientoInventario>();

        // Método para registrar un nuevo movimiento
        public void RegistrarMovimiento(MovimientoInventario movimiento)
        {
            if (movimiento == null)
            {
                throw new ArgumentException("El movimiento no puede ser nulo.");
            }
            movimientos.Encolar(movimiento);
        }

        // Método para obtener todos los movimientos
        public Cola<MovimientoInventario> ObtenerMovimientos()
        {
            return movimientos;
        }

        // Método para obtener el próximo movimiento (FIFO)
        public MovimientoInventario ObtenerProximoMovimiento()
        {
            if (movimientos.EstaVacio())
            {
                throw new InvalidOperationException("No hay movimientos en la cola.");
            }
            return movimientos.Desencolar();
        }

        // Método para buscar movimientos por producto
        public Lista<MovimientoInventario> BuscarMovimientosPorProducto(int idProducto)
        {
            var resultados = new Lista<MovimientoInventario>();
            foreach (var movimiento in movimientos)
            {
                if (movimiento.ID_Producto == idProducto)
                {
                    resultados.Insertar(movimiento);
                }
            }
            return resultados;
        }

        // Método para buscar movimientos por local
        public Lista<MovimientoInventario> BuscarMovimientosPorLocal(int idLocal)
        {
            var resultados = new Lista<MovimientoInventario>();
            foreach (var movimiento in movimientos)
            {
                if (movimiento.ID_Local == idLocal)
                {
                    resultados.Insertar(movimiento);
                }
            }
            return resultados;
        }

        // Método para buscar movimientos por usuario
        public Lista<MovimientoInventario> BuscarMovimientosPorUsuario(int idUsuario)
        {
            var resultados = new Lista<MovimientoInventario>();
            foreach (var movimiento in movimientos)
            {
                if (movimiento.ID_Usuario == idUsuario)
                {
                    resultados.Insertar(movimiento);
                }
            }
            return resultados;
        }

        // Método para listar movimientos por tipo (entrada/salida)
        public Lista<MovimientoInventario> ListarMovimientosPorTipo(string tipoMovimiento)
        {
            var resultados = new Lista<MovimientoInventario>();
            foreach (var movimiento in movimientos)
            {
                if (movimiento.Tipo_Movimiento.Equals(tipoMovimiento, StringComparison.OrdinalIgnoreCase))
                {
                    resultados.Insertar(movimiento);
                }
            }
            return resultados;
        }
    }
}
