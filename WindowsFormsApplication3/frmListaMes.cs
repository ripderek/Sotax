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
    public partial class frmListaMes : Form
    {
        public frmListaMes()
        {
            InitializeComponent();
        }

        private void frmListaMes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetVISTAMES.SP_VISTA_MES' Puede moverla o quitarla según sea necesario.
            this.SP_VISTA_MESTableAdapter.Fill(this.DataSetVISTAMES.SP_VISTA_MES,fecha);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public DateTime fecha
        {
            get;
            set;
        }
    }
}
