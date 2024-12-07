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
    public partial class FrmCategoriasNuevas : Form
    {
        public FrmCategoriasNuevas()
        {
            InitializeComponent();
        }

        private void btnCancelarNuevoRol_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            this.Close();
        }

        private void btnGuardarNuevoRol_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrWhiteSpace(txtNuevoRol.Text) || txtNuevoRol.Text == "NOMBRE")
                {
                    MessageBox.Show("Por favor, ingrese un nombre válido para la categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

             
                var nuevaCategoria = new Categorias(
                    id: CategoriasServices.categorias.GetTam() + 1, 
                    nombre: txtNuevoRol.Text.Trim(),
                    descripcion: "Descripción predeterminada" 
                );

                // Verificar si la categoría ya existe en el árbol
                if (CategoriasServices.categorias.GetValorPorLlave(nuevaCategoria.ID_Categoria) != null)
                {
                    MessageBox.Show("La categoría ya existe. Por favor, ingrese una nueva categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insertar la nueva categoría en el árbol RN
                CategoriasServices.categorias.Insertar(nuevaCategoria.ID_Categoria, nuevaCategoria);

                MessageBox.Show("Categoría guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNuevoRol_Enter(object sender, EventArgs e)
        {
            if (txtNuevoRol.Text == "NOMBRE")
            {
                txtNuevoRol.Text = "";
                txtNuevoRol.ForeColor = Color.Black; // Cambiar el color al normal
            }
        }

        private void txtNuevoRol_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNuevoRol.Text))
            {
                txtNuevoRol.Text = "NOMBRE";
                txtNuevoRol.ForeColor = Color.Gray; // Volver al color gris
            }
        }

        private void FrmCategoriasNuevas_Load(object sender, EventArgs e)
        {

        }
    }
}
