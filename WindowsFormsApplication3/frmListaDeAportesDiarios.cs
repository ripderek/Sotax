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
    public partial class frmListaDeAportesDiarios : Form
    {
        int posicion;
        int fila;

        string n_comprobante;
        public frmListaDeAportesDiarios()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaDeAportesDiarios_Load(object sender, EventArgs e)
        {
            try
            {
                csHISTORIAL_APORTES historial = new csHISTORIAL_APORTES();
                dataGridView1.DataSource = historial.HistorialAportes();
            }
            catch (Exception n)
            {
                MessageBox.Show("NO HAY DATOS PARA MOSTRAR"+n.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                posicion = dataGridView1.CurrentRow.Index;
                fila = e.RowIndex;
                int columna = e.ColumnIndex;
                if (columna == 4)
                {
                    n_comprobante = dataGridView1.CurrentCell.Value.ToString();
                    IMPRIMIR_COMPROBANTE_APORTE_DIARIO_N imprimir = new IMPRIMIR_COMPROBANTE_APORTE_DIARIO_N();
                    imprimir.Numero_de_comprobante = n_comprobante;
                    imprimir.Show();
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

                if (cmbPor.Text == "N°Cedula")
                {

                    dataGridView1.CurrentCell = null;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fila.Visible = fila.Cells["clmN_Cedula"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                    }
                }
                if (cmbPor.Text == "Apellidos")
                {

                    dataGridView1.CurrentCell = null;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fila.Visible = fila.Cells["clmApellido"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                    }
                }
                if (cmbPor.Text == "Nombres")
                {

                    dataGridView1.CurrentCell = null;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fila.Visible = fila.Cells["clmNombre"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
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
                if (cmbPor.Text == "N°Comprobante")
                {

                    dataGridView1.CurrentCell = null;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fila.Visible = fila.Cells["clmN_Comprobante"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                    }
                }
                if (cmbPor.Text == "Efectivo")
                {

                    dataGridView1.CurrentCell = null;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fila.Visible = fila.Cells["clmEfectivo"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                    }
                }
                if (cmbPor.Text == "N°Unidad")
                {

                    dataGridView1.CurrentCell = null;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fila.Visible = fila.Cells["clmUnidad"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                    }
                }

            }
            catch (Exception me)
            {
                MessageBox.Show(me + "");
            }
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
