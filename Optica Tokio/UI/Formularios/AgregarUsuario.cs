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
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Silver;
            }
        }

        private void txtCorreoUsuario_Enter(object sender, EventArgs e)
        {
            if (txtCorreoUsuario.Text == "Usuario@gmail.com")
            {
                txtCorreoUsuario.Text = "";
                txtCorreoUsuario.ForeColor = Color.Black;
            }
        }

        private void txtCorreoUsuario_Leave(object sender, EventArgs e)
        {
            if (txtCorreoUsuario.Text == "")
            {
                txtCorreoUsuario.Text = "Usuario@gmail.com";
                txtCorreoUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Ingresar Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Ingresar Contraseña";
                txtContraseña.ForeColor = Color.Silver;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtReingresarContraseña_Enter(object sender, EventArgs e)
        {
            if (txtReingresarContraseña.Text == "Reingresar Contraseña")
            {
                txtReingresarContraseña.Text = "";
                txtReingresarContraseña.ForeColor = Color.Black;
                txtReingresarContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtReingresarContraseña_Leave(object sender, EventArgs e)
        {
            if (txtReingresarContraseña.Text == "")
            {
                txtReingresarContraseña.Text = "Reingresar Contraseña";
                txtReingresarContraseña.ForeColor = Color.Silver;
                txtReingresarContraseña.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
