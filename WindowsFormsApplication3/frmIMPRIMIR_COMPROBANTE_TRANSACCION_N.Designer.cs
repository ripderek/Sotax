namespace WindowsFormsApplication3
{
    partial class frmIMPRIMIR_COMPROBANTE_TRANSACCION_N
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
            this.IMPRIMIR_COMPRBANTE_TRANSACCION = new WindowsFormsApplication3.IMPRIMIR_COMPRBANTE_TRANSACCION();
            this.SP_IMPRIMIR_TRANSACCION_NBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_IMPRIMIR_TRANSACCION_NTableAdapter = new WindowsFormsApplication3.IMPRIMIR_COMPRBANTE_TRANSACCIONTableAdapters.SP_IMPRIMIR_TRANSACCION_NTableAdapter();
            this.SP_VER_DATOS_EMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_VER_DATOS_EMPRESATableAdapter = new WindowsFormsApplication3.IMPRIMIR_COMPRBANTE_TRANSACCIONTableAdapters.SP_VER_DATOS_EMPRESATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.IMPRIMIR_COMPRBANTE_TRANSACCION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_IMPRIMIR_TRANSACCION_NBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_EMPRESABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_IMPRIMIR_TRANSACCION_NBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.SP_VER_DATOS_EMPRESABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.reporteIMPRIMIR_TRANSACCION_N.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(505, 324);
            this.reportViewer1.TabIndex = 0;
            // 
            // IMPRIMIR_COMPRBANTE_TRANSACCION
            // 
            this.IMPRIMIR_COMPRBANTE_TRANSACCION.DataSetName = "IMPRIMIR_COMPRBANTE_TRANSACCION";
            this.IMPRIMIR_COMPRBANTE_TRANSACCION.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_IMPRIMIR_TRANSACCION_NBindingSource
            // 
            this.SP_IMPRIMIR_TRANSACCION_NBindingSource.DataMember = "SP_IMPRIMIR_TRANSACCION_N";
            this.SP_IMPRIMIR_TRANSACCION_NBindingSource.DataSource = this.IMPRIMIR_COMPRBANTE_TRANSACCION;
            // 
            // SP_IMPRIMIR_TRANSACCION_NTableAdapter
            // 
            this.SP_IMPRIMIR_TRANSACCION_NTableAdapter.ClearBeforeFill = true;
            // 
            // SP_VER_DATOS_EMPRESABindingSource
            // 
            this.SP_VER_DATOS_EMPRESABindingSource.DataMember = "SP_VER_DATOS_EMPRESA";
            this.SP_VER_DATOS_EMPRESABindingSource.DataSource = this.IMPRIMIR_COMPRBANTE_TRANSACCION;
            // 
            // SP_VER_DATOS_EMPRESATableAdapter
            // 
            this.SP_VER_DATOS_EMPRESATableAdapter.ClearBeforeFill = true;
            // 
            // frmIMPRIMIR_COMPROBANTE_TRANSACCION_N
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 324);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmIMPRIMIR_COMPROBANTE_TRANSACCION_N";
            this.Text = "frmIMPRIMIR_COMPROBANTE_TRANSACCION_N";
            this.Load += new System.EventHandler(this.frmIMPRIMIR_COMPROBANTE_TRANSACCION_N_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IMPRIMIR_COMPRBANTE_TRANSACCION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_IMPRIMIR_TRANSACCION_NBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_EMPRESABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_IMPRIMIR_TRANSACCION_NBindingSource;
        private IMPRIMIR_COMPRBANTE_TRANSACCION IMPRIMIR_COMPRBANTE_TRANSACCION;
        private System.Windows.Forms.BindingSource SP_VER_DATOS_EMPRESABindingSource;
        private IMPRIMIR_COMPRBANTE_TRANSACCIONTableAdapters.SP_IMPRIMIR_TRANSACCION_NTableAdapter SP_IMPRIMIR_TRANSACCION_NTableAdapter;
        private IMPRIMIR_COMPRBANTE_TRANSACCIONTableAdapters.SP_VER_DATOS_EMPRESATableAdapter SP_VER_DATOS_EMPRESATableAdapter;
    }
}