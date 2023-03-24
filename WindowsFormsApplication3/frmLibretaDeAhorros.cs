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
    public partial class frmLibretaDeAhorros : Form
    {
        public frmLibretaDeAhorros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banco b = new Banco();
            b.Consultar_SALDO();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLibretaDeAhorros_Load(object sender, EventArgs e)
        {
            frmRESUMEN resumen = new frmRESUMEN();
            resumen.TopLevel = false;
            resumen.Dock = DockStyle.Fill;
            panel3.Controls.Add(resumen);
            panel3.Tag = resumen;
            resumen.BringToFront();
            resumen.Show();
        }
    }
}
