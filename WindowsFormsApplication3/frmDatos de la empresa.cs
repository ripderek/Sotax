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
    public partial class frmDatos_de_la_empresa : Form
    {
        int modificarcampos;
        public frmDatos_de_la_empresa(int modificar = 0)
        {
            InitializeComponent();
            modificarcampos = modificar;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (modificarcampos == 0)
            {
                Application.Exit();
                //ABRIR CONEXION CON LA BASE DE DATOS Y ENVIARLE LOS SIGUIENTES DATOS; NOMBRES = SIN NOMBRE  en todos los campos Unknown's y donde pida valores 00000000000 y la fecha se envia la que se abrió el programa 
            }
            else
            {
                this.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                csValidarCampos validar = new csValidarCampos();
                validar.TextBoxVacios(txtNombreCompañia,"NOMBRE COMPAÑIA");
                int comprobar = validar.comprobar;
                csValidarCampos validar2 = new csValidarCampos();
                validar2.TextBoxVacios(txtDireccion,"DIRECCION");
                int comprobar2 = validar2.comprobar;
                csValidarCampos validar3 = new csValidarCampos();
                csValidarCampos validar4 = new csValidarCampos();
                validar4.TextBoxPrecio(txtRuc,"RUC");
                ulong comprobar4 = validar4.comprobarprecio;
                csValidarCampos validar5 = new csValidarCampos();
                validar5.TextBoxVacios(txtCUENTABANCARIA,"CUENTA BANCARIA");
                validar5.TextBoxPrecio(txtCUENTABANCARIA);
                validar5.tamaño(txtCUENTABANCARIA,10);
                int comprobar5 = validar5.comprobar;
                ulong comprobar6 = validar5.comprobarprecio;
                int comprobar7 = validar5.comprobartamaño;

                if (txtPrecio1.Text == "0000" && txtprecio2.Text == "00")
                {
                    MessageBox.Show("EL EFECTIVO NO PUEDE SER 0", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            else if (comprobar==1&&comprobar2==1&&comprobar4==1&&comprobar5==1&&comprobar6==1&&comprobar7==1)
            {
                if (modificarcampos == 1)
                {
                    //REALIZAR ACTUALIZACION DE LOS DATOS

                    csEmpresa objEmpresa = new csEmpresa();
                    objEmpresa.Nom_Empresa = txtNombreCompañia.Text;
                    objEmpresa.Nom_Propietario = txtPropietario.Text;
                    objEmpresa.Direccion = txtDireccion.Text;
                    objEmpresa.Ruc = txtRuc.Text;
                    objEmpresa.N_Empresa = txtNumeroCelular.Text;
                    objEmpresa.N_Cuenta = txtCUENTABANCARIA.Text;
                    DateTime año = dateTimePicker1.Value;
                    objEmpresa.Fecha = año.ToString();
                    string efectivo_s = txtPrecio1.Text + "," + txtprecio2.Text;
                    objEmpresa.APORTES = decimal.Parse(efectivo_s); ;
                    objEmpresa.ModificarEmpresa();
                   
                }
                else
                {
                    //INGRESAR LOS DATOS OJO ESTO SOLO SE HACE CUANDO ES LA PRIMERA VEZ 
                    csEmpresa objEmpresa = new csEmpresa();
                    objEmpresa.Nom_Empresa = txtNombreCompañia.Text;
                    objEmpresa.Nom_Propietario = txtPropietario.Text;
                    objEmpresa.Direccion = txtDireccion.Text;
                    objEmpresa.Ruc = txtRuc.Text;
                    objEmpresa.N_Empresa = txtNumeroCelular.Text;
                    objEmpresa.N_Cuenta = txtCUENTABANCARIA.Text;
                    DateTime año = dateTimePicker1.Value;
                    objEmpresa.Fecha = año.ToString();
                    string efectivo_s = txtPrecio1.Text + "," + txtprecio2.Text;
                    objEmpresa.APORTES = decimal.Parse(efectivo_s); ;
                    objEmpresa.InsertarEmpresa();
                    csTaxi taxi = new csTaxi();
                    taxi.insertarTaxi();             
                    csConexion conexcion = new csConexion();
                    conexcion.EscribirConfig("11");
                    conexcion.EscribirMES();
                    this.Close();
                }
            }
            }
            catch (Exception er)
            {
                MessageBox.Show(er + "");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtPuestoTrabajos.Text))
            //{
            //    MessageBox.Show("Espacio vacio, debe ingresar un cargo","!!Advertencia!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //}
            //else
            //{
            //    csCargos objCargo = new csCargos();
            //    objCargo.Cargo = txtPuestoTrabajos.Text;
            //    objCargo.InsertarCargo();
            //    txtPuestoTrabajos.Text = null;
            //}
        }

        private void frmDatos_de_la_empresa_Load(object sender, EventArgs e)
        {
            if (modificarcampos == 1)
            {
                txtNombreCompañia.ReadOnly = true;
                txtAñorFundacion.ReadOnly = true;
                txtDireccion.ReadOnly = true;
                txtRuc.ReadOnly = true;
                txtPropietario.ReadOnly = true;
                txtNumeroCelular.ReadOnly = true;
                txtCUENTABANCARIA.ReadOnly = true;
                btnModificar.BringToFront();

                csEmpresa objEmpresa = new csEmpresa();
                objEmpresa.listarEmpresa();
                txtNombreCompañia.Text = objEmpresa.Nom_Empresa;
                txtPropietario.Text = objEmpresa.Nom_Propietario;
                txtDireccion.Text = objEmpresa.Direccion;
                txtRuc.Text = objEmpresa.Ruc;
                txtNumeroCelular.Text = objEmpresa.N_Empresa;
                txtAñorFundacion.Text = objEmpresa.Fecha;
                txtCUENTABANCARIA.Text = objEmpresa.N_Cuenta;
                aporte.Text = objEmpresa.efectivo.ToString("N2");
            }
            else
            {
                dateTimePicker1.Visible = true;
            }
           
        
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            button1.BringToFront();
            txtNombreCompañia.ReadOnly = false;
            txtAñorFundacion.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtRuc.ReadOnly = false;
            dateTimePicker1.Visible = true;
            txtAñorFundacion.Visible = false;
            txtPropietario.ReadOnly = false;
            txtNumeroCelular.ReadOnly = false;

            
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtprecio2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
