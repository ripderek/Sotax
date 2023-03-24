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
    public partial class frmDECLARACIONCUENTA : Form
    {
        public frmDECLARACIONCUENTA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            csValidarCampos validar = new csValidarCampos();
            validar.TextBoxVacios(txtCED,"CEDULA");
            validar.TextBoxPrecio(txtCED);
            validar.tamaño(txtCED,10);
            int comprobar = validar.comprobar;
            ulong comprobar2 = validar.comprobarprecio;
            int comprobar3 = validar.comprobartamaño;

            csValidarCampos validar2 = new csValidarCampos();
            validar2.TextBoxVacios(txtPropietario,"PROPIETAIO");
            int comprobar4 = validar2.comprobar;

            csValidarCampos validar3 = new csValidarCampos();
            validar3.TextBoxVacios(txtCUENTABANCARIA,"CUENTA BANCARIA");
            validar3.TextBoxPrecio(txtCUENTABANCARIA);
            validar3.tamaño(txtCUENTABANCARIA,10);
            int comprobar5 = validar3.comprobar;
            ulong comprobar6 = validar3.comprobarprecio;
            int comproba7 = validar3.comprobartamaño;

            if (comprobar == 1 && comprobar2 == 1 && comprobar3 == 1 && comprobar4 == 1 && comprobar5 == 1 && comprobar6 == 1 && comproba7 == 1)
            {
                csCUENTAS_BANCARIAS declaracion = new csCUENTAS_BANCARIAS();
                declaracion.N_CEDULA = txtCED.Text;
                declaracion.NOMBRES_PROPIETARIO = txtPropietario.Text;
                declaracion.N_RUC = txtCUENTABANCARIA.Text;
                declaracion.REGISTRAR_CONVENIO();
                LIMPIAR();
            }

        }
        private void LIMPIAR()
        {
            txtCUENTABANCARIA.Text = "";
            txtPropietario.Text = "";
            txtCED.Text = "";
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
