namespace Optica_Tokio.UI.Formularios
{
    partial class FrmNuevaSalida
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
            this.txtuser = new System.Windows.Forms.TextBox();
            this.cmblocal = new System.Windows.Forms.ComboBox();
            this.cmbproductos = new System.Windows.Forms.ComboBox();
            this.btnNuevaSalida = new System.Windows.Forms.Button();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantSalida = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelarSalida = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtuser.Location = new System.Drawing.Point(68, 218);
            this.txtuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(361, 24);
            this.txtuser.TabIndex = 37;
            // 
            // cmblocal
            // 
            this.cmblocal.FormattingEnabled = true;
            this.cmblocal.Location = new System.Drawing.Point(489, 137);
            this.cmblocal.Margin = new System.Windows.Forms.Padding(4);
            this.cmblocal.Name = "cmblocal";
            this.cmblocal.Size = new System.Drawing.Size(325, 25);
            this.cmblocal.TabIndex = 36;
            // 
            // cmbproductos
            // 
            this.cmbproductos.FormattingEnabled = true;
            this.cmbproductos.Location = new System.Drawing.Point(68, 150);
            this.cmbproductos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbproductos.Name = "cmbproductos";
            this.cmbproductos.Size = new System.Drawing.Size(275, 25);
            this.cmbproductos.TabIndex = 35;
            // 
            // btnNuevaSalida
            // 
            this.btnNuevaSalida.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevaSalida.FlatAppearance.BorderSize = 3;
            this.btnNuevaSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNuevaSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNuevaSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaSalida.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaSalida.ForeColor = System.Drawing.Color.Black;
            this.btnNuevaSalida.Location = new System.Drawing.Point(401, 331);
            this.btnNuevaSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaSalida.Name = "btnNuevaSalida";
            this.btnNuevaSalida.Size = new System.Drawing.Size(216, 70);
            this.btnNuevaSalida.TabIndex = 34;
            this.btnNuevaSalida.Text = "NUEVA SALIDA";
            this.btnNuevaSalida.UseVisualStyleBackColor = true;
            this.btnNuevaSalida.Click += new System.EventHandler(this.btnNuevaSalida_Click);
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(68, 303);
            this.dtpFechaSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(224, 24);
            this.dtpFechaSalida.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "CODIGO LOCAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "CODIGO USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "CANTIDAD DE SALIDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "FECHA DE SALIDA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "CODIGO PRODUCTO";
            // 
            // txtCantSalida
            // 
            this.txtCantSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCantSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantSalida.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtCantSalida.Location = new System.Drawing.Point(489, 218);
            this.txtCantSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantSalida.Name = "txtCantSalida";
            this.txtCantSalida.Size = new System.Drawing.Size(361, 24);
            this.txtCantSalida.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 69);
            this.panel1.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "NUEVA SALIDA";
            // 
            // btnCancelarSalida
            // 
            this.btnCancelarSalida.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelarSalida.FlatAppearance.BorderSize = 3;
            this.btnCancelarSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelarSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelarSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarSalida.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarSalida.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarSalida.Location = new System.Drawing.Point(651, 331);
            this.btnCancelarSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarSalida.Name = "btnCancelarSalida";
            this.btnCancelarSalida.Size = new System.Drawing.Size(216, 70);
            this.btnCancelarSalida.TabIndex = 39;
            this.btnCancelarSalida.Text = "CANCELAR";
            this.btnCancelarSalida.UseVisualStyleBackColor = true;
            this.btnCancelarSalida.Click += new System.EventHandler(this.btnCancelarSalida_Click);
            // 
            // FrmNuevaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(900, 478);
            this.Controls.Add(this.btnCancelarSalida);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.cmblocal);
            this.Controls.Add(this.cmbproductos);
            this.Controls.Add(this.btnNuevaSalida);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantSalida);
            this.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevaSalida";
            this.Text = "FrmNuevaSalida";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.ComboBox cmblocal;
        private System.Windows.Forms.ComboBox cmbproductos;
        private System.Windows.Forms.Button btnNuevaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantSalida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelarSalida;
    }
}