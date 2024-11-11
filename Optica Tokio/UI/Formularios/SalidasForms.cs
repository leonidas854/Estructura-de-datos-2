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
    public partial class SalidasForms : Form
    {
        public SalidasForms()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtBuscarPorNumero.Text == "Buscar por número de factura")
            {
                txtBuscarPorNumero.Text = "";
                txtBuscarPorNumero.ForeColor = Color.Black; 
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarPorNumero.Text))
            {
                txtBuscarPorNumero.Text = "Buscar por número de factura";
                txtBuscarPorNumero.ForeColor = Color.Gray; // Volver al color gris
            }
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            grbFacturacion.Visible= false;
            grbNuevaFactura.Visible= true;
        }
    }
}
