using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication3
{
    class csUsuarios
    {
        string usuario;
        string contraseña;
        string pregunta;
        string respuesta;
        csConexion conexion = new csConexion();
        public int Login = 0;
        string tipo;
        public string TipoUsuario;


        public string USUARIO
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string CONTRASEÑA
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        public string PREGUNTA
        {
            get { return pregunta; }
            set { pregunta = value; }
        }

        public string RESPUESTA
        {
            get { return respuesta; }
            set { respuesta = value; }
        }

        public string TIPOUSUARIO
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public void REGISTRAR_USUARIO()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIOS", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.abrirCerrarConexion();
                cmd.Parameters.AddWithValue("@Usuario", USUARIO);
                cmd.Parameters.AddWithValue("@Contraseña", CONTRASEÑA);
                cmd.Parameters.AddWithValue("@Preguntas", PREGUNTA);
                cmd.Parameters.AddWithValue("@Respuestas", RESPUESTA);
                cmd.Parameters.AddWithValue("@Tipo", TIPOUSUARIO);
                cmd.ExecuteNonQuery();
                conexion.abrirCerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void VERIFICAR_USUARIO(string U_suario, string C_ontrasena)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("select Usuario , Convert (varchar(max), DECRYPTBYPASSPHRASE ('Sotax1',Contrasena)) as Contrasena , Tipo from Usuario where Usuario = '"+U_suario+"'", conexion.con);
                conexion.abrirCerrarConexion();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (C_ontrasena == dr.GetString(1))
                    {

                    Login = 1; TipoUsuario = dr.GetString(2); 

                    }
                    
                }
                else
                { 
                    Login = 0; 
                }
                conexion.abrirCerrarConexion();
            }
            catch (Exception e)  
            {
                MessageBox.Show(e.Message);
            }
        }

        public void BuscarUsuario(string B_Usuario)
        {
            try 
            {
                SqlCommand cmd = new SqlCommand("select Usuario , Preguntas , Convert (varchar(max), DECRYPTBYPASSPHRASE ('Sotax2',Respuestas)) as Respuestas from Usuario where Usuario = '"+B_Usuario+"'", conexion.con);
                conexion.abrirCerrarConexion();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {USUARIO=dr.GetString(0) ;PREGUNTA = dr.GetString(1); RESPUESTA = dr.GetString(2); }
                else
                { MessageBox.Show("USUARIO NO ENCONTRADO"); }
                conexion.abrirCerrarConexion();
            }
            catch (Exception n) 
            {
                MessageBox.Show(n.Message);
            }
        }

        public void RecuperarContra( string User, string Contra)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SE_RECUPERARCONTRASEÑA1", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.abrirCerrarConexion();
                cmd.Parameters.AddWithValue("@Contraseña", Contra);
                cmd.Parameters.AddWithValue("@Usuario", User);
                cmd.ExecuteNonQuery();
                conexion.abrirCerrarConexion();
            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message);
            }
            
        }

        public DataSet ListarUsuarios()
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da_Trabajador = new SqlDataAdapter();
            da_Trabajador.SelectCommand = new SqlCommand("select * from Usuario;", conexion.con);
            da_Trabajador.SelectCommand.CommandType = CommandType.Text;
            da_Trabajador.Fill(ds, "Usuario");

            return ds;
        }
    }
}
