namespace Optica_Tokio.UI.Formularios
{
    partial class FrmPermisos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkCategorias = new System.Windows.Forms.CheckBox();
            this.chkProveedores = new System.Windows.Forms.CheckBox();
            this.chkProductos = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkEntradas = new System.Windows.Forms.CheckBox();
            this.chkSalidas = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkGestionDeRoles = new System.Windows.Forms.CheckBox();
            this.chkUsuarios = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkReportes = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkInfo = new System.Windows.Forms.CheckBox();
            this.chkContrasenias = new System.Windows.Forms.CheckBox();
            this.btnActualizarPermisos = new System.Windows.Forms.Button();
            this.btnCancelarPermisos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkClientes = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkClientes);
            this.groupBox1.Location = new System.Drawing.Point(50, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkCategorias);
            this.groupBox2.Controls.Add(this.chkProveedores);
            this.groupBox2.Controls.Add(this.chkProductos);
            this.groupBox2.Location = new System.Drawing.Point(50, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestion de productos";
            // 
            // chkCategorias
            // 
            this.chkCategorias.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCategorias.AutoSize = true;
            this.chkCategorias.FlatAppearance.BorderSize = 0;
            this.chkCategorias.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkCategorias.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCategorias.Image = global::Optica_Tokio.Properties.Resources.Unchecked;
            this.chkCategorias.Location = new System.Drawing.Point(23, 30);
            this.chkCategorias.Name = "chkCategorias";
            this.chkCategorias.Size = new System.Drawing.Size(133, 54);
            this.chkCategorias.TabIndex = 3;
            this.chkCategorias.Text = "Categorias";
            this.chkCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkCategorias.UseVisualStyleBackColor = true;
            this.chkCategorias.CheckedChanged += new System.EventHandler(this.chkChangedCh);
            // 
            // chkProveedores
            // 
            this.chkProveedores.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkProveedores.AutoSize = true;
            this.chkProveedores.FlatAppearance.BorderSize = 0;
            this.chkProveedores.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkProveedores.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProveedores.Image = global::Optica_Tokio.Properties.Resources.Unchecked;
            this.chkProveedores.Location = new System.Drawing.Point(390, 30);
            this.chkProveedores.Name = "chkProveedores";
            this.chkProveedores.Size = new System.Drawing.Size(147, 54);
            this.chkProveedores.TabIndex = 2;
            this.chkProveedores.Text = "Proveedores";
            this.chkProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkProveedores.UseVisualStyleBackColor = true;
            this.chkProveedores.CheckedChanged += new System.EventHandler(this.chkChangedCh);
            // 
            // chkProductos
            // 
            this.chkProductos.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkProductos.AutoSize = true;
            this.chkProductos.FlatAppearance.BorderSize = 0;
            this.chkProductos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkProductos.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProductos.Image = global::Optica_Tokio.Properties.Resources.Unchecked;
            this.chkProductos.Location = new System.Drawing.Point(212, 30);
            this.chkProductos.Name = "chkProductos";
            this.chkProductos.Size = new System.Drawing.Size(132, 54);
            this.chkProductos.TabIndex = 1;
            this.chkProductos.Text = "Productos";
            this.chkProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkProductos.UseVisualStyleBackColor = true;
            this.chkProductos.CheckedChanged += new System.EventHandler(this.chkChangedCh);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkEntradas);
            this.groupBox3.Controls.Add(this.chkSalidas);
            this.groupBox3.Location = new System.Drawing.Point(50, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(573, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "gestion de existencias";
            // 
            // chkEntradas
            // 
            this.chkEntradas.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkEntradas.AutoSize = true;
            this.chkEntradas.FlatAppearance.BorderSize = 0;
            this.chkEntradas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkEntradas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEntradas.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEntradas.Image = global::Optica_Tokio.Properties.Resources.Unchecked;
            this.chkEntradas.Location = new System.Drawing.Point(23, 22);
            this.chkEntradas.Name = "chkEntradas";
            this.chkEntradas.Size = new System.Drawing.Size(125, 54);
            this.chkEntradas.TabIndex = 3;
            this.chkEntradas.Text = "Entradas";
            this.chkEntradas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkEntradas.UseVisualStyleBackColor = true;
            this.chkEntradas.CheckedChanged += new System.EventHandler(this.chkChangedCh);
            // 
            // chkSalidas
            // 
            this.chkSalidas.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSalidas.AutoSize = true;
            this.chkSalidas.FlatAppearance.BorderSize = 0;
            this.chkSalidas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkSalidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkSalidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSalidas.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSalidas.Image = global::Optica_Tokio.Properties.Resources.Unchecked;
            this.chkSalidas.Location = new System.Drawing.Point(233, 22);
            this.chkSalidas.Name = "chkSalidas";
            this.chkSalidas.Size = new System.Drawing.Size(111, 54);
            this.chkSalidas.TabIndex = 2;
            this.chkSalidas.Text = "Salidas";
            this.chkSalidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkSalidas.UseVisualStyleBackColor = true;
            this.chkSalidas.CheckedChanged += new System.EventHandler(this.chkChangedCh);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkGestionDeRoles);
            this.groupBox4.Controls.Add(this.chkUsuarios);
            this.groupBox4.Location = new System.Drawing.Point(50, 472);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(573, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gestion de usuarios";
            // 
            // chkGestionDeRoles
            // 
            this.chkGestionDeRoles.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkGestionDeRoles.AutoSize = true;
            this.chkGestionDeRoles.FlatAppearance.BorderSize = 0;
            this.chkGestionDeRoles.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkGestionDeRoles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkGestionDeRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkGestionDeRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkGestionDeRoles.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGestionDeRoles.Image = global::Optica_Tokio.Properties.Resources.Unchecked;
            this.chkGestionDeRoles.Location = new System.Drawing.Point(25, 21);
            this.chkGestionDeRoles.Name = "chkGestionDeRoles";
            this.chkGestionDeRoles.Size = new System.Drawing.Size(167, 54);
            this.chkGestionDeRoles.TabIndex = 3;
            this.chkGestionDeRoles.Text = "Gestion de roles";
            this.chkGestionDeRoles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkGestionDeRoles.UseVisualStyleBackColor = true;
            this.chkGestionDeRoles.CheckedChanged += new System.EventHandler(this.chkChangedCh);
            // 
            // chkUsuarios
            // 
            this.chkUsuarios.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkUsuarios.AutoSize = true;
            this.chkUsuarios.FlatAppearance.BorderSize = 0;
            this.chkUsuarios.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkUsuarios.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUsuarios.Image = global::Optica_Tokio.Properties.Resources.Unchecked;
            this.chkUsuarios.Location = new System.Drawing.Point(230, 21);
            this.chkUsuarios.Name = "chkUsuarios";
            this.chkUsuarios.Size = new System.Drawing.Size(114, 54);
            this.chkUsuarios.TabIndex = 2;
            this.chkUsuarios.Text = "Usarios";
            this.chkUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkUsuarios.UseVisualStyleBackColor = true;
            this.chkUsuarios.CheckedChanged += new System.EventHandler(this.chkChangedCh);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkReportes);
            this.groupBox5.Location = new System.Drawing.Point(50, 606);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(573, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reportes";
            // 
            // chkReportes
            // 
            this.chkReportes.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkReportes.AutoSize = true;
            this.chkReportes.FlatAppearance.BorderSize = 0;
            this.chkReportes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkReportes.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReportes.Image = global::Optica_Tokio.Properties.Resources.Unchecked;
            this.chkReportes.Location = new System.Drawing.Point(31, 21);
            this.chkReportes.Name = "chkReportes";
            this.chkReportes.Size = new System.Drawing.Size(125, 54);
            this.chkReportes.TabIndex = 2;
            this.chkReportes.Text = "Reportes";
            this.chkReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkReportes.UseVisualStyleBackColor = true;
            this.chkReportes.CheckedChanged += new System.EventHandler(this.chkChangedCh);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkInfo);
            this.groupBox6.Controls.Add(this.chkContrasenias);
            this.groupBox6.Location = new System.Drawing.Point(50, 745);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(573, 100);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Configuracion";
            // 
            // chkInfo
            // 
            this.chkInfo.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkInfo.AutoSize = true;
            this.chkInfo.FlatAppearance.BorderSize = 0;
            this.chkInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkInfo.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInfo.Image = global::Optica_Tokio.Properties.Resources.Unchecked;
            this.chkInfo.Location = new System.Drawing.Point(31, 21);
            this.chkInfo.Name = "chkInfo";
            this.chkInfo.Size = new System.Drawing.Size(186, 54);
            this.chkInfo.TabIndex = 3;
            this.chkInfo.Text = "Info. de la empresa";
            this.chkInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkInfo.UseVisualStyleBackColor = true;
            this.chkInfo.CheckedChanged += new System.EventHandler(this.chkChangedCh);
            // 
            // chkContrasenias
            // 
            this.chkContrasenias.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkContrasenias.AutoSize = true;
            this.chkContrasenias.FlatAppearance.BorderSize = 0;
            this.chkContrasenias.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkContrasenias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkContrasenias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkContrasenias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkContrasenias.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkContrasenias.Image = global::Optica_Tokio.Properties.Resources.Unchecked;
            this.chkContrasenias.Location = new System.Drawing.Point(242, 21);
            this.chkContrasenias.Name = "chkContrasenias";
            this.chkContrasenias.Size = new System.Drawing.Size(144, 54);
            this.chkContrasenias.TabIndex = 2;
            this.chkContrasenias.Text = "Contraseñas";
            this.chkContrasenias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkContrasenias.UseVisualStyleBackColor = true;
            this.chkContrasenias.CheckedChanged += new System.EventHandler(this.chkChangedCh);
            // 
            // btnActualizarPermisos
            // 
            this.btnActualizarPermisos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizarPermisos.FlatAppearance.BorderSize = 3;
            this.btnActualizarPermisos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnActualizarPermisos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnActualizarPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPermisos.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPermisos.Location = new System.Drawing.Point(358, 919);
            this.btnActualizarPermisos.Name = "btnActualizarPermisos";
            this.btnActualizarPermisos.Size = new System.Drawing.Size(151, 67);
            this.btnActualizarPermisos.TabIndex = 7;
            this.btnActualizarPermisos.Text = "Actualizar";
            this.btnActualizarPermisos.UseVisualStyleBackColor = true;
            this.btnActualizarPermisos.Click += new System.EventHandler(this.btnActualizarPermisos_Click);
            // 
            // btnCancelarPermisos
            // 
            this.btnCancelarPermisos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelarPermisos.FlatAppearance.BorderSize = 3;
            this.btnCancelarPermisos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelarPermisos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelarPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPermisos.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPermisos.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarPermisos.Location = new System.Drawing.Point(525, 919);
            this.btnCancelarPermisos.Name = "btnCancelarPermisos";
            this.btnCancelarPermisos.Size = new System.Drawing.Size(135, 67);
            this.btnCancelarPermisos.TabIndex = 8;
            this.btnCancelarPermisos.Text = "Cancelar";
            this.btnCancelarPermisos.UseVisualStyleBackColor = true;
            this.btnCancelarPermisos.Click += new System.EventHandler(this.btnCancelarPermisos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 66);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "OTORGAR PERMISOS";
            // 
            // chkClientes
            // 
            this.chkClientes.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkClientes.AutoSize = true;
            this.chkClientes.FlatAppearance.BorderSize = 0;
            this.chkClientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkClientes.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClientes.Image = global::Optica_Tokio.Properties.Resources.Unchecked;
            this.chkClientes.Location = new System.Drawing.Point(39, 34);
            this.chkClientes.Name = "chkClientes";
            this.chkClientes.Size = new System.Drawing.Size(117, 54);
            this.chkClientes.TabIndex = 0;
            this.chkClientes.Text = "Clientes";
            this.chkClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkClientes.UseVisualStyleBackColor = true;
            this.chkClientes.CheckedChanged += new System.EventHandler(this.chkChangedCh);
            // 
            // FrmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(704, 1073);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelarPermisos);
            this.Controls.Add(this.btnActualizarPermisos);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPermisos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkClientes;
        private System.Windows.Forms.CheckBox chkCategorias;
        private System.Windows.Forms.CheckBox chkProveedores;
        private System.Windows.Forms.CheckBox chkProductos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkEntradas;
        private System.Windows.Forms.CheckBox chkSalidas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkGestionDeRoles;
        private System.Windows.Forms.CheckBox chkUsuarios;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkReportes;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkInfo;
        private System.Windows.Forms.CheckBox chkContrasenias;
        private System.Windows.Forms.Button btnActualizarPermisos;
        private System.Windows.Forms.Button btnCancelarPermisos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}