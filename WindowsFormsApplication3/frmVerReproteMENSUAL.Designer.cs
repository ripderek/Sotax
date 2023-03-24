namespace WindowsFormsApplication3
{
    partial class frmVerReproteMENSUAL
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
            this.DataSetReportePorMes = new WindowsFormsApplication3.DataSetReportePorMes();
            this.SP_REGISTROS_AP_POR_MESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_REGISTROS_AP_POR_MESTableAdapter = new WindowsFormsApplication3.DataSetReportePorMesTableAdapters.SP_REGISTROS_AP_POR_MESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportePorMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REGISTROS_AP_POR_MESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_REGISTROS_AP_POR_MESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.ReporteVistaXmes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(763, 480);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetReportePorMes
            // 
            this.DataSetReportePorMes.DataSetName = "DataSetReportePorMes";
            this.DataSetReportePorMes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_REGISTROS_AP_POR_MESBindingSource
            // 
            this.SP_REGISTROS_AP_POR_MESBindingSource.DataMember = "SP_REGISTROS_AP_POR_MES";
            this.SP_REGISTROS_AP_POR_MESBindingSource.DataSource = this.DataSetReportePorMes;
            // 
            // SP_REGISTROS_AP_POR_MESTableAdapter
            // 
            this.SP_REGISTROS_AP_POR_MESTableAdapter.ClearBeforeFill = true;
            // 
            // frmVerReproteMENSUAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 480);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVerReproteMENSUAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerReproteMENSUAL";
            this.Load += new System.EventHandler(this.frmVerReproteMENSUAL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReportePorMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REGISTROS_AP_POR_MESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_REGISTROS_AP_POR_MESBindingSource;
        private DataSetReportePorMes DataSetReportePorMes;
        private DataSetReportePorMesTableAdapters.SP_REGISTROS_AP_POR_MESTableAdapter SP_REGISTROS_AP_POR_MESTableAdapter;
    }
}