namespace WindowsFormsApplication3
{
    partial class frmDIARIOREPORT
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
            this.SP_REPORTE_DIARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReporteDiario = new WindowsFormsApplication3.DataSetReporteDiario();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_REPORTE_DIARIOTableAdapter = new WindowsFormsApplication3.DataSetReporteDiarioTableAdapters.SP_REPORTE_DIARIOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_DIARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteDiario)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_REPORTE_DIARIOBindingSource
            // 
            this.SP_REPORTE_DIARIOBindingSource.DataMember = "SP_REPORTE_DIARIO";
            this.SP_REPORTE_DIARIOBindingSource.DataSource = this.DataSetReporteDiario;
            // 
            // DataSetReporteDiario
            // 
            this.DataSetReporteDiario.DataSetName = "DataSetReporteDiario";
            this.DataSetReporteDiario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_REPORTE_DIARIOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.reportREPORTEDIARIO.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // SP_REPORTE_DIARIOTableAdapter
            // 
            this.SP_REPORTE_DIARIOTableAdapter.ClearBeforeFill = true;
            // 
            // frmDIARIOREPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmDIARIOREPORT";
            this.Text = "frmDIARIOREPORT";
            this.Load += new System.EventHandler(this.frmDIARIOREPORT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_DIARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteDiario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_REPORTE_DIARIOBindingSource;
        private DataSetReporteDiario DataSetReporteDiario;
        private DataSetReporteDiarioTableAdapters.SP_REPORTE_DIARIOTableAdapter SP_REPORTE_DIARIOTableAdapter;
    }
}