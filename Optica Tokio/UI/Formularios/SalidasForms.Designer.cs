namespace Optica_Tokio.UI.Formularios
{
    partial class SalidasForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbSalidas = new System.Windows.Forms.GroupBox();
            this.txtBuscarPorNumero = new System.Windows.Forms.TextBox();
            this.dgvFacturacion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbOpListaSalidas = new System.Windows.Forms.ComboBox();
            this.btnNuevaSalida = new System.Windows.Forms.Button();
            this.grbSalidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSalidas
            // 
            this.grbSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSalidas.Controls.Add(this.dgvFacturacion);
            this.grbSalidas.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSalidas.Location = new System.Drawing.Point(12, 184);
            this.grbSalidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSalidas.Name = "grbSalidas";
            this.grbSalidas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSalidas.Size = new System.Drawing.Size(1199, 314);
            this.grbSalidas.TabIndex = 0;
            this.grbSalidas.TabStop = false;
            this.grbSalidas.Text = "Facturacion";
            // 
            // txtBuscarPorNumero
            // 
            this.txtBuscarPorNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBuscarPorNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPorNumero.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtBuscarPorNumero.Location = new System.Drawing.Point(49, 125);
            this.txtBuscarPorNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarPorNumero.Name = "txtBuscarPorNumero";
            this.txtBuscarPorNumero.Size = new System.Drawing.Size(321, 22);
            this.txtBuscarPorNumero.TabIndex = 7;
            this.txtBuscarPorNumero.Text = "Buscar por número de factura";
            // 
            // dgvFacturacion
            // 
            this.dgvFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacturacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFacturacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFacturacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Editar,
            this.Eliminar});
            this.dgvFacturacion.EnableHeadersVisualStyles = false;
            this.dgvFacturacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvFacturacion.Location = new System.Drawing.Point(5, 73);
            this.dgvFacturacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFacturacion.Name = "dgvFacturacion";
            this.dgvFacturacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvFacturacion.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFacturacion.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvFacturacion.RowTemplate.Height = 24;
            this.dgvFacturacion.Size = new System.Drawing.Size(1188, 160);
            this.dgvFacturacion.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CODIGO SALIDA";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 149;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CODIGO PRODUCTO";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 177;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CODIGO LOCAL";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 145;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CANTIDAD";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 119;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "FECHA";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CODIGO USUARIO";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 161;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 78;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 70;
            // 
            // cmbOpListaSalidas
            // 
            this.cmbOpListaSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOpListaSalidas.FormattingEnabled = true;
            this.cmbOpListaSalidas.Location = new System.Drawing.Point(726, 125);
            this.cmbOpListaSalidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOpListaSalidas.Name = "cmbOpListaSalidas";
            this.cmbOpListaSalidas.Size = new System.Drawing.Size(367, 24);
            this.cmbOpListaSalidas.TabIndex = 3;
            this.cmbOpListaSalidas.SelectedIndexChanged += new System.EventHandler(this.cmbOpListaSalidas_SelectedIndexChanged);
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
            this.btnNuevaSalida.Location = new System.Drawing.Point(49, 11);
            this.btnNuevaSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaSalida.Name = "btnNuevaSalida";
            this.btnNuevaSalida.Size = new System.Drawing.Size(216, 70);
            this.btnNuevaSalida.TabIndex = 35;
            this.btnNuevaSalida.Text = "NUEVA SALIDA";
            this.btnNuevaSalida.UseVisualStyleBackColor = true;
            this.btnNuevaSalida.Click += new System.EventHandler(this.btnNuevaSalida_Click);
            // 
            // SalidasForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1243, 752);
            this.Controls.Add(this.btnNuevaSalida);
            this.Controls.Add(this.txtBuscarPorNumero);
            this.Controls.Add(this.grbSalidas);
            this.Controls.Add(this.cmbOpListaSalidas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SalidasForms";
            this.Text = "Salidas";
            this.Load += new System.EventHandler(this.SalidasForms_Load);
            this.grbSalidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSalidas;
        private System.Windows.Forms.ComboBox cmbOpListaSalidas;
        private System.Windows.Forms.DataGridView dgvFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.TextBox txtBuscarPorNumero;
        private System.Windows.Forms.Button btnNuevaSalida;
    }
}