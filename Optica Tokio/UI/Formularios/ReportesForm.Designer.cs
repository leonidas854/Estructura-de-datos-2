namespace Optica_Tokio.UI.Formularios
{
    partial class ReportesForm
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
            this.grpReportes = new System.Windows.Forms.GroupBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbStockReport = new System.Windows.Forms.ComboBox();
            this.cmbComprobanteReport = new System.Windows.Forms.ComboBox();
            this.cmbProductoReport = new System.Windows.Forms.ComboBox();
            this.cmbProvedorReport = new System.Windows.Forms.ComboBox();
            this.cmbCategoriaReport = new System.Windows.Forms.ComboBox();
            this.cmbVendedorReport = new System.Windows.Forms.ComboBox();
            this.cmbTipoReport = new System.Windows.Forms.ComboBox();
            this.grpReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReportes
            // 
            this.grpReportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReportes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpReportes.Controls.Add(this.btnReporte);
            this.grpReportes.Controls.Add(this.dateTimePicker2);
            this.grpReportes.Controls.Add(this.dateTimePicker1);
            this.grpReportes.Controls.Add(this.cmbStockReport);
            this.grpReportes.Controls.Add(this.cmbComprobanteReport);
            this.grpReportes.Controls.Add(this.cmbProductoReport);
            this.grpReportes.Controls.Add(this.cmbProvedorReport);
            this.grpReportes.Controls.Add(this.cmbCategoriaReport);
            this.grpReportes.Controls.Add(this.cmbVendedorReport);
            this.grpReportes.Controls.Add(this.cmbTipoReport);
            this.grpReportes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReportes.Location = new System.Drawing.Point(36, 30);
            this.grpReportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpReportes.Name = "grpReportes";
            this.grpReportes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpReportes.Size = new System.Drawing.Size(1171, 380);
            this.grpReportes.TabIndex = 0;
            this.grpReportes.TabStop = false;
            this.grpReportes.Text = "Generar Reporte";
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnReporte.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(507, 334);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(205, 46);
            this.btnReporte.TabIndex = 9;
            this.btnReporte.Text = "Hacer Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft YaHei Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(787, 37);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(271, 34);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(419, 37);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(325, 34);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmbStockReport
            // 
            this.cmbStockReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStockReport.FormattingEnabled = true;
            this.cmbStockReport.Location = new System.Drawing.Point(787, 270);
            this.cmbStockReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStockReport.Name = "cmbStockReport";
            this.cmbStockReport.Size = new System.Drawing.Size(271, 35);
            this.cmbStockReport.TabIndex = 6;
            this.cmbStockReport.Enter += new System.EventHandler(this.cmbStockReport_Enter);
            this.cmbStockReport.Leave += new System.EventHandler(this.cmbStockReport_Leave);
            // 
            // cmbComprobanteReport
            // 
            this.cmbComprobanteReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbComprobanteReport.FormattingEnabled = true;
            this.cmbComprobanteReport.Location = new System.Drawing.Point(787, 143);
            this.cmbComprobanteReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbComprobanteReport.Name = "cmbComprobanteReport";
            this.cmbComprobanteReport.Size = new System.Drawing.Size(271, 35);
            this.cmbComprobanteReport.TabIndex = 5;
            this.cmbComprobanteReport.Enter += new System.EventHandler(this.cmbComprobanteReport_Enter);
            this.cmbComprobanteReport.Leave += new System.EventHandler(this.cmbComprobanteReport_Leave);
            // 
            // cmbProductoReport
            // 
            this.cmbProductoReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbProductoReport.FormattingEnabled = true;
            this.cmbProductoReport.Location = new System.Drawing.Point(413, 143);
            this.cmbProductoReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProductoReport.Name = "cmbProductoReport";
            this.cmbProductoReport.Size = new System.Drawing.Size(332, 35);
            this.cmbProductoReport.TabIndex = 4;
            this.cmbProductoReport.Enter += new System.EventHandler(this.cmbProductoReport_Enter);
            this.cmbProductoReport.Leave += new System.EventHandler(this.cmbProductoReport_Leave);
            // 
            // cmbProvedorReport
            // 
            this.cmbProvedorReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbProvedorReport.FormattingEnabled = true;
            this.cmbProvedorReport.Location = new System.Drawing.Point(45, 270);
            this.cmbProvedorReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProvedorReport.Name = "cmbProvedorReport";
            this.cmbProvedorReport.Size = new System.Drawing.Size(329, 35);
            this.cmbProvedorReport.TabIndex = 3;
            this.cmbProvedorReport.Enter += new System.EventHandler(this.cmbProvedorReport_Enter);
            this.cmbProvedorReport.Leave += new System.EventHandler(this.cmbProvedorReport_Leave);
            // 
            // cmbCategoriaReport
            // 
            this.cmbCategoriaReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbCategoriaReport.FormattingEnabled = true;
            this.cmbCategoriaReport.Location = new System.Drawing.Point(45, 145);
            this.cmbCategoriaReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategoriaReport.Name = "cmbCategoriaReport";
            this.cmbCategoriaReport.Size = new System.Drawing.Size(329, 35);
            this.cmbCategoriaReport.TabIndex = 2;
            this.cmbCategoriaReport.Enter += new System.EventHandler(this.cmbCategoriaReport_Enter);
            this.cmbCategoriaReport.Leave += new System.EventHandler(this.cmbCategoriaReport_Leave);
            // 
            // cmbVendedorReport
            // 
            this.cmbVendedorReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbVendedorReport.FormattingEnabled = true;
            this.cmbVendedorReport.Location = new System.Drawing.Point(413, 270);
            this.cmbVendedorReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVendedorReport.Name = "cmbVendedorReport";
            this.cmbVendedorReport.Size = new System.Drawing.Size(332, 35);
            this.cmbVendedorReport.TabIndex = 1;
            this.cmbVendedorReport.Enter += new System.EventHandler(this.cmbVendedorReport_Enter);
            this.cmbVendedorReport.Leave += new System.EventHandler(this.cmbVendedorReport_Leave);
            // 
            // cmbTipoReport
            // 
            this.cmbTipoReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbTipoReport.FormattingEnabled = true;
            this.cmbTipoReport.Items.AddRange(new object[] {
            "reporte de stock",
            "informe de venta",
            "informe de ganancias",
            "informe pendiente",
            "reporte de factura"});
            this.cmbTipoReport.Location = new System.Drawing.Point(45, 33);
            this.cmbTipoReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoReport.Name = "cmbTipoReport";
            this.cmbTipoReport.Size = new System.Drawing.Size(329, 35);
            this.cmbTipoReport.TabIndex = 0;
            this.cmbTipoReport.Enter += new System.EventHandler(this.cmbTipoReport_Enter);
            this.cmbTipoReport.Leave += new System.EventHandler(this.cmbTipoReport_Leave);
            // 
            // ReportesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 752);
            this.Controls.Add(this.grpReportes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReportesForm";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.ReportesForm_Load);
            this.grpReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReportes;
        private System.Windows.Forms.ComboBox cmbTipoReport;
        private System.Windows.Forms.ComboBox cmbStockReport;
        private System.Windows.Forms.ComboBox cmbComprobanteReport;
        private System.Windows.Forms.ComboBox cmbProductoReport;
        private System.Windows.Forms.ComboBox cmbProvedorReport;
        private System.Windows.Forms.ComboBox cmbCategoriaReport;
        private System.Windows.Forms.ComboBox cmbVendedorReport;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnReporte;
    }
}