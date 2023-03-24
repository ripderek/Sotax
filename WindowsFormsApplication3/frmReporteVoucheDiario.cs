using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication3
{
    public partial class frmReporteVoucheDiario : Form
    {
        public frmReporteVoucheDiario()
        {
            InitializeComponent();
        }

        private void frmReporteVoucheDiario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReporteDiarioVoucher.SP_ANALYTICS_1' Puede moverla o quitarla según sea necesario.
            this.SP_ANALYTICS_1TableAdapter.Fill(this.DataSetReporteDiarioVoucher.SP_ANALYTICS_1, DateTime.Parse("01/01/2000"), DateTime.Parse("01/01/2040"));
            // TODO: esta línea de código carga datos en la tabla 'DataSetReporteDiarioVoucher.SP_TOTAL_APORTES_DIARIOS_N' Puede moverla o quitarla según sea necesario.
            this.SP_TOTAL_APORTES_DIARIOS_NTableAdapter.Fill(this.DataSetReporteDiarioVoucher.SP_TOTAL_APORTES_DIARIOS_N, DateTime.Parse("01/01/2000"));
            // TODO: esta línea de código carga datos en la tabla 'DataSetReporteDiarioVoucher.SP_SUMA_TOTAL_VOUCHERS' Puede moverla o quitarla según sea necesario.
            this.SP_SUMA_TOTAL_VOUCHERSTableAdapter.Fill(this.DataSetReporteDiarioVoucher.SP_SUMA_TOTAL_VOUCHERS, DateTime.Parse("01/01/2000"));
            // TODO: esta línea de código carga datos en la tabla 'DataSetReporteDiarioVoucher.SP_PASTEL_DIARIO' Puede moverla o quitarla según sea necesario.
            this.SP_PASTEL_DIARIOTableAdapter.Fill(this.DataSetReporteDiarioVoucher.SP_PASTEL_DIARIO,DateTime.Parse("01/01/2000"),DateTime.Parse("01/01/2040"));
            // TODO: esta línea de código carga datos en la tabla 'DataSetReporteDiarioVoucher.SP_PASTEL_VOUCHER' Puede moverla o quitarla según sea necesario.
            this.SP_PASTEL_VOUCHERTableAdapter.Fill(this.DataSetReporteDiarioVoucher.SP_PASTEL_VOUCHER,DateTime.Parse("01/01/2000"),DateTime.Parse("01/01/2040"));
            // TODO: esta línea de código carga datos en la tabla 'DataSetReporteDiarioVoucher.SP_PASTEL_DIARIO_VOUCHER' Puede moverla o quitarla según sea necesario.
            this.SP_PASTEL_DIARIO_VOUCHERTableAdapter.Fill(this.DataSetReporteDiarioVoucher.SP_PASTEL_DIARIO_VOUCHER,DateTime.Parse("01/01/2000"),DateTime.Parse("01/01/2040"));

            ReportParameter[] parametros = new ReportParameter[]
            {
                new ReportParameter("prFechaIncio","01/01/2000"),
                new ReportParameter("prFechaFin","01/01/2040"),
            };
            this.reportViewer1.LocalReport.SetParameters(parametros);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.SP_PASTEL_DIARIO_VOUCHERTableAdapter.Fill(this.DataSetReporteDiarioVoucher.SP_PASTEL_DIARIO_VOUCHER, dateTimePicker1.Value, dateTimePicker2.Value);

            this.SP_PASTEL_DIARIOTableAdapter.Fill(this.DataSetReporteDiarioVoucher.SP_PASTEL_DIARIO, dateTimePicker1.Value, dateTimePicker2.Value);
            
            this.SP_PASTEL_VOUCHERTableAdapter.Fill(this.DataSetReporteDiarioVoucher.SP_PASTEL_VOUCHER , dateTimePicker1.Value, dateTimePicker2.Value);
            this.SP_ANALYTICS_1TableAdapter.Fill(this.DataSetReporteDiarioVoucher.SP_ANALYTICS_1, dateTimePicker1.Value, dateTimePicker2.Value);

            ReportParameter[] parametros = new ReportParameter[]
          {
                new ReportParameter("prFechaIncio",dateTimePicker1.Value.ToString()),
                new ReportParameter("prFechaFin",dateTimePicker2.Value.ToString()),
          };
            this.reportViewer1.LocalReport.SetParameters(parametros);

            this.reportViewer1.RefreshReport();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
