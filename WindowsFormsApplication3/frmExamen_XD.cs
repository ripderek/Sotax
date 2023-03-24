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
    public partial class frmExamen_XD : Form
    {
        public frmExamen_XD()
        {
            InitializeComponent();
        }

        private void frmExamen_XD_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.UtcNow.Date;
            // TODO: esta línea de código carga datos en la tabla 'DataSetEXAMEN_XD.SP_1' Puede moverla o quitarla según sea necesario.
            this.SP_1TableAdapter.Fill(this.DataSetEXAMEN_XD.SP_1, fecha);
            // TODO: esta línea de código carga datos en la tabla 'DataSetEXAMEN_XD.SP_2' Puede moverla o quitarla según sea necesario.
            this.SP_2TableAdapter.Fill(this.DataSetEXAMEN_XD.SP_2, fecha);
            // TODO: esta línea de código carga datos en la tabla 'DataSetEXAMEN_XD.SP_4' Puede moverla o quitarla según sea necesario.
            this.SP_4TableAdapter.Fill(this.DataSetEXAMEN_XD.SP_4, fecha);
            // TODO: esta línea de código carga datos en la tabla 'DataSetEXAMEN_XD.SP_5' Puede moverla o quitarla según sea necesario.
            this.SP_5TableAdapter.Fill(this.DataSetEXAMEN_XD.SP_5, fecha);

            this.reportViewer1.RefreshReport();
        }
    }
}
