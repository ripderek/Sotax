namespace WindowsFormsApplication3
{
    partial class frmComprobanteBauche
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
            this.DataSetBAUCHE = new WindowsFormsApplication3.DataSetBAUCHE();
            this.SP_REPORTE_ULTIMO_APORTE_BAUCHEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_REPORTE_ULTIMO_APORTE_BAUCHETableAdapter = new WindowsFormsApplication3.DataSetBAUCHETableAdapters.SP_REPORTE_ULTIMO_APORTE_BAUCHETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBAUCHE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_ULTIMO_APORTE_BAUCHEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_REPORTE_ULTIMO_APORTE_BAUCHEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.reporteBAUCHE.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(987, 695);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetBAUCHE
            // 
            this.DataSetBAUCHE.DataSetName = "DataSetBAUCHE";
            this.DataSetBAUCHE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_REPORTE_ULTIMO_APORTE_BAUCHEBindingSource
            // 
            this.SP_REPORTE_ULTIMO_APORTE_BAUCHEBindingSource.DataMember = "SP_REPORTE_ULTIMO_APORTE_BAUCHE";
            this.SP_REPORTE_ULTIMO_APORTE_BAUCHEBindingSource.DataSource = this.DataSetBAUCHE;
            // 
            // SP_REPORTE_ULTIMO_APORTE_BAUCHETableAdapter
            // 
            this.SP_REPORTE_ULTIMO_APORTE_BAUCHETableAdapter.ClearBeforeFill = true;
            // 
            // frmComprobanteBauche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 695);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmComprobanteBauche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComprobanteBauche";
            this.Load += new System.EventHandler(this.frmComprobanteBauche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetBAUCHE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_ULTIMO_APORTE_BAUCHEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_REPORTE_ULTIMO_APORTE_BAUCHEBindingSource;
        private DataSetBAUCHE DataSetBAUCHE;
        private DataSetBAUCHETableAdapters.SP_REPORTE_ULTIMO_APORTE_BAUCHETableAdapter SP_REPORTE_ULTIMO_APORTE_BAUCHETableAdapter;

    }
}