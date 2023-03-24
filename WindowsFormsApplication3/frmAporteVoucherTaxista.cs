using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class frmAporteVoucherTaxista : Form
    {
        public frmAporteVoucherTaxista()
        {
            InitializeComponent();
        }

        private void frmAporteVoucherTaxista_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetAporteVoucherTaxista.SP_ANALYTICS_5' Puede moverla o quitarla según sea necesario.
            this.SP_ANALYTICS_5TableAdapter.Fill(this.DataSetAporteVoucherTaxista.SP_ANALYTICS_5,DateTime.Parse("01/01/2000"),DateTime.Parse("31/12/2100"));
            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.SP_ANALYTICS_5TableAdapter.Fill(this.DataSetAporteVoucherTaxista.SP_ANALYTICS_5, dateTimePicker1.Value,dateTimePicker2.Value);
            this.reportViewer1.RefreshReport();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
