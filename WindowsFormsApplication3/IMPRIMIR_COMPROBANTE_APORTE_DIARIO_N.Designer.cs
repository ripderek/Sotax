namespace WindowsFormsApplication3
{
    partial class IMPRIMIR_COMPROBANTE_APORTE_DIARIO_N
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
            this.DataSet_COMPROBANTE_APORTE_DIARIO_N = new WindowsFormsApplication3.DataSet_COMPROBANTE_APORTE_DIARIO_N();
            this.SP_IMPRIMIR_COMPROBANTE_APORTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_IMPRIMIR_COMPROBANTE_APORTETableAdapter = new WindowsFormsApplication3.DataSet_COMPROBANTE_APORTE_DIARIO_NTableAdapters.SP_IMPRIMIR_COMPROBANTE_APORTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_COMPROBANTE_APORTE_DIARIO_N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_IMPRIMIR_COMPROBANTE_APORTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_IMPRIMIR_COMPROBANTE_APORTEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.reporteCOMPROBANTE_APORTE_DIARIO_N.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(475, 363);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_COMPROBANTE_APORTE_DIARIO_N
            // 
            this.DataSet_COMPROBANTE_APORTE_DIARIO_N.DataSetName = "DataSet_COMPROBANTE_APORTE_DIARIO_N";
            this.DataSet_COMPROBANTE_APORTE_DIARIO_N.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_IMPRIMIR_COMPROBANTE_APORTEBindingSource
            // 
            this.SP_IMPRIMIR_COMPROBANTE_APORTEBindingSource.DataMember = "SP_IMPRIMIR_COMPROBANTE_APORTE";
            this.SP_IMPRIMIR_COMPROBANTE_APORTEBindingSource.DataSource = this.DataSet_COMPROBANTE_APORTE_DIARIO_N;
            // 
            // SP_IMPRIMIR_COMPROBANTE_APORTETableAdapter
            // 
            this.SP_IMPRIMIR_COMPROBANTE_APORTETableAdapter.ClearBeforeFill = true;
            // 
            // IMPRIMIR_COMPROBANTE_APORTE_DIARIO_N
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 363);
            this.Controls.Add(this.reportViewer1);
            this.Name = "IMPRIMIR_COMPROBANTE_APORTE_DIARIO_N";
            this.Text = "IMPRIMIR_COMPROBANTE_APORTE_DIARIO_N";
            this.Load += new System.EventHandler(this.IMPRIMIR_COMPROBANTE_APORTE_DIARIO_N_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_COMPROBANTE_APORTE_DIARIO_N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_IMPRIMIR_COMPROBANTE_APORTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_IMPRIMIR_COMPROBANTE_APORTEBindingSource;
        private DataSet_COMPROBANTE_APORTE_DIARIO_N DataSet_COMPROBANTE_APORTE_DIARIO_N;
        private DataSet_COMPROBANTE_APORTE_DIARIO_NTableAdapters.SP_IMPRIMIR_COMPROBANTE_APORTETableAdapter SP_IMPRIMIR_COMPROBANTE_APORTETableAdapter;
    }
}