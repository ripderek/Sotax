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
    public partial class frmIngresarAporteDiario : Form
    {
        public frmIngresarAporteDiario()
        {
            InitializeComponent();
            csTaxista objTaxista = new csTaxista();
            cmbCedula.DataSource = objTaxista.ListarTaxitasCedu().Tables[0];
            cmbCedula.ValueMember = "ID";
            cmbCedula.DisplayMember = "N_Cedula";
            cmbCedula.SelectedItem = null;

            csTaxi objTaxi = new csTaxi();
            cmbUnidad.DataSource= objTaxi.ListarTaxisXD().Tables[0];
            cmbUnidad.ValueMember = "ID";
            cmbUnidad.DisplayMember = "N_Unidad";
            cmbUnidad.SelectedItem = null;


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
            else if (valida == 1 && valida2 == 1)
            {
                try
                {
                    //MessageBox.Show(txtPrecio1.Text + "," + txtprecio2.Text + "UNIDAD" + cmbUnidad.SelectedValue + "CEDULA" + cmbCedula.SelectedValue);
                    csAPORTESDIARIOS AporteDiario = new csAPORTESDIARIOS();
                    AporteDiario.ID_UNIDAD = int.Parse(cmbUnidad.SelectedValue.ToString());
                    AporteDiario.ID_TAXISTA = int.Parse(cmbCedula.SelectedValue.ToString());
                    string efectivo_s = txtPrecio1.Text + "," + txtprecio2.Text;
                    AporteDiario.C_EFECTIVO = decimal.Parse(efectivo_s);
                    AporteDiario.INGRESAR_APORTE_DIARIO();
                    csCaja suma = new csCaja();
                    suma.N_CAJA = decimal.Parse(efectivo_s);
                    suma.SumarCaja();
                    LimpiarCampos();
                    DialogResult OpcionImprimir = new DialogResult();
                    MessageImprimir messageImprimir = new MessageImprimir();
                    OpcionImprimir = messageImprimir.ShowDialog();
                    if (OpcionImprimir == DialogResult.OK)
                    { frmComprobanteDiario imprimirComprobante = new frmComprobanteDiario(); imprimirComprobante.ShowDialog(); }
                    else if (OpcionImprimir == DialogResult.Cancel)
                    { }
                    else
                    { }
                }
                catch (Exception n)
                {
                    MessageBox.Show("CEDULA O UNIDAD NO REGISTRADA"+n.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmIngresarAporteDiario_Load(object sender, EventArgs e)
        {
            //PRUEBA DE COMO SE DEBE VER EL COMBOBOX XD
            
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            csTaxista objTaxista = new csTaxista();
            string cedula = cmbCedula.Text;
            objTaxista.BuscarTaxista(cedula);
            txtApellidos.Text = objTaxista.Apellidos;
            txtNombres.Text = objTaxista.Nombres;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscarUnidad_Click(object sender, EventArgs e)
        {
            //ESTE BOTÓN AUN NO HACE NADA XD 
        }

        public void LimpiarCampos()
        {
            cmbCedula.Text = null;
            txtApellidos.Text = null;
            txtNombres.Text = null;
            cmbUnidad.Text = null;
            txtPrecio1.Text = "0000";
            txtprecio2.Text = "00";
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
