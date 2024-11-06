using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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
                sidebar_1.Width -= 10;
                if (sidebar_1.Width <= sidebar_1.MinimumSize.Width)
                {
                    sidebar_1.Width = sidebar_1.MinimumSize.Width;
                    siderbartimer.Stop();
                }
            }
            else
            {
                sidebar_1.Width += 10;
                if (sidebar_1.Width >= sidebar_1.MaximumSize.Width) {
                    sidebar_1.Width = sidebar_1.MaximumSize.Width;
                    siderbartimer.Stop();
                }
            }
        }

       
        private void btnMneu_Click(object sender, EventArgs e)
        {
            siderbarexpand = !siderbarexpand;
            siderbartimer.Start();
        }
        
        private void Pproductos_contaneir_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        bool homecollapsed = false;
        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if (homecollapsed)
            {
                Pproductos_contaneir.Height += 10;
                if (Pproductos_contaneir.Height >= Pproductos_contaneir.MaximumSize.Height)
                {
                    Pproductos_contaneir.Height = Pproductos_contaneir.MaximumSize.Height;
                    HomeTimer.Stop();
                }
            }
            else
            {
                Pproductos_contaneir.Height -= 10;
                if (Pproductos_contaneir.Height <= Pproductos_contaneir.MinimumSize.Height)
                {
                    Pproductos_contaneir.Height = Pproductos_contaneir.MinimumSize.Height;
                    HomeTimer.Stop();
                }
            }
        }

        private void btndashborad_Click(object sender, EventArgs e)
        {

        }

        private void btnproduc_Click(object sender, EventArgs e)
        {
            homecollapsed = !homecollapsed;
            HomeTimer.Start();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
        bool existencias=false;
        private void Existencias_timer_Tick(object sender, EventArgs e)
        {
            if (existencias)
            {
                existencias_conteneir.Height += 10;
                if (existencias_conteneir.Height >= existencias_conteneir.MaximumSize.Height)
                {
                    existencias_conteneir.Height = existencias_conteneir.MaximumSize.Height;
                    Existencias_timer.Stop();
                }
            }
            else
            {
                existencias_conteneir.Height -= 10;
                if (existencias_conteneir.Height <= existencias_conteneir.MinimumSize.Height)
                {
                    existencias_conteneir.Height = existencias_conteneir.MinimumSize.Height;
                    Existencias_timer.Stop();
                }
            }
        }

        private void btnexiste_Click(object sender, EventArgs e)
        {
            existencias = !existencias;
            Existencias_timer.Start();
        }

        private void FrmMain_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Pmenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void sidebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            usuarios = !usuarios;
            Usuarios_timer.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Contaneir_users_Paint(object sender, PaintEventArgs e)
        {
           
        }
        bool usuarios = false;
        private void Usuarios_timer_Tick(object sender, EventArgs e)
        {
            if (usuarios)
            {
                Contaneir_users.Height += 10;
                if (Contaneir_users.Height >= Contaneir_users.MaximumSize.Height)
                {
                    Contaneir_users.Height = Contaneir_users.MaximumSize.Height;
                    Usuarios_timer.Stop();
                }
            }
            else
            {
                Contaneir_users.Height -= 10;
                if (existencias_conteneir.Height <= Contaneir_users.MinimumSize.Height)
                {
                    Contaneir_users.Height = Contaneir_users.MinimumSize.Height;
                    Usuarios_timer.Stop();
                }
            }
        }

        private void panel14_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnminimizar.Visible = true;

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnminimizar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void btnocultar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void FrmMain_Menu_Load(object sender, EventArgs e)
        {

        }

        private void sidebar_1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
