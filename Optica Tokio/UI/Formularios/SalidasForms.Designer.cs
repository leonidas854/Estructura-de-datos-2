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
            this.grbFacturacion = new System.Windows.Forms.GroupBox();
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
            this.txtBuscarPorNumero = new System.Windows.Forms.TextBox();
            this.btnNuevaFactura = new System.Windows.Forms.Button();
            this.grbFacturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFacturacion
            // 
            this.grbFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFacturacion.Controls.Add(this.dgvFacturacion);
            this.grbFacturacion.Controls.Add(this.cmbOpListaSalidas);
            this.grbFacturacion.Controls.Add(this.txtBuscarPorNumero);
            this.grbFacturacion.Controls.Add(this.btnNuevaFactura);
            this.grbFacturacion.Location = new System.Drawing.Point(22, 28);
            this.grbFacturacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbFacturacion.Name = "grbFacturacion";
            this.grbFacturacion.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbFacturacion.Size = new System.Drawing.Size(899, 367);
            this.grbFacturacion.TabIndex = 0;
            this.grbFacturacion.TabStop = false;
            this.grbFacturacion.Text = "Facturacion";
            // 
            // dgvFacturacion
            // 
            this.dgvFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvFacturacion.Location = new System.Drawing.Point(4, 187);
            this.dgvFacturacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFacturacion.Name = "dgvFacturacion";
            this.dgvFacturacion.RowHeadersWidth = 51;
            this.dgvFacturacion.RowTemplate.Height = 24;
            this.dgvFacturacion.Size = new System.Drawing.Size(891, 130);
            this.dgvFacturacion.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CODIGO SALIDA";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CODIGO PRODUCTO";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CODIGO LOCAL";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CANTIDAD";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "FECHA";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CODIGO USUARIO";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 125;
            // 
            // cmbOpListaSalidas
            // 
            this.cmbOpListaSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOpListaSalidas.FormattingEnabled = true;
            this.cmbOpListaSalidas.Location = new System.Drawing.Point(566, 91);
            this.cmbOpListaSalidas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbOpListaSalidas.Name = "cmbOpListaSalidas";
            this.cmbOpListaSalidas.Size = new System.Drawing.Size(276, 21);
            this.cmbOpListaSalidas.TabIndex = 3;
            // 
            // txtBuscarPorNumero
            // 
            this.txtBuscarPorNumero.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtBuscarPorNumero.Location = new System.Drawing.Point(56, 91);
            this.txtBuscarPorNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarPorNumero.Name = "txtBuscarPorNumero";
            this.txtBuscarPorNumero.Size = new System.Drawing.Size(238, 20);
            this.txtBuscarPorNumero.TabIndex = 2;
            this.txtBuscarPorNumero.Text = "Buscar por número de factura";
            this.txtBuscarPorNumero.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtBuscarPorNumero.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.Location = new System.Drawing.Point(22, 29);
            this.btnNuevaFactura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Size = new System.Drawing.Size(124, 33);
            this.btnNuevaFactura.TabIndex = 1;
            this.btnNuevaFactura.Text = "NUEVA FACTURA";
            this.btnNuevaFactura.UseVisualStyleBackColor = true;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
            // 
            // SalidasForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(932, 611);
            this.Controls.Add(this.grbFacturacion);
            this.Name = "SalidasForms";
            this.Text = "Salidas";
            this.grbFacturacion.ResumeLayout(false);
            this.grbFacturacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFacturacion;
        private System.Windows.Forms.TextBox txtBuscarPorNumero;
        private System.Windows.Forms.Button btnNuevaFactura;
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
    }
}