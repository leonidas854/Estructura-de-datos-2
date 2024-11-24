namespace Optica_Tokio.UI.Formularios
{
    partial class Frm_User
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
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.txtBCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpUsuarios = new System.Windows.Forms.GroupBox();
            this.btnNewUsuario = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(236, 143);
            this.txtBNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(253, 27);
            this.txtBNombre.TabIndex = 3;
            this.txtBNombre.TextChanged += new System.EventHandler(this.txtBNombre_TextChanged);
            // 
            // txtBCorreo
            // 
            this.txtBCorreo.Location = new System.Drawing.Point(754, 147);
            this.txtBCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBCorreo.Name = "txtBCorreo";
            this.txtBCorreo.Size = new System.Drawing.Size(300, 27);
            this.txtBCorreo.TabIndex = 4;
            this.txtBCorreo.TextChanged += new System.EventHandler(this.txtBCorreo_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar Nombre:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(506, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar por correo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // grpUsuarios
            // 
            this.grpUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUsuarios.BackColor = System.Drawing.SystemColors.Control;
            this.grpUsuarios.Controls.Add(this.dgvUsuarios);
            this.grpUsuarios.Controls.Add(this.btnNewUsuario);
            this.grpUsuarios.Controls.Add(this.label2);
            this.grpUsuarios.Controls.Add(this.label1);
            this.grpUsuarios.Controls.Add(this.txtBCorreo);
            this.grpUsuarios.Controls.Add(this.txtBNombre);
            this.grpUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUsuarios.Location = new System.Drawing.Point(12, 12);
            this.grpUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUsuarios.Name = "grpUsuarios";
            this.grpUsuarios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUsuarios.Size = new System.Drawing.Size(1139, 417);
            this.grpUsuarios.TabIndex = 7;
            this.grpUsuarios.TabStop = false;
            // 
            // btnNewUsuario
            // 
            this.btnNewUsuario.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNewUsuario.FlatAppearance.BorderSize = 0;
            this.btnNewUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnNewUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewUsuario.Location = new System.Drawing.Point(25, 21);
            this.btnNewUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewUsuario.Name = "btnNewUsuario";
            this.btnNewUsuario.Size = new System.Drawing.Size(216, 81);
            this.btnNewUsuario.TabIndex = 8;
            this.btnNewUsuario.Text = "Nuevo usuario";
            this.btnNewUsuario.UseVisualStyleBackColor = false;
            this.btnNewUsuario.Click += new System.EventHandler(this.btnNewUsuario_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 245);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(1133, 170);
            this.dgvUsuarios.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Correo Electronico";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Rol";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Editar";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Eliminar";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1163, 752);
            this.Controls.Add(this.grpUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_User";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Frm_User_Load);
            this.grpUsuarios.ResumeLayout(false);
            this.grpUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.TextBox txtBCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpUsuarios;
        private System.Windows.Forms.Button btnNewUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}