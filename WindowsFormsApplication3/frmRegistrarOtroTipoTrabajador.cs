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
    public partial class frmRegistrarOtroTipoTrabajador : Form
    {
        public frmRegistrarOtroTipoTrabajador()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            picFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            csValidarCampos validar = new csValidarCampos();
            validar.TextBoxVacios(txtApellidos,"APELLIDOS");
            int comprobar = validar.comprobar;
            csValidarCampos validar2 = new csValidarCampos();
            validar2.TextBoxVacios(txtNombres, "NOMBRES");
            int comprobar2 = validar2.comprobar;
            csValidarCampos validar3 = new csValidarCampos();
            validar3.TextBoxVacios(txtDireccion,"DIRECCION");
            int comprobar3 = validar3.comprobar;
            csValidarCampos validar4 = new csValidarCampos();
            validar4.TextBoxPrecio(txtCdula,"CEDULA");
            validar4.tamaño(txtCdula,10);
            int comprobar4 = validar4.comprobartamaño;
            ulong comprobar42 = validar4.comprobarprecio;
            csValidarCampos validar5 = new csValidarCampos();
            validar5.TextBoxPrecio(txtCelular,"CELULAR");
            validar5.tamaño(txtCelular,10);
            int comprobar5 = validar5.comprobartamaño;
            ulong comprobar52 = validar5.comprobarprecio;


            if (cmbSexo.SelectedItem == null)
            {
                MessageBox.Show("SELECCIONE SEXO");
            }
            else if (cmbCargos.SelectedItem == null)
            {
                MessageBox.Show("SELECCIONE CARGO");
            }
            else if (cmbEstudios.SelectedItem == null)
            {
                MessageBox.Show("SELECCIONE ESTUDIOS");
            }
            else
            {
                csTrabajador trabajador = new csTrabajador();
                trabajador.Apellidos = txtApellidos.Text;
                trabajador.Nombres = txtNombres.Text;
                trabajador.Direccion = txtDireccion.Text;
                trabajador.N_Cedula = txtCdula.Text;
                trabajador.Celular = txtCelular.Text;
                trabajador.Sexo = cmbSexo.Text;
                trabajador.Estudios = cmbEstudios.Text;
                trabajador.Cargo = int.Parse(cmbCargos.SelectedValue.ToString());
                trabajador.VerificarExistencia();
                int verificarexis = trabajador.verificar;

                if (comprobar == 1 && comprobar2 == 1 && comprobar3 == 1 && comprobar42 == 1 && comprobar52 == 1 && comprobar4 == 1 && comprobar5 == 1 && verificarexis==1)
                {
                    trabajador.InsertarTrabajador(ms.GetBuffer());
                    csCargos cargos = new csCargos();
                    cmbCargos.DataSource = cargos.ListarCargos().Tables[0];
                    cmbCargos.ValueMember = "ID";
                    cmbCargos.DisplayMember = "Cargo";
                    LimpiarTexbox(txtApellidos);
                    LimpiarTexbox(txtCdula);
                    LimpiarTexbox(txtCelular);
                    LimpiarTexbox(txtDireccion);
                    LimpiarTexbox(txtNombres);
                    LimpiarCombo(cmbCargos);
                    LimpiarCombo(cmbEstudios);
                    LimpiarCombo(cmbSexo);
                    picFoto.Image = picFotoDefault.Image;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistrarOtroTipoTrabajador_Load(object sender, EventArgs e)
        {
            csCargos cargos = new csCargos();
            cmbCargos.DataSource = cargos.ListarCargos().Tables[0];
            cmbCargos.ValueMember = "ID";
            cmbCargos.DisplayMember = "Cargo";
            cmbCargos.SelectedItem = null;
            cmbEstudios.SelectedItem = null;
            cmbSexo.SelectedItem = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Fo = new OpenFileDialog();
            DialogResult Rs = Fo.ShowDialog();
            if (Rs == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(Fo.FileName);

            }
        }
        private void LimpiarTexbox(TextBox Limpiar)
        {
            Limpiar.Text = null;
        }
        private void LimpiarCombo(ComboBox limpiarc)
        {
            limpiarc.SelectedItem = null;
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
