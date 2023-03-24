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
    public partial class frmResumenTotalVoucherEmpresa : Form
    {
        public frmResumenTotalVoucherEmpresa()
        {
            InitializeComponent();
        }

        private void frmResumenTotalVoucherEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetResumenTotalVoucherEmpresa.SP_ANALYTICS_4' Puede moverla o quitarla según sea necesario.
            this.SP_ANALYTICS_4TableAdapter.Fill(this.DataSetResumenTotalVoucherEmpresa.SP_ANALYTICS_4, DateTime.Parse("01/01/2000"), DateTime.Parse("01/01/2100"));
            this.reportViewer1.RefreshReport();  
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.SP_ANALYTICS_4TableAdapter.Fill(this.DataSetResumenTotalVoucherEmpresa.SP_ANALYTICS_4,dateTimePicker1.Value,dateTimePicker2.Value);
            this.reportViewer1.RefreshReport();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
