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
    class csHistorialTransacciones
    {
        csConexion conexion = new csConexion();
        private string comprobante;
        private string cedula;
        private string nombres;
        private string apellidos;
        private string motivo;
        private DateTime fecha;
        private string efetivo;
        private string tipo;

        public string C_COMPROBANTE
        {
            get { return comprobante; }
            set { comprobante= value; }
        }
        public string APELLIDOS
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string NOMBRES
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string N_CEDULA
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string MOTIVO
        {
            get { return motivo; }
            set { motivo = value; }
        }
        public DateTime FECHA_S
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string EFECTIVO
        {
            get { return efetivo; }
            set { efetivo = value; }
        }
        public string TIPO_S
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public List<csHistorialTransacciones> HistorialAportes()
        {

            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("select * from TRASACCIONES_CAJA_N", conexion.con);
            conexion.abrirCerrarConexion();
            dr = cmd.ExecuteReader();
            List<csHistorialTransacciones> lstAportes = new List<csHistorialTransacciones>();
            csHistorialTransacciones aportes;
            while (dr.Read())
            {
                aportes = new csHistorialTransacciones();
                aportes.C_COMPROBANTE = dr.GetString(1);
                aportes.APELLIDOS = dr.GetString(2);
                aportes.NOMBRES = dr.GetString(3);
                aportes.N_CEDULA = dr.GetString(4).ToString();
                aportes.MOTIVO = dr.GetString(5);
                aportes.FECHA_S = dr.GetDateTime(6);
                aportes.EFECTIVO = dr.GetDecimal(7).ToString("N2");
                aportes.TIPO_S = dr.GetString(8);
                lstAportes.Add(aportes);
            }
            return lstAportes;

        }

    }
}
