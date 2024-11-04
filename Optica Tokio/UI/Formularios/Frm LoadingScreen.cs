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
    public partial class FrmLoading_Screen : Form
    {
        public FrmLoading_Screen()
        {
            InitializeComponent();
        }
       

        private void TmIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) { this.Opacity += 0.05; }
            cpbtiempo.Value += 1;
            cpbtiempo.Text = cpbtiempo.Value.ToString();
            if(cpbtiempo.Value == 100)
            {
                TmIn.Stop();
                Tmclose.Start();
            }
            
        }

        private void Tmclose_Tick(object sender, EventArgs e)
        {
            this.Opacity -=0.1;
            if(this.Opacity == 0)
            {
                Tmclose.Stop();
                this.Close();
            }

        }

        private void FrmLoading_Screen_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            cpbtiempo.Value = 0;
            cpbtiempo.Minimum = 0;
            cpbtiempo.Maximum = 100;
            TmIn.Start();
        }
    }
}
