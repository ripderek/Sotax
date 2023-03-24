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
    public partial class frmIMPRIMIR_COMPROBANTE_TRANSACCION : Form
    {
        public frmIMPRIMIR_COMPROBANTE_TRANSACCION()
        {
            InitializeComponent();
        }

        private void frmIMPRIMIR_COMPROBANTE_TRANSACCION_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetULTIMA_TRANSACCION.SP_ULTIMA_TRANSACCION' Puede moverla o quitarla según sea necesario.
            this.SP_ULTIMA_TRANSACCIONTableAdapter.Fill(this.DataSetULTIMA_TRANSACCION.SP_ULTIMA_TRANSACCION);
            // TODO: esta línea de código carga datos en la tabla 'DataSetULTIMA_TRANSACCION.SP_VER_DATOS_EMPRESA' Puede moverla o quitarla según sea necesario.
            this.SP_VER_DATOS_EMPRESATableAdapter.Fill(this.DataSetULTIMA_TRANSACCION.SP_VER_DATOS_EMPRESA);

            this.reportViewer1.RefreshReport();
        }
    }
}
