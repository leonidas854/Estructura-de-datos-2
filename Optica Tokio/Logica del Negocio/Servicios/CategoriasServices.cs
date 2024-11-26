using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Servicios
{
    public class CategoriasServices
    {
       
        public  static ArbolRN<int, Categorias> categorias = new ArbolRN<int, Categorias>();

        
        public void AgregarCategoria(Categorias categoria)
        {
            if (categoria == null)
            {
                throw new ArgumentNullException(nameof(categoria), "La categoría no puede ser nula.");
            }

            if (!categorias.Contiene(categoria.ID_Categoria))
            {
                categorias.Insertar(categoria.ID_Categoria, categoria);
            }
            else
            {
                throw new InvalidOperationException($"La categoría con ID {categoria.ID_Categoria} ya existe.");
            }
        }

      
        public IEnumerable<Categorias> ObtenerCategorias()
        {
            return categorias.RecorridoAmplitud();
        }

        
        public Categorias BuscarCategoriaPorId(int id)
        {
            var categoria = categorias.GetValorPorLlave(id);
            if (categoria == null)
            {
                throw new KeyNotFoundException($"No se encontró ninguna categoría con ID {id}.");
            }
            return categoria;
        }

    
        public bool EliminarCategoriaPorId(int id)
        {
            if (categorias.Contiene(id))
            {
                categorias.Eliminar(id); 
                return true;
            }
            return false;
        }

      
        public void EditarCategoria(int id, string nuevoNombre, string nuevaDescripcion)
        {
            var categoria = BuscarCategoriaPorId(id);
            if (categoria != null)
            {
                categoria.Nombre_Categoria = nuevoNombre ?? throw new ArgumentNullException(nameof(nuevoNombre));
                categoria.Descripcion = nuevaDescripcion ?? throw new ArgumentNullException(nameof(nuevaDescripcion));
            }
            else
            {
                throw new InvalidOperationException($"No se encontró ninguna categoría con ID {id} para editar.");
            }
        }

    }

}

