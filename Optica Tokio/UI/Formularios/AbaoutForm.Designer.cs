namespace Optica_Tokio.UI.Formularios
{
    partial class AbaoutForm
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
            this.lsthola = new System.Windows.Forms.ListBox();
            this.lblhola = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsthola
            // 
            this.lsthola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsthola.FormattingEnabled = true;
            this.lsthola.Location = new System.Drawing.Point(477, 90);
            this.lsthola.Name = "lsthola";
            this.lsthola.Size = new System.Drawing.Size(334, 251);
            this.lsthola.TabIndex = 0;
            // 
            // lblhola
            // 
            this.lblhola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblhola.AutoSize = true;
            this.lblhola.Location = new System.Drawing.Point(775, 552);
            this.lblhola.Name = "lblhola";
            this.lblhola.Size = new System.Drawing.Size(46, 13);
            this.lblhola.TabIndex = 1;
            this.lblhola.Text = "holadios";
            // 
            // AbaoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 611);
            this.Controls.Add(this.lblhola);
            this.Controls.Add(this.lsthola);
            this.Name = "AbaoutForm";
            this.Text = "Abaout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsthola;
        private System.Windows.Forms.Label lblhola;
    }
}