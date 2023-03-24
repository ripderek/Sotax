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
    public partial class frmFacturarMes : Form
    {
        decimal mensualxd;
        csConexion fc = new csConexion();
        int pas = 0;
        public frmFacturarMes()
        {
            InitializeComponent();
            fc.LeerFC();
            pas = fc.bloque0;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTAportes_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
         
                if (double.Parse(lblM.Text) == 0)
                {
                    MessageBox.Show("Estimado cliente no se puede facturar valores nulos");
                    btnGuardar.Enabled = false;
                }
                else if (pas==1)
                {
                    MessageBox.Show("EL MES YA HA SIDO CERRADO NO PUEDE VOLVER A CERRARLO");
                }
                else
                {
                    btnGuardar.Enabled = true;
                    DialogResult OpcionImprimir = new DialogResult();
                    MessageImprimir messageImprimir = new MessageImprimir();
                    OpcionImprimir = messageImprimir.ShowDialog();                
                    fc.EscribirFC(1);
                    btnGuardar.Enabled=false;
                    if (OpcionImprimir == DialogResult.OK)
                    {
                        frmMensual2 mensual = new frmMensual2();
                        csCaja facturar = new csCaja();
                        MessageBox.Show(facturar.nuevo.ToString());
                        DateTime fecha = DateTime.UtcNow.Date;
                        mensual.fecha = fecha;
                        mensual.ShowDialog();
                        csVoucher voucher = new csVoucher();                 //
                        voucher.Banco(Convert.ToDecimal(lblTBauches.Text));  //
                        //facturar.ELIMINAR();
                        lblTAportes.Text = "00.00";
                        lblTBauches.Text = "00.00";
                        lblM.Text = "00.00";
                    }
                    else if (OpcionImprimir == DialogResult.Cancel)
                    { }
                    else
                    { }
                }
            }
              

        private void frmFacturarMes_Load(object sender, EventArgs e)
        {
            try
            {
                csAPORTESDIARIOS aporte = new csAPORTESDIARIOS();
                aporte.CALCULAR_TOTAL_AP();
                string DiarioTemporal = aporte.TOTAL_AP;
                if (DiarioTemporal == null)
                {
                    DiarioTemporal = "00.00";
                }
                lblTAportes.Text = DiarioTemporal;
                csBAUCHES tbauches = new csBAUCHES();
                tbauches.CALCULAR_TOTAL_B();
                string BaucheTemporal = tbauches.TOTAL_B;
                if (BaucheTemporal == null)
	            {
                    BaucheTemporal = "00.00";
	            }
                lblTBauches.Text = BaucheTemporal;
                lblM.Text = (((Convert.ToDecimal(lblTAportes.Text)))).ToString();
                csCaja caja = new csCaja();
                caja.ConsultarCaja();
                lblTCaja.Text = caja.V_CAJA_A;
                mensualxd = Convert.ToDecimal(lblM.Text);
                csConexion mes = new csConexion();
                mes.CERRAR_MES();
                int cerrar = mes.a;
                if (cerrar == 1)
                {
                    btnGuardar.Enabled = true;
                }
                else
                { btnGuardar.Enabled = false; }
            }
            catch (Exception)
            {
                MessageBox.Show("No existen valores para facturar","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
