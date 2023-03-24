using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    class csTaxi
    {
        csConexion conexion = new csConexion();
        private int n_unidad=0;
        private string modelo="none";
        private string marca="none";
        private string n_placa="none";
        private int cilindraje=0;
        private int año=0;
        private string n_motor = "none";
        public int veridicar = 0;
        public int verificarp = 0;

        public int N_Unidad
        {
            get { return n_unidad; }
            set { n_unidad = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string N_Placa
        {
            get { return n_placa; }
            set { n_placa = value; }
        }
        public int Cilindraje
        {
            get { return cilindraje; }
            set { cilindraje = value; }
        }
        public int Año
        {
            get { return año; }
            set { año = value; }
        }
        public string N_Motor
        {
            get { return n_motor; }
            set { n_motor = value; }
        }

        public void insertarTaxi()
        {

            try
            {

                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_INSERTARTAXI", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@N_Unidad", N_Unidad);
                cmd.Parameters.AddWithValue("@Modelo", Modelo);
                cmd.Parameters.AddWithValue("@Marca", Marca);
                cmd.Parameters.AddWithValue("@N_Placa", N_Placa);
                cmd.Parameters.AddWithValue("@Cilindraje", Cilindraje);
                cmd.Parameters.AddWithValue("@Año", Año);
                cmd.Parameters.AddWithValue("@N_Motor", N_Motor);

                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                MessageBox.Show("Datos Guardados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception )
            {
                MessageBox.Show("Unidad ya resgistrada","!!ADVERTENCIA!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public List<csTaxi> listarTaxis()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_MOSTRARTAXI", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç

            //conexion.abrirCerrarConexion();
            conexion.AbrirConexion();


            dr = cmd.ExecuteReader();

            List<csTaxi> lstTaxi = new List<csTaxi>();
            csTaxi taxi;
            while (dr.Read())
            {
                taxi = new csTaxi();
                taxi.N_Unidad = dr.GetInt32(1);
                taxi.Modelo = dr.GetString(2);
                taxi.Marca = dr.GetString(3);
                taxi.N_Placa = dr.GetString(4);
                taxi.Cilindraje = dr.GetInt32(5);
                taxi.Año = dr.GetInt32(6);
                taxi.N_Motor = dr.GetString(7);
                lstTaxi.Add(taxi);
            }
            // Cierra Conexion
            conexion.CerrarConexion();
            //conexion.abrirCerrarConexion();
            dr.Close();
            return lstTaxi;
        }
       
        public void EliminarTaxis(int unidad)
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_ELIMINARTAXI", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                cmd.Parameters.AddWithValue("@N_Unidad", unidad);

                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();

                //Mensaje
                MessageBox.Show("Datos Eliminados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception n)
            { MessageBox.Show("ESTA UNIDAD NO PUEDE SER ELIMINADA PORQUE CONSTA EN APORTES "); }
        }


        public void ModificarTaxi()
        {
            //SqlCommand->Ejecutar una sentencia SQL
            SqlCommand cmd = new SqlCommand("SP_MODIFICARTAXI", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Abrir conexion
            conexion.abrirCerrarConexion();

            //Asignar parámetros
            cmd.Parameters.AddWithValue("@N_Unidad", N_Unidad);
            cmd.Parameters.AddWithValue("@Modelo", Modelo);
            cmd.Parameters.AddWithValue("@Marca", Marca);
            cmd.Parameters.AddWithValue("@N_Placa", N_Placa);
            cmd.Parameters.AddWithValue("@Cilindraje", Cilindraje);
            cmd.Parameters.AddWithValue("@Año", Año);
            cmd.Parameters.AddWithValue("@N_Motor", N_Motor);

            //Ejecutar procedure
            cmd.ExecuteNonQuery();

            //Cerrar conexion
            conexion.abrirCerrarConexion();

            //Mensaje
            MessageBox.Show("Datos Modificados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DataSet ListarTaxisXD()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da_Taxitas = new SqlDataAdapter();
            da_Taxitas.SelectCommand = new SqlCommand("select * from Taxi where not N_Unidad=0;", conexion.con);
            da_Taxitas.SelectCommand.CommandType = CommandType.Text;
            da_Taxitas.Fill(ds, "N_Unidad");
            return ds;
        }
        public void VerificarExistencia(string mensaje="")
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select N_Unidad from  Taxi where N_Unidad='" + N_Unidad + "'", conexion.con);
                conexion.abrirCerrarConexion();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                { MessageBox.Show("ESTA UNIDAD SE ENCUENTRA REGISTRADA"+mensaje); }
                else
                {
                    veridicar = 1;

                }
                conexion.abrirCerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void VerificarPLACA()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select N_Placa from  Taxi where N_Placa='" + N_Placa + "'", conexion.con);
                conexion.abrirCerrarConexion();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                { MessageBox.Show("LA PLACA YA HA SIDO REGISTRADA, INTENTE DE NUEVO"); }
                else
                {
                    verificarp  = 1;

                }
                conexion.abrirCerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


    }
}
