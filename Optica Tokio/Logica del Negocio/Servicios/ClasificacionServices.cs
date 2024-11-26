using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Servicios
{
   class ClasificacionServices
    {
        public static Lista<Clasificacion> listaClasificaciones = new Lista<Clasificacion>();

       
        public void AgregarClasificacion(Clasificacion clasificacion)
        {
            if (clasificacion == null)
            {
                throw new ArgumentNullException(nameof(clasificacion), "La clasificación no puede ser nula.");
            }

            if (!listaClasificaciones.Pertenece(clasificacion))
            {
                listaClasificaciones.Insertar(clasificacion);
            }
            else
            {
                throw new InvalidOperationException("La clasificación ya existe.");
            }
        }

      
        public Lista<Clasificacion> ObtenerClasificaciones()
        {
            return listaClasificaciones;
        }

    
        public Clasificacion BuscarClasificacionPorId(int id)
        {
            for (int i = 0; i < listaClasificaciones.GetTam(); i++)
            {
                var clasificacion = listaClasificaciones.Get(i);
                if (clasificacion.ID_Clasificacion == id)
                {
                    return clasificacion;
                }
            }
            return null;
        }

       
        public bool EliminarClasificacionPorId(int id)
        {
            for (int i = 0; i < listaClasificaciones.GetTam(); i++)
            {
                var clasificacion = listaClasificaciones.Get(i);
                if (clasificacion.ID_Clasificacion == id)
                {
                    listaClasificaciones.Eliminar(clasificacion);
                    return true;
                }
            }
            return false;
        }

       
        public void EditarClasificacion(int id, string nuevoNombre)
        {
            var clasificacion = BuscarClasificacionPorId(id);
            if (clasificacion != null)
            {
                clasificacion.Nombre_Clasificacion = nuevoNombre;
            }
            else
            {
                throw new InvalidOperationException("La clasificación no existe.");
            }
        }
    }
}
