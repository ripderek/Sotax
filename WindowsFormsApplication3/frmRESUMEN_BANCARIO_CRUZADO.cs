using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication3
{
    public partial class frmRESUMEN_BANCARIO_CRUZADO : Form
    {
        public frmRESUMEN_BANCARIO_CRUZADO()
        {
            InitializeComponent();
        }

        private void frmRESUMEN_BANCARIO_CRUZADO_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.UtcNow.Date;
            // TODO: esta línea de código carga datos en la tabla 'DataSetRESUEMEN_BANCARIO_CRUZADO.SP_RESUMEN_BANCARIO_CRUZADO_CREDITO' Puede moverla o quitarla según sea necesario.
            this.SP_RESUMEN_BANCARIO_CRUZADO_CREDITOTableAdapter.Fill(this.DataSetRESUEMEN_BANCARIO_CRUZADO.SP_RESUMEN_BANCARIO_CRUZADO_CREDITO, fecha);
            // TODO: esta línea de código carga datos en la tabla 'DataSetRESUEMEN_BANCARIO_CRUZADO.SP_RESUMEN_BANCARIO_CRUZADO_DEBITO' Puede moverla o quitarla según sea necesario.
            this.SP_RESUMEN_BANCARIO_CRUZADO_DEBITOTableAdapter.Fill(this.DataSetRESUEMEN_BANCARIO_CRUZADO.SP_RESUMEN_BANCARIO_CRUZADO_DEBITO, fecha);
            // TODO: esta línea de código carga datos en la tabla 'DataSetRESUEMEN_BANCARIO_CRUZADO.SP_RESUMEN_BANCARIO_CRUZADO_SALDO' Puede moverla o quitarla según sea necesario.
            this.SP_RESUMEN_BANCARIO_CRUZADO_SALDOTableAdapter.Fill(this.DataSetRESUEMEN_BANCARIO_CRUZADO.SP_RESUMEN_BANCARIO_CRUZADO_SALDO, fecha);


        

            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
    }
}
