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
    public partial class frmHistorialCaja : Form
    {
        int posicion;
        int fila;
        string n_comprobante;
        public frmHistorialCaja()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHistorialCaja_Load(object sender, EventArgs e)
        {
            try
            {
                csHistorialTransacciones historial = new csHistorialTransacciones();
                dataGridView1.DataSource = historial.HistorialAportes();
            }
            catch(Exception n)
            {
                MessageBox.Show(n.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                posicion = dataGridView1.CurrentRow.Index;
                fila = e.RowIndex;
                int columna = e.ColumnIndex;
                if (columna == 0)
                {
                    n_comprobante = dataGridView1.CurrentCell.Value.ToString();
                    frmIMPRIMIR_COMPROBANTE_TRANSACCION_N TRANSACCION = new frmIMPRIMIR_COMPROBANTE_TRANSACCION_N();
                    TRANSACCION.Numero_de_comprobante = n_comprobante;
                    TRANSACCION.Show();
                }
                else
                {
                }

            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (cmbPor.Text == "N°Comprobante")
                {

                    dataGridView1.CurrentCell = null;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fila.Visible = fila.Cells["clmComprobante"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                    }
                }
                if (cmbPor.Text == "N°Cuenta")
                {

                    dataGridView1.CurrentCell = null;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fila.Visible = fila.Cells["clmApellidos"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                    }
                }
                if (cmbPor.Text == "Nombres")
                {

                    dataGridView1.CurrentCell = null;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fila.Visible = fila.Cells["clmNombres"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
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
                if (cmbPor.Text == "Fecha")
                {

                    dataGridView1.CurrentCell = null;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fila.Visible = fila.Cells["clmFecha"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                    }
                }
                if (cmbPor.Text == "Tipo")
                {

                    dataGridView1.CurrentCell = null;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fila.Visible = fila.Cells["clmTipo"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                    }
                }

            }
            catch (Exception me)
            {
                MessageBox.Show(me + "");
            }
        }
    }
}
