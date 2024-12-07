using Optica_Tokio.Logica_del_Negocio.Estructura_de_datos;
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
    public partial class FrmPermisos : Form
    {
        private Lista<string> permisosSeleccionados;
        private int idRol;
        public int IdRolSeleccionado { get; set; }
        public FrmPermisos(int rolId)
        {
            InitializeComponent();
            permisosSeleccionados = new Lista<string>();
            idRol = rolId;
        }

        private void btnActualizarPermisos_Click(object sender, EventArgs e)
        {
            GuardarPermisos();
            MessageBox.Show("Permisos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelarPermisos_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void chkChangedCh(object sender, EventArgs e)
        {
        }
        

        private void FrmPermisos_Load(object sender, EventArgs e)
        {
           
            CargarPermisos();
        }


        private void CargarPermisos()
        {
            // Obtener permisos asignados al rol
            var permisosActuales = PermisosServices.permisos
                .Where(p => p.ID_Rol == idRol)
                .Select(p => p.ID_Controlador)
                .ToList();

            // Marcar CheckBoxes según los permisos actuales
            chkCategorias.Checked = permisosActuales.Contains(2);
            chkProductos.Checked = permisosActuales.Contains(1);
            chkProveedores.Checked = permisosActuales.Contains(3);
            chkEntradas.Checked = permisosActuales.Contains(4);
            chkSalidas.Checked = permisosActuales.Contains(5);
            chkGestionDeRoles.Checked = permisosActuales.Contains(6);
            chkUsuarios.Checked = permisosActuales.Contains(7);
            chkReportes.Checked = permisosActuales.Contains(8);
            chkInfo.Checked = permisosActuales.Contains(10);
        }


        private void MarcarCheckbox(CheckBox chk, string permiso, List<string> permisosActuales)
        {
            if (permisosActuales.Contains(permiso))
            {
                chk.Checked = true;
            }
            else
            {
                chk.Checked = false;
            }
        }
        private void GuardarPermisos()
        {
            // Eliminar permisos existentes para este rol
            var permisosAEliminar = PermisosServices.permisos
                .Where(p => p.ID_Rol == idRol)
                .ToList();

            foreach (var permiso in permisosAEliminar)
            {
                PermisosServices.EliminarPermiso(permiso.ID_Rol, permiso.ID_Controlador);
            }

            // Crear los nuevos permisos seleccionados
            var permisosSeleccionados = new List<PermisoRol>();
            if (chkCategorias.Checked)
                permisosSeleccionados.Add(new PermisoRol(idRol, 2, "Completo"));
            if (chkProductos.Checked)
                permisosSeleccionados.Add(new PermisoRol(idRol, 1, "Completo"));
            if (chkProveedores.Checked)
                permisosSeleccionados.Add(new PermisoRol(idRol, 3, "Completo"));
            if (chkEntradas.Checked)
                permisosSeleccionados.Add(new PermisoRol(idRol, 4, "Completo"));
            if (chkSalidas.Checked)
                permisosSeleccionados.Add(new PermisoRol(idRol, 5, "Completo"));
            if (chkGestionDeRoles.Checked)
                permisosSeleccionados.Add(new PermisoRol(idRol, 6, "Completo"));
            if (chkUsuarios.Checked)
                permisosSeleccionados.Add(new PermisoRol(idRol, 7, "Completo"));
            if (chkReportes.Checked)
                permisosSeleccionados.Add(new PermisoRol(idRol, 8, "Completo"));
            if (chkInfo.Checked)
                permisosSeleccionados.Add(new PermisoRol(idRol, 10, "Completo"));

            // Agregar los permisos seleccionados
            foreach (var permiso in permisosSeleccionados)
            {
                PermisosServices.AgregarPermiso(permiso);
            }

            MessageBox.Show("Permisos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string ObtenerNombrePermisoPorControlador(int controladorId)
        {
            switch (controladorId)
            {
                case 1: return "Productos";
                case 2: return "Categorías";
                case 3: return "Proveedores";
                case 4: return "Entradas";
                case 5: return "Salidas";
                case 6: return "Roles";
                case 7: return "Usuarios";
                case 8: return "Reportes";
                case 9: return "Clientes";
                case 10: return "ABOUT";
                default: return "Desconocido";
            }
        }

        private int ObtenerControladorIdPorNombre(string nombre)
        {
            switch (nombre)
            {
                case "Clientes": return 9;
                case "Categorías": return 2;
                case "Productos": return 1;
                case "Proveedores": return 3;
                case "Entradas": return 4;
                case "Salidas": return 5;
                case "Roles": return 6;
                case "Usuarios": return 7;
                case "Reportes": return 8;
                case "ABOUT": return 10;
                default: return 0;
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
