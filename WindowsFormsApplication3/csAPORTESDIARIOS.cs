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
    class csAPORTESDIARIOS
    {
        private DateTime fecha2 = DateTime.UtcNow.Date;
        csConexion conexion = new csConexion();
        private int idTaxistas;
        private  DateTime fecha= DateTime.UtcNow.Date;
        private decimal efectivo=0;
        private int cod_Unidad;
        private string TOTAL;
        private int ID_EMPRES;
        public string TOTAL_AP
        {
            get { return TOTAL; }
            set { TOTAL = value; }
        }

        public int ID_TAXISTA
        {
            get { return idTaxistas; }
            set { idTaxistas = value; }
        }
        public decimal C_EFECTIVO
        {
            get { return efectivo; }
            set { efectivo = value; }
        }

        public int ID_UNIDAD
        {
            get { return cod_Unidad; }
            set { cod_Unidad = value; }
        }

        public void INGRESAR_APORTE_DIARIO()
        {
            try
            {
                BUSCAR_ID_EMPRESA();
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_REGISTRARAPORTEDIARIO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_Taxista",ID_TAXISTA);
                cmd.Parameters.AddWithValue("@Fecha", fecha);
                cmd.Parameters.AddWithValue("@Efectivo", C_EFECTIVO);
                cmd.Parameters.AddWithValue("@N_Unidad", ID_UNIDAD);
                cmd.Parameters.AddWithValue("@Id_Empresa", ID_EMPRES);

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

        public void CALCULAR_TOTAL_AP()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SP_TOTAL_APORTES_DIARIOS_N", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.abrirCerrarConexion();
                cmd.Parameters.AddWithValue("@Fecha", fecha2);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                { TOTAL_AP = dr.GetDecimal(0).ToString("N2"); }
                conexion.abrirCerrarConexion();
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void BUSCAR_ID_EMPRESA()
        {
            try
            {
                SqlDataReader dr;

                SqlCommand cmd = new SqlCommand(string.Format("select ID  from Empresa"), conexion.con);
                //Tipo de sentencia a ejecutar
                //Abrir conexion
                conexion.abrirCerrarConexion();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ID_EMPRES = dr.GetInt32(0);
                }
                // Cierra Conexion
                conexion.abrirCerrarConexion();
                dr.Close();
            }
            catch (Exception n)
            { MessageBox.Show(n.Message); }
        }
        public void BUSCAR_COD_UNIDAD()
        {
            try
            {
                SqlDataReader dr;

                SqlCommand cmd = new SqlCommand(string.Format("select ID from Taxi where N_Unidad=0"), conexion.con);
                //Tipo de sentencia a ejecutar
                //Abrir conexion
                conexion.abrirCerrarConexion();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ID_UNIDAD = dr.GetInt32(0);
                }
                // Cierra Conexion
                conexion.abrirCerrarConexion();
                dr.Close();
            }
            catch (Exception n)
            { MessageBox.Show(n.Message); }
        }
      
     

    }
}
