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
    class csCargos
    {
        csConexion conexion = new csConexion();

        string cargo;
        string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public void InsertarCargo()
        {

            try
            {

                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_INSERTARCARGO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Cargo", Cargo);


                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                MessageBox.Show("Datos Guardados Correctamente", "!!AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("CARGO YA REGISTRADO", "!!ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public DataSet ListarCargos()
        {
            DataSet ds = new DataSet();

            SqlDataAdapter da_Cargos = new SqlDataAdapter();
            da_Cargos.SelectCommand = new SqlCommand("select * from Cargos where Estado = 'Disponible';", conexion.con);
            da_Cargos.SelectCommand.CommandType = CommandType.Text;
            da_Cargos.Fill(ds, "Cargo");
            return ds;
        }


        public void ModificarCargo(int ID)
        {
            //SqlCommand->Ejecutar una sentencia SQL
            SqlCommand cmd = new SqlCommand("SP_ESTADOCARGO", conexion.con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Abrir conexion
            conexion.abrirCerrarConexion();

            //Asignar parámetros
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@Estado", Estado);

            //Ejecutar procedure
            cmd.ExecuteNonQuery();

            //Cerrar conexion
            conexion.abrirCerrarConexion();

        }

        public void BUSCAR_CARGO_ID(string ID_Cargo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select Cargo from Cargos where ID='" + ID_Cargo + "'", conexion.con);
                conexion.abrirCerrarConexion();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                { Cargo = dr.GetString(0); }
                else
                { }
                conexion.abrirCerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable MostarTrabajadorCargo()
        {
            try
            {
                SqlDataAdapter DataGrid = new SqlDataAdapter("SP_LISTARCARGOS", conexion.con);
                DataGrid.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                DataGrid.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
         
        }
        public DataTable CargosDisponibles()
        {
            try 
            {
                SqlDataAdapter DataGrid = new SqlDataAdapter("SP_CARGOSDISPONIBLES", conexion.con);
                DataGrid.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                DataGrid.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
         
        }
        public void EliminarCargo(string dato)
        {
            try 
            {
                SqlCommand cmd = new SqlCommand("SP_ELIMINARCARGO", conexion.con);
                conexion.abrirCerrarConexion();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", dato);
                cmd.ExecuteNonQuery();
                conexion.abrirCerrarConexion();   
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public bool Verificar(DataGridView TablaCargoOcupado,DataGridView TablaCargoDisponible, string F)
        {
            bool verificador = true;
            for (int i = 0; i < TablaCargoOcupado.Rows.Count; i++)
            {
                if (Convert.ToString(TablaCargoOcupado[3, i].Value).ToUpper() == F.ToUpper())
                {
                    verificador = false;
                }
            }
            if (verificador == true)
            {
                for (int i = 0; i < TablaCargoDisponible.Rows.Count; i++)
                {
                    if (Convert.ToString(TablaCargoDisponible[0, i].Value).ToUpper() == F.ToUpper())
                    {
                        verificador = false;
                    }
                }
            }
            return verificador;
        }

    }
}
