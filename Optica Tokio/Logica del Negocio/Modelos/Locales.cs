using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
   class Locales
    {
        string id_local;
        string nombre_local;
        string dir_local;
        string telf_local;
        string responsable_local;
        Locales enlace_locales;

        public Locales(string id_local, string nombre_local, string dir_local, string telf_local, string responsable_local)
        {
            this.id_local = id_local;
            this.nombre_local = nombre_local;
            this.dir_local = dir_local;
            this.telf_local = telf_local;
            this.responsable_local = responsable_local;
            this.enlace_locales = null;
        }

        public string Id_local { get => id_local; set => id_local = value; }
        public string Nombre_local { get => nombre_local; set => nombre_local = value; }
        public string Dir_local { get => dir_local; set => dir_local = value; }
        public string Telf_local { get => telf_local; set => telf_local = value; }
        public string Responsable_local { get => responsable_local; set => responsable_local = value; }
        internal Locales Enlace_locales { get => enlace_locales; set => enlace_locales = value; }
    }
}
