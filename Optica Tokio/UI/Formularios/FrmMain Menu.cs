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
    public partial class FrmMain_Menu : Form
    {
        public FrmMain_Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lblmenu_Click(object sender, EventArgs e)
        {

        }
        bool siderbarexpand=false;
        private void siderbartimer_Tick(object sender, EventArgs e)
        {
            if (siderbarexpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebar.Width = sidebar.MinimumSize.Width;
                    siderbartimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width) {
                    sidebar.Width = sidebar.MaximumSize.Width;
                    siderbartimer.Stop();
                }
            }
        }

       
        private void btnMneu_Click(object sender, EventArgs e)
        {
            siderbarexpand = !siderbarexpand;
            siderbartimer.Start();
        }
    }
}
