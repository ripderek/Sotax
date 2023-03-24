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
    class csLISTA_CONVENIOS
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
        public List<csLISTA_CONVENIOS> Lista_Covenios()
        {

            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("SP_LISTA_CONVENIOS", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.abrirCerrarConexion();
            dr = cmd.ExecuteReader();
            List<csLISTA_CONVENIOS> lstAportes = new List<csLISTA_CONVENIOS>();
            csLISTA_CONVENIOS aportes;
            while (dr.Read())
            {
                aportes = new csLISTA_CONVENIOS();
                aportes.NOMBRE_EMPRESA = dr.GetString(0);
                aportes.N_CEDULA = dr.GetString(1);
                aportes.NOMBRES_PROPIETARIO = dr.GetString(2);
                aportes.N_CELULAR = dr.GetString(3);
                aportes.N_RUC = dr.GetString(4);
                aportes.N_CUENTA = dr.GetString(5);
                aportes.N_CIUDAD = dr.GetString(6);
                aportes.N_PORCENTAJE = dr.GetInt32(7);
                lstAportes.Add(aportes);
            }
            return lstAportes;

        }
        

    }
}
