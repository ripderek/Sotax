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
    class csTrabajador
    {
        csConexion conexion = new csConexion();
        string n_cedula;
        string apellidos;
        string nombres;
        string celular;
        string direccion;
        string sexo;
        string estudios;
        int cargo;
        public MemoryStream ms;
        public int verificar = 0;
        string cTemporal;
        public int ID_T;
        public string N_Cedula
        {
            get { return n_cedula; }
            set { n_cedula = value; }
        }

        public string C_TEMPORAL
        {
            get { return cTemporal; }
            set { cTemporal = value; }
        }


        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Estudios
        {
            get { return estudios; }
            set { estudios = value; }
        }
        public int Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }


        public void InsertarTrabajador(Byte[] Foto)
        {

            try
            {

                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_INSERTARTRABAJADOR", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@N_Cedula", N_Cedula);
                cmd.Parameters.AddWithValue("@Apellidos", Apellidos);
                cmd.Parameters.AddWithValue("@Nombres", Nombres);
                cmd.Parameters.AddWithValue("@Celular", Celular);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.Parameters.AddWithValue("@Sexo", Sexo);
                cmd.Parameters.AddWithValue("@Estudios", Estudios);
                cmd.Parameters.AddWithValue("@Cargo", Cargo);
                cmd.Parameters.AddWithValue("@Foto", Foto);
            
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();

                csCargos objCargos = new csCargos();
                objCargos.Estado = "Ocupado";
                objCargos.ModificarCargo(Cargo);

                MessageBox.Show("Datos Guardados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Unidad ya resgistrada", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public List<csTrabajador> listarTrabajador()
        {

            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_MOSTRARTRABAJADOR", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexion
            conexion.abrirCerrarConexion();

            dr = cmd.ExecuteReader();

            List<csTrabajador> lstTrabajador = new List<csTrabajador>();
            csTrabajador Trabajador;
            while (dr.Read())
            {
                Trabajador = new csTrabajador();
                Trabajador.N_Cedula = dr.GetString(1);
                Trabajador.Apellidos = dr.GetString(2);
                Trabajador.Nombres = dr.GetString(3);
                Trabajador.Celular = dr.GetString(4);
                Trabajador.Direccion = dr.GetString(5);
                Trabajador.Sexo = dr.GetString(6);
                Trabajador.Estudios = dr.GetString(7);
                Trabajador.Cargo = dr.GetInt32(8);

                lstTrabajador.Add(Trabajador);
            }
            // Cierra Conexion
            conexion.abrirCerrarConexion();
            dr.Close();
            return lstTrabajador;
        }



        public void EliminarTrabajador(string cedulaB)
        {
            //SqlCommand->Ejecutar una sentencia SQL
            SqlCommand cmd = new SqlCommand("SP_ELIMINARTRABAJADOR", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Abrir conexion
            conexion.abrirCerrarConexion();

            cmd.Parameters.AddWithValue("@N_Cedula", cedulaB);

            //Ejecutar procedure
            cmd.ExecuteNonQuery();

            //Cerrar conexion
            conexion.abrirCerrarConexion();

            csCargos objCargos = new csCargos();
            objCargos.Estado = "Disponible";
            objCargos.ModificarCargo(Cargo);

            //Mensaje
            MessageBox.Show("Datos Eliminados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        public void ModificarTrabajador(Byte[] Foto)
        {
            //SqlCommand->Ejecutar una sentencia SQL
            SqlCommand cmd = new SqlCommand("SP_MODIFICARTRABAJADORES", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Abrir conexion
            conexion.abrirCerrarConexion();

            //Asignar parámetros
            cmd.Parameters.AddWithValue("@N_Cedula", N_Cedula);
            cmd.Parameters.AddWithValue("@Apellidos", Apellidos);
            cmd.Parameters.AddWithValue("@Nombres", Nombres);
            cmd.Parameters.AddWithValue("@Celular", Celular);
            cmd.Parameters.AddWithValue("@Direccion", Direccion);
            cmd.Parameters.AddWithValue("@Sexo", Sexo);
            cmd.Parameters.AddWithValue("@Estudios", Estudios);
            cmd.Parameters.AddWithValue("@Foto", Foto);
            cmd.Parameters.AddWithValue("@ID", ID_T);
            //Ejecutar procedure
            cmd.ExecuteNonQuery();

            //Cerrar conexion
            conexion.abrirCerrarConexion();

            //Mensaje
            MessageBox.Show("Datos Modificados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public DataSet ListarTrabajadorCedu()
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da_Trabajador = new SqlDataAdapter();
            da_Trabajador.SelectCommand = new SqlCommand("select * from Trabajadores;", conexion.con);
            da_Trabajador.SelectCommand.CommandType = CommandType.Text;
            da_Trabajador.Fill(ds, "N_Cedula");

            return ds;
        }


        public void BuscarTrabajador(string cedulax)
        {

            SqlCommand cmd = new SqlCommand(string.Format("Select N_Cedula,Apellidos,Nombres,Celular,Direccion,Sexo,Estudios,Cargo,ID from Trabajadores Where N_Cedula = '{0}'", cedulax), conexion.con);

            //Abrir conexion
            conexion.abrirCerrarConexion();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                N_Cedula = rd.GetString(0);
                Apellidos = rd.GetString(1);
                Nombres = rd.GetString(2);
                Celular = rd.GetString(3);
                Direccion = rd.GetString(4);
                Sexo = rd.GetString(5);
                Estudios = rd.GetString(6);
                Cargo = rd.GetInt32(7);
                ID_T = rd.GetInt32(8);
            }

            //Cerrar Conexion
            conexion.abrirCerrarConexion();
            rd.Close();
        }


        public void VerImagen(string cedulaA)
        {
            try
            {

                SqlCommand cmd = new SqlCommand(string.Format("Select Foto from Trabajadores Where N_Cedula ='{0}'", cedulaA), conexion.con);

                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet("Foto");
                dp.Fill(ds, "Foto");
                byte[] Datos = new byte[0];
                DataRow DR = ds.Tables["Foto"].Rows[0];
                Datos = (byte[])DR["Foto"];
                ms = new MemoryStream(Datos);

            }
            catch (Exception)
            {
                MessageBox.Show("Cedula no registrada", "!!Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void VerificarExistencia()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select N_Cedula from  Trabajadores where N_Cedula='" + N_Cedula + "'", conexion.con);
                conexion.abrirCerrarConexion();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                { MessageBox.Show("CEDULA YA REGISTRADA"); }
                else
                { 
                    verificar = 1; 
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
