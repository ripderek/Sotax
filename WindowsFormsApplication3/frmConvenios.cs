using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class frmConvenios : Form
    {
        public frmConvenios()
        {
            InitializeComponent();

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConvenios_Load(object sender, EventArgs e)
        {
            csLISTA_CONVENIOS convenios = new csLISTA_CONVENIOS();
            dataGridView1.DataSource = convenios.Lista_Covenios();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (cmbPor.Text == "Nombre de Empresa")
                {

                    dataGridView1.CurrentCell = null;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fila.Visible = fila.Cells["clmNombreEmpresa"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
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
                if (cmbPor.Text == "Nombre Propietario")
                {

                    dataGridView1.CurrentCell = null;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fila.Visible = fila.Cells["clmNombrePropietario"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                    }
                }
                if (cmbPor.Text == "RUC")
                {

                    dataGridView1.CurrentCell = null;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fila.Visible = fila.Cells["clmRuc"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                    }
                }
                if (cmbPor.Text == "N°Cuenta")
                {

                    dataGridView1.CurrentCell = null;
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        fila.Visible = fila.Cells["clmN_Cuenta"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
                    }
                }

            }
            catch (Exception me)
            {
                MessageBox.Show(me + "");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                csCONENIOS objConvenios = new csCONENIOS();
                objConvenios.VerificarConvenioBauche((dataGridView1.CurrentRow.Cells[0].Value).ToString());
                objConvenios.EliminarConvenio((dataGridView1.CurrentRow.Cells[0].Value).ToString());
            }
            else
                MessageBox.Show("Seleccione una fila");
            }
            catch (Exception me)
            {
                MessageBox.Show(me + "");
            }
        }
    }
}
