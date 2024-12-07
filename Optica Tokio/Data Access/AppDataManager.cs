using Optica_Tokio.Data_Access.Repositorios;
using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using Optica_Tokio.Logica_del_Negocio.Servicios;
using System;

namespace Optica_Tokio.Data_Access
{
    public static class AppDataManager
    {
        // Repositorios
        private static ProovedoresReposi proveedoresRepositorio = new ProovedoresReposi();
        private static ClasificacionReposi clasificacionRepositorio = new ClasificacionReposi();
        private static ProductoReposi productoRepositorio = new ProductoReposi();
        private static CategoriasReposi categoriasRepositorio = new CategoriasReposi();
        private static Producto_CategoriaReposi productoCategoriaRepositorio = new Producto_CategoriaReposi();
        private static InventarioReposi inventarioRepositorio = new InventarioReposi();
        private static MovimientoReposi movimientoRepositorio = new MovimientoReposi();
        private static LocalesReposi localesRepositorio = new LocalesReposi();
        private static RolesReposi rolesRepositorio = new RolesReposi();
        private static UsuarioReposi usuarioRepositorio = new UsuarioReposi();
        private static ControladoresReposi controladoresRepositorio = new ControladoresReposi();
        private static PermisosReposi permisosRepositorio = new PermisosReposi();

        public static void CargarDatos()
        {
            // Clasificación
            ClasificacionServices.listaClasificaciones = clasificacionRepositorio.CargarClasificaciones();
            clasificacionRepositorio.LimpiarTabla();

            // Proveedores
            ProvedoresServices.arbolProveedores = proveedoresRepositorio.CargarProveedores();
            proveedoresRepositorio.LimpiarTabla();

            // Productos
            ProductosServices.arbolProductos = productoRepositorio.CargarProductos();
            productoRepositorio.LimpiarTabla();

            // Categorías
            CategoriasServices.categorias = categoriasRepositorio.CargarCategorias();
            categoriasRepositorio.LimpiarTabla();

            // Producto_Categoría
            Producto_CategoriaServices.productoCategorias = productoCategoriaRepositorio.CargarProductoCategorias();
            productoCategoriaRepositorio.LimpiarTabla();

            // Inventario
            InventarioServices.inventarioArbol = inventarioRepositorio.CargarInventario();
            inventarioRepositorio.LimpiarTabla();

            // Movimientos
            MovimientoServices.movimientos = movimientoRepositorio.CargarMovimientos();
            movimientoRepositorio.LimpiarTabla();

            // Locales
            LocalesServices.locales = localesRepositorio.CargarLocales();
            localesRepositorio.LimpiarTabla();

            // Roles
            RolesServices.roles = rolesRepositorio.CargarRoles();
            rolesRepositorio.LimpiarTabla();

            // Usuarios
            UsuarioService.listaUsuarios = usuarioRepositorio.CargarUsuarios();
            usuarioRepositorio.LimpiarTabla();

            // Controladores
            ControladoresServices.controladores = controladoresRepositorio.CargarControladores();
            controladoresRepositorio.LimpiarTabla();

            // Permisos
            PermisosServices.permisos = permisosRepositorio.CargarPermisos();
            permisosRepositorio.LimpiarTabla();
        }

        public static void GuardarDatos()
        {
            // Clasificación
            clasificacionRepositorio.GuardarClasificaciones(ClasificacionServices.listaClasificaciones);

            // Proveedores
            proveedoresRepositorio.GuardarProveedores(ProvedoresServices.arbolProveedores);

            // Productos
            productoRepositorio.GuardarProductos(ProductosServices.arbolProductos);

            // Categorías
            categoriasRepositorio.GuardarCategorias(CategoriasServices.categorias);

            // Producto_Categoría
            productoCategoriaRepositorio.GuardarProductoCategorias(Producto_CategoriaServices.productoCategorias);

            // Inventario
            inventarioRepositorio.GuardarInventario(InventarioServices.inventarioArbol);

            // Movimientos
            movimientoRepositorio.GuardarMovimientos(MovimientoServices.movimientos);

            // Locales
            localesRepositorio.GuardarLocales(LocalesServices.locales);

            // Roles
            rolesRepositorio.GuardarRoles(RolesServices.roles);

            // Usuarios
            usuarioRepositorio.GuardarUsuarios(UsuarioService.listaUsuarios);

            // Controladores
            controladoresRepositorio.GuardarControladores(ControladoresServices.controladores);

            // Permisos
            permisosRepositorio.GuardarPermisos(PermisosServices.permisos);
        }
    }
}
