namespace WindowsFormsApplication3
{
    partial class frmIMPIMIR_C_BUACHE
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
            this.DataSetIMPRIMIR_COMPROBANTE_N = new WindowsFormsApplication3.DataSetIMPRIMIR_COMPROBANTE_N();
            this.SP_IMPRIMIR_COMPROBANTE_BAUCHEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_IMPRIMIR_COMPROBANTE_BAUCHETableAdapter = new WindowsFormsApplication3.DataSetIMPRIMIR_COMPROBANTE_NTableAdapters.SP_IMPRIMIR_COMPROBANTE_BAUCHETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetIMPRIMIR_COMPROBANTE_N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_IMPRIMIR_COMPROBANTE_BAUCHEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_IMPRIMIR_COMPROBANTE_BAUCHEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.IMPRIMIR_COMPOBANTE_BAUCHE_N.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(519, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetIMPRIMIR_COMPROBANTE_N
            // 
            this.DataSetIMPRIMIR_COMPROBANTE_N.DataSetName = "DataSetIMPRIMIR_COMPROBANTE_N";
            this.DataSetIMPRIMIR_COMPROBANTE_N.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_IMPRIMIR_COMPROBANTE_BAUCHEBindingSource
            // 
            this.SP_IMPRIMIR_COMPROBANTE_BAUCHEBindingSource.DataMember = "SP_IMPRIMIR_COMPROBANTE_BAUCHE";
            this.SP_IMPRIMIR_COMPROBANTE_BAUCHEBindingSource.DataSource = this.DataSetIMPRIMIR_COMPROBANTE_N;
            // 
            // SP_IMPRIMIR_COMPROBANTE_BAUCHETableAdapter
            // 
            this.SP_IMPRIMIR_COMPROBANTE_BAUCHETableAdapter.ClearBeforeFill = true;
            // 
            // frmIMPIMIR_C_BUACHE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 349);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmIMPIMIR_C_BUACHE";
            this.Text = "frmIMPIMIR_C_BUACHE";
            this.Load += new System.EventHandler(this.frmIMPIMIR_C_BUACHE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetIMPRIMIR_COMPROBANTE_N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_IMPRIMIR_COMPROBANTE_BAUCHEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_IMPRIMIR_COMPROBANTE_BAUCHEBindingSource;
        private DataSetIMPRIMIR_COMPROBANTE_N DataSetIMPRIMIR_COMPROBANTE_N;
        private DataSetIMPRIMIR_COMPROBANTE_NTableAdapters.SP_IMPRIMIR_COMPROBANTE_BAUCHETableAdapter SP_IMPRIMIR_COMPROBANTE_BAUCHETableAdapter;
    }
}