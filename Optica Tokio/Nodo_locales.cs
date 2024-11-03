using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio
{
    internal class Nodo_locales
    {
        int id_local;
        string nombre_local;
        string dir_local;
        int telf_local;
        string responsable_local;
        Nodo_locales enlace_locales;

        public Nodo_locales(int id_local, string nombre_local, string dir_local, int telf_local, string responsable_local)
        {
            this.id_local = id_local;
            this.nombre_local = nombre_local;
            this.dir_local = dir_local;
            this.telf_local = telf_local;
            this.responsable_local = responsable_local;
            this.enlace_locales = null;
        }

        public int Id_local { get => id_local; set => id_local = value; }
        public string Nombre_local { get => nombre_local; set => nombre_local = value; }
        public string Dir_local { get => dir_local; set => dir_local = value; }
        public int Telf_local { get => telf_local; set => telf_local = value; }
        public string Responsable_local { get => responsable_local; set => responsable_local = value; }
        internal Nodo_locales Enlace_locales { get => enlace_locales; set => enlace_locales = value; }
    }
}
