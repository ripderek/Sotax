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
    public partial class frmVerTxista : Form
    {
        csTaxista objTaxista;
        int ID; string C_Anterio;

   
        public frmVerTxista()
        {
            InitializeComponent();
            csTaxista objTaxista = new csTaxista();
            cmbCedula.DataSource = objTaxista.ListarTaxitasCedu().Tables[0];
            cmbCedula.ValueMember = "ID";
            cmbCedula.DisplayMember = "N_Cedula";
            cmbCedula.SelectedItem = null;
            BloquearTextBox();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
          
            if (MessageBox.Show("Desea Modificar Esta Unidad", "!!Advertencia!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                DesbloquearTextBox();
                btnGuardar.Enabled = true;
                btnModificar.Enabled = false;
                btnGuardar.BringToFront();
                btnEliminar.Visible = false;
                btnGuardar.BringToFront();
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                txtSexo.Visible = false;
                txtEstudios.Visible = false;
                txtLicencia.Visible = false;
                btnIngresarFoto.Visible = true;
                cmbSexo.Visible = true;
                cmbLicencia.Visible = true;
                cmbEstudios.Visible = true;
                cmbCedula.Visible = false;
                btnBuscar.Visible = false;
                cmbLicencia.Text = txtLicencia.Text;
                cmbEstudios.Text = txtEstudios.Text;
                cmbSexo.Text = txtSexo.Text;

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            csTaxista objTaxista = new csTaxista();
            string cedula = cmbCedula.Text;
            objTaxista.BuscarTaxista(cedula);
            txtApellidos.Text = objTaxista.Apellidos;
            txtCedula.Text = objTaxista.N_Cedula;
            txtCelular.Text = objTaxista.Celular;
            txtDireccion.Text = objTaxista.Direccion;
            txtNombres.Text = objTaxista.Nombres;
            txtSexo.Text = objTaxista.Sexo;
            txtEstudios.Text = objTaxista.Estudios;
            txtLicencia.Text = objTaxista.Licencia;
            objTaxista.VerImagen(cedula,picFoto);
            picFoto.Image = System.Drawing.Bitmap.FromStream(objTaxista.ms);
            ID = objTaxista.ID_Taxista; C_Anterio = txtCedula.Text;                                         
         
            
            }
            catch (Exception ed)
            {
                MessageBox.Show(ed.Message);
            }
            //hola.Image = System.Drawing.Bitmap.FromStream(ms);
            //cmbCedula.DataSource = objTaxi.ListarTaxitasCedu().Tables[0];
            //cmbCedula.DisplayMember = "N_Cedula";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            csTaxista objTaxista = new csTaxista();
            if (MessageBox.Show("Desea Eliminar Este Taxista", "!!Advertencia!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                


                objTaxista.BuscarID(txtCedula.Text);
                objTaxista.N_Cedula = txtCedula.Text;
                objTaxista.VerificarValor();
                objTaxista.EliminarTaxista(txtCedula.Text);

                cmbCedula.DataSource = objTaxista.ListarTaxitasCedu().Tables[0];
                cmbCedula.DisplayMember = "N_Cedula";

                txtCedula.Text = "";
                txtApellidos.Text = "";
                txtNombres.Text = "";
                txtCelular.Text = "";
                txtDireccion.Text = "";
                txtEstudios.Text = "";
                txtLicencia.Text = "";
                txtSexo.Text = "";
                picFoto.Image = null;
                cmbCedula.SelectedItem = null;
                cmbEstudios.SelectedItem = null;
                cmbLicencia.SelectedItem = null;
               
                csTaxista objTaxista1 = new csTaxista();
                cmbCedula.DataSource = objTaxista1.ListarTaxitasCedu().Tables[0];
                cmbCedula.ValueMember = "ID";
                cmbCedula.DisplayMember = "N_Cedula";
                cmbCedula.SelectedItem = null;
                btnEliminar.Enabled = false;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
         
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            picFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            csValidarCampos validar = new csValidarCampos();
            validar.TextBoxVacios(txtApellidos, "APELLIDOS");
            int comprobar = validar.comprobar;

            csValidarCampos validar2 = new csValidarCampos();
            validar2.TextBoxVacios(txtNombres, "NOMBRES");
            int comprobar2 = validar2.comprobar;

            csValidarCampos validar3 = new csValidarCampos();
            validar3.TextBoxPrecio(txtCelular, "CELULAR");
            validar3.tamaño(txtCelular, 10);
            ulong comprobar3 = validar3.comprobarprecio;
            int comprobrar31 = validar3.comprobartamaño;

            csValidarCampos validar4 = new csValidarCampos();
            validar4.TextBoxPrecio(txtCedula, "CEDULA");
            ulong comprobar4 = validar4.comprobarprecio;
            validar4.tamaño(txtCedula, 10);
            int comprobar41 = validar4.comprobartamaño;

            csValidarCampos validar5 = new csValidarCampos();
            validar5.TextBoxVacios(txtDireccion, "DIRECCION");
            int comprobar5 = validar5.comprobar;

            if (cmbSexo.SelectedItem == null)
            {
                MessageBox.Show("SELECCIONE SEXO");
            }
            else if (cmbLicencia.SelectedItem == null)
            {
                MessageBox.Show("SELECCIONE LICENCIA");
            }
            else if (cmbEstudios.SelectedItem == null)
            {
                MessageBox.Show("SELECCIONE ESTUDIOS");
            }
            else
            {
                if (comprobar == 1 && comprobar2 == 1 && comprobar3 == 1 && comprobar4 == 1 && comprobar5 == 1 && comprobrar31 == 1 && comprobar41 == 1)
                {

                    objTaxista = new csTaxista();

                    if (C_Anterio != txtCedula.Text)
                    {
                        objTaxista.N_Cedula = txtCedula.Text;
                        objTaxista.VerificarExistencia();
                        int verificacion = objTaxista.verificar;
                        if (verificacion == 1)
                        {
                            objTaxista.Apellidos = txtApellidos.Text;
                            objTaxista.Nombres = txtNombres.Text;
                            objTaxista.Celular = txtCelular.Text;
                            objTaxista.Direccion = txtDireccion.Text;
                            objTaxista.Sexo = cmbSexo.SelectedItem.ToString();
                            objTaxista.Estudios = cmbEstudios.SelectedItem.ToString();
                            objTaxista.Licencia = cmbLicencia.SelectedItem.ToString();
                            objTaxista.ID_Taxista = ID;
                            objTaxista.ModificarTaxista(ms.GetBuffer());
                            btnEliminar.Visible = true;
                            btnGuardar.Visible = false;
                            pictureBox6.Visible = true;
                            pictureBox7.Visible = true;
                            pictureBox7.Visible = true;
                            txtSexo.Visible = true;
                            txtEstudios.Visible = true;
                            txtLicencia.Visible = true;
                            btnIngresarFoto.Visible = false;
                            cmbSexo.Visible = false;
                            cmbLicencia.Visible = false;
                            cmbEstudios.Visible = false;
                            cmbCedula.Visible = true;
                            btnBuscar.Visible = true;
                            txtCedula.Text = "";
                            txtApellidos.Text = "";
                            txtNombres.Text = "";
                            txtCelular.Text = "";
                            txtDireccion.Text = "";
                            txtEstudios.Text = "";
                            txtLicencia.Text = "";
                            txtSexo.Text = "";
                            picFoto.Image = null;
                            csTaxista objTaxista1 = new csTaxista();
                            cmbCedula.DataSource = objTaxista1.ListarTaxitasCedu().Tables[0];
                            cmbCedula.ValueMember = "ID";
                            cmbCedula.DisplayMember = "N_Cedula";
                            cmbCedula.SelectedItem = null;
                            btnGuardar.Enabled = false;
                            btnModificar.Enabled = true;
                            btnEliminar.Enabled = false;
                            btnModificar.BringToFront();
                            btnGuardar.Visible = true;
                            btnModificar.Enabled = false;
                        }
                    }
                    else
                    {
                        objTaxista.N_Cedula = txtCedula.Text;
                        objTaxista.Apellidos = txtApellidos.Text;
                        objTaxista.Nombres = txtNombres.Text;
                        objTaxista.Celular = txtCelular.Text;
                        objTaxista.Direccion = txtDireccion.Text;
                        objTaxista.Sexo = cmbSexo.SelectedItem.ToString();
                        objTaxista.Estudios = cmbEstudios.SelectedItem.ToString();
                        objTaxista.Licencia = cmbLicencia.SelectedItem.ToString();
                        objTaxista.ID_Taxista = ID;
                        objTaxista.ModificarTaxista(ms.GetBuffer());
                        btnEliminar.Visible = true;
                        btnGuardar.Visible = false;
                        pictureBox6.Visible = true;
                        pictureBox7.Visible = true;
                        pictureBox7.Visible = true;
                        txtSexo.Visible = true;
                        txtEstudios.Visible = true;
                        txtLicencia.Visible = true;
                        btnIngresarFoto.Visible = false;
                        cmbSexo.Visible = false;
                        cmbLicencia.Visible = false;
                        cmbEstudios.Visible = false;
                        cmbCedula.Visible = true;
                        btnBuscar.Visible = true;
                        txtCedula.Text = "";
                        txtApellidos.Text = "";
                        txtNombres.Text = "";
                        txtCelular.Text = "";
                        txtDireccion.Text = "";
                        txtEstudios.Text = "";
                        txtLicencia.Text = "";
                        txtSexo.Text = "";
                        picFoto.Image = null;
                        csTaxista objTaxista1 = new csTaxista();
                        cmbCedula.DataSource = objTaxista1.ListarTaxitasCedu().Tables[0];
                        cmbCedula.ValueMember = "ID";
                        cmbCedula.DisplayMember = "N_Cedula";
                        cmbCedula.SelectedItem = null;
                        btnGuardar.Enabled = false;
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = false;
                        btnModificar.BringToFront();
                        btnGuardar.Visible = true;
                        btnModificar.Enabled = false;
                    }
                }
            }
            BloquearTextBox();
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

        private void frmVerTxista_Load(object sender, EventArgs e)
        {
         
        }
        private void CambiosSinGuardar(string textotxt, TextBox texto)
        {
            if (texto.Text!=textotxt)
            {
                DialogResult op = MessageBox.Show("¿EXISTEN CAMBIOS SIN GUARDAR DESEA SALIR?");
                if (op==DialogResult.OK) 
                {
                    this.Close();
                }
            }
        }
        public void BloquearTextBox()
        {
            txtApellidos.ReadOnly = true;
            txtNombres.ReadOnly = true;
            txtCedula.ReadOnly = true;
            txtCelular.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtSexo.ReadOnly = true;
            txtEstudios.ReadOnly = true;
            txtLicencia.ReadOnly = true;
        }
        public void DesbloquearTextBox()
        {
            txtApellidos.ReadOnly = false;
            txtNombres.ReadOnly = false;
            txtCedula.ReadOnly = false;
            txtCelular.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtSexo.ReadOnly = false;
            txtEstudios.ReadOnly = false;
            txtLicencia.ReadOnly = false;
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
