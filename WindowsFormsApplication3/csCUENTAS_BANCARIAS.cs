using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    class csCUENTAS_BANCARIAS
    {
        csConexion conexion = new csConexion();
        private string cedula;
        private string nombres;
        private string ruc;
        private int existencia;

        public string NOMBRES_PROPIETARIO
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string N_CEDULA
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string N_RUC
        {
            get { return ruc; }
            set { ruc = value; }
        }


        public void REGISTRAR_CONVENIO()
        {
            VERIFCAR_EXISTENCIA_CONVENIO();
            if (existencia == 0)
            {
                try
                {
                    //SqlCommand->Ejecutar una sentencia SQL
                    SqlCommand cmd = new SqlCommand("SP_REGISTRAR_DECLARACION", conexion.con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Abrir conexion
                    conexion.abrirCerrarConexion();

                    //Asignar parámetros
                    cmd.Parameters.AddWithValue("@APELLIDOS_PROPIETARIO", NOMBRES_PROPIETARIO);
                    cmd.Parameters.AddWithValue("@CEDULA_PROPIETARIO", N_CEDULA);
                    cmd.Parameters.AddWithValue("@RUC_EMPRESA", N_RUC);
                    //Ejecutar procedure
                    cmd.ExecuteNonQuery();

                    //Cerrar conexion
                    conexion.abrirCerrarConexion();
                    MessageBox.Show("Datos Guardados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception n)
                {
                    MessageBox.Show(n.Message);
                }

            }
            else { MessageBox.Show("Convenio ya resgistrada", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void VERIFCAR_EXISTENCIA_CONVENIO()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_VERIFICAR_DECLARACION", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@RUC_EMPRESA", N_RUC);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    existencia = 1;
                }
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                rd.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("CUENTA YA DECLARADA", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public DataSet Listar_CUENTAS()
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da_Taxitas = new SqlDataAdapter();
            da_Taxitas.SelectCommand = new SqlCommand("select * from DECLARACION ;", conexion.con);
            da_Taxitas.SelectCommand.CommandType = CommandType.Text;
            da_Taxitas.Fill(ds, "NºCUENTA");

            return ds;
        }
    }
}
