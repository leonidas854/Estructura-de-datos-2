using Optica_Tokio.Logica_del_Negocio.Servicios;
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
        private RolesServices rolesServices;
        public RolesForms()
        {
            InitializeComponent();
            rolesServices = new RolesServices();
        }

        private void btnRolNuevo_Click(object sender, EventArgs e)
        {
            FrmAsignarRoles formRolNuevo = new FrmAsignarRoles();

            // Mostrar el formulario como modal
            if (formRolNuevo.ShowDialog() == DialogResult.OK)
            {
                // Actualizar los roles en el DataGridView
                CargarRoles();
                MessageBox.Show("Rol guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


            CargarRoles();

        }
        private void ConfigurarDataGridView()
        {
            dgvMostrarRol.Rows.Clear();
            dgvMostrarRol.Columns.Clear();

            //dgvMostrarRol.Columns.Add("ID", "ID");
            dgvMostrarRol.Columns.Add("Nombre", "Nombre del Rol");
            dgvMostrarRol.Columns.Add("Descripcion", "Descripción");

            var otorgarPermisosColumna = new DataGridViewButtonColumn
            {
                Name = "Otorgar_Permisos",
                HeaderText = "Otorgar Permisos",
                Text = "Permisos",
                UseColumnTextForButtonValue = true
            };

            var eliminarColumna = new DataGridViewButtonColumn
            {
                Name = "Eliminar",
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };

            dgvMostrarRol.Columns.Add(otorgarPermisosColumna);
            dgvMostrarRol.Columns.Add(eliminarColumna);
        }

        private void CargarRoles()
        {
            dgvMostrarRol.Rows.Clear();
            foreach (var rol in RolesServices.roles)
            {
                dgvMostrarRol.Rows.Add(rol.Nombre_Rol, rol.Descripcion);
            }
        }

        private void dgvRoles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
            
        }

        private void dgvRoles_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvMostrarRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Verificar si el clic no es válido

            // Obtener el rol correspondiente desde la lista según el índice de la fila
            var rolSeleccionado = RolesServices.roles[e.RowIndex];

            if (dgvMostrarRol.Columns[e.ColumnIndex].Name == "Otorgar_Permisos")
            {
                // Pasar el nombre del rol o su objeto completo al formulario FrmPermisos
                FrmPermisos formPermiso = new FrmPermisos(rolSeleccionado.ID_Rol); // Usa el ID del rol del objeto seleccionado

                if (formPermiso.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show($"Permisos otorgados para el rol: {rolSeleccionado.Nombre_Rol}.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (dgvMostrarRol.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                var confirmResult = MessageBox.Show(
                    $"¿Está seguro de eliminar el rol: {rolSeleccionado.Nombre_Rol}?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    rolesServices.EliminarRolPorId(rolSeleccionado.ID_Rol);
                    CargarRoles();
                    MessageBox.Show("Rol eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvMostrarRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
