using Optica_Tokio.Data_Access.Repositorios;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Servicios
{
    internal class ProvedoresServices
    {
        private ProovedoresReposi repositorio = new ProovedoresReposi();

        public Proveedores[] ListarProveedores()
        {
            return repositorio.ListarTodos();
        }

        public void CrearProveedor(Proveedores proveedor)
        {
            repositorio.Insertar(proveedor);
        }

        public void EditarProveedor(Proveedores proveedor)
        {
            var proveedorExistente = repositorio.Buscar(proveedor.Id_proveedor);
            if (proveedorExistente != null)
            {
                proveedorExistente.Nom_proveedor = proveedor.Nom_proveedor;
                proveedorExistente.Telf_proveedor = proveedor.Telf_proveedor;
                proveedorExistente.Email_proveedor = proveedor.Email_proveedor;
                proveedorExistente.Dir_proveedor = proveedor.Dir_proveedor;
                proveedorExistente.Condiciones = proveedor.Condiciones;
            }
        }

        public void EliminarProveedor(string idProveedor)
        {
            repositorio.Eliminar(idProveedor);
        }
    }
}
