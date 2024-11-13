namespace Optica_Tokio.UI.Formularios
{
    partial class AgregarUsuario
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
            this.grpAñadirUsuario = new System.Windows.Forms.GroupBox();
            this.btnConfirmarRol = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtReingresarContraseña = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpAñadirUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAñadirUsuario
            // 
            this.grpAñadirUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpAñadirUsuario.Controls.Add(this.btnConfirmarRol);
            this.grpAñadirUsuario.Controls.Add(this.button1);
            this.grpAñadirUsuario.Controls.Add(this.cmbRol);
            this.grpAñadirUsuario.Controls.Add(this.txtContraseña);
            this.grpAñadirUsuario.Controls.Add(this.txtReingresarContraseña);
            this.grpAñadirUsuario.Controls.Add(this.pictureBox5);
            this.grpAñadirUsuario.Controls.Add(this.pictureBox4);
            this.grpAñadirUsuario.Controls.Add(this.pictureBox3);
            this.grpAñadirUsuario.Controls.Add(this.pictureBox2);
            this.grpAñadirUsuario.Controls.Add(this.pictureBox1);
            this.grpAñadirUsuario.Controls.Add(this.txtCorreoUsuario);
            this.grpAñadirUsuario.Controls.Add(this.txtNombre);
            this.grpAñadirUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAñadirUsuario.Location = new System.Drawing.Point(28, 53);
            this.grpAñadirUsuario.Name = "grpAñadirUsuario";
            this.grpAñadirUsuario.Size = new System.Drawing.Size(784, 377);
            this.grpAñadirUsuario.TabIndex = 1;
            this.grpAñadirUsuario.TabStop = false;
            this.grpAñadirUsuario.Text = "Añadir Usuario";
            // 
            // btnConfirmarRol
            // 
            this.btnConfirmarRol.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmarRol.FlatAppearance.BorderSize = 0;
            this.btnConfirmarRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmarRol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmarRol.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmarRol.Location = new System.Drawing.Point(541, 326);
            this.btnConfirmarRol.Name = "btnConfirmarRol";
            this.btnConfirmarRol.Size = new System.Drawing.Size(122, 50);
            this.btnConfirmarRol.TabIndex = 11;
            this.btnConfirmarRol.Text = "Confirmar";
            this.btnConfirmarRol.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(673, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Seleccione un rol",
            "SuperAdministrador",
            "Gerente",
            "Vendedor",
            "Controlador"});
            this.cmbRol.Location = new System.Drawing.Point(97, 249);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(429, 28);
            this.cmbRol.TabIndex = 9;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtContraseña.Location = new System.Drawing.Point(97, 175);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(227, 27);
            this.txtContraseña.TabIndex = 8;
            this.txtContraseña.Text = "Ingresar Contraseña";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // txtReingresarContraseña
            // 
            this.txtReingresarContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReingresarContraseña.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReingresarContraseña.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtReingresarContraseña.Location = new System.Drawing.Point(440, 175);
            this.txtReingresarContraseña.Name = "txtReingresarContraseña";
            this.txtReingresarContraseña.Size = new System.Drawing.Size(184, 27);
            this.txtReingresarContraseña.TabIndex = 7;
            this.txtReingresarContraseña.Text = "Reingresar Contraseña";
            this.txtReingresarContraseña.Enter += new System.EventHandler(this.txtReingresarContraseña_Enter);
            this.txtReingresarContraseña.Leave += new System.EventHandler(this.txtReingresarContraseña_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Optica_Tokio.Properties.Resources.vector_users_icon_design_2468331650;
            this.pictureBox5.Location = new System.Drawing.Point(23, 233);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Optica_Tokio.Properties.Resources.png_clipart_lock_computer_icons_padlock_technic_security_2157185273;
            this.pictureBox4.Location = new System.Drawing.Point(23, 158);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Optica_Tokio.Properties.Resources._39734_3307008701;
            this.pictureBox3.Location = new System.Drawing.Point(368, 158);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Optica_Tokio.Properties.Resources.mail_email_icon_template_black_color_editable_mail_email_icon_symbol_flat_illustration_for_graphic_and_web_design_free_vector;
            this.pictureBox2.Location = new System.Drawing.Point(368, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Optica_Tokio.Properties.Resources.user_icon_in_trendy_outline_style_isolated_on_white_background_user_silhouette_symbol_for_your_website_design_logo_app_ui_illustration_eps10_free_vector;
            this.pictureBox1.Location = new System.Drawing.Point(23, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreoUsuario.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCorreoUsuario.Location = new System.Drawing.Point(440, 72);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(184, 27);
            this.txtCorreoUsuario.TabIndex = 1;
            this.txtCorreoUsuario.Text = "Usuario@gmail.com";
            this.txtCorreoUsuario.Enter += new System.EventHandler(this.txtCorreoUsuario_Enter);
            this.txtCorreoUsuario.Leave += new System.EventHandler(this.txtCorreoUsuario_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombre.Location = new System.Drawing.Point(97, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 27);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 471);
            this.Controls.Add(this.grpAñadirUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarUsuario";
            this.Text = "AgregarUsuario";
            this.Load += new System.EventHandler(this.AgregarUsuario_Load);
            this.grpAñadirUsuario.ResumeLayout(false);
            this.grpAñadirUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAñadirUsuario;
        private System.Windows.Forms.Button btnConfirmarRol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtReingresarContraseña;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.TextBox txtNombre;
    }
}