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
    public  class Producto_CategoriaReposi:BaseRepository
    {
        public Lista<ProductoCategoria> CargarProductoCategorias()
        {
            var listaProductoCategorias = new Lista<ProductoCategoria>();
            string query = "SELECT * FROM producto_categoria";

            try
            {
                AbrirConexion();
                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productoCategoria = new ProductoCategoria(
                            reader.GetInt32(0), // ID_Producto
                            reader.GetInt32(1)  // ID_Categoria
                        );
                        listaProductoCategorias.Insertar(productoCategoria);
                    }
                }
            }
            finally
            {
                CerrarConexion();
            }

            return listaProductoCategorias;
        }

        public void GuardarProductoCategorias(Lista<ProductoCategoria> listaProductoCategorias)
        {
            string query = "INSERT INTO producto_categoria (id_producto, id_categoria) VALUES (@Producto, @Categoria)";
            try
            {
                AbrirConexion();
                foreach (var productoCategoria in listaProductoCategorias)
                {
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("Producto", productoCategoria.ID_Producto);
                        command.Parameters.AddWithValue("Categoria", productoCategoria.ID_Categoria);
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
            string query = "DELETE FROM producto_categoria";
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
