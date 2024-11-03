using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio
{
    internal class Nodo_Categorias
    {
        int id_cat;
        string nombre_cat;
        string descrip_cat;

        Nodo_Categorias enlace_cat;

        public Nodo_Categorias(int id_cat, string nombre_cat, string descrip_cat)
        {
            this.id_cat = id_cat;
            this.nombre_cat = nombre_cat;
            this.descrip_cat = descrip_cat;
            this.enlace_cat = null;
        }

        public int Id_cat { get => id_cat; set => id_cat = value; }
        public string Nombre_cat { get => nombre_cat; set => nombre_cat = value; }
        public string Descrip_cat { get => descrip_cat; set => descrip_cat = value; }
        internal Nodo_Categorias Enlace_cat { get => enlace_cat; set => enlace_cat = value; }
    }
}
