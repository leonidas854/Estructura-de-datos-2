using Optica_Tokio.Data_Access.Repositorios;
using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Servicios
{
    class ProvedoresServices
    {
      public static  ArbolRN<int, Proveedor> arbolProveedores = new ArbolRN<int, Proveedor>();

   
        public void AgregarProveedor(Proveedor proveedor)
        {
            if (arbolProveedores.Contiene(proveedor.ID_Proveedor))
            {
                throw new InvalidOperationException("El proveedor con este ID ya existe.");
            }
            arbolProveedores.Insertar(proveedor.ID_Proveedor, proveedor);
        }

   
        public Proveedor ObtenerProveedorPorId(int idProveedor)
        {
            return arbolProveedores.GetValorPorLlave(idProveedor) ?? throw new KeyNotFoundException("El proveedor no existe.");
        }


        public void EliminarProveedorPorId(int idProveedor)
        {
            if (!arbolProveedores.Contiene(idProveedor))
            {
                throw new InvalidOperationException("El proveedor no existe.");
            }
            arbolProveedores.Eliminar(idProveedor);
        }

   
        public void EditarProveedor(int idProveedor, string nuevoNombre, string nuevoContacto, string nuevoTelefono, string nuevoEmail, string nuevaDireccion, string nuevasCondiciones)
        {
            var proveedor = ObtenerProveedorPorId(idProveedor);
            if (proveedor != null)
            {
                proveedor.Nombre = nuevoNombre;
                proveedor.Contacto = nuevoContacto;
                proveedor.Telefono = nuevoTelefono;
                proveedor.Email = nuevoEmail;
                proveedor.Direccion = nuevaDireccion;
                proveedor.Condiciones_Entrega = nuevasCondiciones;


                arbolProveedores.Insertar(idProveedor, proveedor);
            }
            else
            {
                throw new InvalidOperationException("El proveedor no existe.");
            }
        }


        public IEnumerable<Proveedor> ListarProveedoresAmplitud()
        {
            return arbolProveedores.RecorridoAmplitud();
        }

        public IEnumerable<Proveedor> ListarProveedoresProfundidad()
        {
            return arbolProveedores.RecorridoPorProfundidad();
        }
    }
}
