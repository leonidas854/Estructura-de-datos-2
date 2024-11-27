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
    public class MovimientoReposi:BaseRepository
    {
        public Cola<MovimientoInventario> CargarMovimientos()
        {
            var colaMovimientos = new Cola<MovimientoInventario>();
            string query = "SELECT * FROM movimientos_inventario";

            try
            {
                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var movimiento = new MovimientoInventario(
                            reader.GetInt32(0), // ID_Movimiento
                            reader.GetInt32(1), // ID_Producto
                            reader.GetInt32(2), // ID_Local
                            reader.GetString(3), // Tipo_Movimiento
                            reader.GetInt32(4), // Cantidad
                            reader.GetDateTime(5), // Fecha
                            reader.GetInt32(6), // ID_Usuario
                            reader.GetString(7)  // Comentarios
                        );
                        colaMovimientos.Encolar(movimiento);
                    }
                }
            }
            finally
            {
                CerrarConexion();
            }

            return colaMovimientos;
        }

        public void GuardarMovimientos(Cola<MovimientoInventario> colaMovimientos)
        {
            string query = "INSERT INTO movimientos_inventario (id_movimiento, id_producto, id_local, tipo_movimiento, cantidad, fecha, id_usuario, comentarios) " +
                           "VALUES (@ID, @Producto, @Local, @Tipo, @Cantidad, @Fecha, @Usuario, @Comentarios)";
            try
            {
                AbrirConexion();
                foreach (var movimiento in colaMovimientos)
                {
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("ID", movimiento.ID_Movimiento);
                        command.Parameters.AddWithValue("Producto", movimiento.ID_Producto);
                        command.Parameters.AddWithValue("Local", movimiento.ID_Local);
                        command.Parameters.AddWithValue("Tipo", movimiento.Tipo_Movimiento);
                        command.Parameters.AddWithValue("Cantidad", movimiento.Cantidad);
                        command.Parameters.AddWithValue("Fecha", movimiento.Fecha);
                        command.Parameters.AddWithValue("Usuario", movimiento.ID_Usuario);
                        command.Parameters.AddWithValue("Comentarios", movimiento.Comentarios);
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
            string query = "DELETE FROM movimientos_inventario";
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
