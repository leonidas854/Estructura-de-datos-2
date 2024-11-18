using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Optica_Tokio.UI.Formularios;
using Optica_Tokio.Logica_del_Negocio.Servicios;
using Optica_Tokio.Logica_del_Negocio.Modelos;


namespace Optica_Tokio
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if(txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtuser.Text))
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.Red;

            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if( txtpassword.Text == "CONTRASEÑA")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.Black;
                txtpassword.UseSystemPasswordChar = true;
            }

        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                txtpassword.Text = "CONTRASEÑA";
                txtpassword.ForeColor = Color.Red;
                txtpassword.UseSystemPasswordChar = false;
            }
        }


        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btneye_Click(object sender, EventArgs e)
        {
            if(txtpassword.UseSystemPasswordChar == false)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtuser.Text) || txtuser.Text == "USUARIO")
            {
                MessageBox.Show("Por favor, ingresa un nombre de usuario válido.", "Error de Validación");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtpassword.Text) || txtpassword.Text == "CONTRASEÑA")
            {
                MessageBox.Show("Por favor, ingresa una contraseña válida.", "Error de Validación");
                return;
            }

            try
            {
             
                Usuario usuario = UsuarioService.ValidarCredenciales(txtuser.Text, txtpassword.Text);
                /*if (usuario == null)
                {
                    
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Autenticación");
                    return;
                }*/
                FrmLoading_Screen loadingScreen = new FrmLoading_Screen();
                loadingScreen.Show();
                this.Hide(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar iniciar sesión: {ex.Message}", "Error");
            }
        }
        
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
