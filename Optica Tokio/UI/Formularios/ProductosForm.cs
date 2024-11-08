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
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {

        }
        private void DisableControls()
        {
            DisableControlsRecursively(this.Controls);
        }

        private void DisableControlsRecursively(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.FromArgb(205, 92, 92);
                    control.ForeColor = Color.White;
                    control.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else if (control is PictureBox pictureBox)
                {
                    pictureBox.BackColor = Color.FromArgb(205, 92, 92);
                }
                else if (control is Panel panel)
                {
                    panel.BackColor = Color.FromArgb(205, 92, 92);
                    DisableControlsRecursively(panel.Controls);
                }
                else if (control is GroupBox || control is FlowLayoutPanel)
                {
                    DisableControlsRecursively(control.Controls);
                }
            }
        }
    }
}
