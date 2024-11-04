namespace Optica_Tokio.UI.Formularios
{
    partial class FrmLoading_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.TmIn = new System.Windows.Forms.Timer(this.components);
            this.Tmclose = new System.Windows.Forms.Timer(this.components);
            this.cpbtiempo = new CircularProgressBar.CircularProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 101);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Optica_Tokio.Properties.Resources.images;
            this.pictureBox2.Location = new System.Drawing.Point(12, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE INVENTARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Optica_Tokio.Properties.Resources.loadinggg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(361, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 58);
            this.label2.TabIndex = 2;
            this.label2.Text = "BIENVENIDO";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.Black;
            this.lbluser.Location = new System.Drawing.Point(367, 197);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(92, 24);
            this.lbluser.TabIndex = 3;
            this.lbluser.Text = "USERNAME";
            // 
            // TmIn
            // 
            this.TmIn.Interval = 30;
            this.TmIn.Tick += new System.EventHandler(this.TmIn_Tick);
            // 
            // Tmclose
            // 
            this.Tmclose.Interval = 30;
            this.Tmclose.Tick += new System.EventHandler(this.Tmclose_Tick);
            // 
            // cpbtiempo
            // 
            this.cpbtiempo.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbtiempo.AnimationSpeed = 500;
            this.cpbtiempo.BackColor = System.Drawing.Color.Transparent;
            this.cpbtiempo.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbtiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbtiempo.InnerColor = System.Drawing.Color.Linen;
            this.cpbtiempo.InnerMargin = 2;
            this.cpbtiempo.InnerWidth = -1;
            this.cpbtiempo.Location = new System.Drawing.Point(437, 224);
            this.cpbtiempo.MarqueeAnimationSpeed = 2000;
            this.cpbtiempo.Name = "cpbtiempo";
            this.cpbtiempo.OuterColor = System.Drawing.Color.DarkOrange;
            this.cpbtiempo.OuterMargin = -25;
            this.cpbtiempo.OuterWidth = 26;
            this.cpbtiempo.ProgressColor = System.Drawing.Color.OrangeRed;
            this.cpbtiempo.ProgressWidth = 25;
            this.cpbtiempo.SecondaryFont = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbtiempo.Size = new System.Drawing.Size(170, 164);
            this.cpbtiempo.StartAngle = 270;
            this.cpbtiempo.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cpbtiempo.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbtiempo.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbtiempo.SubscriptText = "";
            this.cpbtiempo.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbtiempo.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbtiempo.SuperscriptText = "%";
            this.cpbtiempo.TabIndex = 5;
            this.cpbtiempo.Text = "0";
            this.cpbtiempo.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbtiempo.Value = 68;
            // 
            // FrmLoading_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(768, 422);
            this.Controls.Add(this.cpbtiempo);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoading_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Screen";
            this.Load += new System.EventHandler(this.FrmLoading_Screen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Timer TmIn;
        private System.Windows.Forms.Timer Tmclose;
        private CircularProgressBar.CircularProgressBar cpbtiempo;
    }
}