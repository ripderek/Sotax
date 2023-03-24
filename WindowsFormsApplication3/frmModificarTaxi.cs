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
    public partial class frmModificarTaxi : Form
    {
        csTaxi objTaxi;
        int Unidad;
        string Modelo;
        string Marca;
        int Cilindraje;
        int Año;
        string Motor;
        string Placa;

        public frmModificarTaxi(int @unidad, string @modelo, string @marca, int @cilindraje,int @año, string @motor , string @placa)
        {
            Unidad = @unidad;
            Modelo = @modelo;
            Marca = @marca;
            Cilindraje = @cilindraje;
            Año = @año;
            Motor = @motor;
            Placa = @placa;
            InitializeComponent();
        }

        private void frmModificarTaxi_Load(object sender, EventArgs e)
        {
            lblUnidad.Text = Unidad.ToString(); ;
            txtModelo.Text = Modelo; txtMarca.Text = Marca; txtCilindraje.Text = Cilindraje.ToString(); txtAño.Text = Año.ToString(); txtMotor.Text = Motor; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModelo.Text)
                    || string.IsNullOrWhiteSpace(txtMarca.Text) || string.IsNullOrWhiteSpace(txtCilindraje.Text)
                    || string.IsNullOrWhiteSpace(txtAño.Text) || string.IsNullOrWhiteSpace(txtMotor.Text))
            {
                MessageBox.Show("Intento ingresar casillas en blanco, vuelva a intentarlo", "¡AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string N_placa = Placa;
                objTaxi = new csTaxi();
                objTaxi.N_Unidad = int.Parse(lblUnidad.Text);
                objTaxi.Modelo = txtModelo.Text;
                objTaxi.Marca = txtMarca.Text;
                objTaxi.N_Placa = N_placa;
                objTaxi.Cilindraje = int.Parse(txtCilindraje.Text);
                objTaxi.Año = int.Parse(txtAño.Text);
                objTaxi.N_Motor = txtMotor.Text;

                objTaxi.ModificarTaxi();

                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
