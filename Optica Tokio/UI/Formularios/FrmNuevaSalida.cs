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
    public partial class FrmNuevaSalida : Form
    {
        public FrmNuevaSalida()
        {
            InitializeComponent();
        }

        private void btnNuevaSalida_Click(object sender, EventArgs e)
        {
            SalidasForms formSalidas=new SalidasForms();
        }

        private void btnCancelarSalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNuevaSalida_Load(object sender, EventArgs e)
        {

        }

        private void cmbproductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
