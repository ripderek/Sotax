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
    class Banco
    {
        csConexion conexion = new csConexion();
        private string Descripcion;
        private decimal debito;
        private decimal credito;
        private decimal saldo;
        private int id_c;
        private int lectura=0;
        private DateTime fecha = DateTime.UtcNow.Date;
        private decimal nuevo_saldo;
        public string B_DESCRIPCION
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        public decimal B_DEBITO
        {
            get { return debito; }
            set { debito = value; }
        }
        public decimal B_CREDITO
        {
            get { return credito; }
            set { credito = value; }
        }
        public decimal B_SALDO
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public int ID_COMPAÑIA
        {
            get { return id_c; }
            set { id_c = value; }
        }



        private void ConsultarBanco()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from BANCO", conexion.con);
                conexion.abrirCerrarConexion();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                { lectura = 1; }
                conexion.abrirCerrarConexion();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Consultar_SALDO() 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_CONSULTAR_SALDO", conexion.con);
                conexion.abrirCerrarConexion();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                { B_SALDO = Convert.ToDecimal((dr.GetDecimal(0).ToString("N2"))); }
                conexion.abrirCerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void TRANSACCION_BANCO(string TIPO)
        {
            Consultar_SALDO(); ConsultarBanco();
            if (TIPO == "CREDITO") //SI ES CREDITO SE REGISTRARÁ EN ESE CAMPO Y SE EL NUEVO SALDO SERÁ LA SUMA DE ESTE CREDITO MAS EL ULTIMO SALDO QUE SE REGISTRÓ
            {
                if (lectura == 1) // VERIFICA SI YA HUBO UNA LECTURA ENTONCES NO SERÁ LA PRIMER TRANSACCION
                {
                    nuevo_saldo = B_CREDITO + B_SALDO;
                    B_DEBITO = Convert.ToDecimal("0,00");
                    Registrar_Transaccion();
                }
                else //CASO CONTRARIO SERÁ LA PRIMER TRANSACCION Y EL CREDITO SERÁ LO MISMO QUE EL SALDO
                {
                    nuevo_saldo = B_CREDITO;
                    B_DEBITO = Convert.ToDecimal("0,00");
                    Registrar_Transaccion();
                }
            }
            else  //SI NO ES DE TIPO CREDITO ENTONCES SERÁ DEBITO Y SE REALIZA LO CONTRARIO A LO DE CREDITO
            {
                if (lectura == 1) // VERIFICA SI YA HUBO UNA LECTURA ENTONCES NO SERÁ LA PRIMER TRANSACCION
                {
                    decimal comprobar = B_SALDO - B_DEBITO;
                    if (comprobar <= 1)
                    { MessageBox.Show("ESTA TRANSACCION NO SE PUEDE REALIZAR PORQUE SU SALDO QUEDARÁ MENOR O IGUAL A $1.00"); }
                    else
                    {
                        nuevo_saldo = B_SALDO - B_DEBITO;
                        B_CREDITO = Convert.ToDecimal("0,00");
                        Registrar_Transaccion();
                    }
                }
                else //CASO CONTRARIO SERÁ LA PRIMER TRANSACCION Y EL CREDITO SERÁ LO MISMO QUE EL SALDO
                {
                    MessageBox.Show("NO SE PUEDE REALIZAR RETIROS PORQUE NO HAY SALDO");
                }
            }

        }
        private void Registrar_Transaccion()
        {
            BUSCAR_ID_EMPRESA();
            //SqlCommand->Ejecutar una sentencia SQL
            SqlCommand cmd = new SqlCommand("SP_REGISTRAR_MOVIMIENTO_BANCO", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Abrir conexion
            conexion.abrirCerrarConexion();

            //Asignar parámetros
            cmd.Parameters.AddWithValue("@DESCRIPCION", B_DESCRIPCION);
            cmd.Parameters.AddWithValue("@DEBITO", B_DEBITO);
            cmd.Parameters.AddWithValue("@SALDO", nuevo_saldo);
            cmd.Parameters.AddWithValue("@FECHA", fecha);
            cmd.Parameters.AddWithValue("@CREDITO", B_CREDITO);
            cmd.Parameters.AddWithValue("@ID", ID_COMPAÑIA);
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
                ID_COMPAÑIA = dr.GetInt32(0);
            }
            // Cierra Conexion
            conexion.abrirCerrarConexion();
            dr.Close();
        }
       
    }
}
