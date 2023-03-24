namespace WindowsFormsApplication3
{
    partial class frmListaMes
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
            this.SP_VISTA_MESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetVISTAMES = new WindowsFormsApplication3.DataSetVISTAMES();
            this.SP_VISTA_MESTableAdapter = new WindowsFormsApplication3.DataSetVISTAMESTableAdapters.SP_VISTA_MESTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VISTA_MESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetVISTAMES)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_VISTA_MESBindingSource
            // 
            this.SP_VISTA_MESBindingSource.DataMember = "SP_VISTA_MES";
            this.SP_VISTA_MESBindingSource.DataSource = this.DataSetVISTAMES;
            // 
            // DataSetVISTAMES
            // 
            this.DataSetVISTAMES.DataSetName = "DataSetVISTAMES";
            this.DataSetVISTAMES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_VISTA_MESTableAdapter
            // 
            this.SP_VISTA_MESTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_VISTA_MESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.ReportVISTAMES2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(666, 456);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmListaMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 456);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmListaMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaMes";
            this.Load += new System.EventHandler(this.frmListaMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_VISTA_MESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetVISTAMES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource SP_VISTA_MESBindingSource;
        private DataSetVISTAMES DataSetVISTAMES;
        private DataSetVISTAMESTableAdapters.SP_VISTA_MESTableAdapter SP_VISTA_MESTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}