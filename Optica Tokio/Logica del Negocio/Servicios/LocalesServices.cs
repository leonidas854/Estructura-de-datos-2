using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Servicios
{
    public  class LocalesServices
    {
        public static Lista<Local> locales = new Lista<Local>();

        
        public void AgregarLocal(Local local)
        {
            if (local != null && !locales.Pertenece(local))
            {
                locales.Insertar(local);
            }
            else
            {
                throw new InvalidOperationException("El local ya existe o es inválido.");
            }
        }

       
        public static Lista<Local> ObtenerLocales()
        {
            return locales;
        }

    
        public Local BuscarLocalPorId(int idLocal)
        {
            foreach (var local in locales)
            {
                if (local.ID_Local == idLocal)
                {
                    return local;
                }
            }
            return null;
        }

     
        public bool EliminarLocalPorId(int idLocal)
        {
            foreach (var local in locales)
            {
                if (local.ID_Local == idLocal)
                {
                    locales.Eliminar(local);
                    return true;
                }
            }
            return false;
        }

      
        public void EditarLocal(int idLocal, string nuevoNombre, string nuevaDireccion, string nuevoTelefono, string nuevoResponsable)
        {
            var local = BuscarLocalPorId(idLocal);
            if (local != null)
            {
                local.Nombre_Local = nuevoNombre;
                local.Direccion = nuevaDireccion;
                local.Telefono = nuevoTelefono;
                local.Responsable = nuevoResponsable;
            }
            else
            {
                throw new InvalidOperationException("El local no existe.");
            }
        }
    }
}
