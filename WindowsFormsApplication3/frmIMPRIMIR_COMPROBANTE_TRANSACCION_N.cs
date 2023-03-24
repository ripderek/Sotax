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
    public partial class frmIMPRIMIR_COMPROBANTE_TRANSACCION_N : Form
    {
        public frmIMPRIMIR_COMPROBANTE_TRANSACCION_N()
        {
            InitializeComponent();
        }

        private void frmIMPRIMIR_COMPROBANTE_TRANSACCION_N_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'IMPRIMIR_COMPRBANTE_TRANSACCION.SP_IMPRIMIR_TRANSACCION_N' Puede moverla o quitarla según sea necesario.
            this.SP_IMPRIMIR_TRANSACCION_NTableAdapter.Fill(this.IMPRIMIR_COMPRBANTE_TRANSACCION.SP_IMPRIMIR_TRANSACCION_N, Numero_de_comprobante);
            // TODO: esta línea de código carga datos en la tabla 'IMPRIMIR_COMPRBANTE_TRANSACCION.SP_VER_DATOS_EMPRESA' Puede moverla o quitarla según sea necesario.
            this.SP_VER_DATOS_EMPRESATableAdapter.Fill(this.IMPRIMIR_COMPRBANTE_TRANSACCION.SP_VER_DATOS_EMPRESA);

            this.reportViewer1.RefreshReport();
        }
        public string Numero_de_comprobante
        {
            get;
            set;
        }
    }
}
