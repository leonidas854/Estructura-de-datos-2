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
            this.grbNuevaSalida = new System.Windows.Forms.GroupBox();
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
            this.grbSalidas.SuspendLayout();
            this.grbNuevaSalida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSalidas
            // 
            this.grbSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSalidas.Controls.Add(this.txtBuscarPorNumero);
            this.grbSalidas.Controls.Add(this.dgvFacturacion);
            this.grbSalidas.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSalidas.Location = new System.Drawing.Point(11, 314);
            this.grbSalidas.Margin = new System.Windows.Forms.Padding(2);
            this.grbSalidas.Name = "grbSalidas";
            this.grbSalidas.Padding = new System.Windows.Forms.Padding(2);
            this.grbSalidas.Size = new System.Drawing.Size(899, 255);
            this.grbSalidas.TabIndex = 0;
            this.grbSalidas.TabStop = false;
            this.grbSalidas.Text = "Facturacion";
            // 
            // grbNuevaSalida
            // 
            this.grbNuevaSalida.Controls.Add(this.txtuser);
            this.grbNuevaSalida.Controls.Add(this.cmblocal);
            this.grbNuevaSalida.Controls.Add(this.cmbproductos);
            this.grbNuevaSalida.Controls.Add(this.btnNuevaSalida);
            this.grbNuevaSalida.Controls.Add(this.dtpFechaSalida);
            this.grbNuevaSalida.Controls.Add(this.label5);
            this.grbNuevaSalida.Controls.Add(this.label4);
            this.grbNuevaSalida.Controls.Add(this.label3);
            this.grbNuevaSalida.Controls.Add(this.label2);
            this.grbNuevaSalida.Controls.Add(this.label1);
            this.grbNuevaSalida.Controls.Add(this.txtCantSalida);
            this.grbNuevaSalida.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNuevaSalida.Location = new System.Drawing.Point(4, 45);
            this.grbNuevaSalida.Margin = new System.Windows.Forms.Padding(2);
            this.grbNuevaSalida.Name = "grbNuevaSalida";
            this.grbNuevaSalida.Padding = new System.Windows.Forms.Padding(2);
            this.grbNuevaSalida.Size = new System.Drawing.Size(902, 230);
            this.grbNuevaSalida.TabIndex = 9;
            this.grbNuevaSalida.TabStop = false;
            this.grbNuevaSalida.Text = "Nueva Salida";
            this.grbNuevaSalida.Visible = false;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtuser.Location = new System.Drawing.Point(43, 106);
            this.txtuser.Margin = new System.Windows.Forms.Padding(2);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(241, 21);
            this.txtuser.TabIndex = 26;
            // 
            // cmblocal
            // 
            this.cmblocal.FormattingEnabled = true;
            this.cmblocal.Location = new System.Drawing.Point(382, 44);
            this.cmblocal.Name = "cmblocal";
            this.cmblocal.Size = new System.Drawing.Size(218, 21);
            this.cmblocal.TabIndex = 25;
            this.cmblocal.SelectedIndexChanged += new System.EventHandler(this.cmblocal_SelectedIndexChanged);
            // 
            // cmbproductos
            // 
            this.cmbproductos.FormattingEnabled = true;
            this.cmbproductos.Location = new System.Drawing.Point(43, 54);
            this.cmbproductos.Name = "cmbproductos";
            this.cmbproductos.Size = new System.Drawing.Size(185, 21);
            this.cmbproductos.TabIndex = 24;
            this.cmbproductos.SelectedIndexChanged += new System.EventHandler(this.cmbproductos_SelectedIndexChanged);
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
            this.btnNuevaSalida.Location = new System.Drawing.Point(493, 145);
            this.btnNuevaSalida.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevaSalida.Name = "btnNuevaSalida";
            this.btnNuevaSalida.Size = new System.Drawing.Size(144, 54);
            this.btnNuevaSalida.TabIndex = 22;
            this.btnNuevaSalida.Text = "NUEVA SALIDA";
            this.btnNuevaSalida.UseVisualStyleBackColor = true;
            this.btnNuevaSalida.Click += new System.EventHandler(this.btnNuevaSalida_ClickAsync);
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(43, 171);
            this.dtpFechaSalida.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(151, 21);
            this.dtpFechaSalida.TabIndex = 8;
            this.dtpFechaSalida.ValueChanged += new System.EventHandler(this.dtpFechaSalida_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 14);
            this.label5.TabIndex = 21;
            this.label5.Text = "CODIGO LOCAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 14);
            this.label4.TabIndex = 20;
            this.label4.Text = "CODIGO USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "CANTIDAD DE SALIDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "FECHA DE SALIDA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "CODIGO PRODUCTO";
            // 
            // txtCantSalida
            // 
            this.txtCantSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCantSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantSalida.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtCantSalida.Location = new System.Drawing.Point(382, 106);
            this.txtCantSalida.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantSalida.Name = "txtCantSalida";
            this.txtCantSalida.Size = new System.Drawing.Size(241, 21);
            this.txtCantSalida.TabIndex = 14;
            this.txtCantSalida.TextChanged += new System.EventHandler(this.txtCantSalida_TextChanged);
            // 
            // txtBuscarPorNumero
            // 
            this.txtBuscarPorNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBuscarPorNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPorNumero.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtBuscarPorNumero.Location = new System.Drawing.Point(44, 108);
            this.txtBuscarPorNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarPorNumero.Name = "txtBuscarPorNumero";
            this.txtBuscarPorNumero.Size = new System.Drawing.Size(241, 21);
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
            this.dgvFacturacion.Location = new System.Drawing.Point(4, 59);
            this.dgvFacturacion.Margin = new System.Windows.Forms.Padding(2);
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
            this.dgvFacturacion.Size = new System.Drawing.Size(891, 130);
            this.dgvFacturacion.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CODIGO SALIDA";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 126;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CODIGO PRODUCTO";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CODIGO LOCAL";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 123;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CANTIDAD";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 101;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "FECHA";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 78;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CODIGO USUARIO";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 136;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 68;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 63;
            // 
            // cmbOpListaSalidas
            // 
            this.cmbOpListaSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOpListaSalidas.FormattingEnabled = true;
            this.cmbOpListaSalidas.Location = new System.Drawing.Point(582, 11);
            this.cmbOpListaSalidas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOpListaSalidas.Name = "cmbOpListaSalidas";
            this.cmbOpListaSalidas.Size = new System.Drawing.Size(276, 21);
            this.cmbOpListaSalidas.TabIndex = 3;
            this.cmbOpListaSalidas.SelectedIndexChanged += new System.EventHandler(this.cmbOpListaSalidas_SelectedIndexChanged);
            // 
            // SalidasForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(932, 611);
            this.Controls.Add(this.grbNuevaSalida);
            this.Controls.Add(this.grbSalidas);
            this.Controls.Add(this.cmbOpListaSalidas);
            this.Name = "SalidasForms";
            this.Text = "Salidas";
            this.grbSalidas.ResumeLayout(false);
            this.grbSalidas.PerformLayout();
            this.grbNuevaSalida.ResumeLayout(false);
            this.grbNuevaSalida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox grbNuevaSalida;
        private System.Windows.Forms.Button btnNuevaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantSalida;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.ComboBox cmblocal;
        private System.Windows.Forms.ComboBox cmbproductos;
        private System.Windows.Forms.Label label4;
    }
}