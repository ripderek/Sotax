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
    public partial class frmREGISTRAR_CONVENIO : Form
    {
        public frmREGISTRAR_CONVENIO()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            csValidarCampos validar = new csValidarCampos();
            validar.TextBoxVacios(txtEMPRESA,"EMPRESA");
            int comprobar = validar.comprobar;

            csValidarCampos validar2 = new csValidarCampos();
            validar2.TextBoxPrecio(txtCedula);
            validar2.tamaño(txtCedula,10);
            validar2.TextBoxVacios(txtCedula,"CEDULA");
            int comprobar1 = validar2.comprobar;
            ulong comprobar12 = validar2.comprobarprecio;
            int comprobar13 = validar2.comprobartamaño; ;

            csValidarCampos validar3 = new csValidarCampos();
            validar3.TextBoxVacios(txtApellidos,"NOMBRES Y APELLIDOS");
            int comprobar2 = validar3.comprobar;

            csValidarCampos validar4 = new csValidarCampos();
            validar4.TextBoxVacios(txtCelular,"CELULAR");
            validar4.TextBoxPrecio(txtCelular);
            validar4.tamaño(txtCelular,10);
            int comprobar3 = validar4.comprobar;
            ulong comprobar32 = validar4.comprobarprecio;
            int comprobar33 = validar4.comprobartamaño;

            csValidarCampos validar5 = new csValidarCampos();
            validar5.TextBoxVacios(txtRUC, "RUC");
            validar5.TextBoxPrecio(txtRUC);
            validar5.tamaño(txtRUC, 13);
            int comprobar4 = validar5.comprobar;
            ulong comprobar42 = validar5.comprobarprecio;
            int comprobar43 = validar5.comprobartamaño;

            csValidarCampos validar6 = new csValidarCampos();
            validar6.TextBoxVacios(txtCuenta, "NUMERO DE CUENTA");
            validar6.TextBoxPrecio(txtCuenta);
            validar6.tamaño(txtCuenta, 10);
            int comprobar5 = validar6.comprobar;
            ulong comprobar52 = validar6.comprobarprecio;
            int comprobar53 = validar6.comprobartamaño;

            csValidarCampos validar7 = new csValidarCampos();
            validar7.TextBoxVacios(txtCiudad,"CIUDAD");
            int comprobar6 = validar7.comprobar;

            csValidarCampos validar8 = new csValidarCampos();
            validar8.Porcentajes(txtPorcentaje);
            int comprobar9 = validar8.comprobartamaño;


            if (comprobar==1&&comprobar1==1&&comprobar12==1&&comprobar13==1&&comprobar2==1&&comprobar3==1&&comprobar32==1&&comprobar33==1&&comprobar4==1&&comprobar42==1&&comprobar43==1&&comprobar5==1&&comprobar52==1&&comprobar53==1&&comprobar6==1&&comprobar9==1)
            {
                csCONENIOS convenio = new csCONENIOS();
                convenio.NOMBRE_EMPRESA = txtEMPRESA.Text;
                convenio.N_CEDULA = txtCedula.Text;
                convenio.NOMBRES_PROPIETARIO = txtApellidos.Text;
                convenio.N_CELULAR = txtCelular.Text;
                convenio.N_RUC = txtRUC.Text;
                convenio.N_CUENTA = txtCuenta.Text;
                convenio.N_CIUDAD = txtCiudad.Text;
                convenio.N_PORCENTAJE = int.Parse(txtPorcentaje.Text);
                convenio.REGISTRAR_CONVENIO();
                if (convenio.existencia==0)
                LIMPIAR();
            }

        }
        private void LIMPIAR () 
       {
           txtApellidos.Text = "";
           txtEMPRESA.Text = "";
           txtCedula.Text = "";
           txtCelular.Text = "";
           txtRUC.Text = "";
           txtCuenta.Text = "";
           txtCiudad.Text = "";
           txtPorcentaje.Text = "";

       }
    }
}
