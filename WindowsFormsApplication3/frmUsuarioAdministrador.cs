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
    public partial class frmUsuarioAdministrador : Form
    {
        public frmUsuarioAdministrador()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            csValidarCampos validar = new csValidarCampos();
            validar.TextBoxVacios(txtUsuario,"Usuario");
            int comprobar = validar.comprobar;
            csValidarCampos validar2 = new csValidarCampos();
            validar2.TextBoxVacios(txtContraseña,"Contraseña");
            int comprobar2 = validar2.comprobar;
             if (comprobar==1 && comprobar2==1) 
             {
                 try
                 {

                     csUsuarios VerificarLogin = new csUsuarios();
                     VerificarLogin.VERIFICAR_USUARIO(txtUsuario.Text, txtContraseña.Text);
                     string tipo = VerificarLogin.TipoUsuario;
                     int verificar = VerificarLogin.Login;
                     if (verificar == 1)
                     {

                         if (tipo == "AD")
                         {
                             this.DialogResult = DialogResult.OK;
                         }
                         else
                         {
                             MessageBox.Show("LOGIN FALLIDO INTENTE DE NUEVO");
                         }
                     }
                     
                 }
                 catch (Exception n)
                 {
                     MessageBox.Show(n.Message);
                 }
       
             }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;

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

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DarkSlateGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
    }
}
