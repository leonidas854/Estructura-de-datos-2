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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNewUsuario = new System.Windows.Forms.Button();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.txtBCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpUsuarios = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(968, 133);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnNewUsuario
            // 
            this.btnNewUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUsuario.Location = new System.Drawing.Point(24, 21);
            this.btnNewUsuario.Name = "btnNewUsuario";
            this.btnNewUsuario.Size = new System.Drawing.Size(216, 81);
            this.btnNewUsuario.TabIndex = 2;
            this.btnNewUsuario.Text = "Nuevo usuario";
            this.btnNewUsuario.UseVisualStyleBackColor = true;
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(226, 143);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(253, 22);
            this.txtBNombre.TabIndex = 3;
            this.txtBNombre.TextChanged += new System.EventHandler(this.txtBNombre_TextChanged);
            // 
            // txtBCorreo
            // 
            this.txtBCorreo.Location = new System.Drawing.Point(769, 150);
            this.txtBCorreo.Name = "txtBCorreo";
            this.txtBCorreo.Size = new System.Drawing.Size(300, 22);
            this.txtBCorreo.TabIndex = 4;
            this.txtBCorreo.TextChanged += new System.EventHandler(this.txtBCorreo_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar Nombre:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar por correo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // grpUsuarios
            // 
            this.grpUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUsuarios.Controls.Add(this.label2);
            this.grpUsuarios.Controls.Add(this.label1);
            this.grpUsuarios.Controls.Add(this.txtBCorreo);
            this.grpUsuarios.Controls.Add(this.txtBNombre);
            this.grpUsuarios.Controls.Add(this.btnNewUsuario);
            this.grpUsuarios.Controls.Add(this.dataGridView1);
            this.grpUsuarios.Location = new System.Drawing.Point(12, 12);
            this.grpUsuarios.Name = "grpUsuarios";
            this.grpUsuarios.Size = new System.Drawing.Size(1108, 393);
            this.grpUsuarios.TabIndex = 7;
            this.grpUsuarios.TabStop = false;
            // 
            // Frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 776);
            this.Controls.Add(this.grpUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_User";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Frm_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUsuarios.ResumeLayout(false);
            this.grpUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNewUsuario;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.TextBox txtBCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpUsuarios;
    }
}