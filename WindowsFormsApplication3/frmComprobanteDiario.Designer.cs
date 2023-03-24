namespace WindowsFormsApplication3
{
    partial class frmComprobanteDiario
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetAporteDiario = new WindowsFormsApplication3.DataSetAporteDiario();
            this.SP_REPORTE_ULTIMO_APORTE_DIARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_REPORTE_ULTIMO_APORTE_DIARIOTableAdapter = new WindowsFormsApplication3.DataSetAporteDiarioTableAdapters.SP_REPORTE_ULTIMO_APORTE_DIARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAporteDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_ULTIMO_APORTE_DIARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AporteDiario";
            reportDataSource1.Value = this.SP_REPORTE_ULTIMO_APORTE_DIARIOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.reporteAPORTEDIARIO.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(987, 695);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetAporteDiario
            // 
            this.DataSetAporteDiario.DataSetName = "DataSetAporteDiario";
            this.DataSetAporteDiario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_REPORTE_ULTIMO_APORTE_DIARIOBindingSource
            // 
            this.SP_REPORTE_ULTIMO_APORTE_DIARIOBindingSource.DataMember = "SP_REPORTE_ULTIMO_APORTE_DIARIO";
            this.SP_REPORTE_ULTIMO_APORTE_DIARIOBindingSource.DataSource = this.DataSetAporteDiario;
            // 
            // SP_REPORTE_ULTIMO_APORTE_DIARIOTableAdapter
            // 
            this.SP_REPORTE_ULTIMO_APORTE_DIARIOTableAdapter.ClearBeforeFill = true;
            // 
            // frmComprobanteDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 695);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmComprobanteDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComprobanteDiario";
            this.Load += new System.EventHandler(this.frmComprobanteDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAporteDiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_ULTIMO_APORTE_DIARIOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_REPORTE_ULTIMO_APORTE_DIARIOBindingSource;
        private DataSetAporteDiario DataSetAporteDiario;
        private DataSetAporteDiarioTableAdapters.SP_REPORTE_ULTIMO_APORTE_DIARIOTableAdapter SP_REPORTE_ULTIMO_APORTE_DIARIOTableAdapter;

    }
}