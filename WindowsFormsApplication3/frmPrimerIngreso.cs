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
    public partial class frmPrimerIngreso : Form
    {
        public frmPrimerIngreso()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            frmDatos_de_la_empresa ingresardatos = new frmDatos_de_la_empresa(0);
            ingresardatos.ShowDialog();
            this.Close();
        }
    }
}
