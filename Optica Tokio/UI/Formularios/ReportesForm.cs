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
    public partial class ReportesForm : Form
    {
        public ReportesForm()
        {
            InitializeComponent();
            cmbTipoReport.Items.Insert(0, "Tipo de reporte");  // Insertamos el valor predeterminado
            cmbTipoReport.SelectedIndex = 0;  // Seleccionamos el valor predeterminado
            cmbTipoReport.ForeColor = Color.Silver;

            cmbCategoriaReport.Items.Insert(0, "eleguir categoria");  
            cmbCategoriaReport.SelectedIndex = 0;  
            cmbCategoriaReport.ForeColor = Color.Silver;

            cmbProvedorReport.Items.Insert(0, "eleguir Provedor");
            cmbProvedorReport.SelectedIndex = 0;
            cmbProvedorReport.ForeColor = Color.Silver;

            cmbProductoReport.Items.Insert(0, "eleguir Producto");
            cmbProductoReport.SelectedIndex = 0;
            cmbProductoReport.ForeColor = Color.Silver;

            cmbVendedorReport.Items.Insert(0, "eleguir Vendedor");
            cmbVendedorReport.SelectedIndex = 0;
            cmbVendedorReport.ForeColor = Color.Silver;

            cmbComprobanteReport.Items.Insert(0, "Comprobante");
            cmbComprobanteReport.SelectedIndex = 0;
            cmbComprobanteReport.ForeColor = Color.Silver;

            cmbStockReport.Items.Insert(0, "eleguir Stock");
            cmbStockReport.SelectedIndex = 0;
            cmbStockReport.ForeColor = Color.Silver;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "inicial";
            dateTimePicker1.ShowCheckBox = false;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "final";
            dateTimePicker2.ShowCheckBox = false;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {
             
        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            InformedelReport InformedelReportForm=new InformedelReport();
            InformedelReportForm.StartPosition = FormStartPosition.CenterScreen;
            InformedelReportForm.Show();
        }

        private void cmbTipoReport_Enter(object sender, EventArgs e)
        {
            if (cmbTipoReport.Text == "Seleccione una opción")  // Si el texto es el predeterminado
            {
                cmbTipoReport.Text = "";  // Borramos el texto
                cmbTipoReport.ForeColor = Color.Black;  // Cambiamos el color del texto a negro
            }
        }

        private void cmbTipoReport_Leave(object sender, EventArgs e)
        {
            if (cmbTipoReport.Text == "")  
            {
                cmbTipoReport.Text = "Seleccione una opción";  
                cmbTipoReport.ForeColor = Color.Silver;  
            }
        }

        private void cmbCategoriaReport_Enter(object sender, EventArgs e)
        {
            if (cmbCategoriaReport.Text == "Seleccione una opción")  
            {
                cmbCategoriaReport.Text = "";  
                cmbCategoriaReport.ForeColor = Color.Black;  
            }
        }

        private void cmbCategoriaReport_Leave(object sender, EventArgs e)
        {
            if (cmbCategoriaReport.Text == "")
            {
                cmbCategoriaReport.Text = "Seleccione una opción";
                cmbCategoriaReport.ForeColor = Color.Silver;
            }
        }

        private void cmbProvedorReport_Enter(object sender, EventArgs e)
        {
            if (cmbProvedorReport.Text == "Seleccione una opción")
            {
                cmbProvedorReport.Text = "";
                cmbProvedorReport.ForeColor = Color.Black;
            }
        }

        private void cmbProvedorReport_Leave(object sender, EventArgs e)
        {
            if (cmbProvedorReport.Text == "")
            {
                cmbProvedorReport.Text = "Seleccione una opción";
                cmbProvedorReport.ForeColor = Color.Silver;
            }
        }

        private void cmbProductoReport_Leave(object sender, EventArgs e)
        {
            if (cmbProductoReport.Text == "")
            {
                cmbProductoReport.Text = "Seleccione una opción";
                cmbProductoReport.ForeColor = Color.Silver;
            }
        }

        private void cmbProductoReport_Enter(object sender, EventArgs e)
        {
            if (cmbProductoReport.Text == "Seleccione una opción")
            {
                cmbProductoReport.Text = "";
                cmbProductoReport.ForeColor = Color.Black;
            }
        }

        private void cmbVendedorReport_Enter(object sender, EventArgs e)
        {
            if (cmbVendedorReport.Text == "Seleccione una opción")
            {
                cmbVendedorReport.Text = "";
                cmbVendedorReport.ForeColor = Color.Black;
            }
        }

        private void cmbVendedorReport_Leave(object sender, EventArgs e)
        {
            if (cmbVendedorReport.Text == "")
            {
                cmbVendedorReport.Text = "Seleccione una opción";
                cmbVendedorReport.ForeColor = Color.Silver;
            }
        }

        private void cmbComprobanteReport_Enter(object sender, EventArgs e)
        {
            if (cmbComprobanteReport.Text == "Seleccione una opción")
            {
                cmbComprobanteReport.Text = "";
                cmbComprobanteReport.ForeColor = Color.Black;
            }
        }

        private void cmbComprobanteReport_Leave(object sender, EventArgs e)
        {
            if (cmbComprobanteReport.Text == "")
            {
                cmbComprobanteReport.Text = "Seleccione una opción";
                cmbComprobanteReport.ForeColor = Color.Silver;
            }
        }

        private void cmbStockReport_Leave(object sender, EventArgs e)
        {
            if (cmbStockReport.Text == "")
            {
                cmbStockReport.Text = "Seleccione una opción";
                cmbStockReport.ForeColor = Color.Silver;
            }
        }

        private void cmbStockReport_Enter(object sender, EventArgs e)
        {
            if (cmbStockReport.Text == "Seleccione una opción")
            {
                cmbStockReport.Text = "";
                cmbStockReport.ForeColor = Color.Black;
            }
        }
    }
}
