using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio
{
    internal class Nodo_rol
    {
        int id_rol;
        string nom_rol;
        string descr_rol;
        Nodo_rol enlace_rol;

        public Nodo_rol(int id_rol, string nom_rol, string descr_rol)
        {
            this.id_rol = id_rol;
            this.nom_rol = nom_rol;
            this.descr_rol = descr_rol;
            this.enlace_rol = null;
        }

        public int Id_rol { get => id_rol; set => id_rol = value; }
        public string Nom_rol { get => nom_rol; set => nom_rol = value; }
        public string Descr_rol { get => descr_rol; set => descr_rol = value; }
        internal Nodo_rol Enlace_rol { get => enlace_rol; set => enlace_rol = value; }
    }
}
