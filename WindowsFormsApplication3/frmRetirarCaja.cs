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
    public partial class frmRetirarCaja : Form
    {
        public frmRetirarCaja()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult OpcionImprimir = new DialogResult();
            MessageImprimir messageImprimir = new MessageImprimir();
            OpcionImprimir = messageImprimir.ShowDialog();
            if (OpcionImprimir == DialogResult.OK)
            { }
            else if (OpcionImprimir == DialogResult.Cancel)
            { }
            else
            { }
        }
    }
}
