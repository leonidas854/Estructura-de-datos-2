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
    public partial class Frm_User : Form
    {
        public Frm_User()
        {
            InitializeComponent();
        }

        private void Frm_User_Load(object sender, EventArgs e)
        {

        }

        private void txtBNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNewUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario AgregarUsuarioForm = new AgregarUsuario();
            AgregarUsuarioForm.StartPosition = FormStartPosition.CenterScreen;
            AgregarUsuarioForm.Show();
        }
    }
}
