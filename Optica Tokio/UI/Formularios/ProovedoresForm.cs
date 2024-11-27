using Npgsql.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Optica_Tokio.Logica_del_Negocio.Servicios;
using Optica_Tokio.Logica_del_Negocio.Modelos;


namespace Optica_Tokio.UI.Formularios
{
    public partial class ProovedoresForm : Form
    {
        public ProovedoresForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            CargarProveedores();
        }
        private void CargarProveedores()
        {
            dataGridViewProveedores.Rows.Clear();
            foreach (var proveedor in ProvedoresServices.arbolProveedores.RecorridoAmplitud())
            {
                dataGridViewProveedores.Rows.Add(
                    proveedor.Nombre,
                    proveedor.Contacto,
                    proveedor.Telefono,
                    proveedor.Email,
                    proveedor.Direccion,
                    proveedor.Condiciones_Entrega
                );
            }
        }

        private void txtExportar_Click_1(object sender, EventArgs e)//btnExportar
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos PDF (*.pdf)|*.pdf",
                Title = "Exportar Proveedores"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document documento = new Document(PageSize.A4, 50, 50, 25, 25);
                    PdfWriter.GetInstance(documento, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    documento.Open();
                    PdfPTable tabla = new PdfPTable(dataGridViewProveedores.Columns.Count);
                    foreach (DataGridViewColumn columna in dataGridViewProveedores.Columns)
                    {
                        tabla.AddCell(new Phrase(columna.HeaderText));
                    }
                    foreach (DataGridViewRow fila in dataGridViewProveedores.Rows)
                    {
                        if (!fila.IsNewRow)
                        {
                            foreach (DataGridViewCell celda in fila.Cells)
                            {
                                tabla.AddCell(new Phrase(celda.Value?.ToString() ?? ""));
                            }
                        }
                    }
                    documento.Add(tabla);
                    documento.Close();

                    MessageBox.Show("Los datos han sido exportados exitosamente a PDF.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al exportar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnAgregarPROVEEDOR_Click_1(object sender, EventArgs e)
        {
            try
            {
                var nuevoProveedor = new Proveedor(
                    ProvedoresServices.arbolProveedores.GetTam() + 1,
                    txtNombreProveedor.Text,
                    txtContacto.Text,
                    txtTelefono.Text,
                    txtEmail.Text,
                    txtDireccion.Text,
                   txtCcondiciones.Text
                );

                ProvedoresServices.AgregarProveedor( nuevoProveedor );
                CargarProveedores();
                MessageBox.Show("Proveedor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreProveedor.Clear();
                txtContacto.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtDireccion.Clear();
               txtCcondiciones.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarPROVEEDOR_Click_1(object sender, EventArgs e) // Editar Proveedor
        {
            if (dataGridViewProveedores.SelectedRows.Count > 0)
            {
                try
                {
                    var filaSeleccionada = dataGridViewProveedores.SelectedRows[0];
                    int idProveedor = filaSeleccionada.Index + 1;

                    ProvedoresServices.EditarProveedor(new Proveedor(
                        idProveedor,
                        txtNombreProveedor.Text,
                        txtContacto.Text,
                        txtTelefono.Text,
                        txtEmail.Text,
                        txtDireccion.Text,
                        txtCcondiciones.Text
                    ));

                    CargarProveedores();
                    MessageBox.Show("Proveedor editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar el proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proveedor para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElimarPROVEEDOR_Click_1(object sender, EventArgs e) // Eliminar Proveedor
        {
            if (dataGridViewProveedores.SelectedRows.Count > 0)
            {
                try
                {
                    var filaSeleccionada = dataGridViewProveedores.SelectedRows[0];
                    int idProveedor = filaSeleccionada.Index + 1;

                    //ProvedoresServices.EliminarProveedor(idProveedor);
                    CargarProveedores();
                    MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proveedor para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarPROVEEDOR_Click_1(object sender, EventArgs e)
        {
            string nombreBuscado = txtNombreProveedor.Text.ToLower();
            string contactoBuscado = txtContacto.Text.ToLower();
            string emailBuscado = txtEmail.Text.ToLower();
            bool encontrado = false;
            dataGridViewProveedores.ClearSelection();
            foreach (DataGridViewRow fila in dataGridViewProveedores.Rows)
            {
                bool coincideNombre = string.IsNullOrEmpty(nombreBuscado) || fila.Cells["Nombre"].Value?.ToString().ToLower().Contains(nombreBuscado) == true;
                bool coincideContacto = string.IsNullOrEmpty(contactoBuscado) || fila.Cells["Contacto"].Value?.ToString().ToLower().Contains(contactoBuscado) == true;
                bool coincideEmail = string.IsNullOrEmpty(emailBuscado) || fila.Cells["Email"].Value?.ToString().ToLower().Contains(emailBuscado) == true;
                if (coincideNombre && coincideContacto && coincideEmail)
                {
                    fila.Selected = true;
                    encontrado = true;
                }
            }
            if (encontrado)
            {
                MessageBox.Show("Proveedor(es) encontrado(s).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontraron proveedores que coincidan con los criterios especificados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProveedores.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dataGridViewProveedores.SelectedRows[0];
                txtNombreProveedor.Text = filaSeleccionada.Cells["Nombre"].Value?.ToString() ?? "";
                txtContacto.Text = filaSeleccionada.Cells["Contacto"].Value?.ToString() ?? "";
                txtTelefono.Text = filaSeleccionada.Cells["Teléfono"].Value?.ToString() ?? "";
                txtEmail.Text = filaSeleccionada.Cells["Email"].Value?.ToString() ?? "";
                txtDireccion.Text = filaSeleccionada.Cells["Dirección"].Value?.ToString() ?? "";
                txtCcondiciones.Text = filaSeleccionada.Cells["Condiciones"].Value?.ToString() ?? "";
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void txtNombreProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text.Length > 50)
            {
                
                MessageBox.Show("El nombre no puede exceder los 50 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreProveedor.Text = txtNombreProveedor.Text.Substring(0, 50);
            }
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text.Length > 1000)
            {
                MessageBox.Show("El contacto no puede exceder los 1000 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContacto.Text = txtContacto.Text.Substring(0, 1000);
            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Length > 200)
            {
                MessageBox.Show("La dirección no puede exceder los 200 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Text = txtDireccion.Text.Substring(0, 200);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, emailPattern))
                {
                    txtEmail.BackColor = Color.Red;
                }
                else
                {
                    txtEmail.BackColor = Color.White;
                }
            }
            else
            {
                txtEmail.BackColor = Color.White;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (!long.TryParse(txtTelefono.Text, out _) && !string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, introduce solo números en el teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Clear();
            }
        }

        private void ProovedoresForm_Load_1(object sender, EventArgs e)
        {

        }

        private void ProovedoresForm_Load(object sender, EventArgs e)
        {

        }
    }
}
