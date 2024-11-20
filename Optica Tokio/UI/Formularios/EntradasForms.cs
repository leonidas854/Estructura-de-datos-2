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
    public partial class EntradasForms : Form
    {
        public EntradasForms()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            ConfigurarDataGridView();
        }
        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Add("Producto", "Producto");
            dataGridView1.Columns.Add("Proveedor", "Proveedor");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Descripcion", "Descripción");
            dataGridView1.Columns.Add("Fecha", "Fecha");
        }

        private void EntradasForms_Load(object sender, EventArgs e)
        {
            cmbProducto.Items.AddRange(new string[] { "Lentes", "Armazones", "Accesorios" });
            cmbProveedor.Items.AddRange(new string[] { "Proveedor A", "Proveedor B", "Proveedor C" });
            dtpFecha.Value = DateTime.Now;
           MessageBox.Show("Formulario cargado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Gray, 2))
            {
                Rectangle rect = new Rectangle(0, 0, panel1.Width - 1, panel1.Height - 1);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Estás configurando un nuevo registro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productoSeleccionado = cmbProducto.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(productoSeleccionado))
            {
                MessageBox.Show($"Producto seleccionado: {productoSeleccionado}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCantidad.Text, out _) && !string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, introduzca solo números en el campo de cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Clear();
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFecha.Value;
            //MessageBox.Show($"Fecha seleccionada: {fechaSeleccionada.ToShortDateString()}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Length > 200)
            {
                MessageBox.Show("La descripción no puede exceder los 200 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Text = txtDescripcion.Text.Substring(0, 200);
            }
        }

        private void btnRegistrarPROVEEDOR_Click(object sender, EventArgs e)
        {
            try
            {
                string producto = cmbProducto.SelectedItem?.ToString();
                string proveedor = cmbProveedor.SelectedItem?.ToString();
                int cantidad;
                bool esCantidadValida = int.TryParse(txtCantidad.Text, out cantidad);
                string descripcion = txtDescripcion.Text;
                DateTime fecha = dtpFecha.Value;
                if (string.IsNullOrEmpty(producto) || string.IsNullOrEmpty(proveedor) || !esCantidadValida || cantidad <= 0)
                {
                    MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridView1.Rows.Add(producto, proveedor, cantidad, descripcion, fecha.ToShortDateString());
                MessageBox.Show("Registro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            cmbProducto.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            txtCantidad.Clear();
            txtDescripcion.Clear();
            dtpFecha.Value = DateTime.Now;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Campos limpiados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    dataGridView1.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Seleccione un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    cmbProducto.SelectedItem = dataGridView1.Rows[rowIndex].Cells["Producto"].Value.ToString();
                    cmbProveedor.SelectedItem = dataGridView1.Rows[rowIndex].Cells["Proveedor"].Value.ToString();
                    txtCantidad.Text = dataGridView1.Rows[rowIndex].Cells["Cantidad"].Value.ToString();
                    txtDescripcion.Text = dataGridView1.Rows[rowIndex].Cells["Descripcion"].Value.ToString();
                    dtpFecha.Value = DateTime.Parse(dataGridView1.Rows[rowIndex].Cells["Fecha"].Value.ToString());
                    dataGridView1.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    MessageBox.Show("Seleccione un registro para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al editar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string productoBuscar = cmbProducto.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(productoBuscar))
                {
                    MessageBox.Show("Seleccione un producto para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Producto"].Value?.ToString() == productoBuscar)
                    {
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        MessageBox.Show("Registro encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                MessageBox.Show("No se encontró un registro con el producto especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    string columna = dataGridView1.Columns[e.ColumnIndex].HeaderText;
                    string valor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

                    MessageBox.Show($"Columna: {columna}\nValor: {valor}", "Información de Celda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string proveedorSeleccionado = cmbProveedor.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(proveedorSeleccionado))
            {
                MessageBox.Show($"Proveedor seleccionado: {proveedorSeleccionado}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.SetToolTip(dataGridView1, "Aquí puedes ver y gestionar las entradas registradas.");
        }
        public class Entrada
        {
            public string Producto { get; set; }
            public string Proveedor { get; set; }
            public int Cantidad { get; set; }
            public string Descripcion { get; set; }
            public DateTime Fecha { get; set; }
        }
    }
}
