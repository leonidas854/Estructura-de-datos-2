using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    class Productos
    {
        string id_prod;
        string nombre_pord;
        string cantidad_prod;
        string precio_pord;
        string id_prov;
        string fecha_registro;
        Productos enlace_prod;

        public Productos(string id_prod, string nombre_pord, string cantidad_prod, string precio_pord, string id_prov, string fecha_registro)
        {
            this.id_prod = id_prod;
            this.nombre_pord = nombre_pord;
            this.cantidad_prod = cantidad_prod;
            this.precio_pord = precio_pord;
            this.id_prov = id_prov;
            this.fecha_registro = fecha_registro;
            this.enlace_prod = null;
        }

        public string Id_prod { get => id_prod; set => id_prod = value; }
        public string Nombre_pord { get => nombre_pord; set => nombre_pord = value; }
        public string Cantidad_prod { get => cantidad_prod; set => cantidad_prod = value; }
        public string Precio_pord { get => precio_pord; set => precio_pord = value; }
        public string Id_prov { get => id_prov; set => id_prov = value; }
        public string Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        internal Productos Enlace_prod { get => enlace_prod; set => enlace_prod = value; }
    }
}
