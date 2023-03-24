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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
          
            InitializeComponent();

            csConexion conexion = new csConexion();
            conexion.LeerConfig();
            int verficar = conexion.Pasar;
            if (verficar == 0)
            {
                frmREGISTRARUSUARIO usurios = new frmREGISTRARUSUARIO();
                usurios.ShowDialog();
            }
            else
            {

            }

            Console.WriteLine(conexion.Pasar);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void verContra_Click(object sender, EventArgs e)
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

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
           
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //csValidarCampos validar = new csValidarCampos();
            //validar.TextBoxVacios(txtUsuario, "Usuario");
            //int comprobar = validar.comprobar;

            csValidarCampos validar2 = new csValidarCampos();
            validar2.TextBoxVacios(txtContraseña, "Contraseña");
            int comprobar2 = validar2.comprobar;

            if (comprobar2==1)
            {
                try
                {
                  
                    csUsuarios VerificarLogin = new csUsuarios();
                    VerificarLogin.VERIFICAR_USUARIO(cmbUsuario.Text, txtContraseña.Text);
                    string tipo = VerificarLogin.TipoUsuario;
                    int verificar = VerificarLogin.Login;
                    if (verificar == 1)
                    {
                       
                        if (tipo == "AD")
                        {
                            MenuPrincipal frmMenu = new MenuPrincipal(1);
                            MessageBox.Show("LOGIN CORRECTO USUARIO ADMINISTRADOR");
                            this.Close();
                            frmMenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("LOGIN CORRECTO USUARIO OPERADOR");
                            MenuPrincipal frmMenu = new MenuPrincipal(0); // EL LOGIN TIENE QUE DETECTAR QUE SE INICIO COMO ADMINISTRADOR 
                            this.Close();
                            frmMenu.Show();
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("LOGIN FALLIDO INTENTE DE NUEVO");
                    }
                }
                catch(Exception n)
                {
                    MessageBox.Show(n.Message);
                }
                 
            }                                               
           
            
         
        }

       

        private void txtUsuario_Leave_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DarkSlateGray;

              
            }
        }

        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
    
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
                
                novercontra.Visible = true;
                btnVerContra.Visible = true;
                

            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DarkSlateGray;
                txtContraseña.UseSystemPasswordChar = false;
                btnVerContra.Visible = false;
                novercontra.Visible = false;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperarContraseña recuperar = new  frmRecuperarContraseña();
            recuperar.ShowDialog();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            csUsuarios usuario = new csUsuarios();
            cmbUsuario.DataSource=usuario.ListarUsuarios().Tables[0];
            cmbUsuario.DisplayMember = "Usuario";
            cmbUsuario.SelectedItem = null;

      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

      
       
    }
}
