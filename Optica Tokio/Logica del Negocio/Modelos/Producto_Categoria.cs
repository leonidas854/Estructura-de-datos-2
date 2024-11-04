using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    class Producto_Categoria
    {
        string id_prod;
        string id_cat;
        Producto_Categoria enlace_prod_cat;

        public Producto_Categoria(string id_prod, string id_cat)
        {
            this.id_prod = id_prod;
            this.id_cat = id_cat;
            this.enlace_prod_cat = null;
        }

        public string Id_prod { get => id_prod; set => id_prod = value; }
        public string Id_cat { get => id_cat; set => id_cat = value; }
        internal Producto_Categoria Enlace_prod_cat { get => enlace_prod_cat; set => enlace_prod_cat = value; }
    }
}
