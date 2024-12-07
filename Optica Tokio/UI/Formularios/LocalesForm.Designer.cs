namespace Optica_Tokio.UI.Formularios
{
    partial class Locales
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
            this.btnAgregarLocales = new System.Windows.Forms.Button();
            this.dgvLocales = new System.Windows.Forms.DataGridView();
            this.btnReportes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarLocales
            // 
            this.btnAgregarLocales.Location = new System.Drawing.Point(53, 32);
            this.btnAgregarLocales.Name = "btnAgregarLocales";
            this.btnAgregarLocales.Size = new System.Drawing.Size(165, 79);
            this.btnAgregarLocales.TabIndex = 0;
            this.btnAgregarLocales.Text = "Agregar Local";
            this.btnAgregarLocales.UseVisualStyleBackColor = true;
            this.btnAgregarLocales.Click += new System.EventHandler(this.btnAgregarLocales_Click);
            // 
            // dgvLocales
            // 
            this.dgvLocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocales.Location = new System.Drawing.Point(53, 157);
            this.dgvLocales.Name = "dgvLocales";
            this.dgvLocales.Size = new System.Drawing.Size(594, 310);
            this.dgvLocales.TabIndex = 1;
            this.dgvLocales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(265, 38);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(167, 73);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reporte";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // Locales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(932, 611);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.dgvLocales);
            this.Controls.Add(this.btnAgregarLocales);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Locales";
            this.Text = "LocalesForm";
            this.Load += new System.EventHandler(this.Locales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarLocales;
        private System.Windows.Forms.DataGridView dgvLocales;
        private System.Windows.Forms.Button btnReportes;
    }
}