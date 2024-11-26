using Npgsql;
using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using Optica_Tokio.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optica_Tokio.Data_Access.Repositorios
{
  public  class ProovedoresReposi : BaseRepository
    {
        public ArbolRN<int, Proveedor> CargarProveedores()
        {
            var arbolProveedores = new ArbolRN<int, Proveedor>();
            string query = "SELECT * FROM Proveedores";

            try
            {
                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var proveedor = new Proveedor(
                            reader.GetInt32(0), // ID_Proveedor
                            reader.GetString(1), // Nombre
                            reader.GetString(2), // Contacto
                            reader.GetString(3), // Telefono
                            reader.GetString(4), // Email
                            reader.GetString(5), // Direccion
                            reader.GetString(6)  // Condiciones_Entrega
                        );
                        arbolProveedores.Insertar(proveedor.ID_Proveedor, proveedor);
                    }
                }
            }
            finally
            {
                CerrarConexion();
            }

            return arbolProveedores;
        }

        public void GuardarProveedores(ArbolRN<int, Proveedor> arbolProveedores)
        {
            string query = "INSERT INTO Proveedores (ID_Proveedor, Nombre, Contacto, Telefono, Email, Direccion, Condiciones_Entrega) " +
                           "VALUES (@ID, @Nombre, @Contacto, @Telefono, @Email, @Direccion, @Condiciones)";
            try
            {
                AbrirConexion();
                foreach (var proveedor in arbolProveedores.RecorridoAmplitud())
                {
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("ID", proveedor.ID_Proveedor);
                        command.Parameters.AddWithValue("Nombre", proveedor.Nombre);
                        command.Parameters.AddWithValue("Contacto", proveedor.Contacto);
                        command.Parameters.AddWithValue("Telefono", proveedor.Telefono);
                        command.Parameters.AddWithValue("Email", proveedor.Email);
                        command.Parameters.AddWithValue("Direccion", proveedor.Direccion);
                        command.Parameters.AddWithValue("Condiciones", proveedor.Condiciones_Entrega);

                        command.ExecuteNonQuery();
                    }
                }
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void LimpiarTabla()
        {
            string query = "DELETE FROM Proveedores";
            try
            {
                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                CerrarConexion();
            }
        }



    }
}
