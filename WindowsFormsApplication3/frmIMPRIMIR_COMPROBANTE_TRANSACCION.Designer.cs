namespace WindowsFormsApplication3
{
    partial class frmIMPRIMIR_COMPROBANTE_TRANSACCION
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetULTIMA_TRANSACCION = new WindowsFormsApplication3.DataSetULTIMA_TRANSACCION();
            this.SP_ULTIMA_TRANSACCIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_ULTIMA_TRANSACCIONTableAdapter = new WindowsFormsApplication3.DataSetULTIMA_TRANSACCIONTableAdapters.SP_ULTIMA_TRANSACCIONTableAdapter();
            this.SP_VER_DATOS_EMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_VER_DATOS_EMPRESATableAdapter = new WindowsFormsApplication3.DataSetULTIMA_TRANSACCIONTableAdapters.SP_VER_DATOS_EMPRESATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetULTIMA_TRANSACCION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ULTIMA_TRANSACCIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_EMPRESABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_ULTIMA_TRANSACCIONBindingSource;
            reportDataSource2.Name = "Datos_Empresa";
            reportDataSource2.Value = this.SP_VER_DATOS_EMPRESABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.reporteULTIMATRANSACCION.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(561, 377);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetULTIMA_TRANSACCION
            // 
            this.DataSetULTIMA_TRANSACCION.DataSetName = "DataSetULTIMA_TRANSACCION";
            this.DataSetULTIMA_TRANSACCION.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_ULTIMA_TRANSACCIONBindingSource
            // 
            this.SP_ULTIMA_TRANSACCIONBindingSource.DataMember = "SP_ULTIMA_TRANSACCION";
            this.SP_ULTIMA_TRANSACCIONBindingSource.DataSource = this.DataSetULTIMA_TRANSACCION;
            // 
            // SP_ULTIMA_TRANSACCIONTableAdapter
            // 
            this.SP_ULTIMA_TRANSACCIONTableAdapter.ClearBeforeFill = true;
            // 
            // SP_VER_DATOS_EMPRESABindingSource
            // 
            this.SP_VER_DATOS_EMPRESABindingSource.DataMember = "SP_VER_DATOS_EMPRESA";
            this.SP_VER_DATOS_EMPRESABindingSource.DataSource = this.DataSetULTIMA_TRANSACCION;
            // 
            // SP_VER_DATOS_EMPRESATableAdapter
            // 
            this.SP_VER_DATOS_EMPRESATableAdapter.ClearBeforeFill = true;
            // 
            // frmIMPRIMIR_COMPROBANTE_TRANSACCION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 377);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmIMPRIMIR_COMPROBANTE_TRANSACCION";
            this.Text = "frmIMPRIMIR_COMPROBANTE_TRANSACCION";
            this.Load += new System.EventHandler(this.frmIMPRIMIR_COMPROBANTE_TRANSACCION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetULTIMA_TRANSACCION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ULTIMA_TRANSACCIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_EMPRESABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_ULTIMA_TRANSACCIONBindingSource;
        private DataSetULTIMA_TRANSACCION DataSetULTIMA_TRANSACCION;
        private System.Windows.Forms.BindingSource SP_VER_DATOS_EMPRESABindingSource;
        private DataSetULTIMA_TRANSACCIONTableAdapters.SP_ULTIMA_TRANSACCIONTableAdapter SP_ULTIMA_TRANSACCIONTableAdapter;
        private DataSetULTIMA_TRANSACCIONTableAdapters.SP_VER_DATOS_EMPRESATableAdapter SP_VER_DATOS_EMPRESATableAdapter;
    }
}