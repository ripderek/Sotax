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
    public partial class frmAJUSTES : Form
    {
        public frmAJUSTES()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAJUSTES_Load(object sender, EventArgs e)
        {
            csControl_Aportes control = new csControl_Aportes();
            dataGridView1.DataSource = control.ControlAportes();
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
                        fila.Visible = fila.Cells["ClmApellidos"].Value.ToString().ToUpper().Contains(txtBuscar.Text.ToUpper());
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

            }
            catch (Exception me)
            {
                MessageBox.Show(me + "");
            }
        }
    }
}
