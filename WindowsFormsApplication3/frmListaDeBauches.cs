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
    public partial class frmListaDeBauches : Form
    {
        int posicion;
        int fila;
       
        string n_comprobante;
        public frmListaDeBauches()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaDeBauches_Load(object sender, EventArgs e)
        {
            try
            {
                csVER_VOUCHES historial_bauches = new csVER_VOUCHES();
                dataGridView1.DataSource = historial_bauches.HistorialAportes_Bauches();
            }
            catch (Exception n)
            {
                MessageBox.Show("NO HAY DATOS PARA MOSTRAR " + n.Message);
            }
        }

        private void btnIMPRIMIR_Click(object sender, EventArgs e)
        {
            MessageBox.Show(n_comprobante);
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    posicion = dataGridView1.CurrentRow.Index;
            //    fila = e.RowIndex;
            //    int columna = e.ColumnIndex;
            //    if (columna == 6)
            //    {
            //        n_comprobante = dataGridView1.CurrentCell.Value.ToString();
            //        frmIMPIMIR_C_BUACHE imprimir = new frmIMPIMIR_C_BUACHE();
            //        imprimir.Numero_de_comprobante = n_comprobante;
            //        imprimir.Show();
            //    }
            //    else
            //    {
            //    }

            //}
            //catch (Exception n)
            //{
            //    MessageBox.Show(n.Message);
            //}
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {

            if (cmbPor.Text == "Nombre De Empresa")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmN_Empresa"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                }
            }
            if (cmbPor.Text == "N°Cedula")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmN_Cedula"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                }
            }
            if (cmbPor.Text == "N°Comprobante")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmN_Comprobante"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                }
            }
            if (cmbPor.Text == "N°Voucher")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmN_Voucher"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                }
            }
            if (cmbPor.Text == "Fecha")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmFecha"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                }
            }

            }
            catch (Exception me)
            {
                MessageBox.Show(me +"");
            }
        }

        private void cmbPor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
