namespace Optica_Tokio.UI.Formularios
{
    partial class AgregarLocalForm
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbltel = new System.Windows.Forms.Label();
            this.lblDirecc = new System.Windows.Forms.Label();
            this.lblreposable = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtRespobsable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(259, 38);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(267, 32);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(259, 86);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(267, 32);
            this.txtdireccion.TabIndex = 1;
            this.txtdireccion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(259, 133);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(267, 32);
            this.txttelefono.TabIndex = 2;
            this.txttelefono.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(49, 41);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(174, 24);
            this.lblnombre.TabIndex = 4;
            this.lblnombre.Text = "NOMBRE LOCAL";
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltel.Location = new System.Drawing.Point(49, 141);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(121, 24);
            this.lbltel.TabIndex = 5;
            this.lbltel.Text = "TELEFONO";
            // 
            // lblDirecc
            // 
            this.lblDirecc.AutoSize = true;
            this.lblDirecc.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirecc.Location = new System.Drawing.Point(49, 94);
            this.lblDirecc.Name = "lblDirecc";
            this.lblDirecc.Size = new System.Drawing.Size(126, 24);
            this.lblDirecc.TabIndex = 6;
            this.lblDirecc.Text = "DIRECCION";
            // 
            // lblreposable
            // 
            this.lblreposable.AutoSize = true;
            this.lblreposable.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreposable.Location = new System.Drawing.Point(49, 190);
            this.lblreposable.Name = "lblreposable";
            this.lblreposable.Size = new System.Drawing.Size(164, 24);
            this.lblreposable.TabIndex = 7;
            this.lblreposable.Text = "RESPONSABLE";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(48, 245);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(175, 64);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(293, 245);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(175, 64);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtRespobsable
            // 
            this.txtRespobsable.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespobsable.Location = new System.Drawing.Point(259, 182);
            this.txtRespobsable.Name = "txtRespobsable";
            this.txtRespobsable.Size = new System.Drawing.Size(267, 32);
            this.txtRespobsable.TabIndex = 10;
            // 
            // AgregarLocalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(574, 333);
            this.Controls.Add(this.txtRespobsable);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lblreposable);
            this.Controls.Add(this.lblDirecc);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtnombre);
            this.Name = "AgregarLocalForm";
            this.Text = "AgregarLocalForm";
            this.Load += new System.EventHandler(this.AgregarLocalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblDirecc;
        private System.Windows.Forms.Label lblreposable;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtRespobsable;
    }
}