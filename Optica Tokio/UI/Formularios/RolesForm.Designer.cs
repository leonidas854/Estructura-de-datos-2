namespace Optica_Tokio.UI.Formularios
{
    partial class RolesForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRolNuevo = new System.Windows.Forms.Button();
            this.dgvMostrarRol = new System.Windows.Forms.DataGridView();
            this.grbRol = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otorgar_Permisos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarRol)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRolNuevo
            // 
            this.btnRolNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRolNuevo.FlatAppearance.BorderSize = 3;
            this.btnRolNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolNuevo.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnRolNuevo.Location = new System.Drawing.Point(34, 37);
            this.btnRolNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRolNuevo.Name = "btnRolNuevo";
            this.btnRolNuevo.Size = new System.Drawing.Size(128, 59);
            this.btnRolNuevo.TabIndex = 0;
            this.btnRolNuevo.Text = "Rol Nuevo";
            this.btnRolNuevo.UseVisualStyleBackColor = true;
            this.btnRolNuevo.Click += new System.EventHandler(this.btnRolNuevo_Click);
            // 
            // dgvMostrarRol
            // 
            this.dgvMostrarRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrarRol.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMostrarRol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvMostrarRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMostrarRol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarRol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostrarRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Otorgar_Permisos,
            this.Eliminar});
            this.dgvMostrarRol.EnableHeadersVisualStyles = false;
            this.dgvMostrarRol.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvMostrarRol.Location = new System.Drawing.Point(20, 161);
            this.dgvMostrarRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMostrarRol.Name = "dgvMostrarRol";
            this.dgvMostrarRol.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarRol.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostrarRol.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMostrarRol.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMostrarRol.RowTemplate.Height = 24;
            this.dgvMostrarRol.Size = new System.Drawing.Size(865, 130);
            this.dgvMostrarRol.TabIndex = 8;
            this.dgvMostrarRol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarRol_CellClick);
            this.dgvMostrarRol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarRol_CellContentClick);
            // 
            // grbRol
            // 
            this.grbRol.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRol.Location = new System.Drawing.Point(9, 129);
            this.grbRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbRol.Name = "grbRol";
            this.grbRol.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbRol.Size = new System.Drawing.Size(914, 188);
            this.grbRol.TabIndex = 9;
            this.grbRol.TabStop = false;
            this.grbRol.Text = "Mostrar Roles";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Otorgar_Permisos
            // 
            this.Otorgar_Permisos.HeaderText = "Otorgar Permisos";
            this.Otorgar_Permisos.MinimumWidth = 6;
            this.Otorgar_Permisos.Name = "Otorgar_Permisos";
            this.Otorgar_Permisos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Otorgar_Permisos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            // 
            // RolesForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(932, 611);
            this.Controls.Add(this.dgvMostrarRol);
            this.Controls.Add(this.grbRol);
            this.Controls.Add(this.btnRolNuevo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "RolesForms";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.RolesForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarRol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRolNuevo;
        private System.Windows.Forms.DataGridView dgvMostrarRol;
        private System.Windows.Forms.GroupBox grbRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Otorgar_Permisos;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}