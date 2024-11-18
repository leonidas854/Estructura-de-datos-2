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
            int n = dgvCategoria.Rows.Add();
            dgvCategoria.Rows[n].Cells[0].Value = txtCategoria.Text;
            txtCategoria.Text = "";
        }

        private void Click_Eliminar(object sender, DataGridViewCellEventArgs e)
        {
            dgvCategoria.Rows.Clear();
        }
    }
}
