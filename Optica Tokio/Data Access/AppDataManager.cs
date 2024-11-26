using Optica_Tokio.Data_Access.Repositorios;
using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Optica_Tokio.Logica_del_Negocio.Servicios;

namespace Optica_Tokio.Data_Access
{
    public static class AppDataManager
    {
        //public static ArbolRN<int, Proveedor> ProveedoresArbol = new ArbolRN<int, Proveedor>();
        // Aquí se agregan otras estructuras como listas, colas, etc.

        private static ProovedoresReposi proveedoresRepositorio = new ProovedoresReposi();
        private static CategoriasReposi CategoriasRepos = new CategoriasReposi();

        public static void CargarDatos()
        {
            // Cargar Proveedores
          // ProvedoresServices.arbolProveedores = proveedoresRepositorio.CargarProveedores();
           // proveedoresRepositorio.LimpiarTabla();
            //cargar categorias
            CategoriasServices.categorias = CategoriasRepos.CargarCategorias();
            CategoriasRepos .LimpiarTabla ();
            // Cargar otras tablas...
        }

        public static void GuardarDatos()
        {
            // Guardar Proveedores
           // proveedoresRepositorio.GuardarProveedores(ProvedoresServices.arbolProveedores);

            CategoriasRepos.GuardarCategorias(CategoriasServices.categorias);
            // Guardar otras tablas...
        }
    }
}
