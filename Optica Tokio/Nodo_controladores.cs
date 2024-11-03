using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio
{
    internal class Nodo_controladores
    {
        int id_controlador;
        string nom_controlador;
        string descr_controlador;
        Nodo_controladores enlace_controladores;

        public Nodo_controladores(int id_controlador, string nom_controlador, string descr_controlador)
        {
            this.id_controlador = id_controlador;
            this.nom_controlador = nom_controlador;
            this.descr_controlador = descr_controlador;
            this.enlace_controladores = null;
        }

        public int Id_controlador { get => id_controlador; set => id_controlador = value; }
        public string Nom_controlador { get => nom_controlador; set => nom_controlador = value; }
        public string Descr_controlador { get => descr_controlador; set => descr_controlador = value; }
        internal Nodo_controladores Enlace_controladores { get => enlace_controladores; set => enlace_controladores = value; }
    }
}
