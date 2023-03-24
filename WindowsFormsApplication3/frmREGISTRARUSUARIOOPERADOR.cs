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
    public partial class frmREGISTRARUSUARIOOPERADOR : Form
    {
        string Usuario1;
        string Contraseña1;
        string Pregunta1;
        string Respuesta1;
        
        public frmREGISTRARUSUARIOOPERADOR(string UsuarioAdministrador, string ContraseñaAdministrador, string PreguntaAdimistrador, string RespuestaAdministrador)
        {
            InitializeComponent();
            Usuario1 = UsuarioAdministrador;
            Contraseña1 = ContraseñaAdministrador;
            Pregunta1 = PreguntaAdimistrador;
            Respuesta1 = RespuestaAdministrador;
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void btnVerContra_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar)
            {
                btnVerContra.BringToFront();
                txtContraseña.UseSystemPasswordChar = false;
            }

            else
            {
                novercontra.BringToFront();
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void novercontra_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar)
            {
                btnVerContra.BringToFront();
                txtContraseña.UseSystemPasswordChar = false;
            }

            else
            {
                novercontra.BringToFront();
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void novercontra12_Click(object sender, EventArgs e)
        {

        }

        private void btnVerContra12_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña1_Leave(object sender, EventArgs e)
        {
            if (txtContraseña1.Text == "")
            {
                txtContraseña1.Text = "Repetir Contraseña";
                txtContraseña1.ForeColor = Color.DarkSlateGray;
                if (txtContraseña1.Text == "Repetir Contraseña")
                {
                    txtContraseña1.UseSystemPasswordChar = false;
                }

            }
        }

        private void txtContraseña1_Enter(object sender, EventArgs e)
        {
            if (txtContraseña1.Text == "Repetir Contraseña")
            {
                txtContraseña1.Text = "";
                txtContraseña1.ForeColor = Color.Black;
                txtContraseña1.UseSystemPasswordChar = true;

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DarkSlateGray;


            }

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;

            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DarkSlateGray;
                novercontra.Visible = false;
                btnVerContra.Visible = false;

            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                novercontra.Visible = true;
                btnVerContra.Visible = true;
                txtContraseña.UseSystemPasswordChar = true;


            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Respuesta de Seguridad";
                textBox3.ForeColor = Color.DarkSlateGray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Respuesta de Seguridad")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            csValidarCampos validar = new csValidarCampos();
            validar.TextBoxVacios(txtUsuario, "Usuario");
            int comprobar = validar.comprobar;


            csValidarCampos validar2 = new csValidarCampos(); //txtContraseña
            validar2.TextBoxVacios(txtContraseña, "Contraseña");
            int comprobar2 = validar2.comprobar;

            csValidarCampos validar3 = new csValidarCampos(); //Repetir txtContraseña
            validar3.TextBoxVacios(txtContraseña1, "Repetir Contraseña");
            int comprobar3 = validar3.comprobar;

;

            csValidarCampos validar5 = new csValidarCampos(); // Respuesta de seguridad txtContraseña
            validar5.TextBoxVacios(textBox3, "Respuesta de Seguridad");
            int comprobar5 = validar5.comprobar;

            if (cmbPregunta.SelectedItem == null)
            {
                MessageBox.Show("SELECCIONE UNA PREGUNTA");
            }
            else if (comprobar == 1 && comprobar2 == 1 && comprobar3 == 1  && comprobar5 == 1  && txtContraseña.Text==txtContraseña1.Text)
            {
                csUsuarios UsurarioAdiministrador = new csUsuarios();
                UsurarioAdiministrador.USUARIO = Usuario1;
                UsurarioAdiministrador.CONTRASEÑA = Contraseña1;
                UsurarioAdiministrador.PREGUNTA = Pregunta1;
                UsurarioAdiministrador.RESPUESTA = Respuesta1;
                UsurarioAdiministrador.TIPOUSUARIO = "AD";
                UsurarioAdiministrador.REGISTRAR_USUARIO(); 
                Console.Write("HOLA" + Usuario1 + Contraseña1 + Pregunta1 + Respuesta1);


                csUsuarios UsuarioOperador = new csUsuarios();
                UsuarioOperador.USUARIO = txtUsuario.Text;
                UsuarioOperador.CONTRASEÑA = txtContraseña.Text;
                UsuarioOperador.PREGUNTA = cmbPregunta.Text;
                UsuarioOperador.RESPUESTA = textBox3.Text;
                UsuarioOperador.TIPOUSUARIO = "OP";
                UsuarioOperador.REGISTRAR_USUARIO();
                csConexion escribirconfig = new csConexion();
                escribirconfig.EscribirConfig();
                MessageBox.Show("USUARIOS REGISTRADOS CORRECTAMENTE");
                this.Close();
            }
            else if (txtContraseña.Text != txtContraseña1.Text)
            {
                MessageBox.Show("NO CONCUERDAN LAS CONTRASEÑAS");
            }
            
        }

        private void btnMasIfno_Click(object sender, EventArgs e)
        {
            frmINFORMACIONUSUARIOS info = new frmINFORMACIONUSUARIOS();
            info.ShowDialog();
        }

        private void cTerminos_CheckedChanged(object sender, EventArgs e)
        {
            frmTERMINOSCONDICIONES terminos = new frmTERMINOSCONDICIONES();
            terminos.ShowDialog();
        }
    }
}
