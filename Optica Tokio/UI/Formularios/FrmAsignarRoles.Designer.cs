namespace Optica_Tokio.UI.Formularios
{
    partial class FrmAsignarRoles
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
            this.txtNuevoRol = new System.Windows.Forms.TextBox();
            this.btnGuardarNuevoRol = new System.Windows.Forms.Button();
            this.btnCancelarNuevoRol = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNuevoRol
            // 
            this.txtNuevoRol.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNuevoRol.Location = new System.Drawing.Point(82, 73);
            this.txtNuevoRol.Name = "txtNuevoRol";
            this.txtNuevoRol.Size = new System.Drawing.Size(322, 22);
            this.txtNuevoRol.TabIndex = 0;
            this.txtNuevoRol.Text = "NOMBRE";
            this.txtNuevoRol.Enter += new System.EventHandler(this.txtNuevoRol_Enter);
            this.txtNuevoRol.Leave += new System.EventHandler(this.txtNuevoRol_Leave);
            // 
            // btnGuardarNuevoRol
            // 
            this.btnGuardarNuevoRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarNuevoRol.FlatAppearance.BorderSize = 3;
            this.btnGuardarNuevoRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardarNuevoRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardarNuevoRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNuevoRol.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevoRol.Location = new System.Drawing.Point(199, 179);
            this.btnGuardarNuevoRol.Name = "btnGuardarNuevoRol";
            this.btnGuardarNuevoRol.Size = new System.Drawing.Size(125, 38);
            this.btnGuardarNuevoRol.TabIndex = 1;
            this.btnGuardarNuevoRol.Text = "Guardar";
            this.btnGuardarNuevoRol.UseVisualStyleBackColor = true;
            this.btnGuardarNuevoRol.Click += new System.EventHandler(this.btnGuardarNuevoRol_Click);
            // 
            // btnCancelarNuevoRol
            // 
            this.btnCancelarNuevoRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarNuevoRol.FlatAppearance.BorderSize = 3;
            this.btnCancelarNuevoRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelarNuevoRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelarNuevoRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarNuevoRol.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarNuevoRol.Location = new System.Drawing.Point(349, 179);
            this.btnCancelarNuevoRol.Name = "btnCancelarNuevoRol";
            this.btnCancelarNuevoRol.Size = new System.Drawing.Size(124, 38);
            this.btnCancelarNuevoRol.TabIndex = 2;
            this.btnCancelarNuevoRol.Text = "Cancelar";
            this.btnCancelarNuevoRol.UseVisualStyleBackColor = true;
            this.btnCancelarNuevoRol.Click += new System.EventHandler(this.btnCancelarNuevoRol_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 45);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Rol";
            // 
            // FrmAsignarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(492, 229);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelarNuevoRol);
            this.Controls.Add(this.btnGuardarNuevoRol);
            this.Controls.Add(this.txtNuevoRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAsignarRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAsignarRoles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNuevoRol;
        private System.Windows.Forms.Button btnGuardarNuevoRol;
        private System.Windows.Forms.Button btnCancelarNuevoRol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}