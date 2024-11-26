using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Servicios
{
    public class Producto_CategoriaServices
    {
        public static Lista<ProductoCategoria> productoCategorias = new Lista<ProductoCategoria>();

    
        public void AgregarRelacion(ProductoCategoria productoCategoria)
        {
            if (productoCategoria != null && !productoCategorias.Pertenece(productoCategoria))
            {
                productoCategorias.Insertar(productoCategoria);
            }
            else
            {
                throw new InvalidOperationException("La relación ya existe o es inválida.");
            }
        }

   
        public Lista<ProductoCategoria> ObtenerRelaciones()
        {
            return productoCategorias;
        }

     
        public Lista<ProductoCategoria> BuscarPorProducto(int idProducto)
        {
            Lista<ProductoCategoria> resultado = new Lista<ProductoCategoria>();
            foreach (var relacion in productoCategorias)
            {
                if (relacion.ID_Producto == idProducto)
                {
                    resultado.Insertar(relacion);
                }
            }
            return resultado;
        }

   
        public Lista<ProductoCategoria> BuscarPorCategoria(int idCategoria)
        {
            Lista<ProductoCategoria> resultado = new Lista<ProductoCategoria>();
            foreach (var relacion in productoCategorias)
            {
                if (relacion.ID_Categoria == idCategoria)
                {
                    resultado.Insertar(relacion);
                }
            }
            return resultado;
        }

 
        public bool EliminarRelacion(int idProducto, int idCategoria)
        {
            foreach (var relacion in productoCategorias)
            {
                if (relacion.ID_Producto == idProducto && relacion.ID_Categoria == idCategoria)
                {
                    productoCategorias.Eliminar(relacion);
                    return true;
                }
            }
            return false;
        }
    }
}
