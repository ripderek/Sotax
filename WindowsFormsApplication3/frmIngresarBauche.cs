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
    public partial class frmIngresarBauche : Form
    {
        public frmIngresarBauche()
        {
            InitializeComponent();
          
          
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            csValidarCampos validar = new csValidarCampos();
            validar.TextBoxPrecio(txtBauche,"BAUCHE NO VALIDO");
            ulong comprobar = validar.comprobarprecio;

            csValidarCampos validar1 = new csValidarCampos();
            validar1.TextBoxVacios(txtEmpresa,"NOMBRE EMPRESA");
            int comprobar1 = validar1.comprobar;

            csValidarCampos validar2 = new csValidarCampos();
            validar2.TextBoxVacios(txtOrigen,"ORIGEN");
            int comprobar2 = validar2.comprobar;

            csValidarCampos validar3 = new csValidarCampos();
            validar3.TextBoxVacios(txtDestino,"DESTINO");
            int comprobar3 = validar3.comprobar;

            csValidarCampos validar4 = new csValidarCampos();
            validar4.TextBoxPrecio(txtPrecio);
            ulong comprobar4 = validar4.comprobarprecio;

            csValidarCampos validar5 = new csValidarCampos();
            validar5.TextBoxPrecio(txtPrecio2);
            ulong comprobar5 = validar5.comprobarprecio;

            if (txtPrecio.Text=="0000" && txtPrecio2.Text=="00")
            {
                MessageBox.Show("EL EFECTIVO NO PUEDE SER 0","ADVERTENCIA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

             else if (comprobar ==1 && comprobar1==1 && comprobar2==1 && comprobar3==1 &&  comprobar4==1 && comprobar5==1  )
             {
                 try
                 {
                     csBAUCHES BAUCHE = new csBAUCHES();
                     csEmpresa Empresa = new csEmpresa();
                     Empresa.BUSCAR_ID_EMPRESA();
                     int ID_EMPRESA = Empresa.ID_EMPRES;
                     BAUCHE.ID_EMPRESA = ID_EMPRESA;
                     BAUCHE.ID_TAXISTA = int.Parse(cmbCedula.SelectedValue.ToString());
                     BAUCHE.ID_UNIDAD = int.Parse(cmbUnidad.SelectedValue.ToString());
                     BAUCHE.NUMEROBAUCHE = txtBauche.Text;
                     BAUCHE.NOMBRE_EMPRESA = txtEmpresa.Text;
                     BAUCHE.ORIGEN_B = txtOrigen.Text;
                     BAUCHE.DESTINO_B = txtDestino.Text;
                     DateTime fecha = dateTimePicker1.Value;
                     BAUCHE.FECHA_B = fecha.ToString(); ;
                     string efectivo_s = txtPrecio.Text + "," + txtPrecio2.Text;
                     BAUCHE.MONTO = decimal.Parse(efectivo_s);      
                     int exite = BAUCHE.EXISTE_N;
                     if (exite==0)
                     {
                         csCaja suma = new csCaja();
                         suma.N_CAJA = decimal.Parse(efectivo_s);
                         suma.SumarCaja();
                         BAUCHE.INGRESAR_APORTE_BAUCHE();
                     DialogResult OpcionImprimir = new DialogResult();
                     MessageImprimir messageImprimir = new MessageImprimir();
                     OpcionImprimir = messageImprimir.ShowDialog();
                     if (OpcionImprimir == DialogResult.OK)
                     { frmComprobanteBauche imprimir = new frmComprobanteBauche(); imprimir.Show(); }
                     else if (OpcionImprimir == DialogResult.Cancel)
                     { }
                     else
                     { }
                         }
                 }
                 catch (Exception n)
                 {
                     MessageBox.Show("CEDULA NO REGISTRADA O UNIDAD");
                 }

             }
        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {
            if  (txtPrecio.Text=="0000") 
            {
                txtPrecio.Text = "";
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if(txtPrecio.Text=="")
            {
                txtPrecio.Text="0000";
            }
        }

        private void txtPrecio2_Enter(object sender, EventArgs e)
        {
            if (txtPrecio2.Text == "00")
            {
                txtPrecio2.Text = "";
            }
        }

        private void txtPrecio2_Leave(object sender, EventArgs e)
        {
            if (txtPrecio2.Text == "")
            {
                txtPrecio2.Text = "00";
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

        private void frmIngresarBauche_Load(object sender, EventArgs e)
        {
     
            csTaxista objTaxista = new csTaxista();
            cmbCedula.DataSource = objTaxista.ListarTaxitasCedu().Tables[0];
            cmbCedula.ValueMember = "ID";
            cmbCedula.DisplayMember = "N_Cedula";
            cmbCedula.SelectedItem = null;

    
            csTaxi objTaxi = new csTaxi();
            cmbUnidad.DataSource = objTaxi.ListarTaxisXD().Tables[0];
            cmbUnidad.ValueMember = "ID";
            cmbUnidad.DisplayMember = "N_Unidad"; cmbUnidad.SelectedItem = null;
        }
    }
}
