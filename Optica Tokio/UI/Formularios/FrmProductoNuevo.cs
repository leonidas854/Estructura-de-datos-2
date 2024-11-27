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
    public partial class FrmProductoNuevo : Form
    {
        public string Nombre { get; private set; }
        public string Categoria { get; private set; }
        public FrmProductoNuevo()
        {
            InitializeComponent();
        }

        private void btnGuardado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxDeCategorias.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Tiene que llenar el nombre y asignarle una categoria");
                return;
            }

            Categoria = comboBoxDeCategorias.Text;
            Nombre = txtNombre.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = Color.Gray;
            }
        }
    }
}
