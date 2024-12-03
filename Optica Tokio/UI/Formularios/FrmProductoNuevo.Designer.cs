namespace Optica_Tokio.UI.Formularios
{
    partial class FrmProductoNuevo
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardado = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.comboBoxDeCategorias = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.gbVidrio = new System.Windows.Forms.GroupBox();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtGrosor = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.gbMontura = new System.Windows.Forms.GroupBox();
            this.txtMonturaPrecio = new System.Windows.Forms.TextBox();
            this.txtMonturaCantidad = new System.Windows.Forms.TextBox();
            this.txtMonturaPeso = new System.Windows.Forms.TextBox();
            this.txtMonturaNombre = new System.Windows.Forms.TextBox();
            this.txtMonturaDescripcion = new System.Windows.Forms.TextBox();
            this.gbEstuche = new System.Windows.Forms.GroupBox();
            this.txtEstucheCantidad = new System.Windows.Forms.TextBox();
            this.txtEstucheNombre = new System.Windows.Forms.TextBox();
            this.txtEstucheDescripcion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gbVidrio.SuspendLayout();
            this.gbMontura.SuspendLayout();
            this.gbEstuche.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 76);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo producto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatAppearance.BorderSize = 3;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(696, 365);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(202, 64);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardado
            // 
            this.btnGuardado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardado.FlatAppearance.BorderSize = 3;
            this.btnGuardado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardado.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardado.Location = new System.Drawing.Point(696, 279);
            this.btnGuardado.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardado.Name = "btnGuardado";
            this.btnGuardado.Size = new System.Drawing.Size(203, 64);
            this.btnGuardado.TabIndex = 9;
            this.btnGuardado.Text = "Guardar";
            this.btnGuardado.UseVisualStyleBackColor = true;
            this.btnGuardado.Visible = false;
            this.btnGuardado.Click += new System.EventHandler(this.btnGuardado_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombre.Location = new System.Drawing.Point(17, 35);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 34);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Text = "NOMBRE";
            // 
            // comboBoxDeCategorias
            // 
            this.comboBoxDeCategorias.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxDeCategorias.FormattingEnabled = true;
            this.comboBoxDeCategorias.Items.AddRange(new object[] {
            "Vidrio",
            "Montura",
            "Estuche"});
            this.comboBoxDeCategorias.Location = new System.Drawing.Point(625, 95);
            this.comboBoxDeCategorias.Name = "comboBoxDeCategorias";
            this.comboBoxDeCategorias.Size = new System.Drawing.Size(256, 35);
            this.comboBoxDeCategorias.TabIndex = 12;
            this.comboBoxDeCategorias.Text = "Elija una Clasificacion";
            this.comboBoxDeCategorias.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeCategorias_SelectedIndexChanged);
            this.comboBoxDeCategorias.Enter += new System.EventHandler(this.comboBoxDeCategorias_Enter);
            this.comboBoxDeCategorias.Leave += new System.EventHandler(this.comboBoxDeCategorias_Leave);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtDescripcion.Location = new System.Drawing.Point(17, 89);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(230, 34);
            this.txtDescripcion.TabIndex = 13;
            this.txtDescripcion.Text = "DESCRIPCION";
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // gbVidrio
            // 
            this.gbVidrio.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbVidrio.Controls.Add(this.txtGrosor);
            this.gbVidrio.Controls.Add(this.txtPrecio);
            this.gbVidrio.Controls.Add(this.txtAlto);
            this.gbVidrio.Controls.Add(this.txtAncho);
            this.gbVidrio.Controls.Add(this.txtNombre);
            this.gbVidrio.Controls.Add(this.txtDescripcion);
            this.gbVidrio.Location = new System.Drawing.Point(12, 197);
            this.gbVidrio.Name = "gbVidrio";
            this.gbVidrio.Size = new System.Drawing.Size(533, 269);
            this.gbVidrio.TabIndex = 14;
            this.gbVidrio.TabStop = false;
            this.gbVidrio.Text = "Vidrio";
            this.gbVidrio.Visible = false;
            // 
            // txtAlto
            // 
            this.txtAlto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtAlto.Location = new System.Drawing.Point(17, 149);
            this.txtAlto.Margin = new System.Windows.Forms.Padding(5);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(230, 34);
            this.txtAlto.TabIndex = 14;
            this.txtAlto.Text = "ALTO";
            this.txtAlto.Enter += new System.EventHandler(this.txtAlto_Enter);
            this.txtAlto.Leave += new System.EventHandler(this.txtAlto_Leave);
            // 
            // txtAncho
            // 
            this.txtAncho.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtAncho.Location = new System.Drawing.Point(17, 205);
            this.txtAncho.Margin = new System.Windows.Forms.Padding(5);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(230, 34);
            this.txtAncho.TabIndex = 15;
            this.txtAncho.Text = "ANCHO";
            this.txtAncho.Enter += new System.EventHandler(this.txtAncho_Enter);
            this.txtAncho.Leave += new System.EventHandler(this.txtAncho_Leave);
            // 
            // txtGrosor
            // 
            this.txtGrosor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtGrosor.Location = new System.Drawing.Point(277, 149);
            this.txtGrosor.Margin = new System.Windows.Forms.Padding(5);
            this.txtGrosor.Name = "txtGrosor";
            this.txtGrosor.Size = new System.Drawing.Size(230, 34);
            this.txtGrosor.TabIndex = 16;
            this.txtGrosor.Text = "GROSOR";
            this.txtGrosor.Enter += new System.EventHandler(this.txtGrosor_Enter);
            this.txtGrosor.Leave += new System.EventHandler(this.txtGrosor_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPrecio.Location = new System.Drawing.Point(277, 205);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(230, 34);
            this.txtPrecio.TabIndex = 17;
            this.txtPrecio.Text = "PRECIO";
            this.txtPrecio.Enter += new System.EventHandler(this.txtPrecio_Enter);
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // gbMontura
            // 
            this.gbMontura.BackColor = System.Drawing.Color.RosyBrown;
            this.gbMontura.Controls.Add(this.txtMonturaPrecio);
            this.gbMontura.Controls.Add(this.txtMonturaCantidad);
            this.gbMontura.Controls.Add(this.txtMonturaPeso);
            this.gbMontura.Controls.Add(this.txtMonturaNombre);
            this.gbMontura.Controls.Add(this.txtMonturaDescripcion);
            this.gbMontura.Location = new System.Drawing.Point(29, 167);
            this.gbMontura.Name = "gbMontura";
            this.gbMontura.Size = new System.Drawing.Size(533, 269);
            this.gbMontura.TabIndex = 18;
            this.gbMontura.TabStop = false;
            this.gbMontura.Text = "Montura";
            this.gbMontura.Visible = false;
            // 
            // txtMonturaPrecio
            // 
            this.txtMonturaPrecio.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtMonturaPrecio.Location = new System.Drawing.Point(277, 205);
            this.txtMonturaPrecio.Margin = new System.Windows.Forms.Padding(5);
            this.txtMonturaPrecio.Name = "txtMonturaPrecio";
            this.txtMonturaPrecio.Size = new System.Drawing.Size(230, 34);
            this.txtMonturaPrecio.TabIndex = 17;
            this.txtMonturaPrecio.Text = "PRECIO";
            this.txtMonturaPrecio.Enter += new System.EventHandler(this.txtMonturaPrecio_Enter);
            this.txtMonturaPrecio.Leave += new System.EventHandler(this.txtMonturaPrecio_Leave);
            // 
            // txtMonturaCantidad
            // 
            this.txtMonturaCantidad.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtMonturaCantidad.Location = new System.Drawing.Point(17, 149);
            this.txtMonturaCantidad.Margin = new System.Windows.Forms.Padding(5);
            this.txtMonturaCantidad.Name = "txtMonturaCantidad";
            this.txtMonturaCantidad.Size = new System.Drawing.Size(230, 34);
            this.txtMonturaCantidad.TabIndex = 14;
            this.txtMonturaCantidad.Text = "CANTIDAD";
            this.txtMonturaCantidad.Enter += new System.EventHandler(this.txtMonturaCantidad_Enter);
            this.txtMonturaCantidad.Leave += new System.EventHandler(this.txtMonturaCantidad_Leave);
            // 
            // txtMonturaPeso
            // 
            this.txtMonturaPeso.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtMonturaPeso.Location = new System.Drawing.Point(17, 205);
            this.txtMonturaPeso.Margin = new System.Windows.Forms.Padding(5);
            this.txtMonturaPeso.Name = "txtMonturaPeso";
            this.txtMonturaPeso.Size = new System.Drawing.Size(230, 34);
            this.txtMonturaPeso.TabIndex = 15;
            this.txtMonturaPeso.Text = "PESO";
            this.txtMonturaPeso.Enter += new System.EventHandler(this.txtMonturaPeso_Enter);
            this.txtMonturaPeso.Leave += new System.EventHandler(this.txtMonturaPeso_Leave);
            // 
            // txtMonturaNombre
            // 
            this.txtMonturaNombre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtMonturaNombre.Location = new System.Drawing.Point(17, 35);
            this.txtMonturaNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtMonturaNombre.Name = "txtMonturaNombre";
            this.txtMonturaNombre.Size = new System.Drawing.Size(230, 34);
            this.txtMonturaNombre.TabIndex = 8;
            this.txtMonturaNombre.Text = "NOMBRE";
            this.txtMonturaNombre.Enter += new System.EventHandler(this.txtMonturaNombre_Enter);
            this.txtMonturaNombre.Leave += new System.EventHandler(this.txtMonturaNombre_Leave);
            // 
            // txtMonturaDescripcion
            // 
            this.txtMonturaDescripcion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtMonturaDescripcion.Location = new System.Drawing.Point(17, 89);
            this.txtMonturaDescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.txtMonturaDescripcion.Name = "txtMonturaDescripcion";
            this.txtMonturaDescripcion.Size = new System.Drawing.Size(230, 34);
            this.txtMonturaDescripcion.TabIndex = 13;
            this.txtMonturaDescripcion.Text = "DESCRIPCION";
            this.txtMonturaDescripcion.Enter += new System.EventHandler(this.txtMonturaDescripcion_Enter);
            this.txtMonturaDescripcion.Leave += new System.EventHandler(this.txtMonturaDescripcion_Leave);
            // 
            // gbEstuche
            // 
            this.gbEstuche.BackColor = System.Drawing.Color.SandyBrown;
            this.gbEstuche.Controls.Add(this.txtEstucheCantidad);
            this.gbEstuche.Controls.Add(this.txtEstucheNombre);
            this.gbEstuche.Controls.Add(this.txtEstucheDescripcion);
            this.gbEstuche.Location = new System.Drawing.Point(46, 137);
            this.gbEstuche.Name = "gbEstuche";
            this.gbEstuche.Size = new System.Drawing.Size(533, 269);
            this.gbEstuche.TabIndex = 19;
            this.gbEstuche.TabStop = false;
            this.gbEstuche.Text = "Estuche";
            this.gbEstuche.Visible = false;
            // 
            // txtEstucheCantidad
            // 
            this.txtEstucheCantidad.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtEstucheCantidad.Location = new System.Drawing.Point(17, 149);
            this.txtEstucheCantidad.Margin = new System.Windows.Forms.Padding(5);
            this.txtEstucheCantidad.Name = "txtEstucheCantidad";
            this.txtEstucheCantidad.Size = new System.Drawing.Size(230, 34);
            this.txtEstucheCantidad.TabIndex = 14;
            this.txtEstucheCantidad.Text = "CANTIDAD";
            this.txtEstucheCantidad.Enter += new System.EventHandler(this.txtEstucheCantidad_Enter);
            this.txtEstucheCantidad.Leave += new System.EventHandler(this.txtEstucheCantidad_Leave);
            // 
            // txtEstucheNombre
            // 
            this.txtEstucheNombre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtEstucheNombre.Location = new System.Drawing.Point(17, 35);
            this.txtEstucheNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtEstucheNombre.Name = "txtEstucheNombre";
            this.txtEstucheNombre.Size = new System.Drawing.Size(230, 34);
            this.txtEstucheNombre.TabIndex = 8;
            this.txtEstucheNombre.Text = "NOMBRE";
            this.txtEstucheNombre.Enter += new System.EventHandler(this.txtEstucheNombre_Enter);
            this.txtEstucheNombre.Leave += new System.EventHandler(this.txtEstucheNombre_Leave);
            // 
            // txtEstucheDescripcion
            // 
            this.txtEstucheDescripcion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtEstucheDescripcion.Location = new System.Drawing.Point(17, 89);
            this.txtEstucheDescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.txtEstucheDescripcion.Name = "txtEstucheDescripcion";
            this.txtEstucheDescripcion.Size = new System.Drawing.Size(230, 34);
            this.txtEstucheDescripcion.TabIndex = 13;
            this.txtEstucheDescripcion.Text = "DESCRIPCION";
            this.txtEstucheDescripcion.Enter += new System.EventHandler(this.txtEstucheDescripcion_Enter);
            this.txtEstucheDescripcion.Leave += new System.EventHandler(this.txtEstucheDescripcion_Leave);
            // 
            // FrmProductoNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(939, 478);
            this.Controls.Add(this.gbEstuche);
            this.Controls.Add(this.gbMontura);
            this.Controls.Add(this.gbVidrio);
            this.Controls.Add(this.comboBoxDeCategorias);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardado);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductoNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProductoNuevo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbVidrio.ResumeLayout(false);
            this.gbVidrio.PerformLayout();
            this.gbMontura.ResumeLayout(false);
            this.gbMontura.PerformLayout();
            this.gbEstuche.ResumeLayout(false);
            this.gbEstuche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox comboBoxDeCategorias;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.GroupBox gbVidrio;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtGrosor;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox gbMontura;
        private System.Windows.Forms.TextBox txtMonturaPrecio;
        private System.Windows.Forms.TextBox txtMonturaCantidad;
        private System.Windows.Forms.TextBox txtMonturaPeso;
        private System.Windows.Forms.TextBox txtMonturaNombre;
        private System.Windows.Forms.TextBox txtMonturaDescripcion;
        private System.Windows.Forms.GroupBox gbEstuche;
        private System.Windows.Forms.TextBox txtEstucheCantidad;
        private System.Windows.Forms.TextBox txtEstucheNombre;
        private System.Windows.Forms.TextBox txtEstucheDescripcion;
    }
}