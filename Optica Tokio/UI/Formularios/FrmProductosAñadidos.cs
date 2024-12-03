using iTextSharp.text;

using Optica_Tokio.Logica_del_Negocio.Modelos;
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
    public partial class FrmProductosAñadidos : Form
    {
        public string Nombre { get; private set; }
        public string Categoria { get; private set; }
        public string Descripcion { get; private set; }
        public string Alto { get; private set; }
        public string Ancho { get; private set; }
        public string Grosor { get; private set; }
        public string Precio { get; private set; }
        public string Peso { get; private set; }
        public string Cantidad { get; private set; }
        public FrmProductosAñadidos()
        {
            InitializeComponent();
        }
        private void btnGuardado_Click(object sender, EventArgs e)
        {
            if (gbEstuche.Visible == true || gbMontura.Visible == true || gbVidrio.Visible == true)
            {
                btnGuardado.Visible = true;
            }
            //CONDICION DE GUARDADO DE VIDRIO
            if ((txtNombre.Text == null || txtDescripcion.Text == null || txtAlto.Text == null || txtAncho.Text == null || txtGrosor.Text == null
                || txtPrecio.Text == null) && (gbEstuche.Visible == false && gbMontura.Visible == false))
            {
                MessageBox.Show("Debe llenar todas las casillas que se le muestra");
                return;
            }
            //GUARDADO DE VIDRIO
            if (gbVidrio.Visible == true)
            {
                Categoria = comboBoxDeCategorias.Text;
                Nombre = txtNombre.Text;
                Descripcion = txtDescripcion.Text;
                Alto = txtAlto.Text;
                Ancho = txtAncho.Text;
                Grosor = txtGrosor.Text;
                Precio = txtPrecio.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            //CONDICION DE GUARDADO DE MONTURA
            if ((txtMonturaNombre.Text == null || txtMonturaDescripcion.Text == null || txtMonturaCantidad.Text == null || txtMonturaPeso.Text == null
                || txtMonturaPrecio.Text == null) && (gbEstuche.Visible == false && gbVidrio.Visible == false))
            {
                MessageBox.Show("Debe llenar todas las casillas que se le muestra");
                return;
            }
            //GUARDADO DE MONTURA
            if (gbMontura.Visible == true)
            {
                Categoria = comboBoxDeCategorias.Text;
                Nombre = txtMonturaNombre.Text;
                Descripcion = txtMonturaDescripcion.Text;
                Cantidad = txtMonturaCantidad.Text;
                Peso = txtMonturaPeso.Text;
                Precio = txtMonturaPrecio.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            //CONDICION DE GUARDADO DE ESTUCHE
            if ((txtEstucheNombre.Text == null || txtEstucheCantidad.Text == null || txtEstucheDescripcion.Text == null)
                 && (gbMontura.Visible == false && gbVidrio.Visible == false))
            {
                MessageBox.Show("Debe llenar todas las casillas que se le muestra");
                return;
            }
            //GUARDADO DE ESTUCHE
            if (gbEstuche.Visible == true)
            {
                Categoria = comboBoxDeCategorias.Text;
                Nombre = txtEstucheNombre.Text;
                Cantidad = txtEstucheCantidad.Text;
                Descripcion = txtDescripcion.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void comboBoxDeCategorias_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Elija una clasificacion")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void comboBoxDeCategorias_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "Elija una clasificacion";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "DESCRIPCION")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "DESCRIPCION";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtAlto_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "ALTO")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtAlto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "ALTO";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtAncho_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "ANCHO")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtAncho_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "ANCHO";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "PRECIO")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "PRECIO";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtGrosor_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "GROSOR")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtGrosor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "GROSOR";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtMonturaNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtMonturaNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtMonturaDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "DESCRIPCION")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtMonturaDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "DESCRIPCION";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtMonturaCantidad_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "CANTIDAD")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtMonturaCantidad_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "CANTIDAD";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtMonturaPeso_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "PESO")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtMonturaPeso_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "PESO";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtMonturaPrecio_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "PRECIO")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtMonturaPrecio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "PRECIO";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtEstucheNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtEstucheNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtEstucheDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "DESCRIPCION")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtEstucheDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "DESCRIPCION";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtEstucheCantidad_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "CANTIDAD")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtEstucheCantidad_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.Text = "CANTIDAD";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void comboBoxDeCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxDeCategorias.SelectedIndex)
            {
                case 0:
                    gbVidrio.Visible = true;
                    gbMontura.Visible = false;
                    gbEstuche.Visible = false;
                    break;

                case 1:
                    gbVidrio.Visible = false;
                    gbMontura.Visible = Visible;
                    gbEstuche.Visible = false;
                    break;

                case 2:
                    gbVidrio.Visible = false;
                    gbMontura.Visible = false;
                    gbEstuche.Visible = true;
                    break;
            }
        }
    }
}
    

