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
    public partial class IMPRIMIR_COMPROBANTE_APORTE_DIARIO_N : Form
    {
        public IMPRIMIR_COMPROBANTE_APORTE_DIARIO_N()
        {
            InitializeComponent();
        }

        private void IMPRIMIR_COMPROBANTE_APORTE_DIARIO_N_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_COMPROBANTE_APORTE_DIARIO_N.SP_IMPRIMIR_COMPROBANTE_APORTE' Puede moverla o quitarla según sea necesario.
            this.SP_IMPRIMIR_COMPROBANTE_APORTETableAdapter.Fill(this.DataSet_COMPROBANTE_APORTE_DIARIO_N.SP_IMPRIMIR_COMPROBANTE_APORTE, Numero_de_comprobante);

            this.reportViewer1.RefreshReport();
        }
        public string Numero_de_comprobante
        {
            get;
            set;
        }
    }
}
