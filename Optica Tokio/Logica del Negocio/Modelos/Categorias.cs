using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    class Categorias
    {
        public int ID_Categoria { get; set; }
        public string Nombre_Categoria { get; set; }
        public string Descripcion { get; set; }

        // Constructor predeterminado para flexibilidad
        public Categorias() { }

        // Constructor completo
        public Categorias(int id, string nombre, string descripcion)
        {
            ID_Categoria = id;
            Nombre_Categoria = nombre;
            Descripcion = descripcion;
        }

        // Método para representar la categoría como una cadena (útil para depuración)
        public override string ToString()
        {
            return $"{ID_Categoria}: {Nombre_Categoria} - {Descripcion}";
        }
    }
}
