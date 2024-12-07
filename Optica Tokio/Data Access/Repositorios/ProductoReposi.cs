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
                var PredeterminadoID_Proveedor = ObtenerPredeterminado(); // Valor predeterminado para ID_Proveedor
                var PredeterminadoID_Clasificacion = ObtenerPredeterminado(); // Valor predeterminado para ID_Clasificación
                var PredeterminadoDescripcion = "Sin descripción"; // Valor predeterminado para Descripción
                var PredeterminadoFoto = Array.Empty<byte>(); // Valor predeterminado para Foto
                var PredeterminadoCantidadTotal = 0; // Valor predeterminado para Cantidad_Total
                var PredeterminadoPeso = 0.0m; // Valor predeterminado para Peso
                var PredeterminadoAncho = 0.0m; // Valor predeterminado para Ancho
                var PredeterminadoAlto = 0.0m; // Valor predeterminado para Alto
                var PredeterminadoGrosor = 0.0m; // Valor predeterminado para Grosor
                var PredeterminadoFechaRegistro = DateTime.MinValue; // Valor predeterminado para Fecha_Registro

                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var producto = new Producto(
                            reader.GetInt32(0), // ID_Producto
                            reader.GetString(1), // Nombre
                            reader.IsDBNull(2) ? PredeterminadoDescripcion : reader.GetString(2), // Descripción
                            reader.IsDBNull(3) ? PredeterminadoCantidadTotal : reader.GetInt32(3), // Cantidad_Total
                            reader.IsDBNull(4) ? 0 : reader.GetDecimal(4), // Precio_Costo
                            reader.IsDBNull(5) ? PredeterminadoID_Proveedor : reader.GetInt32(5), // ID_Proveedor
                            reader.IsDBNull(6) ? PredeterminadoFechaRegistro : reader.GetDateTime(6), // Fecha_Registro
                            reader.IsDBNull(7) ? PredeterminadoFoto : reader["foto"] as byte[], // Foto
                            reader.IsDBNull(8) ? PredeterminadoPeso : reader.GetDecimal(8), // Peso
                            reader.IsDBNull(9) ? PredeterminadoAncho : reader.GetDecimal(9), // Ancho
                            reader.IsDBNull(10) ? PredeterminadoAlto : reader.GetDecimal(10), // Alto
                            reader.IsDBNull(11) ? PredeterminadoGrosor : reader.GetDecimal(11), // Grosor
                            reader.IsDBNull(12) ? PredeterminadoID_Clasificacion : reader.GetInt32(12) // ID_Clasificación
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
        private int ObtenerPredeterminado()
        {

            return 1;
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
