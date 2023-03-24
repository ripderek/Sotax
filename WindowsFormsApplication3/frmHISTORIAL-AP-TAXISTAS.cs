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
    public partial class frmHISTORIAL_AP_TAXISTAS : Form
    {
        public frmHISTORIAL_AP_TAXISTAS()
        {
            InitializeComponent();
        }

        private void frmHISTORIAL_AP_TAXISTAS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_APORTES_DIARIOS_TAXISTAS.SP_ANALYTICS_2' Puede moverla o quitarla según sea necesario.
            this.SP_ANALYTICS_2TableAdapter.Fill(this.DataSet_APORTES_DIARIOS_TAXISTAS.SP_ANALYTICS_2, DateTime.Parse("01/01/2000"), DateTime.Parse("01/01/2040"));

            this.reportViewer1.RefreshReport();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.SP_ANALYTICS_2TableAdapter.Fill(this.DataSet_APORTES_DIARIOS_TAXISTAS.SP_ANALYTICS_2, dateTimePicker1.Value, dateTimePicker2.Value);

            this.reportViewer1.RefreshReport();
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
