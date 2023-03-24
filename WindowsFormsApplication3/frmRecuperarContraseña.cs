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
    public partial class frmRecuperarContraseña : Form
    {
        string respuesta;
        string usuario; 
        public frmRecuperarContraseña()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            csUsuarios VerificarUsuario = new csUsuarios();
            VerificarUsuario.BuscarUsuario(txtUsuario.Text);
            usuario = VerificarUsuario.USUARIO;
            txtPregunta.Text = VerificarUsuario.PREGUNTA;
            respuesta = VerificarUsuario.RESPUESTA;
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRespuesta.Text == respuesta)
            {
                csValidarCampos validar = new csValidarCampos();
                validar.TextBoxVacios(txtContraseña, "CONTRASEÑA");
                int v1 = validar.comprobar;

                csValidarCampos validar2 = new csValidarCampos();
                validar2.TextBoxVacios(txtContraeña1, "REPETIR CONTRASEÑA");
                int v2 = validar2.comprobar;

                if (v1 == 1 && v2 == 1 && txtContraseña.Text == txtContraeña1.Text)
                {
                    csUsuarios cambiarc = new csUsuarios();
                    cambiarc.RecuperarContra(usuario,txtContraseña.Text);
                    MessageBox.Show("CAMBIADO CORRECTAMENTE");
                    txtUsuario.Text = "";
                    txtRespuesta.Text = "";
                    txtPregunta.Text = "";
                    txtContraseña.Text = "";
                    txtContraeña1.Text = "";
                    
                }
                else { MessageBox.Show("LAS CONSTRASEÑAS NO CONCUERDAN"); }
            }
            else
            {
                MessageBox.Show("RESPUESTA INCORRECTA VUELVA A INTENTARLO");
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

        private void frmRecuperarContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
