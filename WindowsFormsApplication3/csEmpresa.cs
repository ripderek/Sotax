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
    class csEmpresa
    {
        csConexion conexion = new csConexion();
        private string nom_empresa;
        private  string nom_propietario;
        private string direccion;
        private string ruc;
        private string n_empresa;
        private string fecha;
        private int ID;
        private string cuenta;
        private decimal ap;
        private decimal totalmes;
        public decimal efectivo;

        public decimal APORTES
        {
            get { return ap; }
            set { ap = value; }
        }

        public string N_Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        public int ID_EMPRES
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Nom_Empresa
        {
            get { return nom_empresa; }
            set { nom_empresa = value; }
        }
        public string Nom_Propietario
        {
            get { return nom_propietario; }
            set { nom_propietario = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }
        public string N_Empresa
        {
            get { return n_empresa; }
            set { n_empresa = value; }
        }
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public void InsertarEmpresa()
        {

            try
            {
                CacularMes();
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_INSERTAREMPRESA", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Nom_Empresa", Nom_Empresa);
                cmd.Parameters.AddWithValue("@Nom_Propietario", Nom_Propietario);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.Parameters.AddWithValue("@RUC", Ruc);
                cmd.Parameters.AddWithValue("@N_Empresa",N_Empresa );
                cmd.Parameters.AddWithValue("@Fecha_Fundacion", Fecha);
                cmd.Parameters.AddWithValue("@Cuenta", N_Cuenta);
                cmd.Parameters.AddWithValue("@AporteDiario", APORTES);
                cmd.Parameters.AddWithValue("@AporteMensual", totalmes);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();

                MessageBox.Show("Datos Guardados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Unidad ya resgistrada", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void listarEmpresa()
        {

            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_MOSTRAREMPRESA", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexion
            conexion.abrirCerrarConexion();

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Nom_Empresa = dr.GetString(1);
                Nom_Propietario = dr.GetString(2);
                Direccion = dr.GetString(3);
                Ruc = dr.GetString(4);
                N_Empresa = dr.GetString(5);
                Fecha = dr.GetDateTime(6).ToString();
                N_Cuenta = dr.GetString(7);
                efectivo = dr.GetDecimal(8);
            }
            // Cierra Conexion
            conexion.abrirCerrarConexion();
            dr.Close();
        }

        public void ModificarEmpresa()
        {
            CacularMes();
            //SqlCommand->Ejecutar una sentencia SQL
            SqlCommand cmd = new SqlCommand("SP_MODIFICAREMPRESA", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Abrir conexion
            conexion.abrirCerrarConexion();

            //Asignar parámetros
            cmd.Parameters.AddWithValue("@Nom_Empresa", Nom_Empresa);
            cmd.Parameters.AddWithValue("@Nom_Propietario", Nom_Propietario);
            cmd.Parameters.AddWithValue("@Direccion", Direccion);
            cmd.Parameters.AddWithValue("@RUC", Ruc);
            cmd.Parameters.AddWithValue("@N_Empresa", N_Empresa);
            cmd.Parameters.AddWithValue("@Fecha_Fundacion", Fecha);
            cmd.Parameters.AddWithValue("@Cuenta", N_Cuenta);
            cmd.Parameters.AddWithValue("@AporteDiario", APORTES);
            cmd.Parameters.AddWithValue("@AporteMensual", totalmes);
            //Ejecutar procedure
            cmd.ExecuteNonQuery();

            //Cerrar conexion
            conexion.abrirCerrarConexion();

            //Mensaje
            MessageBox.Show("Datos Modificados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void BUSCAR_ID_EMPRESA()
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
        private void CacularMes()
        {
            DateTime today = DateTime.Today;
            int days = DateTime.DaysInMonth(today.Year, today.Month);
            totalmes = decimal.Parse((days * APORTES).ToString());        
        }
        public void ModificarMENSUAL()
        {
            BUSCAR_APORTES();
            CacularMes();
            //SqlCommand->Ejecutar una sentencia SQL
            SqlCommand cmd = new SqlCommand("SP_ACTUALIZAR_APORTE_MESUAL", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexion
            conexion.abrirCerrarConexion();
            //Asignar parámetros
            cmd.Parameters.AddWithValue("@AporteMensual", totalmes);
            //Ejecutar procedure
            cmd.ExecuteNonQuery();
            //Cerrar conexion
            conexion.abrirCerrarConexion();
            //Mensaje
        }
        private void BUSCAR_APORTES()
        {
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand(string.Format("select AporteDiario  from Empresa"), conexion.con);
            //Tipo de sentencia a ejecutar
            //Abrir conexion
            conexion.abrirCerrarConexion();

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                APORTES = dr.GetDecimal(0);
            }
            // Cierra Conexion
            conexion.abrirCerrarConexion();
            dr.Close();
        }
    }
}
