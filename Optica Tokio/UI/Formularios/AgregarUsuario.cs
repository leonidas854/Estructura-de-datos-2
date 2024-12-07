using Optica_Tokio.Logica_del_Negocio.Modelos;
using Optica_Tokio.Logica_del_Negocio.Servicios;
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

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmarRol_Click(object sender, EventArgs e)
        {
       
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || txtNombre.Text == "Nombre")
            {
                MessageBox.Show("Por favor, ingrese un nombre válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCorreoUsuario.Text) || txtCorreoUsuario.Text == "Usuario@gmail.com")
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text) || txtContraseña.Text == "Ingresar Contraseña")
            {
                MessageBox.Show("Por favor, ingrese una contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtContraseña.Text != txtReingresarContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo nuevamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
           
                Usuario nuevoUsuario = new Usuario
                {
                    ID_Usuario = new Random().Next(1, 1000), 
                    Nombre_Usuario = txtNombre.Text.Trim(),
                    Correo = txtCorreoUsuario.Text.Trim(),
                    Contrasena = txtContraseña.Text,
                    ID_Rol = 1, 
                    Fecha_Creacion = DateTime.Now,
                    Foto = null
                };

            
                UsuarioService.CrearUsuario(nuevoUsuario);

                MessageBox.Show("Usuario agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

