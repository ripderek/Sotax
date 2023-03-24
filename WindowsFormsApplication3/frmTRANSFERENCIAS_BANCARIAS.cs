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
    public partial class frmTRANSFERENCIAS_BANCARIAS : Form
    {
        public frmTRANSFERENCIAS_BANCARIAS()
        {
            InitializeComponent();
        }

        private void frmTRANSFERENCIAS_BANCARIAS_Load(object sender, EventArgs e)
        {
            csCaja caja = new csCaja();
            csEmpresa datos = new csEmpresa();
            datos.listarEmpresa();
            txtApellidos.Text = datos.N_Cuenta;
            txtCedula.Text = datos.Ruc;
            txtNombres.Text = datos.Nom_Propietario;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            csValidarCampos validaprecio = new csValidarCampos();
            validaprecio.TextBoxPrecio(txtPrecio1);
            ulong valida = validaprecio.comprobarprecio;
            csValidarCampos validaprecio2 = new csValidarCampos();
            validaprecio2.TextBoxPrecio(txtprecio2);
            ulong valida2 = validaprecio2.comprobarprecio;
            csValidarCampos validaprecio3 = new csValidarCampos();
            validaprecio3.TextBoxVacios(txtdetalle, "DETALLE");
                int comprobar = validaprecio3.comprobar;

             if (txtPrecio1.Text == "0000" && txtprecio2.Text == "00")
            {
                MessageBox.Show("EL EFECTIVO NO PUEDE SER 0", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             else if (DEBITO.Checked==false && CREDITO.Checked==false )
             {
                 MessageBox.Show("POR FAVOR SELECCIONE UN TIPO DE TRANSFERENCIA");
             }

             else if (valida == 1 && valida2 == 1&&comprobar==1)
             {
                 Banco banco = new Banco();
                 string efectivo = txtPrecio1.Text + "," + txtprecio2.Text;
                 decimal efectivo1 = decimal.Parse(efectivo);
                 if (CREDITO.Checked)
                 {
                     banco.B_CREDITO = efectivo1;
                     banco.B_DESCRIPCION = txtdetalle.Text;
                     banco.TRANSACCION_BANCO("CREDITO");
                 }
                 else 
                 {
                     banco.B_DEBITO= efectivo1;
                     banco.B_DESCRIPCION = txtdetalle.Text;
                     banco.TRANSACCION_BANCO("DEBITO");
                 }

             }
        }

        private void txtPrecio1_Leave(object sender, EventArgs e)
        {
            if (txtPrecio1.Text == "")
            {
                txtPrecio1.Text = "0000";
            }
        }

        private void txtPrecio1_Enter(object sender, EventArgs e)
        {
            if (txtPrecio1.Text == "0000")
            {
                txtPrecio1.Text = "";
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
