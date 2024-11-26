using Npgsql;
using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
using Optica_Tokio.Logica_del_Negocio.Modelos;
using Optica_Tokio.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Optica_Tokio.Logica_del_Negocio.Servicios;
using System.Windows.Forms;
using System.Drawing;

namespace Optica_Tokio.Data_Access.Repositorios
{
    public class CategoriasReposi :BaseRepository
    {
        public ArbolRN<int, Categorias> CargarCategorias()
        {
            /*string queryCheck = "SELECT current_schema()";
            using (var command = new NpgsqlCommand(queryCheck, connection))
            {
                var schema = command.ExecuteScalar()?.ToString();
                Console.WriteLine($"Esquema actual: {schema}");
            }*/

            var arbolCategorias = new ArbolRN<int, Categorias>();
            string query = "SELECT id_categoria, nombre_categoria, descripcion FROM public.categorias";
            
            try
            {
                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var idCategoria = reader.GetInt32(0);
                        var nombreCategoria = reader.IsDBNull(1) ? "Sin Nombre" : reader.GetString(1);
                        var descripcion = reader.IsDBNull(2) ? "Sin Descripción" : reader.GetString(2);

                        var categoria = new Categorias(idCategoria, nombreCategoria, descripcion);
                        arbolCategorias.Insertar(categoria.ID_Categoria, categoria);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar categorías: " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }

            return arbolCategorias;
        }

        public void GuardarCategorias(ArbolRN<int, Categorias> arbolCategorias)
        {
            string query = "INSERT INTO public.categorias (id_categoria, nombre_categoria, descripcion) " +
                           "VALUES (@ID, @Nombre, @Descripcion)";

            try
            {
                AbrirConexion();
                foreach (var categoria in arbolCategorias.RecorridoAmplitud())
                {
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("ID", categoria.ID_Categoria);
                        command.Parameters.AddWithValue("Nombre", categoria.Nombre_Categoria);
                        command.Parameters.AddWithValue("Descripcion", categoria.Descripcion);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar categorías: " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void LimpiarTabla()
        {
            string query = "DELETE FROM public.categorias";

            try
            {
                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al limpiar la tabla de categorías: " + ex.Message, ex);
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}
