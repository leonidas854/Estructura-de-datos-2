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
using Optica_Tokio.UI.Formularios;

namespace Optica_Tokio.UI.Formularios
{
    public partial class FrmMain_Menu : Form
    {
        private Button currentBoton;
        private Random random;
        private int tempIndex;
        private Form activateForm;
        private int bordersize = 2;
        public FrmMain_Menu()
        {
            InitializeComponent();
            random = new Random();
            this.Padding = new Padding(bordersize);
            this.BackColor = Color.FromArgb(233,150,122);
           
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        protected override void WndProc(ref Message message)
        {
            const int WM_NCCALSIZE = 0x0083;
            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;

            const int HTCLIENT = 1;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;
            if (message.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref message);
                if (this.WindowState == FormWindowState.Normal)
                {
                    if ((int)message.Result == HTCLIENT)
                    {
                        Point screenPoint = new Point(message.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);

                        if (clientPoint.Y <= resizeAreaSize)
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                message.Result = (IntPtr)HTTOPLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                message.Result = (IntPtr)HTTOP;
                            else
                                message.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y >= (this.Size.Height - resizeAreaSize))
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                message.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                message.Result = (IntPtr)HTBOTTOM;
                            else
                                message.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                message.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X >= (this.Size.Width - resizeAreaSize))
                                message.Result = (IntPtr)HTRIGHT;
                        }
                    }
                }
                return;
            }

            if (message.Msg== WM_NCCALSIZE && message.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref message);
        }
        private void OpenchildFrom(Form ChildFrom, object btnsender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            ActivateColor(btnsender);
            activateForm = ChildFrom;
            ChildFrom.TopLevel = false;
            ChildFrom.FormBorderStyle = FormBorderStyle.None;
            ChildFrom.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(ChildFrom);
            this.panelDesktop.Tag = ChildFrom;
            ChildFrom.BringToFront();
            ChildFrom.Show();
            lbltitle.Text = ChildFrom.Text;

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
                    ThemeColor.primaryColor = color;
                    ThemeColor.secondaryColor = ThemeColor.ChangeColorBrigthness(color,-0.3);
                    btncloseForm.Visible = true;

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
            OpenchildFrom(new ProductosForm(), sender);
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
            OpenchildFrom(new DashboardForm(), sender);
            
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
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

            //this.WindowState = FormWindowState.Maximized;
              //  btnmaximizar.Visible = false;
                //btnminimizar.Visible = true;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
           // btnminimizar.Visible = false;
           // btnmaximizar.Visible = true;
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
            OpenchildFrom(new ReportesForm(), sender);
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            ActivateColor(sender);
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            OpenchildFrom(new AbaoutForm(), sender);
        }

        private void panel14_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Pmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebar_1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void sidebar_1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            OpenchildFrom(new CategoriasForms(), sender);
            
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            OpenchildFrom(new ProovedoresForm(), sender);
           
        }

        private void btnentradas_Click(object sender, EventArgs e)
        {
            OpenchildFrom(new EntradasForms(), sender);
          
        }

        private void btnsalidas_Click(object sender, EventArgs e)
        {
            OpenchildFrom(new SalidasForms(), sender);
         
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            OpenchildFrom(new RolesForms(), sender);           
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OpenchildFrom(new Frm_User(), sender);
            
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmMain_Menu_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0,8,8,0);
                    break;
                case FormWindowState.Normal:
                    if(this.Padding.Top!= bordersize)
                        this.Padding =new Padding(bordersize); 
                    break;
            }
            
        }

        private void btncloseForm_Click(object sender, EventArgs e)
        {
            if (activateForm != null)
                activateForm.Close();
            Reset();
            
        }
        private void Reset()
        {
            DisableControls();
            lbltitle.Text = "HOME";
            panTop.BackColor = Color.FromArgb(165,42,42);
            currentBoton = null;
            btncloseForm.Visible = false;
        }

        private void productos_Click(object sender, EventArgs e)
        {
            
        }

        private void Fecha_hora_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
