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
    public partial class frmComprobanteDiario : Form
    {
        public frmComprobanteDiario()
        {
            InitializeComponent();
        }

        private void frmComprobanteDiario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetAporteDiario.SP_REPORTE_ULTIMO_APORTE_DIARIO' Puede moverla o quitarla según sea necesario.
            this.SP_REPORTE_ULTIMO_APORTE_DIARIOTableAdapter.Fill(this.DataSetAporteDiario.SP_REPORTE_ULTIMO_APORTE_DIARIO);


            this.reportViewer1.RefreshReport();
        }
    }
}
