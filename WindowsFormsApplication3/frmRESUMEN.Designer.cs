namespace WindowsFormsApplication3
{
    partial class frmRESUMEN
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
            this.SP_RESUMEN_MOVIMIENTOS_BANCARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetMOVIMIENTOS_BANCARIOS = new WindowsFormsApplication3.DataSetMOVIMIENTOS_BANCARIOS();
            this.SP_VER_DATOS_EMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_SALDOTOTALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_RESUMEN_MOVIMIENTOS_BANCARIOSTableAdapter = new WindowsFormsApplication3.DataSetMOVIMIENTOS_BANCARIOSTableAdapters.SP_RESUMEN_MOVIMIENTOS_BANCARIOSTableAdapter();
            this.SP_VER_DATOS_EMPRESATableAdapter = new WindowsFormsApplication3.DataSetMOVIMIENTOS_BANCARIOSTableAdapters.SP_VER_DATOS_EMPRESATableAdapter();
            this.SP_SALDOTOTALTableAdapter = new WindowsFormsApplication3.DataSetMOVIMIENTOS_BANCARIOSTableAdapters.SP_SALDOTOTALTableAdapter();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.SP_RESUMEN_MOVIMIENTOS_BANCARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMOVIMIENTOS_BANCARIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_EMPRESABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_SALDOTOTALBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_RESUMEN_MOVIMIENTOS_BANCARIOSBindingSource
            // 
            this.SP_RESUMEN_MOVIMIENTOS_BANCARIOSBindingSource.DataMember = "SP_RESUMEN_MOVIMIENTOS_BANCARIOS";
            this.SP_RESUMEN_MOVIMIENTOS_BANCARIOSBindingSource.DataSource = this.DataSetMOVIMIENTOS_BANCARIOS;
            // 
            // DataSetMOVIMIENTOS_BANCARIOS
            // 
            this.DataSetMOVIMIENTOS_BANCARIOS.DataSetName = "DataSetMOVIMIENTOS_BANCARIOS";
            this.DataSetMOVIMIENTOS_BANCARIOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_VER_DATOS_EMPRESABindingSource
            // 
            this.SP_VER_DATOS_EMPRESABindingSource.DataMember = "SP_VER_DATOS_EMPRESA";
            this.SP_VER_DATOS_EMPRESABindingSource.DataSource = this.DataSetMOVIMIENTOS_BANCARIOS;
            // 
            // SP_SALDOTOTALBindingSource
            // 
            this.SP_SALDOTOTALBindingSource.DataMember = "SP_SALDOTOTAL";
            this.SP_SALDOTOTALBindingSource.DataSource = this.DataSetMOVIMIENTOS_BANCARIOS;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "F. Fin";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(18, 14);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(107, 31);
            this.lbl.TabIndex = 22;
            this.lbl.Text = "F. Inicio";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(636, 9);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 40);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 14);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 30);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_RESUMEN_MOVIMIENTOS_BANCARIOSBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.SP_VER_DATOS_EMPRESABindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.SP_SALDOTOTALBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.ReportRESUMEN_MOVIMIENTOS_BANCARIOS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 75);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1480, 840);
            this.reportViewer1.TabIndex = 24;
            // 
            // SP_RESUMEN_MOVIMIENTOS_BANCARIOSTableAdapter
            // 
            this.SP_RESUMEN_MOVIMIENTOS_BANCARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // SP_VER_DATOS_EMPRESATableAdapter
            // 
            this.SP_VER_DATOS_EMPRESATableAdapter.ClearBeforeFill = true;
            // 
            // SP_SALDOTOTALTableAdapter
            // 
            this.SP_SALDOTOTALTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(441, 15);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(187, 30);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // frmRESUMEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 917);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRESUMEN";
            this.Text = "frmRESUMEN";
            this.Load += new System.EventHandler(this.frmRESUMEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_RESUMEN_MOVIMIENTOS_BANCARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMOVIMIENTOS_BANCARIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_VER_DATOS_EMPRESABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_SALDOTOTALBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_RESUMEN_MOVIMIENTOS_BANCARIOSBindingSource;
        private DataSetMOVIMIENTOS_BANCARIOS DataSetMOVIMIENTOS_BANCARIOS;
        private System.Windows.Forms.BindingSource SP_VER_DATOS_EMPRESABindingSource;
        private System.Windows.Forms.BindingSource SP_SALDOTOTALBindingSource;
        private DataSetMOVIMIENTOS_BANCARIOSTableAdapters.SP_RESUMEN_MOVIMIENTOS_BANCARIOSTableAdapter SP_RESUMEN_MOVIMIENTOS_BANCARIOSTableAdapter;
        private DataSetMOVIMIENTOS_BANCARIOSTableAdapters.SP_VER_DATOS_EMPRESATableAdapter SP_VER_DATOS_EMPRESATableAdapter;
        private DataSetMOVIMIENTOS_BANCARIOSTableAdapters.SP_SALDOTOTALTableAdapter SP_SALDOTOTALTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}