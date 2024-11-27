using Notion.Client;
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
    public partial class SalidasForms : Form
    {
        private INotionClient notionClient;
        private const string databaseId = "tu_database_id";
        public SalidasForms()
        {
            InitializeComponent();
            //InicializarNotion();
            CargarProductos();
            CargarLocales();
        }
        private void InicializarNotion()
        {
            var notionClient = Notion.Client.NotionClientFactory.Create(new ClientOptions
            {
                AuthToken = "tu-token-de-integración"
            });

        }

        private void CargarProductos()
        {
            cmbproductos.Items.Clear();
            foreach (var producto in ProductosServices.arbolProductos.RecorridoAmplitud())
            {
                cmbproductos.Items.Add(producto.Nombre);
            }
        }

        private void CargarLocales()
        {
            cmblocal.Items.Clear();
            foreach (var local in LocalesServices.locales)
            {
                cmblocal.Items.Add(local.Nombre_Local);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtBuscarPorNumero.Text == "Buscar por número de factura")
            {
                txtBuscarPorNumero.Text = "";
                //txtBuscarPorNumero.ForeColor = Color.Black; 
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarPorNumero.Text))
            {
                txtBuscarPorNumero.Text = "Buscar por número de factura";
                //txtBuscarPorNumero.ForeColor = Color.Gray; // Volver al color gris
            }
        }



        private void btnNuevaFactura_Click_1(object sender, EventArgs e)
        {
            grbNuevaSalida.Visible = true;
            grbSalidas.Visible = false;
        }

        private void btnCancelarSalida_Click(object sender, EventArgs e)
        {
            grbNuevaSalida.Visible = false;
            grbSalidas.Visible = true;
        }

        private void cmbOpListaSalidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbproductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmblocal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantSalida_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnNuevaSalida_ClickAsync(object sender, EventArgs e)
        {
            if (cmbproductos.SelectedIndex < 0 || cmblocal.SelectedIndex < 0 || string.IsNullOrWhiteSpace(txtCantSalida.Text))
            {
                MessageBox.Show("Por favor, selecciona un producto, un local y una cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string productoSeleccionado = cmbproductos.SelectedItem.ToString();
            string localSeleccionado = cmblocal.SelectedItem.ToString();
            int cantidad;

            if (!int.TryParse(txtCantSalida.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, introduce una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            await EnviarReporteNotion(productoSeleccionado, localSeleccionado, cantidad);

            MessageBox.Show($"Salida registrada: {cantidad} unidades del producto '{productoSeleccionado}' al local '{localSeleccionado}'.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private async Task EnviarReporteNotion(string producto, string local, int cantidad)
        {
            var pageProperties = new Dictionary<string, PropertyValue>
    {
        {
            "Producto", new TitlePropertyValue
            {
                Title = new List<RichTextBase>
                {
                    new RichTextText
                    {
                        Text = new Text
                        {
                            Content = producto
                        }
                    }
                }
            }
        },
        {
            "Local", new RichTextPropertyValue
            {
                RichText = new List<RichTextBase>
                {
                    new RichTextText
                    {
                        Text = new Text
                        {
                            Content = local
                        }
                    }
                }
            }
        },
        {
            "Cantidad", new NumberPropertyValue
            {
                Number = cantidad
            }
        },
        {
            "Fecha", new DatePropertyValue
            {
                Date = new Date
                {
                    //Start = dateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ") // Formato ISO 8601
                }
            }
        }
    };

            try
            {
                await notionClient.Pages.CreateAsync(new PagesCreateParameters
                {
                    Parent = new ParentPageInput
                    {
                       // Type = ParentType.DatabaseId,
                       // DatabaseId = databaseId
                    },
                    Properties = pageProperties
                });

                MessageBox.Show("Reporte enviado exitosamente a Notion.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar reporte a Notion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dtpFechaSalida_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
