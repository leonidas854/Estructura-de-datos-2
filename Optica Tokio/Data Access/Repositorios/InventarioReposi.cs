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
    public class InventarioReposi:BaseRepository
    {
        public ArbolRN<int, InventarioLocal> CargarInventario()
        {
            var arbolInventario = new ArbolRN<int, InventarioLocal>();
            string query = "SELECT * FROM inventario_local";

            try
            {
                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var inventario = new InventarioLocal(
                            reader.GetInt32(0), // ID_Inventario
                            reader.GetInt32(1), // ID_Producto
                            reader.GetInt32(2), // ID_Local
                            reader.GetInt32(3), // Cantidad
                            reader.GetDateTime(4) // Fecha_Ultima_Actualizacion
                        );
                        arbolInventario.Insertar(inventario.ID_Inventario, inventario);
                    }
                }
            }
            finally
            {
                CerrarConexion();
            }

            return arbolInventario;
        }

        public void GuardarInventario(ArbolRN<int, InventarioLocal> arbolInventario)
        {
            string query = "INSERT INTO inventario_local (id_inventario, id_producto, id_local, cantidad, fecha_ultima_actualizacion) " +
                           "VALUES (@ID, @Producto, @Local, @Cantidad, @Fecha)";
            try
            {
                AbrirConexion();
                foreach (var inventario in arbolInventario.RecorridoAmplitud())
                {
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("ID", inventario.ID_Inventario);
                        command.Parameters.AddWithValue("Producto", inventario.ID_Producto);
                        command.Parameters.AddWithValue("Local", inventario.ID_Local);
                        command.Parameters.AddWithValue("Cantidad", inventario.Cantidad);
                        command.Parameters.AddWithValue("Fecha", inventario.Fecha_Ultima_Actualizacion);
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
            string query = "DELETE FROM inventario_local";
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

