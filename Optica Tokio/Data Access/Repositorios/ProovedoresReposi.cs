using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Data_Access.Repositorios
{
    internal class ProovedoresReposi
    {
        private Proveedores primerProveedor;

        // Método para insertar un nuevo proveedor
        public void Insertar(Proveedores nuevoProveedor)
        {
            if (primerProveedor == null)
            {
                primerProveedor = nuevoProveedor;
            }
            else
            {
                Proveedores actual = primerProveedor;
                while (actual.Enlace_proveedores != null)
                {
                    actual = actual.Enlace_proveedores;
                }
                actual.Enlace_proveedores = nuevoProveedor;
            }
        }

        // Método para buscar un proveedor por ID
        public Proveedores Buscar(string idProveedor)
        {
            Proveedores actual = primerProveedor;
            while (actual != null)
            {
                if (actual.Id_proveedor == idProveedor)
                {
                    return actual;
                }
                actual = actual.Enlace_proveedores;
            }
            return null;
        }

        // Método para eliminar un proveedor por ID
        public void Eliminar(string idProveedor)
        {
            if (primerProveedor == null) return;

            if (primerProveedor.Id_proveedor == idProveedor)
            {
                primerProveedor = primerProveedor.Enlace_proveedores;
                return;
            }

            Proveedores actual = primerProveedor;
            while (actual.Enlace_proveedores != null)
            {
                if (actual.Enlace_proveedores.Id_proveedor == idProveedor)
                {
                    actual.Enlace_proveedores = actual.Enlace_proveedores.Enlace_proveedores;
                    return;
                }
                actual = actual.Enlace_proveedores;
            }
        }

        // Método para listar todos los proveedores
        public Proveedores[] ListarTodos()
        {
            Proveedores actual = primerProveedor;
            var lista = new System.Collections.ArrayList();

            while (actual != null)
            {
                lista.Add(actual);
                actual = actual.Enlace_proveedores;
            }

            return (Proveedores[])lista.ToArray(typeof(Proveedores));
        }
    }
}
