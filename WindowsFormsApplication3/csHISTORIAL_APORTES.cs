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
    class csHISTORIAL_APORTES
    {
        private DateTime fecha2 = DateTime.UtcNow.Date;
        csConexion conexion = new csConexion();
        private string cedula;
        private string apellido;
        private string nombre;
        private DateTime fecha_s;
        private string N_Comprobante;
        private int N_unidad;
        private string Monto;

        public string N_Cedula
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
            get { return fecha_s; }
            set { fecha_s = value; }
        }
        public string N_COMPROBAN
        {
            get { return N_Comprobante; }
            set { N_Comprobante = value; }
        }
        public string EFECTIVO
        {
            get { return Monto; }
            set { Monto = value; }
        }
        public int UNIDAD
        {
            get { return N_unidad; }
            set { N_unidad = value; }
        }


        public List<csHISTORIAL_APORTES> HistorialAportes()
        {
            
                SqlDataReader dr;
                SqlCommand cmd = new SqlCommand("SP_VER_APORTES_NUEVO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.abrirCerrarConexion();
                cmd.Parameters.AddWithValue("@Fecha", fecha2);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                List<csHISTORIAL_APORTES> lstAportes = new List<csHISTORIAL_APORTES>();
                csHISTORIAL_APORTES aportes;
                while (dr.Read())
                {
                    aportes = new csHISTORIAL_APORTES();
                    aportes.N_Cedula = dr.GetString(1);
                    aportes.APELLIDOS = dr.GetString(2);
                    aportes.NOMBRES = dr.GetString(3);
                    aportes.FECHA = dr.GetDateTime(4);
                    aportes.N_COMPROBAN = dr.GetString(5);
                    aportes.EFECTIVO = dr.GetDecimal(6).ToString("N2");
                    aportes.UNIDAD = dr.GetInt32(7);
                    lstAportes.Add(aportes);
                }
                return lstAportes;
         
        }
        
    }
}
