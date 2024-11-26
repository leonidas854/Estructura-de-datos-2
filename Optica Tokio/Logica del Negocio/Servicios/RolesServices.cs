using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Servicios
{
    public class RolesServices
    {
       public static Lista<Rol> roles = new Lista<Rol>();

       
        public void AgregarRol(Rol rol)
        {
            if (rol != null && !roles.Pertenece(rol))
            {
                roles.Insertar(rol);
            }
            else
            {
                throw new InvalidOperationException("El rol ya existe o es inválido.");
            }
        }

        
        public Lista<Rol> ObtenerRoles()
        {
            return roles;
        }

      
        public Rol BuscarRolPorId(int idRol)
        {
            foreach (var rol in roles)
            {
                if (rol.ID_Rol == idRol)
                {
                    return rol;
                }
            }
            return null;
        }

    
        public bool EliminarRolPorId(int idRol)
        {
            foreach (var rol in roles)
            {
                if (rol.ID_Rol == idRol)
                {
                    roles.Eliminar(rol);
                    return true;
                }
            }
            return false;
        }

      
        public void EditarRol(int idRol, string nuevoNombre, string nuevaDescripcion)
        {
            var rol = BuscarRolPorId(idRol);
            if (rol != null)
            {
                rol.Nombre_Rol = nuevoNombre;
                rol.Descripcion = nuevaDescripcion;
            }
            else
            {
                throw new InvalidOperationException("El rol no existe.");
            }
        }
    }
}
