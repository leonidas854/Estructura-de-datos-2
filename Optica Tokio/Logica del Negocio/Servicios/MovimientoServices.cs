using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Servicios
{
    internal class MovimientoServices
    {
        private int idProducto;
        private int cantidad;
        private int idUsuario;
        private int idLocal;
        private DateTime fecha;
        private string comentarios;

        public MovimientoServices(int idProducto, int cantidad, int idUsuario, int idLocal, DateTime fecha, string comentarios)
        {
            this.idProducto = idProducto;
            this.cantidad = cantidad;
            this.idUsuario = idUsuario;
            this.idLocal = idLocal;
            this.fecha = fecha;
            this.comentarios = comentarios;
        }
        public MovimientoServices()
        {
            this.idProducto = 0;
            this.cantidad = 0;
            this.idUsuario = 0;
            this.idLocal = 0;
            this.fecha = DateTime.Now;
            this.comentarios = "";
        }

        private void registrarSalida(int idProducto, int cantidad, int idUsuario, int idLocal)
        {

        }
    }
}
