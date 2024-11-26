using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    public class ProductoCategoria
    {
        public int ID_Producto { get; set; }
        public int ID_Categoria { get; set; }

        public ProductoCategoria(int iD_Producto, int iD_Categoria)
        {
            ID_Producto = iD_Producto;
            ID_Categoria = iD_Categoria;
        }
    }

}
