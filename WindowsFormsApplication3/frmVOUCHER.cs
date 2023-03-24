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
    public partial class frmVOUCHER : Form
    {
        public frmVOUCHER()
        {
            InitializeComponent();
            csTaxista objTaxista = new csTaxista();
            cmbCedula.DataSource = objTaxista.ListarTaxitasCedu().Tables[0];
            cmbCedula.ValueMember = "ID";
            cmbCedula.DisplayMember = "N_Cedula";
            cmbCedula.SelectedItem = null;
            csCONENIOS convenios = new csCONENIOS();
            cmbConvenio.DataSource = convenios.Listar_CONVENIOS().Tables[0];
            cmbConvenio.ValueMember="ID";
            cmbConvenio.DisplayMember = "NOMBRE_EMPRESA";
            cmbConvenio.SelectedItem = null;
           
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtprecio2_Enter(object sender, EventArgs e)
        {
            if (txtprecio2.Text == "00")
            {
                txtprecio2.Text = "";
            }
        }

        private void txtprecio2_Leave(object sender, EventArgs e)
        {
            if (txtprecio2.Text == "")
            {
                txtprecio2.Text = "00";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            csValidarCampos validaprecio = new csValidarCampos();
            validaprecio.TextBoxPrecio(txtPrecio1);
            ulong valida = validaprecio.comprobarprecio;

            csValidarCampos validaprecio2 = new csValidarCampos();
            validaprecio2.TextBoxPrecio(txtprecio2);
            ulong valida2 = validaprecio2.comprobarprecio;

            csValidarCampos validar3 = new csValidarCampos();
            validar3.TextBoxPrecio(txtVoucher);
            validar3.tamaño(txtVoucher,10);
            validar3.TextBoxVacios(txtVoucher,"VOUCHER");
            int comprobar1 = validar3.comprobar;
            ulong comprobar2 = validar3.comprobarprecio;
            int comprobar3 = validar3.comprobartamaño;

            if (txtPrecio1.Text == "0000" && txtprecio2.Text == "00")
            {
                MessageBox.Show("EL EFECTIVO NO PUEDE SER 0", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbConvenio.SelectedItem==null )
            {
                MessageBox.Show("SELECCIONE EMPRESA DE CONVENIO");
            }
            else if (cmbCedula.SelectedItem == null) 
            {
                MessageBox.Show("SELECCIONE CEDULA DEL TAXISTA");
            }
            else if (valida == 1 && valida2 == 1&&comprobar1==1&&comprobar2==1&&comprobar3==1)
            {
                /*
                 *  AporteDiario.ID_UNIDAD = int.Parse(cmbUnidad.SelectedValue.ToString());
                    AporteDiario.ID_TAXISTA = int.Parse(cmbCedula.SelectedValue.ToString());
                    string efectivo_s = txtPrecio1.Text + "," + txtprecio2.Text;
                    AporteDiario.C_EFECTIVO = decimal.Parse(efectivo_s);
                    AporteDiario.INGRESAR_APORTE_DIARIO();
                 * */
                csVoucher voucher = new csVoucher();
                voucher.ID_EMPRESA = int.Parse(cmbConvenio.SelectedValue.ToString());
                voucher.ID_TAXISTA = int.Parse(cmbCedula.SelectedValue.ToString());
                voucher.N_VOCUHER=txtVoucher.Text;
                string efectivo_s = txtPrecio1.Text + "," + txtprecio2.Text;
                voucher.V_SALDO = decimal.Parse(efectivo_s);
                voucher.V_TOTAL = decimal.Parse(efectivo_s);
                //MessageBox.Show(voucher.V_SALDO.ToString());
                voucher.Registrar_Transaccion();
                Limpiar();
            } 
        }
        public void Limpiar()
        {
            cmbConvenio.Text = null;
            cmbCedula.Text = null;
            txtVoucher.Text = null;
            txtPrecio1.Text = "000";
            txtprecio2.Text = "00";
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
