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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Optica_Tokio.UI.Formularios
{
    public partial class AgregarLocalForm : Form
    {
        public AgregarLocalForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
       

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
              
                string nombreLocal = txtnombre.Text.Trim();
                string direccion = txtdireccion.Text.Trim();
                string telefono = txttelefono.Text.Trim();
               string  idResponsable = txtRespobsable.Text.Trim();

                
                if (string.IsNullOrWhiteSpace(nombreLocal) || string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(telefono))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              
                var nuevoLocal = new Local
                {
                    ID_Local = LocalesServices.locales.GetTam() + 1, 
                    Nombre_Local = nombreLocal,
                    Direccion = direccion,
                    Telefono = telefono,
                    Responsable = idResponsable.ToString() 
                };

              
                LocalesServices servicios = new LocalesServices();
                servicios.AgregarLocal(nuevoLocal);

                MessageBox.Show("El local ha sido agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el local: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarFormulario()
        {
           txtnombre.Clear();
           txtdireccion.Clear();
           txttelefono.Clear();
            txtRespobsable.Clear();
        }

        private void AgregarLocalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
