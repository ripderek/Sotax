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
    public partial class frmResumenTotalAños : Form
    {
        public frmResumenTotalAños()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy";
            dateTimePicker2.ShowUpDown = true;

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.SP_ANALYTICS_3TableAdapter.Fill(this.DataSetResumenTotalAños.SP_ANALYTICS_3, dateTimePicker1.Value.Year.ToString() , dateTimePicker2.Value.Year.ToString() );

            this.reportViewer1.RefreshReport();
        }

        private void frmResumenTotalAños_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetResumenTotalAños.SP_ANALYTICS_3' Puede moverla o quitarla según sea necesario.
            this.SP_ANALYTICS_3TableAdapter.Fill(this.DataSetResumenTotalAños.SP_ANALYTICS_3, "2000" , "2100");

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.SP_ANALYTICS_3TableAdapter.Fill(this.DataSetResumenTotalAños.SP_ANALYTICS_3, (FechaActual()-5).ToString() , FechaActual().ToString() );

            this.reportViewer1.RefreshReport();
        }

        public int FechaActual()
        {
            int fecha;
            return fecha = DateTime.Today.Year;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SP_ANALYTICS_3TableAdapter.Fill(this.DataSetResumenTotalAños.SP_ANALYTICS_3, (FechaActual() - 10).ToString(), FechaActual().ToString());

            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.SP_ANALYTICS_3TableAdapter.Fill(this.DataSetResumenTotalAños.SP_ANALYTICS_3, "2000", "2100");

            this.reportViewer1.RefreshReport();
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
