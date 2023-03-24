using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    class csBAUCHES
    {
        csConexion conexion = new csConexion();
        private int IDempresa;
        private int IDtaxita;
        private string NumeroBau;
        private string Nombre_Empresa_A;
        private string Origen;
        private string Destino;
        private string Fecha;
        private decimal Monto;
        private int N_Unidad;
        private int existe;
        private string TOTAL;

        public string TOTAL_B
        {
            get { return TOTAL; }
            set { TOTAL = value; }
        }
        public int EXISTE_N
        {
            get { return existe; }
            set { existe = value; }
        }
        public string FECHA_B
        {
            get { return Fecha; }
            set { Fecha = value; }
        }

        public int ID_TAXISTA
        {
            get { return IDtaxita; }
            set { IDtaxita = value; }
        }
        public int ID_EMPRESA
        {
            get { return IDempresa; }
            set { IDempresa = value; }
        }
        public int ID_UNIDAD
        {
            get { return N_Unidad ; }
            set { N_Unidad = value; }
        }
        public decimal MONTO
        {
            get { return Monto; }
            set { Monto = value; }
        }
        public string NUMEROBAUCHE
        {
            get { return NumeroBau; }
            set { NumeroBau = value; }
        }
        public string NOMBRE_EMPRESA
        {
            get { return Nombre_Empresa_A; }
            set { Nombre_Empresa_A = value; }
        }
        public string ORIGEN_B
        {
            get { return Origen; }
            set { Origen = value; }
        }
        public string DESTINO_B
        {
            get { return Destino; }
            set { Destino = value; }
        }

        public void INGRESAR_APORTE_BAUCHE()
        {
            VerificarExistenciaBauche();
            if (existe == 0)
            {
                try
                {

                    //SqlCommand->Ejecutar una sentencia SQL
                    SqlCommand cmd = new SqlCommand("SP_REGISTRAR_BACUHE_N1", conexion.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Abrir conexion
                    conexion.abrirCerrarConexion();
                    //Asignar parámetros
                    cmd.Parameters.AddWithValue("@ID_Empresa", ID_EMPRESA);
                    cmd.Parameters.AddWithValue("@ID_Taxista", ID_TAXISTA);
                    cmd.Parameters.AddWithValue("@N_Bacuhe", NUMEROBAUCHE);
                    cmd.Parameters.AddWithValue("@N_Empresa", NOMBRE_EMPRESA);
                    cmd.Parameters.AddWithValue("@Origen", ORIGEN_B);
                    cmd.Parameters.AddWithValue("@Destino", DESTINO_B);
                    cmd.Parameters.AddWithValue("@Fecha", FECHA_B);
                    cmd.Parameters.AddWithValue("@Efectivo", MONTO);
                    cmd.Parameters.AddWithValue("@N_Unidad", ID_UNIDAD);
                    //Ejecutar procedure
                    cmd.ExecuteNonQuery();
                    //Cerrar conexion
                    conexion.abrirCerrarConexion();
                    MessageBox.Show("Datos Guardados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                MessageBox.Show("EL NUMERO DE BAUCHE YA HA SIDO REGISTRADO");
            }

           
        }

        private void VerificarExistenciaBauche()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select N_Bauche from APORTES_BUACHES where N_Bauche='" + NUMEROBAUCHE + "'", conexion.con);
                conexion.abrirCerrarConexion();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                { existe = 1; }
                else
                {
                    existe = 0;
                }
                conexion.abrirCerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void CALCULAR_TOTAL_B()
        {
            try
            {
                DateTime fecha2 = DateTime.UtcNow.Date;
                SqlCommand cmd = new SqlCommand("SP_SUMA_TOTAL_VOUCHERS", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.abrirCerrarConexion();
                cmd.Parameters.AddWithValue("@Fecha", fecha2);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                { TOTAL_B = dr.GetDecimal(0).ToString("N2"); }
                conexion.abrirCerrarConexion();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
