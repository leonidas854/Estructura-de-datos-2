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
    public partial class CategoriasForms : Form
    {
        public CategoriasForms()
        {
            InitializeComponent();
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoriasNuevas formNuevaCategoria = new FrmCategoriasNuevas();
            if (formNuevaCategoria.ShowDialog() == DialogResult.OK)
            {
               // MessageBox.Show("Categoría guardada correctamente.");
                ActualizarDataGridView();
            }
        }
        //int n = dgvCategoria.Rows.Add();
        //dgvCategoria.Rows[n].Cells[0].Value = txtCategoria.Text;
            //txtCategoria.Text = "";

        

        private void txtCategoria_Enter(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "BUSCAR POR NOMBRE")
            {
                txtCategoria.Text = "";
                txtCategoria.ForeColor = Color.Black; // Cambiar el color al normal
            }
        }

        private void txtCategoria_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                txtCategoria.Text = "BUSCAR POR NOMBRE";
                txtCategoria.ForeColor = Color.Gray; // Volver al color gris
            }
        }

        private void CategoriasForms_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }
        private void ActualizarDataGridView()
        {
            dgvCategoria.Rows.Clear();
            foreach (var categoria in CategoriasServices.categorias)
            {
                dgvCategoria.Rows.Add(
                    categoria.Nombre_Categoria,
                    "Editar",
                    "Eliminar"
                );
            }
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
    }
}
