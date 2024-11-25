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
    public partial class AbaoutForm : Form
    {
        public AbaoutForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void AbaoutForm_Load(object sender, EventArgs e){}
        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.opticatokio.com",
                UseShellExecute = true
            });
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.LightBlue, 2))
            {
                Rectangle rect = new Rectangle(0, 0, panel1.Width - 1, panel1.Height - 1);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Óptica Tokio se dedica a brindar servicios de alta calidad desde 1990.", "Acerca de Nosotros", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Para más información, contáctanos al +591 123 456 789 o visita nuestra página web.", "Información de Contacto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void label3_Click(object sender, EventArgs e){}
        private void pictureBox2_Click(object sender, EventArgs e){}
        private void pictureBox4_Click(object sender, EventArgs e){}
        private void pictureBox3_Click(object sender, EventArgs e){}
        private void pictureBox5_Click(object sender, EventArgs e){}
        private void pictureBox6_Click(object sender, EventArgs e){}
        private void label4_Click(object sender, EventArgs e){}
        private void label5_Click(object sender, EventArgs e){}
        private void label7_Click(object sender, EventArgs e){}
        private void label6_Click(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}
    }
}
