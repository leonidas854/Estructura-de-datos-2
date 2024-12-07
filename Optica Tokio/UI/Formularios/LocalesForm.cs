using iTextSharp.text.pdf;
using iTextSharp.text;
using Optica_Tokio.Logica_del_Negocio.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;
using Npgsql.Internal;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;




namespace Optica_Tokio.UI.Formularios
{
    public partial class Locales : Form
    {
        public Locales()
        {
            InitializeComponent();
            CargarDatosEnDataGridView();
        }

        private void btnAgregarLocales_Click(object sender, EventArgs e)
        {
            using (var agregarLocalForm = new AgregarLocalForm())
            {
                if (agregarLocalForm.ShowDialog() == DialogResult.OK)
                {
                    CargarDatosEnDataGridView();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConfigurarColumnas();
        }

        private void CargarDatosEnDataGridView()
        {
            try
            {
                var locales = LocalesServices.ObtenerLocales();
                dgvLocales.DataSource = locales.ToList();
                ConfigurarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnas()
        {

            var columnas = new Dictionary<string, string>
            {
                { "Nombre_Local", "Nombre" },
                { "Direccion", "Dirección" },
                { "Telefono", "Teléfono" },
                { "Responsable", "Responsable" }
            };

            foreach (var columna in columnas)
            {
                if (dgvLocales.Columns[columna.Key] != null)
                {
                    dgvLocales.Columns[columna.Key].HeaderText = columna.Value;
                }
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos PDF (*.pdf)|*.pdf",
                Title = "Exportar Datos a PDF",
                FileName = "Reporte.pdf" // Nombre por defecto
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    iTextSharp.text.Document documento = new iTextSharp.text.Document(PageSize.A4, 50, 50, 25, 25);

              
                    iTextSharp.text.pdf.PdfWriter.GetInstance(documento, new FileStream(saveFileDialog.FileName, FileMode.Create));

                 
                    documento.Open();

                  
                    PdfPTable tabla = new PdfPTable(dgvLocales.Columns.Count)
                    {
                        WidthPercentage = 100 
                    };

                    // Agregar encabezados
                    foreach (DataGridViewColumn columna in dgvLocales.Columns)
                    {
                        PdfPCell celdaEncabezado = new PdfPCell(new Phrase(columna.HeaderText))
                        {
                            BackgroundColor = BaseColor.LIGHT_GRAY, 
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };
                        tabla.AddCell(celdaEncabezado);
                    }

                 
                    foreach (DataGridViewRow fila in dgvLocales.Rows)
                    {
                        if (!fila.IsNewRow) 
                        {
                            foreach (DataGridViewCell celda in fila.Cells)
                            {
                                string textoCelda = celda.Value?.ToString() ?? "N/A"; 
                                PdfPCell celdaContenido = new PdfPCell(new Phrase(textoCelda))
                                {
                                    HorizontalAlignment = Element.ALIGN_CENTER 
                                };
                                tabla.AddCell(celdaContenido);
                            }
                        }
                    }

                  
                    documento.Add(tabla);

                    // Cerrar documento
                    documento.Close();

              
                    MessageBox.Show("Los datos han sido exportados exitosamente a PDF.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show("Ocurrió un error al exportar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Locales_Load(object sender, EventArgs e)
        {
        }
    }
}