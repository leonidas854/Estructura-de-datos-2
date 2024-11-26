using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Modelos
{
    public class Proveedor
    {
        public int ID_Proveedor { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Condiciones_Entrega { get; set; }

        public Proveedor(int iD_Proveedor, string nombre, string contacto, string telefono, string email, string direccion, string condiciones_Entrega)
        {
            ID_Proveedor = iD_Proveedor;
            Nombre = nombre;
            Contacto = contacto;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
            Condiciones_Entrega = condiciones_Entrega;
        }
    }

}