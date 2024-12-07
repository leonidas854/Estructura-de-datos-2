using Optica_Tokio.Logica_del_Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Optica_Tokio.Logica_del_Negocio.Servicios;

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
            CargarUsuarios();
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
        private void ConfigurarColumnas()
        {
           
            if (dgvUsuarios.Columns["Contrasena"] != null)
                dgvUsuarios.Columns["Contrasena"].Visible = false;

            if (dgvUsuarios.Columns["Foto"] != null)
                dgvUsuarios.Columns["Foto"].Visible = false;

            if (dgvUsuarios.Columns["ID_Usuario"] != null)
                dgvUsuarios.Columns["ID_Usuario"].HeaderText = "ID";

            if (dgvUsuarios.Columns["Nombre_Usuario"] != null)
                dgvUsuarios.Columns["Nombre_Usuario"].HeaderText = "Nombre";

            if (dgvUsuarios.Columns["Correo"] != null)
                dgvUsuarios.Columns["Correo"].HeaderText = "Correo Electrónico";

            if (dgvUsuarios.Columns["ID_Rol"] != null)
                dgvUsuarios.Columns["ID_Rol"].HeaderText = "Rol";

            if (dgvUsuarios.Columns["Fecha_Creacion"] != null)
                dgvUsuarios.Columns["Fecha_Creacion"].HeaderText = "Fecha de Creación";
        }
        private void CargarUsuarios()
        {
            try
            {
           
                List<Usuario> usuarios = UsuarioService.ListarUsuarios();

            
                dgvUsuarios.DataSource = usuarios;

             
                ConfigurarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnNewUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario AgregarUsuarioForm = new AgregarUsuario();
            AgregarUsuarioForm.StartPosition = FormStartPosition.CenterScreen;
            AgregarUsuarioForm.Show();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
