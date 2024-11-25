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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbSalidas = new System.Windows.Forms.GroupBox();
            this.txtBuscarPorNumero = new System.Windows.Forms.TextBox();
            this.btnNuevaFactura = new System.Windows.Forms.Button();
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
            this.grbNuevaSalida = new System.Windows.Forms.GroupBox();
            this.btnCancelarSalida = new System.Windows.Forms.Button();
            this.btnNuevaSalida = new System.Windows.Forms.Button();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodUsuarioSalida = new System.Windows.Forms.TextBox();
            this.txtCantSalida = new System.Windows.Forms.TextBox();
            this.txtCodLocalSalida = new System.Windows.Forms.TextBox();
            this.txtCodProductoSalida = new System.Windows.Forms.TextBox();
            this.grbSalidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
            this.grbNuevaSalida.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSalidas
            // 
            this.grbSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSalidas.Controls.Add(this.txtBuscarPorNumero);
            this.grbSalidas.Controls.Add(this.btnNuevaFactura);
            this.grbSalidas.Controls.Add(this.dgvFacturacion);
            this.grbSalidas.Controls.Add(this.cmbOpListaSalidas);
            this.grbSalidas.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSalidas.Location = new System.Drawing.Point(29, 34);
            this.grbSalidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSalidas.Name = "grbSalidas";
            this.grbSalidas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSalidas.Size = new System.Drawing.Size(1199, 452);
            this.grbSalidas.TabIndex = 0;
            this.grbSalidas.TabStop = false;
            this.grbSalidas.Text = "Facturacion";
            // 
            // txtBuscarPorNumero
            // 
            this.txtBuscarPorNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBuscarPorNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPorNumero.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtBuscarPorNumero.Location = new System.Drawing.Point(58, 133);
            this.txtBuscarPorNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarPorNumero.Name = "txtBuscarPorNumero";
            this.txtBuscarPorNumero.Size = new System.Drawing.Size(321, 24);
            this.txtBuscarPorNumero.TabIndex = 7;
            this.txtBuscarPorNumero.Text = "Buscar por número de factura";
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevaFactura.FlatAppearance.BorderSize = 3;
            this.btnNuevaFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNuevaFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNuevaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaFactura.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaFactura.ForeColor = System.Drawing.Color.Black;
            this.btnNuevaFactura.Location = new System.Drawing.Point(58, 32);
            this.btnNuevaFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Size = new System.Drawing.Size(192, 67);
            this.btnNuevaFactura.TabIndex = 6;
            this.btnNuevaFactura.Text = "NUEVA FACTURA";
            this.btnNuevaFactura.UseVisualStyleBackColor = true;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click_1);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvFacturacion.Location = new System.Drawing.Point(5, 210);
            this.dgvFacturacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFacturacion.Name = "dgvFacturacion";
            this.dgvFacturacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFacturacion.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFacturacion.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
            this.cmbOpListaSalidas.Location = new System.Drawing.Point(764, 93);
            this.cmbOpListaSalidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOpListaSalidas.Name = "cmbOpListaSalidas";
            this.cmbOpListaSalidas.Size = new System.Drawing.Size(367, 25);
            this.cmbOpListaSalidas.TabIndex = 3;
            // 
            // grbNuevaSalida
            // 
            this.grbNuevaSalida.Controls.Add(this.btnCancelarSalida);
            this.grbNuevaSalida.Controls.Add(this.btnNuevaSalida);
            this.grbNuevaSalida.Controls.Add(this.dtpFechaSalida);
            this.grbNuevaSalida.Controls.Add(this.label5);
            this.grbNuevaSalida.Controls.Add(this.label4);
            this.grbNuevaSalida.Controls.Add(this.label3);
            this.grbNuevaSalida.Controls.Add(this.label2);
            this.grbNuevaSalida.Controls.Add(this.label1);
            this.grbNuevaSalida.Controls.Add(this.txtCodUsuarioSalida);
            this.grbNuevaSalida.Controls.Add(this.txtCantSalida);
            this.grbNuevaSalida.Controls.Add(this.txtCodLocalSalida);
            this.grbNuevaSalida.Controls.Add(this.txtCodProductoSalida);
            this.grbNuevaSalida.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNuevaSalida.Location = new System.Drawing.Point(26, 147);
            this.grbNuevaSalida.Name = "grbNuevaSalida";
            this.grbNuevaSalida.Size = new System.Drawing.Size(1202, 283);
            this.grbNuevaSalida.TabIndex = 9;
            this.grbNuevaSalida.TabStop = false;
            this.grbNuevaSalida.Text = "Nueva Salida";
            this.grbNuevaSalida.Visible = false;
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
            this.btnCancelarSalida.Location = new System.Drawing.Point(882, 179);
            this.btnCancelarSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarSalida.Name = "btnCancelarSalida";
            this.btnCancelarSalida.Size = new System.Drawing.Size(192, 67);
            this.btnCancelarSalida.TabIndex = 23;
            this.btnCancelarSalida.Text = "CANCELAR";
            this.btnCancelarSalida.UseVisualStyleBackColor = true;
            this.btnCancelarSalida.Click += new System.EventHandler(this.btnCancelarSalida_Click);
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
            this.btnNuevaSalida.Location = new System.Drawing.Point(657, 179);
            this.btnNuevaSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaSalida.Name = "btnNuevaSalida";
            this.btnNuevaSalida.Size = new System.Drawing.Size(192, 67);
            this.btnNuevaSalida.TabIndex = 22;
            this.btnNuevaSalida.Text = "NUEVA SALIDA";
            this.btnNuevaSalida.UseVisualStyleBackColor = true;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(57, 210);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(200, 24);
            this.dtpFechaSalida.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "CODIGO LOCAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "CODIGO USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "CANTIDAD DE SALIDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "FECHA DE SALIDA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "CODIGO PRODUCTO";
            // 
            // txtCodUsuarioSalida
            // 
            this.txtCodUsuarioSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCodUsuarioSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodUsuarioSalida.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtCodUsuarioSalida.Location = new System.Drawing.Point(58, 131);
            this.txtCodUsuarioSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodUsuarioSalida.Name = "txtCodUsuarioSalida";
            this.txtCodUsuarioSalida.Size = new System.Drawing.Size(321, 24);
            this.txtCodUsuarioSalida.TabIndex = 16;
            // 
            // txtCantSalida
            // 
            this.txtCantSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCantSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantSalida.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtCantSalida.Location = new System.Drawing.Point(509, 131);
            this.txtCantSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantSalida.Name = "txtCantSalida";
            this.txtCantSalida.Size = new System.Drawing.Size(321, 24);
            this.txtCantSalida.TabIndex = 14;
            // 
            // txtCodLocalSalida
            // 
            this.txtCodLocalSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCodLocalSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodLocalSalida.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtCodLocalSalida.Location = new System.Drawing.Point(509, 64);
            this.txtCodLocalSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodLocalSalida.Name = "txtCodLocalSalida";
            this.txtCodLocalSalida.Size = new System.Drawing.Size(321, 24);
            this.txtCodLocalSalida.TabIndex = 13;
            // 
            // txtCodProductoSalida
            // 
            this.txtCodProductoSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCodProductoSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodProductoSalida.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtCodProductoSalida.Location = new System.Drawing.Point(58, 64);
            this.txtCodProductoSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodProductoSalida.Name = "txtCodProductoSalida";
            this.txtCodProductoSalida.Size = new System.Drawing.Size(321, 24);
            this.txtCodProductoSalida.TabIndex = 12;
            // 
            // SalidasForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1243, 752);
            this.Controls.Add(this.grbNuevaSalida);
            this.Controls.Add(this.grbSalidas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalidasForms";
            this.Text = "Salidas";
            this.grbSalidas.ResumeLayout(false);
            this.grbSalidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).EndInit();
            this.grbNuevaSalida.ResumeLayout(false);
            this.grbNuevaSalida.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSalidas;
        private System.Windows.Forms.ComboBox cmbOpListaSalidas;
        private System.Windows.Forms.Button btnNuevaFactura;
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
        private System.Windows.Forms.GroupBox grbNuevaSalida;
        private System.Windows.Forms.Button btnCancelarSalida;
        private System.Windows.Forms.Button btnNuevaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodUsuarioSalida;
        private System.Windows.Forms.TextBox txtCantSalida;
        private System.Windows.Forms.TextBox txtCodLocalSalida;
        private System.Windows.Forms.TextBox txtCodProductoSalida;
    }
}