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
    public partial class frmCargo : Form
    {
        csCargos accesoCargo = new csCargos();
        public frmCargo()
        {
            InitializeComponent();
        }

        private void frmCargo_Load(object sender, EventArgs e)
        {

            Llenar();
        }
        public void Llenar()
        {
            dataGridCargo.DataSource = accesoCargo.MostarTrabajadorCargo();
            dataGridDisponible.DataSource = accesoCargo.CargosDisponibles();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

           bool Verificar = accesoCargo.Verificar(dataGridCargo,dataGridDisponible, txtCargo.Text);
           if (Verificar == true)
           {
               if (string.IsNullOrWhiteSpace(txtCargo.Text))
               {
                   MessageBox.Show("Espacio vacio, debe ingresar un cargo", "!!Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }
               else
               {
                   csCargos objCargo = new csCargos();
                   objCargo.Cargo = txtCargo.Text;
                   objCargo.InsertarCargo();
                   txtCargo.Text = null;
                   Llenar();
               }
           }
           else
           {
               MessageBox.Show("Cargo ya registrado o ocupado", "!!Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnElinimar_Click(object sender, EventArgs e)
        {
            if (dataGridDisponible.SelectedRows.Count > 0)
            {
                accesoCargo.EliminarCargo((dataGridDisponible.CurrentRow.Cells[0].Value).ToString());
                MessageBox.Show("Se elimino satisfactoriamente");
                Llenar();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }
    }
}
