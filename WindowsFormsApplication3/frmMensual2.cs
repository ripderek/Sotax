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
    public partial class frmMensual2 : Form
    {
        public frmMensual2()
        {
            InitializeComponent();
        }

        private void frmMensual2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetMENSUAL.SP_VOUCHER_POR_TAXISTA' Puede moverla o quitarla según sea necesario.
            this.SP_VOUCHER_POR_TAXISTATableAdapter.Fill(this.DataSetMENSUAL.SP_VOUCHER_POR_TAXISTA, fecha);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMENSUAL.SP_VOUCHER_POR_EMPRESA' Puede moverla o quitarla según sea necesario.
            this.SP_VOUCHER_POR_EMPRESATableAdapter.Fill(this.DataSetMENSUAL.SP_VOUCHER_POR_EMPRESA, fecha);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMENSUAL.SP_VOUCHER_TOTAL_POR_TAXISTA' Puede moverla o quitarla según sea necesario.
            this.SP_VOUCHER_TOTAL_POR_TAXISTATableAdapter.Fill(this.DataSetMENSUAL.SP_VOUCHER_TOTAL_POR_TAXISTA, fecha);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMENSUAL.SP_TOTAL_AP_DIARIOS' Puede moverla o quitarla según sea necesario.
            this.SP_TOTAL_AP_DIARIOSTableAdapter.Fill(this.DataSetMENSUAL.SP_TOTAL_AP_DIARIOS, fecha);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMENSUAL.SP_TOTAL_AP_BAUCHES' Puede moverla o quitarla según sea necesario.
            this.SP_TOTAL_AP_BAUCHESTableAdapter.Fill(this.DataSetMENSUAL.SP_TOTAL_AP_BAUCHES, fecha);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMENSUAL.SP_VER_DATOS_EMPRESA' Puede moverla o quitarla según sea necesario.
            this.SP_VER_DATOS_EMPRESATableAdapter.Fill(this.DataSetMENSUAL.SP_VER_DATOS_EMPRESA);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMENSUAL.SP_SUMA_T_AP_B' Puede moverla o quitarla según sea necesario.
            this.SP_SUMA_T_AP_BTableAdapter.Fill(this.DataSetMENSUAL.SP_SUMA_T_AP_B, fecha);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMENSUAL.SP_CAJA' Puede moverla o quitarla según sea necesario.
            this.SP_CAJATableAdapter.Fill(this.DataSetMENSUAL.SP_CAJA);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMENSUAL.SP_SUMA_T_AP' Puede moverla o quitarla según sea necesario.
            this.SP_SUMA_T_APTableAdapter.Fill(this.DataSetMENSUAL.SP_SUMA_T_AP, fecha);
            // TODO: esta línea de código carga datos en la tabla 'DataSetMENSUAL.SP_TRANSACCIONES_CAJA_MENSUAL' Puede moverla o quitarla según sea necesario.
            this.SP_TRANSACCIONES_CAJA_MENSUALTableAdapter.Fill(this.DataSetMENSUAL.SP_TRANSACCIONES_CAJA_MENSUAL, fecha);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
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
