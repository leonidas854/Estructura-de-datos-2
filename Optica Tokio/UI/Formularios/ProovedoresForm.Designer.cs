namespace Optica_Tokio.UI.Formularios
{
    partial class ProovedoresForm
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
            this.dataGridViewProveedores = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarPROVEEDOR = new System.Windows.Forms.Button();
            this.txtExportar = new System.Windows.Forms.Button();
            this.btnAgregarPROVEEDOR = new System.Windows.Forms.Button();
            this.btnElimarPROVEEDOR = new System.Windows.Forms.Button();
            this.btnEditarPROVEEDOR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProveedores
            // 
            this.dataGridViewProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Contacto,
            this.Direccion,
            this.Email,
            this.Telefono});
            this.dataGridViewProveedores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewProveedores.GridColor = System.Drawing.Color.Black;
            this.dataGridViewProveedores.Location = new System.Drawing.Point(186, 412);
            this.dataGridViewProveedores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewProveedores.Name = "dataGridViewProveedores";
            this.dataGridViewProveedores.RowHeadersWidth = 51;
            this.dataGridViewProveedores.RowTemplate.Height = 24;
            this.dataGridViewProveedores.Size = new System.Drawing.Size(746, 199);
            this.dataGridViewProveedores.TabIndex = 8;
            this.dataGridViewProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProveedores_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Contacto
            // 
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.MinimumWidth = 6;
            this.Contacto.Name = "Contacto";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtContacto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.txtNombreProveedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(280, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(545, 333);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles Del Proveedor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(165, 277);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(319, 36);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(165, 218);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(319, 36);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(165, 159);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(319, 36);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección:";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(165, 102);
            this.txtContacto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(319, 36);
            this.txtContacto.TabIndex = 7;
            this.txtContacto.TextChanged += new System.EventHandler(this.txtContacto_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(48, 108);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(92, 25);
            this.label.TabIndex = 4;
            this.label.Text = "Contacto:";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(165, 43);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(319, 36);
            this.txtNombreProveedor.TabIndex = 1;
            this.txtNombreProveedor.TextChanged += new System.EventHandler(this.txtNombreProveedor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(429, 354);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lista de proveedores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "OPCIONES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScrollMargin = new System.Drawing.Size(200, 0);
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBuscarPROVEEDOR);
            this.panel1.Controls.Add(this.txtExportar);
            this.panel1.Controls.Add(this.btnAgregarPROVEEDOR);
            this.panel1.Controls.Add(this.btnElimarPROVEEDOR);
            this.panel1.Controls.Add(this.btnEditarPROVEEDOR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 611);
            this.panel1.TabIndex = 7;
            // 
            // btnBuscarPROVEEDOR
            // 
            this.btnBuscarPROVEEDOR.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscarPROVEEDOR.BackgroundImage = global::Optica_Tokio.Properties.Resources.Captura_de_pantalla_2024_11_17_031820;
            this.btnBuscarPROVEEDOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarPROVEEDOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPROVEEDOR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPROVEEDOR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarPROVEEDOR.Location = new System.Drawing.Point(32, 351);
            this.btnBuscarPROVEEDOR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarPROVEEDOR.Name = "btnBuscarPROVEEDOR";
            this.btnBuscarPROVEEDOR.Size = new System.Drawing.Size(103, 82);
            this.btnBuscarPROVEEDOR.TabIndex = 5;
            this.btnBuscarPROVEEDOR.UseVisualStyleBackColor = false;
            this.btnBuscarPROVEEDOR.Click += new System.EventHandler(this.btnBuscarPROVEEDOR_Click_1);
            // 
            // txtExportar
            // 
            this.txtExportar.BackColor = System.Drawing.Color.LimeGreen;
            this.txtExportar.BackgroundImage = global::Optica_Tokio.Properties.Resources.Captura_de_pantalla_2024_11_10_234455;
            this.txtExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtExportar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExportar.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtExportar.Location = new System.Drawing.Point(32, 464);
            this.txtExportar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExportar.Name = "txtExportar";
            this.txtExportar.Size = new System.Drawing.Size(103, 68);
            this.txtExportar.TabIndex = 9;
            this.txtExportar.UseVisualStyleBackColor = false;
            this.txtExportar.Click += new System.EventHandler(this.txtExportar_Click_1);
            // 
            // btnAgregarPROVEEDOR
            // 
            this.btnAgregarPROVEEDOR.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarPROVEEDOR.BackgroundImage = global::Optica_Tokio.Properties.Resources.png_clipart_computer_icons_document_add_button_number_add_button;
            this.btnAgregarPROVEEDOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarPROVEEDOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPROVEEDOR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPROVEEDOR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarPROVEEDOR.Location = new System.Drawing.Point(32, 77);
            this.btnAgregarPROVEEDOR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarPROVEEDOR.Name = "btnAgregarPROVEEDOR";
            this.btnAgregarPROVEEDOR.Size = new System.Drawing.Size(103, 82);
            this.btnAgregarPROVEEDOR.TabIndex = 2;
            this.btnAgregarPROVEEDOR.UseVisualStyleBackColor = false;
            this.btnAgregarPROVEEDOR.Click += new System.EventHandler(this.btnAgregarPROVEEDOR_Click_1);
            // 
            // btnElimarPROVEEDOR
            // 
            this.btnElimarPROVEEDOR.BackColor = System.Drawing.Color.DarkRed;
            this.btnElimarPROVEEDOR.BackgroundImage = global::Optica_Tokio.Properties.Resources.png_transparent_logo_trademark_brand_delete_button_miscellaneous_text_trademark_thumbnail;
            this.btnElimarPROVEEDOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnElimarPROVEEDOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimarPROVEEDOR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimarPROVEEDOR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnElimarPROVEEDOR.Location = new System.Drawing.Point(32, 260);
            this.btnElimarPROVEEDOR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnElimarPROVEEDOR.Name = "btnElimarPROVEEDOR";
            this.btnElimarPROVEEDOR.Size = new System.Drawing.Size(103, 82);
            this.btnElimarPROVEEDOR.TabIndex = 4;
            this.btnElimarPROVEEDOR.UseVisualStyleBackColor = false;
            this.btnElimarPROVEEDOR.Click += new System.EventHandler(this.btnElimarPROVEEDOR_Click_1);
            // 
            // btnEditarPROVEEDOR
            // 
            this.btnEditarPROVEEDOR.BackColor = System.Drawing.Color.Orange;
            this.btnEditarPROVEEDOR.BackgroundImage = global::Optica_Tokio.Properties.Resources._6325975;
            this.btnEditarPROVEEDOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarPROVEEDOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPROVEEDOR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPROVEEDOR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarPROVEEDOR.Location = new System.Drawing.Point(32, 171);
            this.btnEditarPROVEEDOR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarPROVEEDOR.Name = "btnEditarPROVEEDOR";
            this.btnEditarPROVEEDOR.Size = new System.Drawing.Size(103, 82);
            this.btnEditarPROVEEDOR.TabIndex = 3;
            this.btnEditarPROVEEDOR.UseVisualStyleBackColor = false;
            this.btnEditarPROVEEDOR.Click += new System.EventHandler(this.btnEditarPROVEEDOR_Click_1);
            // 
            // ProovedoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(932, 611);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewProveedores);
            this.Controls.Add(this.panel1);
            this.Name = "ProovedoresForm";
            this.Text = "Proovedores";
            //this.Load += new System.EventHandler(this.ProovedoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditarPROVEEDOR;
        private System.Windows.Forms.Button btnElimarPROVEEDOR;
        private System.Windows.Forms.Button btnAgregarPROVEEDOR;
        private System.Windows.Forms.Button txtExportar;
        private System.Windows.Forms.Button btnBuscarPROVEEDOR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}