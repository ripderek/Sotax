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
    public partial class frmComprobanteBauche : Form
    {
        public frmComprobanteBauche()
        {
            InitializeComponent();
        }

        private void frmComprobanteBauche_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetBAUCHE.SP_REPORTE_ULTIMO_APORTE_BAUCHE' Puede moverla o quitarla según sea necesario.
            this.SP_REPORTE_ULTIMO_APORTE_BAUCHETableAdapter.Fill(this.DataSetBAUCHE.SP_REPORTE_ULTIMO_APORTE_BAUCHE);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
