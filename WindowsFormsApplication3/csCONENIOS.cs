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
    class csCONENIOS
    {
        csConexion conexion = new csConexion();
        private string nombre;
        private string cedula;
        private string nombres;
        private string celular;
        private string ruc;
        private string cuenta;
        private string ciudad;
        private int porcentaje;
        public int existencia=0;

        public string NOMBRE_EMPRESA
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string N_CEDULA
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string NOMBRES_PROPIETARIO
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string N_CELULAR
        {
            get { return celular; }
            set { celular = value; }
        }
        public string N_RUC
        {
            get { return ruc; }
            set { ruc = value; }
        }
        public string N_CUENTA
        {
            get { return cuenta; }
            set { cuenta = value; }
        }
        public string N_CIUDAD
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public int N_PORCENTAJE
        {
            get { return porcentaje; }
            set { porcentaje = value; }
        }

        public void REGISTRAR_CONVENIO()
        {
            VERIFCAR_EXISTENCIA_CONVENIO();
            if (existencia == 0)
            {
                try
                {
                    //SqlCommand->Ejecutar una sentencia SQL
                    SqlCommand cmd = new SqlCommand("SP_REGISTRAR_CONVENIO", conexion.con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Abrir conexion
                    conexion.abrirCerrarConexion();

                    //Asignar parámetros
                    cmd.Parameters.AddWithValue("@NOMBRE_EMPRESA", NOMBRE_EMPRESA);
                    cmd.Parameters.AddWithValue("@CEDULA_PROPIETARIO", N_CEDULA);
                    cmd.Parameters.AddWithValue("@APELLIDOS_PROPIETARIO", NOMBRES_PROPIETARIO);
                    cmd.Parameters.AddWithValue("@CELULAR_EMPRESA", N_CELULAR);
                    cmd.Parameters.AddWithValue("@RUC_EMPRESA", N_RUC);
                    cmd.Parameters.AddWithValue("@N_CUENTA_EMPRESA", N_CUENTA);
                    cmd.Parameters.AddWithValue("@CIUDAD_EMPRESA", N_CIUDAD);
                    cmd.Parameters.AddWithValue("@PORCENTAJE_VOCHER", N_PORCENTAJE);
                    cmd.Parameters.AddWithValue("@Estado", "DISPONIBLE");

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
            else{MessageBox.Show("Convenio ya resgistrada", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);}
        }
        private void VERIFCAR_EXISTENCIA_CONVENIO()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_VERIFICAR_CONVENIO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@NOMBRE_EMPRESA", NOMBRE_EMPRESA);
                cmd.Parameters.AddWithValue("@CEDULA_PROPIETARIO", N_CEDULA);
                cmd.Parameters.AddWithValue("@RUC_EMPRESA", N_RUC);
                cmd.Parameters.AddWithValue("@N_CUENTA_EMPRESA", N_CUENTA);
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
                MessageBox.Show("Convenio ya resgistrado", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public List<csCONENIOS> Lista_Covenios()
        {

            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("SP_LISTA_CONVENIOS", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.abrirCerrarConexion();
            dr = cmd.ExecuteReader();
            List<csCONENIOS> lstAportes = new List<csCONENIOS>();
            csCONENIOS aportes;
            while (dr.Read())
            {
                aportes = new csCONENIOS();
                aportes.NOMBRE_EMPRESA = dr.GetString(0);
                aportes.N_CEDULA = dr.GetString(1);
                aportes.NOMBRES_PROPIETARIO = dr.GetString(2);
                aportes.N_CELULAR = dr.GetString(3);
                aportes.N_RUC = dr.GetString(4);
                aportes.N_CUENTA = dr.GetString(5);
                aportes.N_CIUDAD = dr.GetString(6);
                aportes.N_PORCENTAJE = dr.GetInt32(7);
            }
            return lstAportes;

        }
        public DataSet Listar_CONVENIOS()
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da_Taxitas = new SqlDataAdapter();
            da_Taxitas.SelectCommand = new SqlCommand("select * from CONVENIOS where ESTADO='DISPONIBLE';", conexion.con);
            da_Taxitas.SelectCommand.CommandType = CommandType.Text;
            da_Taxitas.Fill(ds, "NOMBRE_EMPRESA");

            return ds;
        }


        public void EliminarConvenio(string dato)
        {
            try
            {          
                   SqlCommand cmd = new SqlCommand("SP_ELIMINARCONVENIO", conexion.con);
                    conexion.abrirCerrarConexion();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NOMBRE_EMPRESA", dato);
                    cmd.Parameters.AddWithValue("@estado", "NO DISPONIBLE");
                    cmd.ExecuteNonQuery();
                    conexion.abrirCerrarConexion();
                    MessageBox.Show("Se elimino satisfactoriamente","!!Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void VerificarConvenioBauche(string DatoNombre)
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_VERIFICARCONVENIO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Nombre_Empresa", DatoNombre);
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
            catch (Exception ec)
            {
                MessageBox.Show(ec+"");
            }
        }

    }
}
