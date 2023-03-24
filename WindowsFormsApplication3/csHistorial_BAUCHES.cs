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
    class csHistorial_BAUCHES
    {
        private DateTime fecha2 = DateTime.UtcNow.Date;
        csConexion conexion = new csConexion();
        private string cedula;  
        private string apellido; 
        private string nombre; 
        private string comprobante;
        private string n_bauche;
        private string empresa;
        private string origen;
        private string destino;
        private DateTime fecha;  
        private string monto;  
        private int unidad; 
        public string N_CEDULA
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string APELLIDOS
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string NOMBRES
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public DateTime FECHA
        {
            get { return fecha; }
            set { fecha= value; }
        }
        public string EFECTIVO
        {
            get { return monto; }
            set { monto = value; }
        }
        public int UNIDAD
        {
            get { return unidad; }
            set { unidad = value; }
        }
        public string B_COMPROBANTE
        {
            get { return comprobante; }
            set { comprobante = value; }
        }
        public string BAUCHE
        {
            get { return n_bauche; }
            set { n_bauche = value; }
        }
        public string N_EMPRESA
        {
            get { return empresa; }
            set { empresa = value; }
        }
        public string B_ORIGEN
        {
            get { return origen; }
            set { origen = value; }
        }
        public string B_DESTINO
        {
            get { return destino; }
            set { destino = value; }
        }

        public List<csHistorial_BAUCHES> HistorialAportes_Bauches()
        {

            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("SP_HISTORIAL_APORTES_BAUCHES_NUEVO", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.abrirCerrarConexion();
            cmd.Parameters.AddWithValue("@Fecha", fecha2);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            List<csHistorial_BAUCHES> lstAportes = new List<csHistorial_BAUCHES>();
            csHistorial_BAUCHES aportes;
            while (dr.Read())
            {
                aportes = new csHistorial_BAUCHES();
                aportes.N_CEDULA = dr.GetString(1);
                aportes.APELLIDOS = dr.GetString(2);
                aportes.NOMBRES = dr.GetString(3);
                aportes.B_COMPROBANTE = dr.GetString(4);
                aportes.BAUCHE = dr.GetString(5);
                aportes.N_EMPRESA = dr.GetString(6);
                aportes.B_ORIGEN = dr.GetString(7);
                aportes.B_DESTINO = dr.GetString(8);
                aportes.FECHA = dr.GetDateTime(9);
                aportes.EFECTIVO = dr.GetDecimal(10).ToString("N2");
                aportes.UNIDAD = dr.GetInt32(11);
                lstAportes.Add(aportes);
            }
            return lstAportes;

        }

    }
}
