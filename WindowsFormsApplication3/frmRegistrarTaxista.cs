using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class frmRegistrarTaxista : Form
    {
        public frmRegistrarTaxista()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            csTaxista objTaxista = new csTaxista();

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            picFoto.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);

            csValidarCampos validar = new csValidarCampos();
            validar.TextBoxVacios(txtApellidos,"APELLIDOS");
            int comprobar = validar.comprobar;

            csValidarCampos validar2 = new csValidarCampos();
            validar2.TextBoxVacios(txtNombres, "NOMBRES");
            int comprobar2 = validar2.comprobar;

            csValidarCampos validar3 = new csValidarCampos();
            validar3.TextBoxPrecio(txtCelular, "CELULAR");
            ulong comprobar3 = validar3.comprobarprecio;

            csValidarCampos validar4 = new csValidarCampos();
            validar4.TextBoxPrecio(txtCedula, "CEDULA");
            ulong comprobar4 = validar4.comprobarprecio;

            csValidarCampos validar5 = new csValidarCampos();
            validar5.TextBoxVacios(txtDireccion, "DIRECCION");
            int comprobar5 = validar5.comprobar;
      
            if (cmbSexo.SelectedItem == null    )
            {
                MessageBox.Show("SELECCIONE");
            }
            else if (cmbLicencia.SelectedItem == null) 
            {
                MessageBox.Show("SELECCIONE");
            }
            else if (cmbEstudios.SelectedItem == null)
            {
                MessageBox.Show("SELECCIONE");
            }
            else
            {
                if (comprobar == 1 && comprobar2 == 1 && comprobar3 == 1 && comprobar4 == 1 && comprobar5 == 1)
                {
                    objTaxista.N_Cedula = txtCedula.Text;
                    objTaxista.VerificarExistencia();
                    int verficar = objTaxista.verificar;
                    if (verficar==1)
                    {
                        objTaxista.Apellidos = txtApellidos.Text;
                        objTaxista.Nombres = txtNombres.Text;
                        objTaxista.Celular = txtCelular.Text;
                        objTaxista.Direccion = txtDireccion.Text;
                        objTaxista.Sexo = cmbSexo.Text;
                        objTaxista.Estudios = cmbEstudios.Text;
                        objTaxista.Licencia = cmbLicencia.Text;
                        objTaxista.InsertarTaxista(ms.GetBuffer());
                         objTaxista.BuscarID(txtCedula.Text);
                        csAPORTESDIARIOS primeraporte = new csAPORTESDIARIOS();
                        primeraporte.ID_TAXISTA = objTaxista.ID_Taxista;
                        primeraporte.BUSCAR_COD_UNIDAD();
                        primeraporte.INGRESAR_APORTE_DIARIO();
                        Limpiar();
                    }
                   
                    
                }
            }
        }

        private void btnIngresarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fo = new OpenFileDialog();
            DialogResult Rs = Fo.ShowDialog();
            if (Rs == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(Fo.FileName);

            }

        }
        public void Limpiar()
        {
            txtApellidos.Text = null;
            txtNombres.Text = null;
            txtCedula.Text = null;
            txtCelular.Text = null;
            txtDireccion.Text = null;
            cmbSexo.Text = null;
            cmbEstudios.Text = null;
            cmbLicencia.Text = null;

        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
