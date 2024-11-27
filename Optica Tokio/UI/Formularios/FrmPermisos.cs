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
            CheckBox chk = sender as CheckBox;
            if (chk != null)
            {
                if (chk.Checked)
                {
                    permisosSeleccionados.Insertar(chk.Text);
                }
                else
                {
                    permisosSeleccionados.Eliminar(chk.Text);
                }
            }
        }
        

        private void FrmPermisos_Load(object sender, EventArgs e)
        {
           // CargarPermisos();
            // Cargar los permisos existentes para el rol seleccionado
            var permisosActuales = PermisosServices.permisos
                .Where(p => p.ID_Rol == IdRolSeleccionado)
                .ToList();

            // Lógica para marcar los permisos existentes en los CheckBoxes
            foreach (var permiso in permisosActuales)
            {
                // Marca los CheckBoxes según los permisos existentes
                switch (permiso.ID_Controlador)
                {
                    case 1: chkProductos.Checked = true; break;
                    case 2: chkCategorias.Checked = true; break;
                    case 3: chkProveedores.Checked = true; break;
                        // Agregar los demás casos según el controlador
                }
            }
        }
        private void CargarPermisos()
        {
            // Obtenemos los permisos asignados a este rol
            PermisosServices permisosServices = new PermisosServices();
            var permisosActuales = permisosServices.BuscarPermisosPorRol(idRol);

            // Cargar permisos asignados
            foreach (var permiso in permisosActuales)
            {
                permisosSeleccionados.Insertar(permiso.ID_Controlador.ToString());
            }

            // Marcar checkboxes basados en permisos
            MarcarCheckbox(chkCategorias, "Categorías");
            MarcarCheckbox(chkProductos, "Productos");
            MarcarCheckbox(chkProveedores, "Proveedores");
            MarcarCheckbox(chkEntradas, "Entradas");
            MarcarCheckbox(chkSalidas, "Salidas");
            MarcarCheckbox(chkGestionDeRoles, "Roles");
            MarcarCheckbox(chkUsuarios, "Usuarios");
            MarcarCheckbox(chkReportes, "Reportes");
            MarcarCheckbox(chkInfo, "ABOUT");
        }
        private void MarcarCheckbox(CheckBox chk, string permiso)
        {
            if (permisosSeleccionados.Contains(permiso))
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
            var permisosAEliminar = PermisosServices.permisos
                .Where(p => p.ID_Rol == idRol)
                .ToList();

            foreach (var permiso in permisosAEliminar)
            {
                PermisosServices.EliminarPermiso(permiso.ID_Rol, permiso.ID_Controlador);
            }

            // Agregar los nuevos permisos
            foreach (var permiso in permisosSeleccionados)
            {
                var controladorId = ObtenerControladorIdPorNombre(permiso);
                if (controladorId > 0)
                {
                    PermisosServices.AgregarPermiso(new PermisoRol(idRol, controladorId, "ACTIVO"));
                }
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
    }
}
