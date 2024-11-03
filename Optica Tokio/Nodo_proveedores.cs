using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio
{
    internal class Nodo_proveedores
    {
        int id_proveedor;
        string nom_proveedor;
        int telf_proveedor;
        string email_proveedor;
        string dir_proveedor;
        string condiciones;
        Nodo_proveedores enlace_proveedores;

        public Nodo_proveedores(int id_proveedor, string nom_proveedor, int telf_proveedor, string email_proveedor, string dir_proveedor, string condiciones)
        {
            this.id_proveedor = id_proveedor;
            this.nom_proveedor = nom_proveedor;
            this.telf_proveedor = telf_proveedor;
            this.email_proveedor = email_proveedor;
            this.dir_proveedor = dir_proveedor;
            this.condiciones = condiciones;
            this.enlace_proveedores = null;
        }

        public int Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Nom_proveedor { get => nom_proveedor; set => nom_proveedor = value; }
        public int Telf_proveedor { get => telf_proveedor; set => telf_proveedor = value; }
        public string Email_proveedor { get => email_proveedor; set => email_proveedor = value; }
        public string Dir_proveedor { get => dir_proveedor; set => dir_proveedor = value; }
        public string Condiciones { get => condiciones; set => condiciones = value; }
        internal Nodo_proveedores Enlace_proveedores { get => enlace_proveedores; set => enlace_proveedores = value; }
    }
}
