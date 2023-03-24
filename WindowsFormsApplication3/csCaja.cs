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
    class csCaja
    {
        csConexion conexion = new csConexion();
        private string valor_Caja;
        private decimal N_Valor_Caja;
        private string Apell;
        private string Nomb;
        private string cedu;
        private string mot="DEPOSITO EN BANCO";
        private DateTime fecha = DateTime.UtcNow.Date;
        private string tip;
        private int ID_empresa;
        public decimal nuevo;
        public int verificar=0;
        private int ID_EMPRES;
        public string APELLIDO

        {
            get { return Apell; }
            set { Apell = value; }
        }

        public string NOMBRE
        {
            get { return Nomb; }
            set { Nomb = value; }
        }
        public string CEDULA
        {
            get { return cedu; }
            set { cedu = value; }
        }
        public string MOTIVO
        {
            get { return mot; }
            set { mot = value; }
        }

      
        public int ID_EMPRESA
        {
            get { return ID_empresa; }
            set { ID_empresa = value; }
        }

        public string V_CAJA_A
        {
            get { return valor_Caja; }
            set { valor_Caja = value; }
        }
        public decimal N_CAJA
        {
            get { return N_Valor_Caja; }
            set { N_Valor_Caja = value; }
        }

        public void RealizarTransaccion(string tipo)
        {
            try
            {
            ConsultarCaja();
            Banco Credito_Banco = new Banco();
                if (tipo == "RETIRO")
                {
                    nuevo =  (decimal.Parse(V_CAJA_A))-N_CAJA ;
                    MessageBox.Show(nuevo.ToString());
                    double cadena = double.Parse(N_CAJA.ToString());
                    double cadena2 = double.Parse(V_CAJA_A.ToString());
                    double nuevoxD = double.Parse(nuevo.ToString());
                    if ( nuevoxD <=1.00|| cadena2 == 0)
                    {
                        MessageBox.Show("LO SENTIMOS ESTA TRANSACCION NO SE PUEDE LLEVAR A CABO POR QUE CAJA NO PUEDE TENER UN VALOR MENOR O IGUAL A 1.00. O Caja no tiene fondos");
                    }
                    else
                    {
                        tip = "RETIRO";
                        REGISTRAR_TRASACCION();
                        UpdateCaja();
                        Credito_Banco.B_CREDITO = N_CAJA;
                        Credito_Banco.B_DESCRIPCION = "RETIRO CAJA";
                        Credito_Banco.TRANSACCION_BANCO("CREDITO");
                        verificar = 1;
                        
                    }
                }         
            }
            catch (Exception n) 
            {
                MessageBox.Show(n.Message+"  EL VALOR NO PUEDE SER NULO");
            }
        }

        private void UpdateCaja()
        {
            //SqlCommand->Ejecutar una sentencia SQL
            SqlCommand cmd = new SqlCommand("SP_AC_CAJA", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Abrir conexion
            conexion.abrirCerrarConexion();

            //Asignar parámetros
            cmd.Parameters.AddWithValue("@Valor", nuevo);
            //Ejecutar procedure
            cmd.ExecuteNonQuery();

            //Cerrar conexion
            conexion.abrirCerrarConexion();

            //Mensaje
            MessageBox.Show("Datos Modificados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public void ConsultarCaja()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select T_caja from Caja", conexion.con);
                conexion.abrirCerrarConexion();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                { V_CAJA_A = dr.GetDecimal(0).ToString("N2"); }
                conexion.abrirCerrarConexion();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void REGISTRAR_TRASACCION()
        {
            SqlCommand cmd = new SqlCommand("SP_INGRESAR_TRANSACCION", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;
            BUSCAR_ID_EMPRESA();
            //Abrir conexion
            conexion.abrirCerrarConexion();
            //Asignar parámetros
            cmd.Parameters.AddWithValue("@N_APELLIDOS", APELLIDO);
            cmd.Parameters.AddWithValue("@N_NOMBRES", NOMBRE);
            cmd.Parameters.AddWithValue("@N_NCEDULA", CEDULA);
            cmd.Parameters.AddWithValue("@N_MOTIVO", MOTIVO);
            cmd.Parameters.AddWithValue("@N_Fecha", fecha);
            cmd.Parameters.AddWithValue("@N_Efectivo", N_CAJA);
            cmd.Parameters.AddWithValue("@N_TIPO", tip);
            cmd.Parameters.AddWithValue("@id_empresa", ID_EMPRES);
            //Ejecutar procedure
            cmd.ExecuteNonQuery();

            //Cerrar conexion
            conexion.abrirCerrarConexion();

            //Mensaje
            MessageBox.Show("Datos Modificados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BUSCAR_ID_EMPRESA()
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
        public void FACTURAR_MES()
        {
            nuevo = N_CAJA + (decimal.Parse(V_CAJA_A));
            UpdateCaja();
        }

        private void ELIMINAR_DIARIO()
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_DIARIOS", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.abrirCerrarConexion();
            //Ejecutar procedure
            cmd.ExecuteNonQuery();
            conexion.abrirCerrarConexion();
        }
        private void ELIMINAR_BAUCHE()
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_BAUCHES", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.abrirCerrarConexion();
            //Ejecutar procedure
            cmd.ExecuteNonQuery();
            conexion.abrirCerrarConexion();
        }
        private void ELIMINAR_TRANSACCION()
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_TRANSACCIONES", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.abrirCerrarConexion();
            //Ejecutar procedure
            cmd.ExecuteNonQuery();
            conexion.abrirCerrarConexion();
        }
        public void ELIMINAR()
        {
            ELIMINAR_DIARIO();
            ELIMINAR_BAUCHE();
            ELIMINAR_TRANSACCION();
        }
        public void Actualizar_efectivo()
        {
            SqlCommand cmd = new SqlCommand("SP_ACTUALIZAR_EFECTIVO", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.abrirCerrarConexion();
            //Ejecutar procedure
            cmd.ExecuteNonQuery();
            conexion.abrirCerrarConexion();
        }

        public void SumarCaja()
        {
            ConsultarCaja();
            nuevo = N_CAJA + (decimal.Parse(V_CAJA_A));
            MessageBox.Show(nuevo.ToString());
            UpdateCaja();
        }
    }
}
