namespace Optica_Tokio.UI.Formularios
{
    partial class FrmMain_Menu
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
            this.FLPmain = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FLPmain
            // 
            this.FLPmain.Dock = System.Windows.Forms.DockStyle.Left;
            this.FLPmain.Location = new System.Drawing.Point(0, 0);
            this.FLPmain.Name = "FLPmain";
            this.FLPmain.Size = new System.Drawing.Size(197, 561);
            this.FLPmain.TabIndex = 0;
            // 
            // FrmMain_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.FLPmain);
            this.Name = "FrmMain_Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLPmain;
    }
}