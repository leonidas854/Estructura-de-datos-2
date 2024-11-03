using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio
{
    internal class Nodo_Prod_cat
    {
        int id_prod;
        int id_cat;
        Nodo_Prod_cat enlace_prod_cat;

        public Nodo_Prod_cat(int id_prod, int id_cat)
        {
            this.id_prod = id_prod;
            this.id_cat = id_cat;
            this.enlace_prod_cat = null;
        }

        public int Id_prod { get => id_prod; set => id_prod = value; }
        public int Id_cat { get => id_cat; set => id_cat = value; }
        internal Nodo_Prod_cat Enlace_prod_cat { get => enlace_prod_cat; set => enlace_prod_cat = value; }
    }
}
