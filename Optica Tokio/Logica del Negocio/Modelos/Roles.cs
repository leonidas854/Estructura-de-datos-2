using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    class Roles
    {
        string id_rol;
        string nom_rol;
        string descr_rol;
        Roles enlace_rol;

        public Roles(string id_rol, string nom_rol, string descr_rol)
        {
            this.id_rol = id_rol;
            this.nom_rol = nom_rol;
            this.descr_rol = descr_rol;
            this.enlace_rol = null;
        }

        public string Id_rol { get => id_rol; set => id_rol = value; }
        public string Nom_rol { get => nom_rol; set => nom_rol = value; }
        public string Descr_rol { get => descr_rol; set => descr_rol = value; }
        internal Roles Enlace_rol { get => enlace_rol; set => enlace_rol = value; }
    }
}
