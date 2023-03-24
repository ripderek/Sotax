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
    class csTaxista
    {
        csConexion conexion = new csConexion();
        private string n_cedula;
        private string apellidos;
        private string nombres;
        private string celular;
        private string direccion;
        private string sexo;
        private string estudios;
        private string licencia;
        private int ID;
        public MemoryStream ms;
        public int verificar;
        public int consta_diario=0;
        public int consta_bauche=0;
        public int verificarexistencia = 0;
        private decimal valor;
        private string valors = "0,00";
        public int ID_Taxista
        {
            get { return ID; }
            set { ID = value; }
        }



        public string N_Cedula
        {
            get { return n_cedula; }
            set { n_cedula = value; }
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
        public string Licencia
        {
            get { return licencia; }
            set { licencia = value; }
        }

        public void InsertarTaxista(Byte []Foto)
        {

            try
            {

                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_INSERTARTAXISTAS", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@N_Cedula", N_Cedula);
                cmd.Parameters.AddWithValue("@Apellido", Apellidos);
                cmd.Parameters.AddWithValue("@Nombre", Nombres);
                cmd.Parameters.AddWithValue("@Celular", Celular);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.Parameters.AddWithValue("@Sexo", Sexo);
                cmd.Parameters.AddWithValue("@Estudios", Estudios);
                cmd.Parameters.AddWithValue("@Licencia", Licencia);
                cmd.Parameters.AddWithValue("@Foto", Foto);
                cmd.Parameters.AddWithValue("@ESTADO", "DISPONIBLE");
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                MessageBox.Show("Datos Guardados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Unidad ya resgistrada", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public List<csTaxista> listarTaxistas()
        {

            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_MOSTRARTAXISTAS", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexion
            conexion.abrirCerrarConexion();

            dr = cmd.ExecuteReader();

            List<csTaxista> lstTaxista = new List<csTaxista>();
            csTaxista Taxista;
            while (dr.Read())
            {
                Taxista = new csTaxista();
                Taxista.N_Cedula = dr.GetString(1);
                Taxista.Apellidos = dr.GetString(2);
                Taxista.Nombres = dr.GetString(3);
                Taxista.Celular = dr.GetString(4);
                Taxista.Direccion = dr.GetString(5);
                Taxista.Sexo = dr.GetString(6);
                Taxista.Estudios = dr.GetString(7);
                Taxista.Licencia = dr.GetString(8);
                
                lstTaxista.Add(Taxista);
            }
            // Cierra Conexion
            conexion.abrirCerrarConexion();
            dr.Close();
            return lstTaxista;
        }


        public void EliminarTaxista(string cedulaB)
        {
            try
            {
                
                    //SqlCommand->Ejecutar una sentencia SQL
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARTAXISTAS", conexion.con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    //Abrir conexion
                    conexion.abrirCerrarConexion();

                    cmd.Parameters.AddWithValue("@N_Cedula", cedulaB);
                    cmd.Parameters.AddWithValue("@ESTADO", "NO DISPONIBLE");
                    //Ejecutar procedure
                    cmd.ExecuteNonQuery();

                    //Cerrar conexion
                    conexion.abrirCerrarConexion();

                    //Mensaje
                   
            }
            catch (Exception n) 
            {
                MessageBox.Show("EL TAXISTA NO SE PUEDE ELIMINAR PORQUE CONSTA EN APORTES "+n.Message);
            }

            
        }

        public void ModificarTaxista(Byte[] Foto)
        {
            //SqlCommand->Ejecutar una sentencia SQL
            SqlCommand cmd = new SqlCommand("SP_MODIFICARTAXISTAS", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Abrir conexion
            conexion.abrirCerrarConexion();

            //Asignar parámetros
            cmd.Parameters.AddWithValue("@N_Cedula", N_Cedula);
            cmd.Parameters.AddWithValue("@Apellido", Apellidos);
            cmd.Parameters.AddWithValue("@Nombre", Nombres);
            cmd.Parameters.AddWithValue("@Celular", Celular);
            cmd.Parameters.AddWithValue("@Direccion", Direccion);
            cmd.Parameters.AddWithValue("@Sexo", Sexo);
            cmd.Parameters.AddWithValue("@Estudios", Estudios);
            cmd.Parameters.AddWithValue("@Licencia", Licencia);
            cmd.Parameters.AddWithValue("@Foto", Foto);
            cmd.Parameters.AddWithValue("@ID", ID_Taxista);
            //Ejecutar procedure
            cmd.ExecuteNonQuery();

            //Cerrar conexion
            conexion.abrirCerrarConexion();

            //Mensaje
            MessageBox.Show("Datos Modificados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public DataSet ListarTaxitasCedu()
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da_Taxitas = new SqlDataAdapter();
            da_Taxitas.SelectCommand = new SqlCommand("select * from Taxistas where Estado='DISPONIBLE';", conexion.con);
            da_Taxitas.SelectCommand.CommandType = CommandType.Text;
            da_Taxitas.Fill(ds, "N_Cedula");

            return ds;
        }


        public void BuscarTaxista( string cedulax)
        {

            SqlCommand cmd = new SqlCommand(string.Format("Select N_Cedula,Apellido,Nombre,Celular,Direccion,Sexo,Estudios,Licencia,ID from Taxistas Where N_Cedula = '{0}'", cedulax), conexion.con);
            
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
                licencia = rd.GetString(7);
                ID_Taxista = rd.GetInt32(8);

            }

            //Cerrar Conexion
            conexion.abrirCerrarConexion();
            rd.Close();



        }
        public void BuscarID(string cedulax)
        {
            SqlCommand cmd = new SqlCommand(string.Format("Select  ID from Taxistas Where N_Cedula = '{0}'", cedulax), conexion.con);

            //Abrir conexion
            conexion.abrirCerrarConexion();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ID_Taxista = rd.GetInt32(0);
            }

            //Cerrar Conexion
            conexion.abrirCerrarConexion();
            rd.Close();
        }

        public void VerImagen(string cedulaA, PictureBox picFoto)
        {
            try
            {

            SqlCommand cmd = new SqlCommand(string.Format("Select Foto from Taxistas Where N_Cedula = '{0}'", cedulaA), conexion.con);

            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet("Foto");
            dp.Fill(ds,"Foto");
            byte[] Datos = new byte[0];
            DataRow DR = ds.Tables["Foto"].Rows[0];
            Datos = (byte[])DR["Foto"];
            ms = new MemoryStream(Datos);

            }
            catch (Exception)   
            {
                MessageBox.Show("Cedula no registrada","!!Advertencia!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                picFoto.Image = null;
            }
            //hola.Image = System.Drawing.Bitmap.FromStream(ms);
        }

        public void VerificarExistencia(string N_Cedula, string mensaje = "CEDULA YA REGISTRADA")
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select N_Cedula from  Taxistas where N_Cedula='" + N_Cedula + "'", conexion.con);
                conexion.abrirCerrarConexion();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                { MessageBox.Show(mensaje); verificar = 0; }
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
        private void VERIFICAR_SI_CONSTA_DIARIO()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select ID_Taxista  from APORTES_DIARIOS where ID_Taxista='" + ID_Taxista + "'", conexion.con);
                conexion.abrirCerrarConexion();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                { consta_diario = 1; }
                else
                {
                    consta_diario = 0;
                }
                conexion.abrirCerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void VERIFICAR_SI_CONSTA_BAUCHE()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select ID_Taxista from APORTES_BUACHES where ID_Taxista='" + ID_Taxista + "'", conexion.con);
                conexion.abrirCerrarConexion();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                { consta_bauche = 1; }
                else
                {
                    consta_bauche = 0;
                }
                conexion.abrirCerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public void VerificarExistencia()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select N_Cedula from  Taxistas where N_Cedula='" + N_Cedula + "'", conexion.con);
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
        public void VerificarValor()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_VERIFICAR_0", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@N_Cedula", N_Cedula);


                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    valor = rd.GetDecimal(0);
                }
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                rd.Close();
                MessageBox.Show(valor.ToString());

            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message);
            }
        }
        private void Eliminar_de_Aportes()
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_APORTE_0", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Abrir conexion
            conexion.abrirCerrarConexion();

            //Asignar parámetros
            cmd.Parameters.AddWithValue("@ID_T", ID_Taxista);
            //Ejecutar procedure
            cmd.ExecuteNonQuery();

            //Cerrar conexion
            conexion.abrirCerrarConexion();

        }



    }
}
