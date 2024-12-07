using Optica_Tokio.Logica_del_Negocio.Modelos;
using Optica_Tokio.Logica_del_Negocio.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optica_Tokio.UI.Formularios
{
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
            InicializarDataGridView();
        }
        private void InicializarDataGridView()
        {
           
            dgvCategoria.Columns.Add("Nro", "Nro");
            dgvCategoria.Columns["Nro"].ReadOnly = true;

            dgvCategoria.Columns.Add("Nombre", "Nombre");
            dgvCategoria.Columns.Add("Categoria", "Categoría");

          
            dgvCategoria.Columns["Nro"].Width = 50;
            dgvCategoria.Columns["Nombre"].Width = 150;
            dgvCategoria.Columns["Categoria"].Width = 150;
        }
        private void ActualizarContador()
        {
           
           
        }
        private void ProductosForm_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void DisableControls()
        {
            
        }
        private void CargarDatos()
        {
            try
            {
               
                dgvCategoria.Rows.Clear();

              
                var productos = ProductosServices.ObtenerProductos();

           
                foreach (var producto in productos)
                {
                    dgvCategoria.Rows.Add(producto.ID_Producto, producto.Nombre, producto.ID_Clasificacion);
                }

               
           
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim();
            bool encontrado = false;

           
            foreach (DataGridViewRow fila in dgvCategoria.Rows)
            {
                if (fila.Cells["Nombre"].Value == null ||
                 fila.Cells["Nombre"].Value.ToString()
                .IndexOf(textoBusqueda, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    fila.Selected = false; 
                }
                else
                {
                    fila.Selected = true; 
                    dgvCategoria.FirstDisplayedScrollingRowIndex = fila.Index; 
                    encontrado = true;
                    break; 
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró ningún producto con ese nombre.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
           
        }
        private int ObtenerCantidadFilas()
        {
            return dgvCategoria.Rows.Count;       
        }

       
    }
}
