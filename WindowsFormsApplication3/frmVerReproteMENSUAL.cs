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
    public partial class frmVerReproteMENSUAL : Form
    {
        public frmVerReproteMENSUAL()
        {
            InitializeComponent();
        }

        private void frmVerReproteMENSUAL_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReportePorMes.SP_REGISTROS_AP_POR_MES' Puede moverla o quitarla según sea necesario.
            this.SP_REGISTROS_AP_POR_MESTableAdapter.Fill(this.DataSetReportePorMes.SP_REGISTROS_AP_POR_MES);

            this.reportViewer1.RefreshReport();
        }
    }
}
