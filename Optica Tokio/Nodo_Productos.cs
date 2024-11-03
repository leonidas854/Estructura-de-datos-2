using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio
{
    internal class Nodo_Productos
    {
        int id_prod;
        string nombre_pord;
        int cantidad_prod;
        float precio_pord;
        int id_prov;
        DateTime fecha_registro;
        Nodo_Productos enlace_prod;

        public Nodo_Productos(int id_prod, string nombre_pord, int cantidad_prod, float precio_pord, int id_prov, DateTime fecha_registro)
        {
            this.id_prod = id_prod;
            this.nombre_pord = nombre_pord;
            this.cantidad_prod = cantidad_prod;
            this.precio_pord = precio_pord;
            this.id_prov = id_prov;
            this.fecha_registro = fecha_registro;
            this.enlace_prod = null;
        }

        public int Id_prod { get => id_prod; set => id_prod = value; }
        public string Nombre_pord { get => nombre_pord; set => nombre_pord = value; }
        public int Cantidad_prod { get => cantidad_prod; set => cantidad_prod = value; }
        public float Precio_pord { get => precio_pord; set => precio_pord = value; }
        public int Id_prov { get => id_prov; set => id_prov = value; }
        public DateTime Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        internal Nodo_Productos Enlace_prod { get => enlace_prod; set => enlace_prod = value; }
    }
}
