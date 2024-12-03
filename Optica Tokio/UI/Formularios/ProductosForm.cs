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
            dgvCategoria.Columns.Add("Categoria", "Categoria");

        }
        private void ActualizarContador()
        {
            for (int i = 0; i < dgvCategoria.Rows.Count; i++)
            {
                dgvCategoria.Rows[i].Cells["Nro"].Value = (i + 1).ToString();
            }
        }
        private void ProductosForm_Load(object sender, EventArgs e)
        {

        }
        private void DisableControls()
        {
            DisableControlsRecursively(this.Controls);
        }

        private void DisableControlsRecursively(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.FromArgb(205, 92, 92);
                    control.ForeColor = Color.White;
                    control.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else if (control is PictureBox pictureBox)
                {
                    pictureBox.BackColor = Color.FromArgb(205, 92, 92);
                }
                else if (control is Panel panel)
                {
                    panel.BackColor = Color.FromArgb(205, 92, 92);
                    DisableControlsRecursively(panel.Controls);
                }
                else if (control is GroupBox || control is FlowLayoutPanel)
                {
                    DisableControlsRecursively(control.Controls);
                }
            }
        }
        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategoria.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvCategoria.SelectedRows)
                {
                    if (!fila.IsNewRow)
                    {
                        dgvCategoria.Rows.Remove(fila);
                    }
                }

                // Actualiza el contador después de eliminar filas
                ActualizarContador();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text;
            bool encontrado = false;

            foreach (DataGridViewRow fila in dgvCategoria.Rows)
            {
                if (fila.Cells["Nombre"].Value != null && fila.Cells["Nombre"].Value.ToString().Contains(textoBusqueda))
                {
                    fila.Selected = true; // Selecciona la fila que coincide
                    dgvCategoria.FirstDisplayedScrollingRowIndex = fila.Index; // Desplaza a la fila encontrada
                    encontrado = true;
                    break; // Finaliza la búsqueda al encontrar la primera coincidencia
                }
                else
                {
                    fila.Selected = false; // Deselecciona otras filas
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró ningún producto con ese nombre.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            using (var formulario = new FrmProductoNuevo())
            {
                if (formulario.ShowDialog() == DialogResult.OK)
                {
                    string nombre = formulario.Nombre;
                    string categoria = formulario.Categoria;
                    string descripcion = formulario.Descripcion;
                    string alto = formulario.Alto;
                    string ancho = formulario.Ancho;
                    string grosor = formulario.Grosor;
                    string precio = formulario.Precio;
                    string peso = formulario.Peso;
                    string cantidad = formulario.Cantidad;

                    dgvCategoria.Rows.Add("", categoria, nombre, descripcion, alto, ancho, grosor, precio, peso, cantidad);

                    // Actualiza el contador después de añadir filas
                    ActualizarContador();
                }
            }
        }
        private int ObtenerCantidadFilas()
        {
            return dgvCategoria.Rows.Count; // Devuelve el número de filas actuales
        }

        private void btnAbrirDashboard_Click(object sender, EventArgs e)
        {
            int contadorFilas = ObtenerCantidadFilas();

            // Abre el formulario DashboardForm y pasa el contador
            var dashboard = new DashboardForm();
            dashboard.ActualizarContador(contadorFilas);
            dashboard.Show();
        }
    }
}
