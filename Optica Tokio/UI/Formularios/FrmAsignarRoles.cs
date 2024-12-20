﻿using Optica_Tokio.Logica_del_Negocio.Modelos;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Optica_Tokio.UI.Formularios
{
    public partial class FrmAsignarRoles : Form
    {
        private RolesServices rolesService;
        public FrmAsignarRoles()
        {
            InitializeComponent();
            rolesService = new RolesServices();
        }

        private void btnGuardarNuevoRol_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNuevoRol.Text) || txtNuevoRol.Text == "NOMBRE")
                {
                    MessageBox.Show("Por favor, ingrese un nombre válido para el rol.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nuevoNombre = txtNuevoRol.Text.Trim();
                string nuevaDescripcion = txtdescrip.Text.Trim(); 

                
                int nuevoId = RolesServices.roles.GetTam() + 1;
                var nuevoRol = new Rol(nuevoId, nuevoNombre, nuevaDescripcion);

               
                rolesService.AgregarRol(nuevoRol);

                //MessageBox.Show("Rol agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el rol: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarNuevoRol_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            this.Close();
        }

        private void txtNuevoRol_Enter(object sender, EventArgs e)
        {
            if (txtNuevoRol.Text == "NOMBRE")
            {
                txtNuevoRol.Text = "";
                txtNuevoRol.ForeColor = Color.Black; 
            }
        }

        private void txtNuevoRol_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNuevoRol.Text))
            {
                txtNuevoRol.Text = "NOMBRE";
                txtNuevoRol.ForeColor = Color.Gray; 
            }
        }

        private void FrmAsignarRoles_Load(object sender, EventArgs e)
        {

        }

        private void txtdescrip_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdescrip.Text))
            {
                txtdescrip.Text = "DESCRIPCION";
                txtdescrip.ForeColor = Color.Gray;
            }
        }
    }
}
