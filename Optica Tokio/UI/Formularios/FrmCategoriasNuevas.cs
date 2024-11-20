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
    public partial class FrmCategoriasNuevas : Form
    {
        public FrmCategoriasNuevas()
        {
            InitializeComponent();
        }

        private void btnCancelarNuevoRol_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Retorna Cancel si se cancela
            this.Close();
        }

        private void btnGuardarNuevoRol_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtNuevoRol_Enter(object sender, EventArgs e)
        {
            if (txtNuevoRol.Text == "NOMBRE")
            {
                txtNuevoRol.Text = "";
                txtNuevoRol.ForeColor = Color.Black; // Cambiar el color al normal
            }
        }

        private void txtNuevoRol_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNuevoRol.Text))
            {
                txtNuevoRol.Text = "NOMBRE";
                txtNuevoRol.ForeColor = Color.Gray; // Volver al color gris
            }
        }
    }
}
