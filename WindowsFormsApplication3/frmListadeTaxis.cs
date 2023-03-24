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
    public partial class frmListadeTaxis : Form
    {
        csTaxi objtaxi;
        int unidad;
        int fila;
        int posicion;
        public frmListadeTaxis()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //int columna = e.ColumnIndex;
            //if (columna == 9)
            //{
            //    string unidad = "A", modelo = "A", marca = "A", cilindraje = "A", año = "A", motor = "A", placa = "A";
            //    frmModificarTaxi modificarTaxi = new frmModificarTaxi(unidad,modelo,marca,cilindraje,año,motor,placa);
            //    modificarTaxi.ShowDialog();
            //}
        }

        private void frmListadeTaxis_Load(object sender, EventArgs e)
        {
            //dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = true;
            csTaxi objtaxi = new csTaxi();
            dataGridView1.DataSource = objtaxi.listarTaxis();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;
            fila = e.RowIndex;
            int columna = e.ColumnIndex;
            if (columna == 0)
            {
                unidad = int.Parse(dataGridView1.CurrentCell.Value.ToString());
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            csTaxi objtaxi = new csTaxi();
            if (MessageBox.Show("Desea Eliminar Esta Unidad","!!Advertencia!!",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                objtaxi.EliminarTaxis(unidad);

                dataGridView1.DataSource = objtaxi.listarTaxis();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            objtaxi = new csTaxi();
            if (MessageBox.Show("Desea Modificar Esta Unidad", "!!Advertencia!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                objtaxi.N_Unidad = int.Parse(dataGridView1[0, posicion].Value.ToString());
                objtaxi.Modelo = dataGridView1[1, posicion].Value.ToString();
                objtaxi.Marca = dataGridView1[2, posicion].Value.ToString();
                objtaxi.N_Placa = dataGridView1[3, posicion].Value.ToString();
                objtaxi.Cilindraje = int.Parse(dataGridView1[4, posicion].Value.ToString());
                objtaxi.Año = int.Parse(dataGridView1[5, posicion].Value.ToString());
                objtaxi.N_Motor = dataGridView1[6, posicion].Value.ToString();
                frmModificarTaxi modi = new frmModificarTaxi(objtaxi.N_Unidad, objtaxi.Modelo, objtaxi.Marca, objtaxi.Cilindraje, objtaxi.Año, objtaxi.N_Motor, objtaxi.N_Placa);

                modi.ShowDialog();
                dataGridView1.DataSource = objtaxi.listarTaxis();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbPor.Text == "Numero_Unidad")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmN_Unidad"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                }
            }
            if (cmbPor.Text == "Modelo")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmModelo"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                }
            }
            if (cmbPor.Text == "Marca")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmMarca"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                }
            }
            if (cmbPor.Text == "Numero_Placa")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmN_Placa"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                }
            }
            if (cmbPor.Text == "Cilindraje")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmCilindraje"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                }
            }
            if (cmbPor.Text == "Año")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmAño"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                }
            }
            if (cmbPor.Text == "Numero_Motor")
            {

                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Visible = fila.Cells["clmN_Motor"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                }
            }
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbPor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
