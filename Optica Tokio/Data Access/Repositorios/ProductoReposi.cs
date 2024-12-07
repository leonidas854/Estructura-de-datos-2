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
    public class ProductoReposi:BaseRepository
    {
        public ArbolRN<int, Producto> CargarProductos()
        {
            var arbolProductos = new ArbolRN<int, Producto>();
            string query = "SELECT * FROM productos";

            try
            {
                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var producto = new Producto(
                            reader.GetInt32(0), // ID_Producto
                            reader.GetString(1), // Nombre
                            reader.GetString(2), // Descripción
                            reader.GetInt32(3), // Cantidad_Total
                            reader.GetDecimal(4), // Precio_Costo
                            reader.GetInt32(5), // ID_Proveedor
                            reader.GetDateTime(6), // Fecha_Registro
                            reader["foto"] as byte[], // Foto
                            reader.GetDecimal(8), // Peso
                            reader.GetDecimal(9), // Ancho
                            reader.GetDecimal(10), // Alto
                            reader.GetDecimal(11), // Grosor
                            reader.GetInt32(12) // ID_Clasificación
                        );
                        arbolProductos.Insertar(producto.ID_Producto, producto);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error al cargar productos desde la base de datos: {ex.Message}", ex);
            }
            finally
            {
                CerrarConexion();
            }

            return arbolProductos;
        }

        public void GuardarProductos(ArbolRN<int, Producto> arbolProductos)
        {
            string query = @"INSERT INTO productos 
                        (id_producto, nombre, descripcion, cantidad_total, precio_costo, id_proveedor, fecha_registro, foto, peso, ancho, alto, grosor, id_clasificacion) 
                        VALUES 
                        (@ID, @Nombre, @Descripcion, @CantidadTotal, @PrecioCosto, @IDProveedor, @FechaRegistro, @Foto, @Peso, @Ancho, @Alto, @Grosor, @IDClasificacion)";

            try
            {
                AbrirConexion();
                foreach (var producto in arbolProductos.RecorridoAmplitud())
                {
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("ID", producto.ID_Producto);
                        command.Parameters.AddWithValue("Nombre", producto.Nombre);
                        command.Parameters.AddWithValue("Descripcion", producto.Descripcion);
                        command.Parameters.AddWithValue("CantidadTotal", producto.Cantidad_Total);
                        command.Parameters.AddWithValue("PrecioCosto", producto.Precio_Costo);
                        command.Parameters.AddWithValue("IDProveedor", producto.ID_Proveedor);
                        command.Parameters.AddWithValue("FechaRegistro", producto.Fecha_Registro);
                        command.Parameters.AddWithValue("Foto", producto.Foto ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("Peso", producto.Peso);
                        command.Parameters.AddWithValue("Ancho", producto.Ancho);
                        command.Parameters.AddWithValue("Alto", producto.Alto);
                        command.Parameters.AddWithValue("Grosor", producto.Grosor);
                        command.Parameters.AddWithValue("IDClasificacion", producto.ID_Clasificacion);

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
            string query = "DELETE FROM productos";
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
