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
    class csControl_Aportes
    {
        csConexion conexion = new csConexion();
        private string cedula;
        private string apellido;
        private string nombre;
        private string Monto;
        private DateTime fecha = DateTime.UtcNow.Date;
        private string deuda;
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
    
        public string ABONO_TOTAL
        {
            get { return Monto; }
            set { Monto = value; }
        }
        public string DEUDA_TOTAL
        {
            get { return deuda; }
            set { deuda = value; }
        }

        public List<csControl_Aportes> ControlAportes()
        {

            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("SP_CONTROL_APORTES_NUEVO", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;
           
            conexion.abrirCerrarConexion();
            cmd.Parameters.AddWithValue("@Fecha",fecha );
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            List<csControl_Aportes> lstAportes = new List<csControl_Aportes>();
            csControl_Aportes aportes;
            while (dr.Read())
            {
                aportes = new csControl_Aportes();
                aportes.N_Cedula = dr.GetString(0);
                aportes.APELLIDOS = dr.GetString(1);
                aportes.NOMBRES = dr.GetString(2);
                aportes.ABONO_TOTAL = dr.GetDecimal(3).ToString("N2");
                aportes.DEUDA_TOTAL = dr.GetDecimal(4).ToString("N2");  
                lstAportes.Add(aportes);
            }
            return lstAportes;

        }
    }
}
