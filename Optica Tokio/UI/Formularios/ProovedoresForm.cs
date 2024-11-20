﻿using System;
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
            dataGridViewProveedores.Columns.Clear();
            dataGridViewProveedores.Columns.Add("Nombre", "Nombre");
            dataGridViewProveedores.Columns.Add("Contacto", "Contacto");
            dataGridViewProveedores.Columns.Add("Teléfono", "Teléfono");
            dataGridViewProveedores.Columns.Add("Email", "Email");
            dataGridViewProveedores.Columns.Add("Dirección", "Dirección");
        }
<<<<<<< HEAD
        private void ProovedoresForm_Load(object sender, EventArgs e){}
=======
>>>>>>> ab481e60986b39eb2dedd84cd78402ccd6e07983
        private void btnAgregarPROVEEDOR_Click(object sender, EventArgs e){}
        private void btnEditarPROVEEDOR_Click(object sender, EventArgs e){}
        private void btnElimarPROVEEDOR_Click(object sender, EventArgs e){}
        private void btnBuscarPROVEEDOR_Click(object sender, EventArgs e){}
        private void txtExportar_Click(object sender, EventArgs e){}
        private void txtExportar_Click_1(object sender, EventArgs e)//btnExportar
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos CSV (*.csv)|*.csv",
                Title = "Exportar Proveedores"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();
                foreach (DataGridViewRow fila in dataGridViewProveedores.Rows)
                {
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        sb.Append(celda.Value?.ToString() + ",");
                    }
                    sb.AppendLine();
                }

                System.IO.File.WriteAllText(saveFileDialog.FileName, sb.ToString());
                MessageBox.Show("Proveedores exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarPROVEEDOR_Click_1(object sender, EventArgs e)
        {
            dataGridViewProveedores.Rows.Add(txtNombreProveedor.Text, txtContacto.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text);
            MessageBox.Show("Proveedor agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombreProveedor.Clear();
            txtContacto.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
        }

        private void btnEditarPROVEEDOR_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridViewProveedores.SelectedRows[0];
                filaSeleccionada.Cells["Nombre"].Value = txtNombreProveedor.Text;
                filaSeleccionada.Cells["Contacto"].Value = txtContacto.Text;
                filaSeleccionada.Cells["Teléfono"].Value = txtTelefono.Text;
                filaSeleccionada.Cells["Email"].Value = txtEmail.Text;
                filaSeleccionada.Cells["Dirección"].Value = txtDireccion.Text;

                MessageBox.Show("Proveedor editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proveedor para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElimarPROVEEDOR_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewProveedores.SelectedRows.Count > 0)
            {
                dataGridViewProveedores.Rows.Remove(dataGridViewProveedores.SelectedRows[0]);
                MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DataGridViewRow filaSeleccionada = dataGridViewProveedores.SelectedRows[0];
                txtNombreProveedor.Text = filaSeleccionada.Cells["Nombre"].Value?.ToString() ?? "";
                txtContacto.Text = filaSeleccionada.Cells["Contacto"].Value?.ToString() ?? "";
                txtTelefono.Text = filaSeleccionada.Cells["Teléfono"].Value?.ToString() ?? "";
                txtEmail.Text = filaSeleccionada.Cells["Email"].Value?.ToString() ?? "";
                txtDireccion.Text = filaSeleccionada.Cells["Dirección"].Value?.ToString() ?? "";
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
    }
}
