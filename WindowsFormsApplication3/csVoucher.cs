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
    class csVoucher
    {
        private DateTime fecha = DateTime.UtcNow.Date;
        private int id_t;
        private int id_e;
        private string n_vou;
        private decimal saldo;
        private int procentaje;
        private decimal valor_final;
        private int exist=0;
        private decimal valor_Taxista;
        private decimal Total;
        public string N_VOCUHER
        {
            get { return n_vou; }
            set { n_vou = value; }
        }
        public int ID_TAXISTA
        {
            get { return id_t; }
            set { id_t = value; }
        }
        public int ID_EMPRESA
        {
            get { return id_e; }
            set { id_e = value; }
        }
        public decimal V_SALDO
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public decimal V_SALDO_TAXISTA
        {
            get { return valor_Taxista; }
            set { valor_Taxista = value; }
        }
        public decimal V_TOTAL
        {
            get { return Total; }
            set { Total = value; }
        }
        csConexion conexion = new csConexion();
        public void Registrar_Transaccion()   
        {
            try
            {
                VerificarExis();
                if (exist == 1)
                {
                    MessageBox.Show("ESTE NÚMERO DE BAUCHE YA SE ENCUENTRA REGISTRADO");
                }
                else
                {
                    CALCULAR_PORCENTAJE();
                    //SqlCommand->Ejecutar una sentencia SQL
                    SqlCommand cmd = new SqlCommand("SP_REGISTRAR_VOCHER", conexion.con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Abrir conexion
                    conexion.abrirCerrarConexion();

                    //Asignar parámetros
                    cmd.Parameters.AddWithValue("@ID_Taxista", ID_TAXISTA);
                    cmd.Parameters.AddWithValue("@ID_EMPRESA", ID_EMPRESA);
                    cmd.Parameters.AddWithValue("@N_Voucher", N_VOCUHER);
                    cmd.Parameters.AddWithValue("@FECHA", fecha);
                    cmd.Parameters.AddWithValue("@SALDO", valor_final);
                    cmd.Parameters.AddWithValue("@SALDO_TAXISTA", V_SALDO_TAXISTA);
                    cmd.Parameters.AddWithValue("@TOTAL", V_TOTAL);
                    //Ejecutar procedure
                    cmd.ExecuteNonQuery();

                    //Cerrar conexion
                    conexion.abrirCerrarConexion();

                    //Mensaje
                    MessageBox.Show("VAUCHE REGISTRADO ", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception n) { MessageBox.Show(n.Message); }
        }

        private void ExtraerPorcentaje()
        {
            //SqlCommand->Ejecutar una sentencia SQL
            SqlCommand cmd = new SqlCommand("SP_EXTRAER_Porcentaje", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexion
            conexion.abrirCerrarConexion();
            //Asignar parámetros
            cmd.Parameters.AddWithValue("@DI", ID_EMPRESA);
            //Ejecutar procedure
            cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                procentaje = (rd.GetInt32(0));
            }
            //Cerrar conexion
            conexion.abrirCerrarConexion();
            rd.Close();
            //MessageBox.Show(procentaje.ToString());

        }
        private void CALCULAR_PORCENTAJE()
        {
            ExtraerPorcentaje();
            int p=100;
            decimal p2 = Convert.ToDecimal(procentaje);
            valor_final = Convert.ToDecimal((((p2) / 100)*V_SALDO).ToString("N2"));
            V_SALDO_TAXISTA = Convert.ToDecimal((V_TOTAL - valor_final).ToString("N2"));
            //MessageBox.Show(valor_final.ToString());
        }
        private void VerificarExis()
        {
            //SqlCommand->Ejecutar una sentencia SQL
            SqlCommand cmd = new SqlCommand("SP_VERIFICAR_VOUCHER", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexion
            conexion.abrirCerrarConexion();
            //Asignar parámetros
            cmd.Parameters.AddWithValue("@N_Voucher", N_VOCUHER);
            //Ejecutar procedure
            cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                exist = 1;
            }

            //Cerrar conexion
            conexion.abrirCerrarConexion();
            rd.Close();
        }
        public void Banco(decimal valor)
        {
            Banco bc = new Banco();
            bc.B_DESCRIPCION = "APORTE VOUCHER";
            bc.B_CREDITO = valor;
            bc.TRANSACCION_BANCO("CRÉDITO");
        }

    }
}
