namespace WindowsFormsApplication3
{
    partial class frmReporteVoucheDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteVoucheDiario));
            this.SP_PASTEL_DIARIO_VOUCHERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReporteDiarioVoucher = new WindowsFormsApplication3.DataSetReporteDiarioVoucher();
            this.SP_PASTEL_DIARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_PASTEL_VOUCHERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_ANALYTICS_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SP_PASTEL_DIARIO_VOUCHERTableAdapter = new WindowsFormsApplication3.DataSetReporteDiarioVoucherTableAdapters.SP_PASTEL_DIARIO_VOUCHERTableAdapter();
            this.SP_PASTEL_DIARIOTableAdapter = new WindowsFormsApplication3.DataSetReporteDiarioVoucherTableAdapters.SP_PASTEL_DIARIOTableAdapter();
            this.SP_PASTEL_VOUCHERTableAdapter = new WindowsFormsApplication3.DataSetReporteDiarioVoucherTableAdapters.SP_PASTEL_VOUCHERTableAdapter();
            this.SP_TOTAL_APORTES_DIARIOS_NBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_TOTAL_APORTES_DIARIOS_NTableAdapter = new WindowsFormsApplication3.DataSetReporteDiarioVoucherTableAdapters.SP_TOTAL_APORTES_DIARIOS_NTableAdapter();
            this.SP_SUMA_TOTAL_VOUCHERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_SUMA_TOTAL_VOUCHERSTableAdapter = new WindowsFormsApplication3.DataSetReporteDiarioVoucherTableAdapters.SP_SUMA_TOTAL_VOUCHERSTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SP_ANALYTICS_1TableAdapter = new WindowsFormsApplication3.DataSetReporteDiarioVoucherTableAdapters.SP_ANALYTICS_1TableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SP_PASTEL_DIARIO_VOUCHERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteDiarioVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_PASTEL_DIARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_PASTEL_VOUCHERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ANALYTICS_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_TOTAL_APORTES_DIARIOS_NBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_SUMA_TOTAL_VOUCHERSBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_PASTEL_DIARIO_VOUCHERBindingSource
            // 
            this.SP_PASTEL_DIARIO_VOUCHERBindingSource.DataMember = "SP_PASTEL_DIARIO_VOUCHER";
            this.SP_PASTEL_DIARIO_VOUCHERBindingSource.DataSource = this.DataSetReporteDiarioVoucher;
            // 
            // DataSetReporteDiarioVoucher
            // 
            this.DataSetReporteDiarioVoucher.DataSetName = "DataSetReporteDiarioVoucher";
            this.DataSetReporteDiarioVoucher.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_PASTEL_DIARIOBindingSource
            // 
            this.SP_PASTEL_DIARIOBindingSource.DataMember = "SP_PASTEL_DIARIO";
            this.SP_PASTEL_DIARIOBindingSource.DataSource = this.DataSetReporteDiarioVoucher;
            // 
            // SP_PASTEL_VOUCHERBindingSource
            // 
            this.SP_PASTEL_VOUCHERBindingSource.DataMember = "SP_PASTEL_VOUCHER";
            this.SP_PASTEL_VOUCHERBindingSource.DataSource = this.DataSetReporteDiarioVoucher;
            // 
            // SP_ANALYTICS_1BindingSource
            // 
            this.SP_ANALYTICS_1BindingSource.DataMember = "SP_ANALYTICS_1";
            this.SP_ANALYTICS_1BindingSource.DataSource = this.DataSetReporteDiarioVoucher;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(222, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 28;
            this.label3.Text = "F. Fin";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl.Location = new System.Drawing.Point(10, 63);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(73, 22);
            this.lbl.TabIndex = 27;
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
            this.btnBuscar.Location = new System.Drawing.Point(408, 58);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 26);
            this.btnBuscar.TabIndex = 26;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(281, 62);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(110, 22);
            this.dateTimePicker2.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // SP_PASTEL_DIARIO_VOUCHERTableAdapter
            // 
            this.SP_PASTEL_DIARIO_VOUCHERTableAdapter.ClearBeforeFill = true;
            // 
            // SP_PASTEL_DIARIOTableAdapter
            // 
            this.SP_PASTEL_DIARIOTableAdapter.ClearBeforeFill = true;
            // 
            // SP_PASTEL_VOUCHERTableAdapter
            // 
            this.SP_PASTEL_VOUCHERTableAdapter.ClearBeforeFill = true;
            // 
            // SP_TOTAL_APORTES_DIARIOS_NBindingSource
            // 
            this.SP_TOTAL_APORTES_DIARIOS_NBindingSource.DataMember = "SP_TOTAL_APORTES_DIARIOS_N";
            this.SP_TOTAL_APORTES_DIARIOS_NBindingSource.DataSource = this.DataSetReporteDiarioVoucher;
            // 
            // SP_TOTAL_APORTES_DIARIOS_NTableAdapter
            // 
            this.SP_TOTAL_APORTES_DIARIOS_NTableAdapter.ClearBeforeFill = true;
            // 
            // SP_SUMA_TOTAL_VOUCHERSBindingSource
            // 
            this.SP_SUMA_TOTAL_VOUCHERSBindingSource.DataMember = "SP_SUMA_TOTAL_VOUCHERS";
            this.SP_SUMA_TOTAL_VOUCHERSBindingSource.DataSource = this.DataSetReporteDiarioVoucher;
            // 
            // SP_SUMA_TOTAL_VOUCHERSTableAdapter
            // 
            this.SP_SUMA_TOTAL_VOUCHERSTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_PASTEL_DIARIO_VOUCHERBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.SP_PASTEL_DIARIOBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.SP_PASTEL_VOUCHERBindingSource;
            reportDataSource4.Name = "sumas";
            reportDataSource4.Value = this.SP_ANALYTICS_1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication3.ReportPastelDiarioVoucher.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 106);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(987, 590);
            this.reportViewer1.TabIndex = 31;
            // 
            // SP_ANALYTICS_1TableAdapter
            // 
            this.SP_ANALYTICS_1TableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 48);
            this.panel1.TabIndex = 46;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(828, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.BackColor = System.Drawing.Color.Transparent;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(35)))));
            this.btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(35)))));
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btncerrar.Location = new System.Drawing.Point(940, 5);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(36, 42);
            this.btncerrar.TabIndex = 2;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(116, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "Resumen de aportes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 46;
            this.label1.Text = "Analytics  >";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(408, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmReporteVoucheDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(987, 695);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmReporteVoucheDiario";
            this.Text = "frmReporteVoucheDiario";
            this.Load += new System.EventHandler(this.frmReporteVoucheDiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_PASTEL_DIARIO_VOUCHERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteDiarioVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_PASTEL_DIARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_PASTEL_VOUCHERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ANALYTICS_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_TOTAL_APORTES_DIARIOS_NBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_SUMA_TOTAL_VOUCHERSBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource SP_PASTEL_DIARIO_VOUCHERBindingSource;
        private DataSetReporteDiarioVoucher DataSetReporteDiarioVoucher;
        private DataSetReporteDiarioVoucherTableAdapters.SP_PASTEL_DIARIO_VOUCHERTableAdapter SP_PASTEL_DIARIO_VOUCHERTableAdapter;
        private System.Windows.Forms.BindingSource SP_PASTEL_DIARIOBindingSource;
        private System.Windows.Forms.BindingSource SP_PASTEL_VOUCHERBindingSource;
        private DataSetReporteDiarioVoucherTableAdapters.SP_PASTEL_DIARIOTableAdapter SP_PASTEL_DIARIOTableAdapter;
        private DataSetReporteDiarioVoucherTableAdapters.SP_PASTEL_VOUCHERTableAdapter SP_PASTEL_VOUCHERTableAdapter;
        private System.Windows.Forms.BindingSource SP_TOTAL_APORTES_DIARIOS_NBindingSource;
        private System.Windows.Forms.BindingSource SP_SUMA_TOTAL_VOUCHERSBindingSource;
        private DataSetReporteDiarioVoucherTableAdapters.SP_TOTAL_APORTES_DIARIOS_NTableAdapter SP_TOTAL_APORTES_DIARIOS_NTableAdapter;
        private DataSetReporteDiarioVoucherTableAdapters.SP_SUMA_TOTAL_VOUCHERSTableAdapter SP_SUMA_TOTAL_VOUCHERSTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_ANALYTICS_1BindingSource;
        private DataSetReporteDiarioVoucherTableAdapters.SP_ANALYTICS_1TableAdapter SP_ANALYTICS_1TableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}