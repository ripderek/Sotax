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
    public partial class frmTRANSFERENCIA_A_OTRA_CUENTA : Form
    {
        public frmTRANSFERENCIA_A_OTRA_CUENTA()
        {
            InitializeComponent();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            csValidarCampos validar1 = new csValidarCampos();
            validar1.TextBoxVacios(txtdetalle,"DETALLE");
            int coprobar = validar1.comprobar;

            if (txtPrecio1.Text == "0000" && txtprecio2.Text == "00")
            {
                MessageBox.Show("EL EFECTIVO NO PUEDE SER 0", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (coprobar == 1)
            {
                string efectivo = txtPrecio1.Text + "," + txtprecio2.Text;
                 decimal efectivo1 = decimal.Parse(efectivo);
                    Banco bc = new Banco();
                    bc.B_DESCRIPCION=txtdetalle.Text;
                    bc.B_DEBITO=efectivo1;
                bc.TRANSACCION_BANCO("DEBITO");
                cmbCUENTAS.SelectedItem = null;
                txtdetalle.Text = "";
                txtPrecio1.Text = "0000";
                txtprecio2.Text = "00";


            }
            else if (cmbCUENTAS.SelectedItem==null)
            {
                MessageBox.Show("POR FAVOR SELECCIONE UNA CUENTA VALIDA PARA EFECTUAR LA TRANSFERENCIA");
            }
        }

        private void frmTRANSFERENCIA_A_OTRA_CUENTA_Load(object sender, EventArgs e)
        {
            csCUENTAS_BANCARIAS bcs = new csCUENTAS_BANCARIAS();
            cmbCUENTAS.DataSource = bcs.Listar_CUENTAS().Tables[0];
            cmbCUENTAS.ValueMember = "NºCUENTA";
            cmbCUENTAS.DisplayMember = "NºCUENTA";
            cmbCUENTAS.SelectedItem = null;

        }
    }
}
