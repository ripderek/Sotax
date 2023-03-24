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
    public partial class frmDIARIOREPORT : Form
    {
        public frmDIARIOREPORT()
        {
            InitializeComponent();
        }

        private void frmDIARIOREPORT_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetReporteDiario.SP_REPORTE_DIARIO' Puede moverla o quitarla según sea necesario.
            this.SP_REPORTE_DIARIOTableAdapter.Fill(this.DataSetReporteDiario.SP_REPORTE_DIARIO, FECHA_DIARIA);

            this.reportViewer1.RefreshReport();
        }
        public DateTime FECHA_DIARIA
        {
            get;
            set;
        }
    }
}
