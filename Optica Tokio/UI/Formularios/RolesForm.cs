using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Optica_Tokio.UI.Formularios
{
    public partial class RolesForms : Form
    {
        public RolesForms()
        {
            InitializeComponent();
            //dgvRoles.CellClick += dgvRoles_CellClick;
        }

        private void btnRolNuevo_Click(object sender, EventArgs e)
        {
            FrmAsignarRoles formRolNuevo = new FrmAsignarRoles();

            // Mostrar el formulario como modal
            if (formRolNuevo.ShowDialog() == DialogResult.OK)
            {
                // Aquí puedes manejar lo que sucede después de guardar
                MessageBox.Show("Rol guardado correctamente.");
            }
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void RolesForms_Load(object sender, EventArgs e)
        {
            

            

        }

        private void dgvRoles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
            
        }

        private void dgvRoles_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvMostrarRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvMostrarRol.Columns[e.ColumnIndex].Name == "Otorgar_Permisos")
            {
                FrmPermisos formPermiso = new FrmPermisos();

                // Mostrar el formulario como modal
                if (formPermiso.ShowDialog() == DialogResult.OK)
                {
                    // Aquí puedes manejar lo que sucede después de guardar
                    MessageBox.Show("PERMISOS OTRGADOS EXITOSAMENTE.");
                }
            }
        }
    }
}
