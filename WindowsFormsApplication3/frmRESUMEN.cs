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
    public partial class frmRESUMEN : Form
    {
        public frmRESUMEN()
        {
            InitializeComponent();
        }

        private void frmRESUMEN_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetMOVIMIENTOS_BANCARIOS.SP_SALDOTOTAL' Puede moverla o quitarla según sea necesario.
            this.SP_SALDOTOTALTableAdapter.Fill(this.DataSetMOVIMIENTOS_BANCARIOS.SP_SALDOTOTAL);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMOVIMIENTOS_BANCARIOS.SP_RESUMEN_MOVIMIENTOS_BANCARIOS' Puede moverla o quitarla según sea necesario.
            this.SP_RESUMEN_MOVIMIENTOS_BANCARIOSTableAdapter.Fill(this.DataSetMOVIMIENTOS_BANCARIOS.SP_RESUMEN_MOVIMIENTOS_BANCARIOS, DateTime.Parse("01/01/2000"),DateTime.Parse("01/01/2040"));
            // TODO: esta línea de código carga datos en la tabla 'DataSetMOVIMIENTOS_BANCARIOS.SP_VER_DATOS_EMPRESA' Puede moverla o quitarla según sea necesario.
            this.SP_VER_DATOS_EMPRESATableAdapter.Fill(this.DataSetMOVIMIENTOS_BANCARIOS.SP_VER_DATOS_EMPRESA);

            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.SP_RESUMEN_MOVIMIENTOS_BANCARIOSTableAdapter.Fill(this.DataSetMOVIMIENTOS_BANCARIOS.SP_RESUMEN_MOVIMIENTOS_BANCARIOS,dateTimePicker1.Value, dateTimePicker2.Value);
            this.reportViewer1.RefreshReport();
        }

    }
}
