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
    public partial class CategoriasForms : Form
    {
        public CategoriasForms()
        {
            InitializeComponent();
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoriasNuevas formRolNuevo = new FrmCategoriasNuevas();

            // Mostrar el formulario como modal
            if (formRolNuevo.ShowDialog() == DialogResult.OK)
            {
                // Aquí puedes manejar lo que sucede después de guardar
                MessageBox.Show("Categoria guardada correctamente.");
            }
        }
        //int n = dgvCategoria.Rows.Add();
        //dgvCategoria.Rows[n].Cells[0].Value = txtCategoria.Text;
            //txtCategoria.Text = "";

        private void Click_Eliminar(object sender, DataGridViewCellEventArgs e)
        {
            dgvCategoria.Rows.Clear();
        }

        private void txtCategoria_Enter(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "BUSCAR POR NOMBRE")
            {
                txtCategoria.Text = "";
                txtCategoria.ForeColor = Color.Black; // Cambiar el color al normal
            }
        }

        private void txtCategoria_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                txtCategoria.Text = "BUSCAR POR NOMBRE";
                txtCategoria.ForeColor = Color.Gray; // Volver al color gris
            }
        }
    }
}
