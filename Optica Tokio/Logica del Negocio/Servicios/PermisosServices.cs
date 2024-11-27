using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Servicios
{
    public class PermisosServices
    {
       public static Lista<PermisoRol> permisos = new Lista<PermisoRol>();

  
        public static void AgregarPermiso(PermisoRol permiso)
        {
            if (permiso != null && !permisos.Pertenece(permiso))
            {
                permisos.Insertar(permiso);
            }
            else
            {
                throw new InvalidOperationException("El permiso ya existe o es inválido.");
            }
        }

    
        public Lista<PermisoRol> ObtenerPermisos()
        {
            return permisos;
        }

      
        public Lista<PermisoRol> BuscarPermisosPorRol(int idRol)
        {
            var permisosPorRol = new Lista<PermisoRol>();
            foreach (var permiso in permisos)
            {
                if (permiso.ID_Rol == idRol)
                {
                    permisosPorRol.Insertar(permiso);
                }
            }
            return permisosPorRol;
        }

        
        public Lista<PermisoRol> BuscarPermisosPorControlador(int idControlador)
        {
            var permisosPorControlador = new Lista<PermisoRol>();
            foreach (var permiso in permisos)
            {
                if (permiso.ID_Controlador == idControlador)
                {
                    permisosPorControlador.Insertar(permiso);
                }
            }
            return permisosPorControlador;
        }

      
        public static bool EliminarPermiso(int idRol, int idControlador)
        {
            foreach (var permiso in permisos)
            {
                if (permiso.ID_Rol == idRol && permiso.ID_Controlador == idControlador)
                {
                    permisos.Eliminar(permiso);
                    return true;
                }
            }
            return false;
        }

        
        public void EditarPermiso(int idRol, int idControlador, string nuevoPermiso)
        {
            foreach (var permiso in permisos)
            {
                if (permiso.ID_Rol == idRol && permiso.ID_Controlador == idControlador)
                {
                    permiso.Permiso = nuevoPermiso;
                    return;
                }
            }
            throw new InvalidOperationException("El permiso no existe.");
        }
    }
}
