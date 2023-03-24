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
    public partial class frmCaja : Form
    {
        public frmCaja()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            csValidarCampos validaprecio = new csValidarCampos();
            validaprecio.TextBoxPrecio(txtPrecio1);
            ulong valida = validaprecio.comprobarprecio;
            csValidarCampos validaprecio2 = new csValidarCampos();
            validaprecio2.TextBoxPrecio(txtprecio2);
            ulong valida2 = validaprecio2.comprobarprecio;

             if (txtPrecio1.Text == "0000" && txtprecio2.Text == "00")
            {
                MessageBox.Show("EL EFECTIVO NO PUEDE SER 0", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             
             else  if (valida==1&&valida2==1) 
             {
                 csCaja caja = new csCaja();             
                 string efectivo = txtPrecio1.Text + "," + txtprecio2.Text;
                 decimal efectivo1 = decimal.Parse(efectivo);
                 caja.N_CAJA = efectivo1;
                 caja.APELLIDO = txtApellidos.Text;
                 caja.NOMBRE = txtNombres.Text;
                 caja.CEDULA = txtCedula.Text;
                 caja.RealizarTransaccion("RETIRO");
                 if (caja.verificar==1)
                 {
                 DialogResult OpcionImprimir = new DialogResult();
                 MessageImprimir messageImprimir = new MessageImprimir();
                 OpcionImprimir = messageImprimir.ShowDialog();
                 if (OpcionImprimir == DialogResult.OK)
                 { frmIMPRIMIR_COMPROBANTE_TRANSACCION imprimirc = new frmIMPRIMIR_COMPROBANTE_TRANSACCION(); imprimirc.Show(); }
                 else if (OpcionImprimir == DialogResult.Cancel)
                 { }
                 else
                 { }
                 }
             }
        }

        private void frmCaja_Load(object sender, EventArgs e)
        {
            csCaja caja = new csCaja();
            csEmpresa datos = new csEmpresa();
            datos.listarEmpresa();
            txtApellidos.Text = datos.N_Cuenta;
            txtCedula.Text = datos.Ruc;
            txtNombres.Text = datos.Nom_Propietario;
            caja.ConsultarCaja();
            lblTCaja.Text = caja.V_CAJA_A;
        }

        private void txtPrecio1_Enter(object sender, EventArgs e)
        {

            if (txtPrecio1.Text == "0000")
            {
                txtPrecio1.Text = "";
            }
        }

        private void txtPrecio1_Leave(object sender, EventArgs e)
        {
            if (txtPrecio1.Text == "")
            {
                txtPrecio1.Text = "0000";
            }
        }

        private void txtprecio2_Leave(object sender, EventArgs e)
        {
            if (txtprecio2.Text == "")
            {
                txtprecio2.Text = "00";
            }
        }

        private void txtprecio2_Enter(object sender, EventArgs e)
        {
            if (txtprecio2.Text == "00")
            {
                txtprecio2.Text = "";
            }
        }
    }
}
