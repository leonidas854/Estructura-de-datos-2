using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Servicios
{
    class CategoriasServices
    {
        public static Lista<Categorias> categorias = new Lista<Categorias>();

        
        public void AgregarCategoria(Categorias categoria)
        {
            if (categoria != null && !categorias.Pertenece(categoria))
            {
                categorias.Insertar(categoria);
            }
            else
            {
                throw new InvalidOperationException("La categoría ya existe o es inválida.");
            }
        }

        
        public Lista<Categorias> ObtenerCategorias()
        {
            return categorias;
        }

      
        public Categorias BuscarCategoriaPorId(int id)
        {
            foreach (var categoria in categorias)
            {
                if (categoria.ID_Categoria == id)
                {
                    return categoria;
                }
            }
            return null;
        }


        
        public bool EliminarCategoriaPorId(int id)
        {
            foreach (var categoria in categorias)
            {
                if (categoria.ID_Categoria == id)
                {
                    categorias.Eliminar(categoria);
                    return true;
                }
            }
            return false;
        }

       
        public void EditarCategoria(int id, string nuevoNombre, string nuevaDescripcion)
        {
            var categoria = BuscarCategoriaPorId(id);
            if (categoria != null)
            {
                categoria.Nombre_Categoria = nuevoNombre;
                categoria.Descripcion = nuevaDescripcion;
            }
            else
            {
                throw new InvalidOperationException("La categoría no existe.");
            }
        }

    }

}

