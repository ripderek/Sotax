namespace WindowsFormsApplication3
{
    partial class frmExamen_XD
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetEXAMEN_XD = new WindowsFormsApplication3.DataSetEXAMEN_XD();
            this.SP_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_1TableAdapter = new WindowsFormsApplication3.DataSetEXAMEN_XDTableAdapters.SP_1TableAdapter();
            this.SP_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_2TableAdapter = new WindowsFormsApplication3.DataSetEXAMEN_XDTableAdapters.SP_2TableAdapter();
            this.SP_4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_4TableAdapter = new WindowsFormsApplication3.DataSetEXAMEN_XDTableAdapters.SP_4TableAdapter();
            this.SP_5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_5TableAdapter = new WindowsFormsApplication3.DataSetEXAMEN_XDTableAdapters.SP_5TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEXAMEN_XD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_1BindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.SP_2BindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.SP_4BindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.SP_5BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.reportEXAMEN_XD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(987, 695);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetEXAMEN_XD
            // 
            this.DataSetEXAMEN_XD.DataSetName = "DataSetEXAMEN_XD";
            this.DataSetEXAMEN_XD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_1BindingSource
            // 
            this.SP_1BindingSource.DataMember = "SP_1";
            this.SP_1BindingSource.DataSource = this.DataSetEXAMEN_XD;
            // 
            // SP_1TableAdapter
            // 
            this.SP_1TableAdapter.ClearBeforeFill = true;
            // 
            // SP_2BindingSource
            // 
            this.SP_2BindingSource.DataMember = "SP_2";
            this.SP_2BindingSource.DataSource = this.DataSetEXAMEN_XD;
            // 
            // SP_2TableAdapter
            // 
            this.SP_2TableAdapter.ClearBeforeFill = true;
            // 
            // SP_4BindingSource
            // 
            this.SP_4BindingSource.DataMember = "SP_4";
            this.SP_4BindingSource.DataSource = this.DataSetEXAMEN_XD;
            // 
            // SP_4TableAdapter
            // 
            this.SP_4TableAdapter.ClearBeforeFill = true;
            // 
            // SP_5BindingSource
            // 
            this.SP_5BindingSource.DataMember = "SP_5";
            this.SP_5BindingSource.DataSource = this.DataSetEXAMEN_XD;
            // 
            // SP_5TableAdapter
            // 
            this.SP_5TableAdapter.ClearBeforeFill = true;
            // 
            // frmExamen_XD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 695);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmExamen_XD";
            this.Text = "frmExamen_XD";
            this.Load += new System.EventHandler(this.frmExamen_XD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEXAMEN_XD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_5BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_1BindingSource;
        private DataSetEXAMEN_XD DataSetEXAMEN_XD;
        private System.Windows.Forms.BindingSource SP_2BindingSource;
        private System.Windows.Forms.BindingSource SP_4BindingSource;
        private System.Windows.Forms.BindingSource SP_5BindingSource;
        private DataSetEXAMEN_XDTableAdapters.SP_1TableAdapter SP_1TableAdapter;
        private DataSetEXAMEN_XDTableAdapters.SP_2TableAdapter SP_2TableAdapter;
        private DataSetEXAMEN_XDTableAdapters.SP_4TableAdapter SP_4TableAdapter;
        private DataSetEXAMEN_XDTableAdapters.SP_5TableAdapter SP_5TableAdapter;
    }
}