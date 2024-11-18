namespace Optica_Tokio.UI.Formularios
{
    partial class FrmCategoriasNuevas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarNuevoRol = new System.Windows.Forms.Button();
            this.btnGuardarNuevoRol = new System.Windows.Forms.Button();
            this.txtNuevoRol = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 76);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Categoria";
            // 
            // btnCancelarNuevoRol
            // 
            this.btnCancelarNuevoRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarNuevoRol.FlatAppearance.BorderSize = 3;
            this.btnCancelarNuevoRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelarNuevoRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelarNuevoRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarNuevoRol.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarNuevoRol.Location = new System.Drawing.Point(423, 290);
            this.btnCancelarNuevoRol.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancelarNuevoRol.Name = "btnCancelarNuevoRol";
            this.btnCancelarNuevoRol.Size = new System.Drawing.Size(202, 64);
            this.btnCancelarNuevoRol.TabIndex = 6;
            this.btnCancelarNuevoRol.Text = "Cancelar";
            this.btnCancelarNuevoRol.UseVisualStyleBackColor = true;
            this.btnCancelarNuevoRol.Click += new System.EventHandler(this.btnCancelarNuevoRol_Click);
            // 
            // btnGuardarNuevoRol
            // 
            this.btnGuardarNuevoRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarNuevoRol.FlatAppearance.BorderSize = 3;
            this.btnGuardarNuevoRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardarNuevoRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardarNuevoRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNuevoRol.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevoRol.Location = new System.Drawing.Point(179, 290);
            this.btnGuardarNuevoRol.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGuardarNuevoRol.Name = "btnGuardarNuevoRol";
            this.btnGuardarNuevoRol.Size = new System.Drawing.Size(203, 64);
            this.btnGuardarNuevoRol.TabIndex = 5;
            this.btnGuardarNuevoRol.Text = "Guardar";
            this.btnGuardarNuevoRol.UseVisualStyleBackColor = true;
            this.btnGuardarNuevoRol.Click += new System.EventHandler(this.btnGuardarNuevoRol_Click);
            // 
            // txtNuevoRol
            // 
            this.txtNuevoRol.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNuevoRol.Location = new System.Drawing.Point(145, 200);
            this.txtNuevoRol.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNuevoRol.Name = "txtNuevoRol";
            this.txtNuevoRol.Size = new System.Drawing.Size(521, 34);
            this.txtNuevoRol.TabIndex = 4;
            this.txtNuevoRol.Text = "NOMBRE";
            this.txtNuevoRol.Enter += new System.EventHandler(this.txtNuevoRol_Enter);
            this.txtNuevoRol.Leave += new System.EventHandler(this.txtNuevoRol_Leave);
            // 
            // FrmCategoriasNuevas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(939, 478);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelarNuevoRol);
            this.Controls.Add(this.btnGuardarNuevoRol);
            this.Controls.Add(this.txtNuevoRol);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCategoriasNuevas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategoriasNuevas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarNuevoRol;
        private System.Windows.Forms.Button btnGuardarNuevoRol;
        private System.Windows.Forms.TextBox txtNuevoRol;
    }
}