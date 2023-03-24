using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    class csConexion
    {
       private  string server;
       private string baseDeDatos;
       private string usuario;
       private string clave;
       private string FechaFormateada;
        public SqlConnection con;
        public int Pasar ;
        private int mesp;
        public int a = 0;
        public int bloque0 = 0;

        public csConexion()
        {
            Server = ".";
            BaseDeDatos = "Sotax";
            Usuario = "sa";
            Clave = "1234";

            con = new SqlConnection();
            con.ConnectionString = "Server=" + "." + ";DataBase=" + BaseDeDatos
                + ";User id=" + Usuario + ";Password=" + Clave;
        }
        public string Server
        {
            get { return server; }
            set { server = value; }
        }
        public string BaseDeDatos
        {
            get { return baseDeDatos; }
            set { baseDeDatos = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public bool abrirCerrarConexion()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();
            }
            return true;
        }

        public void AbrirConexion()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Open();
            }
            else
            {
                con.Open();
            }
            
        }
        public void CerrarConexion()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                con.Close();
            }
            else
            {
                con.Close();
            }
        }

        public void  LeerConfig(string config="1")
        {
            
            try
            {
                StreamReader archivo = new StreamReader(@"..\Config.txt");
                string linea;
                string[] vector; 
                while ((linea = archivo.ReadLine()) != null)
                {
                    vector = linea.Split('-');
                    if (vector[0] == config || vector[0] == "11" )
                    { Pasar = 1; }
                    else
                    { Pasar = 0; }
                }
                archivo.Close();
            }
            catch (Exception n)
            {
                MessageBox.Show("EL ARCHIVO CONFIG A SIDO SOBREESCRITO O NO EXISTE"+n);
            }
        }

        //Mes
        public void EscribirConfig(string Config = "1")
        {
            try
            {
                StreamWriter archivop = new StreamWriter(@"..\Config.txt");
                archivop.WriteLine(Config);
                archivop.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("EL ARCHIVO CONFIG A SIDO SOBREESCRITO O NO EXISTE" + e);
            }
          
        }
        public void EscribirMES()
        {
            DateTime fecha = DateTime.Now;
            FechaFormateada = fecha.ToString("MMMM") + " del " + fecha.ToString("yyyy");
            try
            {
                StreamWriter archivop = new StreamWriter(@"..\Mes.txt");
                archivop.WriteLine(FechaFormateada);
                archivop.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("EL ARCHIVO CONFIG A SIDO SOBREESCRITO O NO EXISTE" + e);
            }

        }
        public void verificarMES()
        {
            DateTime fecha = DateTime.Now;
            FechaFormateada = fecha.ToString("MMMM") + " del " + fecha.ToString("yyyy");
        }
        public void LeerMES()
        {
            verificarMES();
            try
            {
                StreamReader archivo = new StreamReader(@"..\Mes.txt");
                string linea;
                string[] vector;
                while ((linea = archivo.ReadLine()) != null)
                {
                    vector = linea.Split('-');
                    if (vector[0] != FechaFormateada)
                    { csEmpresa empresa = new csEmpresa();
                    empresa.ModificarMENSUAL();               
                    } //AQUI TENDRIA QUE ACTUALIZAR LO QUE DEBE CADA TAXISTA OSEA ACTUALIZAR EL APORTE DIARIO*MES
                    else
                    { }                 
                }
                archivo.Close();
                EscribirMES();
            }
            catch (Exception n)
            {
                MessageBox.Show("EL ARCHIVO MES A SIDO SOBREESCRITO O NO EXISTE" + n);
            }
        }
        public void CERRAR_MES()
        {
            
            DateTime today = DateTime.Today;
            int days = (DateTime.DaysInMonth(today.Year, today.Month))-2;
            int diaSemana = int.Parse(DateTime.Now.ToString("dd"));
            if (diaSemana>=days)
            { a = 1; }        
        }
        public void EscribirFC(int accion=0)
        {
            if (accion == 1)
            {
                try
                {
                    StreamWriter archivop = new StreamWriter(@"..\FC.txt");
                    archivop.WriteLine(1);
                    archivop.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("EL ARCHIVO CONFIG A SIDO SOBREESCRITO O NO EXISTE" + e);
                }
            }
            else
            {
                int diaSemana = int.Parse(DateTime.Now.ToString("dd"));
                if (diaSemana <=2)
                { 
                try
                {
                    StreamWriter archivop = new StreamWriter(@"..\FC.txt");
                    archivop.WriteLine(0);
                    archivop.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("EL ARCHIVO CONFIG A SIDO SOBREESCRITO O NO EXISTE" + e);
                }
                }  
            }

        }
        public void LeerFC()
        {
            try
            {
                StreamReader archivo = new StreamReader(@"..\FC.txt");
                string linea;
                string[] vector;
                while ((linea = archivo.ReadLine()) != null)
                {
                        vector = linea.Split('-');
                        if (vector[0] == "1")
                        {
                            bloque0 = 1;
                        }
                }
                archivo.Close();
            }
            catch (Exception n)
            {
                MessageBox.Show("EL ARCHIVO MES A SIDO SOBREESCRITO O NO EXISTE" + n);
            }
        }
    }
}
