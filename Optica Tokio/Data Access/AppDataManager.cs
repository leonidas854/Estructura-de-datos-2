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
    
        // Repositorios
        private static ProovedoresReposi proveedoresRepositorio = new ProovedoresReposi();
        private static CategoriasReposi categoriasRepositorio = new CategoriasReposi();
        private static ClasificacionReposi clasificacionRepositorio = new ClasificacionReposi();
        private static ProductoReposi productoRepositorio = new ProductoReposi();
        private static Producto_CategoriaReposi productoCategoriaRepositorio = new Producto_CategoriaReposi();
        private static LocalesReposi localesRepositorio = new LocalesReposi();
        private static InventarioReposi inventarioRepositorio = new InventarioReposi();
        private static MovimientoReposi movimientoRepositorio = new MovimientoReposi();
        private static UsuarioReposi usuarioRepositorio = new UsuarioReposi();
        private static RolesReposi rolesRepositorio = new RolesReposi();
        private static ControladoresReposi controladoresRepositorio = new ControladoresReposi();
        private static PermisosReposi permisosRepositorio = new PermisosReposi();
        public static void CargarDatos()
        {
            // Proveedores
            ProvedoresServices.arbolProveedores = proveedoresRepositorio.CargarProveedores();
            proveedoresRepositorio.LimpiarTabla();

            // Categorías
            CategoriasServices.categorias = categoriasRepositorio.CargarCategorias();
            categoriasRepositorio.LimpiarTabla();

            // Clasificación
            ClasificacionServices.listaClasificaciones = clasificacionRepositorio.CargarClasificaciones();
            clasificacionRepositorio.LimpiarTabla();

            // Productos
            ProductosServices.arbolProductos = productoRepositorio.CargarProductos();
            productoRepositorio.LimpiarTabla();

            // Producto_Categoría
            Producto_CategoriaServices.productoCategorias = productoCategoriaRepositorio.CargarProductoCategorias();
            productoCategoriaRepositorio.LimpiarTabla();

            // Locales
            LocalesServices.locales = localesRepositorio.CargarLocales();
            localesRepositorio.LimpiarTabla();

            // Inventario
            InventarioServices.inventarioArbol = inventarioRepositorio.CargarInventario();
            inventarioRepositorio.LimpiarTabla();

            // Movimientos
            MovimientoServices.movimientos = movimientoRepositorio.CargarMovimientos();
            movimientoRepositorio.LimpiarTabla();

            // Usuarios
            UsuarioService.listaUsuarios = usuarioRepositorio.CargarUsuarios();
            usuarioRepositorio.LimpiarTabla();

            // Roles
            RolesServices.roles = rolesRepositorio.CargarRoles();
            rolesRepositorio.LimpiarTabla();

            // Controladores
            ControladoresServices.controladores = controladoresRepositorio.CargarControladores();
            controladoresRepositorio.LimpiarTabla();

            // Permisos
            PermisosServices.permisos = permisosRepositorio.CargarPermisos();
            permisosRepositorio.LimpiarTabla();
        }

        public static void GuardarDatos()
        {
            // Proveedores
            proveedoresRepositorio.GuardarProveedores(ProvedoresServices.arbolProveedores);

            // Categorías
            categoriasRepositorio.GuardarCategorias(CategoriasServices.categorias);

            // Clasificación
            clasificacionRepositorio.GuardarClasificaciones(ClasificacionServices.listaClasificaciones);

            // Productos
            productoRepositorio.GuardarProductos(ProductosServices.arbolProductos);

            // Producto_Categoría
            productoCategoriaRepositorio.GuardarProductoCategorias(Producto_CategoriaServices.productoCategorias);

            // Locales
            localesRepositorio.GuardarLocales(LocalesServices.locales);

            // Inventario
            inventarioRepositorio.GuardarInventario(InventarioServices.inventarioArbol);

            // Movimientos
            movimientoRepositorio.GuardarMovimientos(MovimientoServices.movimientos);

            // Usuarios
            usuarioRepositorio.GuardarUsuarios(UsuarioService.listaUsuarios);

            // Roles
            rolesRepositorio.GuardarRoles(RolesServices.roles);

            // Controladores
            controladoresRepositorio.GuardarControladores(ControladoresServices.controladores);

            // Permisos
            permisosRepositorio.GuardarPermisos(PermisosServices.permisos);
        }
    }
}
