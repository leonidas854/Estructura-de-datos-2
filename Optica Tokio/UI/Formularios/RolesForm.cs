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
            DataGridViewButtonColumn btnOtorgarPermisos = new DataGridViewButtonColumn();
            btnOtorgarPermisos.Name = "Otorgar Permisos";
            dgvRoles.Columns.Add(btnOtorgarPermisos);

            

        }

        private void dgvRoles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvRoles.Columns[e.ColumnIndex].Name=="Otorgar Permisos" && e.RowIndex>=0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celPermisos = this.dgvRoles.Rows[e.RowIndex].Cells["Otorgar Permisos"] as DataGridViewButtonCell;
                //Icon icoPermiso=new Icon(Environment.CurrentDirectory)
                //e.Graphics
                e.Handled = true;
            }
            
        }

        private void dgvRoles_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvRoles.Columns[e.ColumnIndex].Name == "Otorgar Permisos")
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
