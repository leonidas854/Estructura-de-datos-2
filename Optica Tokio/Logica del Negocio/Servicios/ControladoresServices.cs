using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Logica_del_Negocio.Servicios
{
    public class ControladoresServices
    {
        public static Lista<Controlador> controladores = new Lista<Controlador>();


        public void AgregarControlador(Controlador controlador)
        {
            if (controlador != null && !controladores.Pertenece(controlador))
            {
                controladores.Insertar(controlador);
            }
            else
            {
                throw new InvalidOperationException("El controlador ya existe o es inválido.");
            }
        }


        public Lista<Controlador> ObtenerControladores()
        {
            return controladores;
        }


        public Controlador BuscarControladorPorId(int idControlador)
        {
            foreach (var controlador in controladores)
            {
                if (controlador.ID_Controlador == idControlador)
                {
                    return controlador;
                }
            }
            return null;
        }


        public bool EliminarControladorPorId(int idControlador)
        {
            foreach (var controlador in controladores)
            {
                if (controlador.ID_Controlador == idControlador)
                {
                    controladores.Eliminar(controlador);
                    return true;
                }
            }
            return false;
        }


        public void EditarControlador(int idControlador, string nuevoNombre, string nuevaDescripcion)
        {
            var controlador = BuscarControladorPorId(idControlador);
            if (controlador != null)
            {
                controlador.Nombre_Controlador = nuevoNombre;
                controlador.Descripcion = nuevaDescripcion;
            }
            else
            {
                throw new InvalidOperationException("El controlador no existe.");
            }
        }
    }
}
