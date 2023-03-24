namespace WindowsFormsApplication3
{
    partial class frmRESUMEN_BANCARIO_CRUZADO
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
            this.DataSetRESUEMEN_BANCARIO_CRUZADO = new WindowsFormsApplication3.DataSetRESUEMEN_BANCARIO_CRUZADO();
            this.SP_RESUMEN_BANCARIO_CRUZADO_CREDITOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_RESUMEN_BANCARIO_CRUZADO_CREDITOTableAdapter = new WindowsFormsApplication3.DataSetRESUEMEN_BANCARIO_CRUZADOTableAdapters.SP_RESUMEN_BANCARIO_CRUZADO_CREDITOTableAdapter();
            this.SP_RESUMEN_BANCARIO_CRUZADO_DEBITOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_RESUMEN_BANCARIO_CRUZADO_DEBITOTableAdapter = new WindowsFormsApplication3.DataSetRESUEMEN_BANCARIO_CRUZADOTableAdapters.SP_RESUMEN_BANCARIO_CRUZADO_DEBITOTableAdapter();
            this.SP_RESUMEN_BANCARIO_CRUZADO_SALDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_RESUMEN_BANCARIO_CRUZADO_SALDOTableAdapter = new WindowsFormsApplication3.DataSetRESUEMEN_BANCARIO_CRUZADOTableAdapters.SP_RESUMEN_BANCARIO_CRUZADO_SALDOTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRESUEMEN_BANCARIO_CRUZADO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_RESUMEN_BANCARIO_CRUZADO_CREDITOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_RESUMEN_BANCARIO_CRUZADO_DEBITOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_RESUMEN_BANCARIO_CRUZADO_SALDOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSetRESUEMEN_BANCARIO_CRUZADO
            // 
            this.DataSetRESUEMEN_BANCARIO_CRUZADO.DataSetName = "DataSetRESUEMEN_BANCARIO_CRUZADO";
            this.DataSetRESUEMEN_BANCARIO_CRUZADO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_RESUMEN_BANCARIO_CRUZADO_CREDITOBindingSource
            // 
            this.SP_RESUMEN_BANCARIO_CRUZADO_CREDITOBindingSource.DataMember = "SP_RESUMEN_BANCARIO_CRUZADO_CREDITO";
            this.SP_RESUMEN_BANCARIO_CRUZADO_CREDITOBindingSource.DataSource = this.DataSetRESUEMEN_BANCARIO_CRUZADO;
            // 
            // SP_RESUMEN_BANCARIO_CRUZADO_CREDITOTableAdapter
            // 
            this.SP_RESUMEN_BANCARIO_CRUZADO_CREDITOTableAdapter.ClearBeforeFill = true;
            // 
            // SP_RESUMEN_BANCARIO_CRUZADO_DEBITOBindingSource
            // 
            this.SP_RESUMEN_BANCARIO_CRUZADO_DEBITOBindingSource.DataMember = "SP_RESUMEN_BANCARIO_CRUZADO_DEBITO";
            this.SP_RESUMEN_BANCARIO_CRUZADO_DEBITOBindingSource.DataSource = this.DataSetRESUEMEN_BANCARIO_CRUZADO;
            // 
            // SP_RESUMEN_BANCARIO_CRUZADO_DEBITOTableAdapter
            // 
            this.SP_RESUMEN_BANCARIO_CRUZADO_DEBITOTableAdapter.ClearBeforeFill = true;
            // 
            // SP_RESUMEN_BANCARIO_CRUZADO_SALDOBindingSource
            // 
            this.SP_RESUMEN_BANCARIO_CRUZADO_SALDOBindingSource.DataMember = "SP_RESUMEN_BANCARIO_CRUZADO_SALDO";
            this.SP_RESUMEN_BANCARIO_CRUZADO_SALDOBindingSource.DataSource = this.DataSetRESUEMEN_BANCARIO_CRUZADO;
            // 
            // SP_RESUMEN_BANCARIO_CRUZADO_SALDOTableAdapter
            // 
            this.SP_RESUMEN_BANCARIO_CRUZADO_SALDOTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_RESUMEN_BANCARIO_CRUZADO_CREDITOBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.SP_RESUMEN_BANCARIO_CRUZADO_DEBITOBindingSource;
            reportDataSource3.Name = "SALDO";
            reportDataSource3.Value = this.SP_RESUMEN_BANCARIO_CRUZADO_SALDOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.reportRESUMEN_BANCARIO_CRUZADO.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 55);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(988, 643);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmRESUMEN_BANCARIO_CRUZADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 695);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRESUMEN_BANCARIO_CRUZADO";
            this.Text = "frmRESUMEN_BANCARIO_CRUZADO";
            this.Load += new System.EventHandler(this.frmRESUMEN_BANCARIO_CRUZADO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRESUEMEN_BANCARIO_CRUZADO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_RESUMEN_BANCARIO_CRUZADO_CREDITOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_RESUMEN_BANCARIO_CRUZADO_DEBITOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_RESUMEN_BANCARIO_CRUZADO_SALDOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource SP_RESUMEN_BANCARIO_CRUZADO_CREDITOBindingSource;
        private DataSetRESUEMEN_BANCARIO_CRUZADO DataSetRESUEMEN_BANCARIO_CRUZADO;
        private System.Windows.Forms.BindingSource SP_RESUMEN_BANCARIO_CRUZADO_DEBITOBindingSource;
        private System.Windows.Forms.BindingSource SP_RESUMEN_BANCARIO_CRUZADO_SALDOBindingSource;
        private DataSetRESUEMEN_BANCARIO_CRUZADOTableAdapters.SP_RESUMEN_BANCARIO_CRUZADO_CREDITOTableAdapter SP_RESUMEN_BANCARIO_CRUZADO_CREDITOTableAdapter;
        private DataSetRESUEMEN_BANCARIO_CRUZADOTableAdapters.SP_RESUMEN_BANCARIO_CRUZADO_DEBITOTableAdapter SP_RESUMEN_BANCARIO_CRUZADO_DEBITOTableAdapter;
        private DataSetRESUEMEN_BANCARIO_CRUZADOTableAdapters.SP_RESUMEN_BANCARIO_CRUZADO_SALDOTableAdapter SP_RESUMEN_BANCARIO_CRUZADO_SALDOTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}