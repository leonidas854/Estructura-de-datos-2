using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Optica_Tokio.UI.Controles;

namespace Optica_Tokio.UI.Formularios
{
    public partial class FrmMain_Menu : Form
    {
        private Button currentBoton;
        private Random random;
        private int tempIndex;

        public FrmMain_Menu()
        {
            InitializeComponent();
            random = new Random();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.colores.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.colores.Count);
            }
            tempIndex = index;
            string color =ThemeColor.colores[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateColor(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentBoton != (Button)btnsender)
                {
                    DisableControls(); 
                    Color color = SelectThemeColor();
                    currentBoton = (Button)btnsender;
                    currentBoton.BackColor = color;
                    currentBoton.ForeColor = Color.White;
                    currentBoton.Font = new System.Drawing.Font("Elephant", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panTop.BackColor = color;

                    ApplyColorToAssociatedControls(currentBoton.Parent, color);
                }
            }
        }

        private void DisableControls()
        {
            DisableControlsRecursively(sidebar_1.Controls);
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
        private void ApplyColorToAssociatedControls(Control parent, Color color)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.BackColor = color;
                }
                else if (control is Panel)
                {
                    control.BackColor = color;
                    ApplyColorToAssociatedControls(control, color); // Llama recursivamente para aplicar el color a los sub-paneles dentro
                }
                else if (control is Button)
                {
                    control.BackColor = color;
                    control.ForeColor = Color.White;
                    control.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
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
            ActivateColor(sender);
        }

        private void btnproduc_Click(object sender, EventArgs e)
        {
            ActivateColor(sender);
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
            ActivateColor(sender);
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
            ActivateColor(sender);
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

        private void btnreport_Click(object sender, EventArgs e)
        {
            ActivateColor(sender);
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            ActivateColor(sender);
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            ActivateColor(sender);
        }

        private void panel14_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Pmenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
