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
   public class ProvedoresServices
    {
      public static  ArbolRN<int, Proveedor> arbolProveedores = new ArbolRN<int, Proveedor>();

   
        public static  void AgregarProveedor(Proveedor proveedor)
        {
            if (arbolProveedores.Contiene(proveedor.ID_Proveedor))
            {
                throw new InvalidOperationException("El proveedor con este ID ya existe.");
            }
            arbolProveedores.Insertar(proveedor.ID_Proveedor, proveedor);
        }

   
        public static Proveedor ObtenerProveedorPorId(int idProveedor)
        {
            return arbolProveedores.GetValorPorLlave(idProveedor) ?? throw new KeyNotFoundException("El proveedor no existe.");
        }


        public static void EliminarProveedorPorId(int idProveedor)
        {
            if (!arbolProveedores.Contiene(idProveedor))
            {
                throw new InvalidOperationException("El proveedor no existe.");
            }
            arbolProveedores.Eliminar(idProveedor);
        }

   
        public static void EditarProveedor(Proveedor proveedorr)
        {
            var proveedor = ObtenerProveedorPorId(proveedorr.ID_Proveedor);
            if (proveedor != null)
            {
                proveedor.Nombre = proveedorr.Nombre;
                proveedor.Contacto = proveedorr.Contacto;
                proveedor.Telefono = proveedorr.Telefono;
                proveedor.Email = proveedorr.Email;
                proveedor.Direccion = proveedorr.Direccion;
                proveedor.Condiciones_Entrega = proveedorr.Condiciones_Entrega;


                arbolProveedores.Insertar(proveedorr.ID_Proveedor, proveedorr);
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
