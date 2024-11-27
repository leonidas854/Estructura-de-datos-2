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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
        public void ActualizarContador(int contador)
        {
            lbProductosTotales.Text = $"Total de filas: {contador}";
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }

    }
}
//ObtenerEstadisticasInventario();
//ObtenerResumenMovimientos(DateTime fechaInicio, DateTime fechaFin);