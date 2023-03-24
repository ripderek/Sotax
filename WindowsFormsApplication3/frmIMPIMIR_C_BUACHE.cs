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
    public partial class frmIMPIMIR_C_BUACHE : Form
    {
        public frmIMPIMIR_C_BUACHE()
        {
            InitializeComponent();
        }

        private void frmIMPIMIR_C_BUACHE_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetIMPRIMIR_COMPROBANTE_N.SP_IMPRIMIR_COMPROBANTE_BAUCHE' Puede moverla o quitarla según sea necesario.
            this.SP_IMPRIMIR_COMPROBANTE_BAUCHETableAdapter.Fill(this.DataSetIMPRIMIR_COMPROBANTE_N.SP_IMPRIMIR_COMPROBANTE_BAUCHE,Numero_de_comprobante);

            this.reportViewer1.RefreshReport();
        }

        public string Numero_de_comprobante
        {
            get;
            set;
        }
    }
}
