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
    public partial class frmListaTaxistas : Form
    {
        csTaxista Taxista = new csTaxista();

        public frmListaTaxistas()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaTaxistas_Load(object sender, EventArgs e)
        {
            dgvTaxistas.RowHeadersVisible = false;
            csTaxista objTaxista = new csTaxista();
            dgvTaxistas.DataSource = objTaxista.listarTaxistas(); 
        }
    }
}
