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
    public partial class frmRegistrarTaxi : Form
    {
        public frmRegistrarTaxi()
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
            validar.TextBoxPrecio(txtUnidad,"UNIDAD");
            ulong comprobar = validar.comprobarprecio;

            csValidarCampos validar2 = new csValidarCampos();
            validar2.TextBoxVacios(txtModelo,"MODELO");
            int comprobar2 = validar2.comprobar;

            csValidarCampos validar3 = new csValidarCampos();
            validar3.TextBoxVacios(txtMarca, "Marca");
            int comprobar3 = validar3.comprobar;

            csValidarCampos validar4 = new csValidarCampos();
            validar4.TextBoxPrecio(txtCilindraje,"CILINDRAJE");
            ulong comprobar4 = validar4.comprobarprecio;

            csValidarCampos validar5 = new csValidarCampos();
            validar5.TextBoxPrecio(txtAño,"AÑO");
            ulong comprobar5 = validar5.comprobarprecio;

            csValidarCampos validar6 = new csValidarCampos();
            validar6.TextBoxVacios(txtMotor,"N motor");
            int comprobar6 = validar6.comprobar;

            csValidarCampos validar7 = new csValidarCampos();
            validar7.TextBoxVacios(txtPlaca,"N placa");
            int comprobar7 = validar7.comprobar;


            csValidarCampos validar8 = new csValidarCampos();
            validar8.TextBoxPrecio(txtPlaca2,"Numero de placa");
            ulong comprobar8 = validar8.comprobarprecio;
            csValidarCampos validar9 = new csValidarCampos();
            validar9.tamaño(txtAño,4);

            csTaxi objtaxi = new csTaxi();

            if (comprobar == 1 &&comprobar2 == 1 &&comprobar3 == 1 &&comprobar4 == 1 &&comprobar5 == 1 &&comprobar6 == 1 &&comprobar7 == 1 &&comprobar8 == 1 )
            {
                string placa = txtPlaca.Text + Convert.ToString(txtPlaca2.Text); // EL STRING PLACA TIENE QUE ENVIARSE COMO PARÁMETRO PARA QUE SE INGRESE A LA BASE DE DATOS
                objtaxi.N_Unidad = int.Parse(txtUnidad.Text);
                objtaxi.VerificarExistencia();
                int verificar = objtaxi.veridicar;
                if (verificar == 1)
                {
                    objtaxi.Modelo = txtModelo.Text;
                    objtaxi.Marca = txtMarca.Text;
                    objtaxi.N_Placa = placa;
                    objtaxi.Cilindraje = int.Parse(txtCilindraje.Text);
                    objtaxi.Año = int.Parse(txtAño.Text);
                    objtaxi.N_Motor = txtMotor.Text;
                    objtaxi.VerificarPLACA();
                    int verificarp = objtaxi.verificarp;
                    if (verificarp==1)
                    {
                        objtaxi.insertarTaxi();
                        csValidarCampos Borrar = new csValidarCampos();
                        Borrar.BorrarCampos(this);
                    }
                    Limpiar();
                  
                }
                //AQUI SE TIENE QUE REALIZAR LA CONEXCION A LA BASE DE DATOS
            }


        
        }
        public void Limpiar()
        {
            txtUnidad.Text = null;
            txtModelo.Text = null;
            txtMarca.Text = null;
            txtCilindraje.Text = null;
            txtAño.Text = null;
            txtMotor.Text = null;
            txtPlaca.Text = null;
            txtPlaca2.Text = null;

        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
