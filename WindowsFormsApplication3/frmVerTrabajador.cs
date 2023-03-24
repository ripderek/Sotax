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
    public partial class frmVerTrabajador : Form
    {
        string C_Anterior;
        int id;
        csTrabajador objTrabajador = new csTrabajador();
        public frmVerTrabajador()
        {
            InitializeComponent();
            refrescarCMBCEDULA();
            cmbCedula.SelectedItem = null;
            BloquearTextBox();
        }
        public void refrescarCMBCEDULA ()
        {
            csTrabajador objTrabajador = new csTrabajador();
            cmbCedula.DataSource = objTrabajador.ListarTrabajadorCedu().Tables[0];
            cmbCedula.DisplayMember ="N_Cedula";
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

            if (cmbCedula.Text == "")
            {
               
            }
            else
            {
                string ncedula = cmbCedula.Text;
                objTrabajador.BuscarTrabajador(ncedula);
                txtApellidos.Text = objTrabajador.Apellidos;
                txtCedula.Text = objTrabajador.N_Cedula;
                txtCelular.Text = objTrabajador.Celular;
                txtDireccion.Text = objTrabajador.Direccion;
                txtNombres.Text = objTrabajador.Nombres;
                txtSexo.Text = objTrabajador.Sexo;
                txtEstudios.Text = objTrabajador.Estudios;
                C_Anterior = txtCedula.Text;
                id = objTrabajador.ID_T;
                csCargos Cargo = new csCargos();
                Cargo.BUSCAR_CARGO_ID(objTrabajador.Cargo.ToString());
                txtCargo.Text = Cargo.Cargo;


                objTrabajador.VerImagen(ncedula);
                picFoto.Image = System.Drawing.Bitmap.FromStream(objTrabajador.ms);
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
            }
            catch (Exception) 
            { 
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea Eliminar Este Trabajador?", "!!Advertencia!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {

                objTrabajador.EliminarTrabajador(txtCedula.Text);
                refrescarCMBCEDULA();
                txtCedula.Text = "";
                txtApellidos.Text = "";
                txtNombres.Text = "";
                txtCelular.Text = "";
                txtDireccion.Text = "";
                txtEstudios.Text = "";
                txtSexo.Text = "";
                picFoto.Image = null;
                cmbSexo.SelectedItem = null;
                cmbEstudios.SelectedItem = null;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                txtCargo.Text = "";
                cmbCedula.SelectedItem = null;
                cmbCedula.Text = "";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        
            if (MessageBox.Show("¿Desea Modificar Este Trabajador?", "!!Advertencia!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                DesbloquearTextBox();
                btnEliminar.Visible = false;
                btnGuardar.BringToFront();
                btnGuardar.Enabled = true;
                btnModificar.Enabled = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                txtSexo.Visible = false;
                txtEstudios.Visible = false;
                btnIngresarFoto.Visible = true;
                cmbSexo.Visible = true;
                cmbEstudios.Visible = true;
                cmbCedula.Visible = false;
                btnBuscar.Visible = false;
                cmbEstudios.Text = txtEstudios.Text;
                cmbSexo.Text = txtSexo.Text;

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
            else if (cmbEstudios.SelectedItem == null)
            {
                MessageBox.Show("SELECCIONE ESTUDIOS");
            }
            else
            {
                if (comprobar == 1 && comprobar2 == 1 && comprobar3 == 1 && comprobar4 == 1 && comprobar5 == 1 && comprobrar31 == 1 && comprobar41 == 1)
                {
                    csTrabajador objTrabajador = new csTrabajador();
                    if (C_Anterior != txtCedula.Text)
                    {
                        Console.Write(C_Anterior);
                        objTrabajador.N_Cedula = txtCedula.Text;
                        objTrabajador.VerificarExistencia();
                        int verificacion = objTrabajador.verificar;
                        if (verificacion == 1)
                        {
                            objTrabajador.Apellidos = txtApellidos.Text;
                            objTrabajador.Nombres = txtNombres.Text;
                            objTrabajador.N_Cedula = txtCedula.Text;
                            objTrabajador.Celular = txtCelular.Text;
                            objTrabajador.Direccion = txtDireccion.Text;
                            objTrabajador.Sexo = cmbSexo.SelectedItem.ToString();
                            objTrabajador.Estudios = cmbEstudios.SelectedItem.ToString();
                            objTrabajador.ID_T = id;
                            objTrabajador.ModificarTrabajador(ms.GetBuffer());
                            btnEliminar.Visible = true;
                            btnGuardar.Visible = false;
                            pictureBox6.Visible = true;
                            pictureBox7.Visible = true;
                            pictureBox7.Visible = true;
                            txtSexo.Visible = true;
                            txtEstudios.Visible = true;
                            btnIngresarFoto.Visible = false;
                            cmbSexo.Visible = false;
                            cmbEstudios.Visible = false;
                            cmbCedula.Visible = true;
                            btnBuscar.Visible = true;
                            txtCedula.Text = "";
                            txtApellidos.Text = "";
                            txtNombres.Text = "";
                            txtCelular.Text = "";
                            txtDireccion.Text = "";
                            txtEstudios.Text = "";
                            txtSexo.Text = "";
                            picFoto.Image = null;
                            btnModificar.Enabled = false;
                            btnEliminar.Enabled = false;
                            txtCargo.Text = "";
                            cmbCedula.SelectedItem = null;
                            refrescarCMBCEDULA();
                            cmbCedula.SelectedItem = null;
                        }
                    }
                    else
                    {
                        objTrabajador.Apellidos = txtApellidos.Text;
                        objTrabajador.Nombres = txtNombres.Text;
                        objTrabajador.N_Cedula = txtCedula.Text;
                        objTrabajador.Celular = txtCelular.Text;
                        objTrabajador.Direccion = txtDireccion.Text;
                        objTrabajador.Sexo = cmbSexo.SelectedItem.ToString();
                        objTrabajador.Estudios = cmbEstudios.SelectedItem.ToString();
                        objTrabajador.ID_T = id;
                        objTrabajador.ModificarTrabajador(ms.GetBuffer());
                        btnEliminar.Visible = true;
                        btnGuardar.Visible = false;
                        pictureBox6.Visible = true;
                        pictureBox7.Visible = true;
                        pictureBox7.Visible = true;
                        txtSexo.Visible = true;
                        txtEstudios.Visible = true;
                        btnIngresarFoto.Visible = false;
                        cmbSexo.Visible = false;
                        cmbEstudios.Visible = false;
                        cmbCedula.Visible = true;
                        btnBuscar.Visible = true;
                        txtCedula.Text = "";
                        txtApellidos.Text = "";
                        txtNombres.Text = "";
                        txtCelular.Text = "";
                        txtDireccion.Text = "";
                        txtEstudios.Text = "";
                        txtSexo.Text = "";
                        picFoto.Image = null;
                        btnModificar.Enabled = false;
                        btnEliminar.Enabled = false;
                        txtCargo.Text = "";
                        cmbCedula.SelectedItem = null;
                        refrescarCMBCEDULA();
                        cmbCedula.SelectedItem = null;
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
        public void BloquearTextBox()
        {
            txtApellidos.ReadOnly = true;
            txtNombres.ReadOnly = true;
            txtCedula.ReadOnly = true;
            txtCelular.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtCargo.ReadOnly = true;
            txtSexo.ReadOnly = true;
            txtEstudios.ReadOnly = true;
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
        }
        private void frmVerTrabajador_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
