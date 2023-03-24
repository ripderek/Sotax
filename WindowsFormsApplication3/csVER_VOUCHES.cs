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
    class csVER_VOUCHES
    {
        private DateTime fecha2 = DateTime.UtcNow.Date;
        csConexion conexion = new csConexion();
        private string empresa;
        private string cedula;
        private string comprobante;
        private DateTime fecha;
        private decimal saldo;
        private string numero;
        private decimal saldo_Taxista;
        private decimal Total;

        public string V_EMPRESA
        {
            get { return empresa; }
            set { empresa = value; }
        }
        public string V_CEDULA
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string V_COMPROBANTE
        {
            get { return comprobante; }
            set { comprobante = value; }
        }
        public string V_NUMERO
        {
            get { return numero; }
            set { numero = value; }
        }
        public DateTime V_FECHA
        {
            get { return fecha; }
            set { fecha= value; }
        }
        public Decimal V_SALDO
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public Decimal V_SALDO_TAXISTA
        {
            get { return saldo_Taxista; }
            set { saldo_Taxista = value; }
        }
        public Decimal V_TOTAL
        {
            get { return Total; }
            set { Total = value; }
        }
        public List<csVER_VOUCHES> HistorialAportes_Bauches()
        {

            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("SP_VER_VOUCHER_NUEVO", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.abrirCerrarConexion();
            cmd.Parameters.AddWithValue("@Fecha", fecha2);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            List<csVER_VOUCHES> lstAportes = new List<csVER_VOUCHES>();
            csVER_VOUCHES aportes;
            while (dr.Read())
            {
                aportes = new csVER_VOUCHES();
                aportes.V_EMPRESA = dr.GetString(0);
                aportes.V_CEDULA = dr.GetString(1);
                aportes.V_COMPROBANTE = dr.GetString(2);
                aportes.V_FECHA = dr.GetDateTime(3);
                aportes.V_SALDO = Convert.ToDecimal(dr.GetDecimal(4).ToString("N2"));
                aportes.V_NUMERO = dr.GetString(5);
                aportes.V_SALDO_TAXISTA = Convert.ToDecimal(dr.GetDecimal(6).ToString("N2"));
                aportes.V_TOTAL = Convert.ToDecimal(dr.GetDecimal(7).ToString("N2"));
                lstAportes.Add(aportes);
            }
            return lstAportes;

        }
    }
}
