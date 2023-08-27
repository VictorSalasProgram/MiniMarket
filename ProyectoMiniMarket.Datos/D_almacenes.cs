using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using ProyectoMiniMarket.Entidades;
using System.Security.Cryptography.X509Certificates;

namespace ProyectoMiniMarket.Datos
{
    public class D_almacenes
    {
        public DataTable Listado_al(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SQLCon = new MySqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("USP_Listado_al", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = cTexto;
                SQLCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }
        public string Guardar_al(int nOpcion, E_almacenes oAl)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("USP_Guardar_al", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nOpcion", MySqlDbType.Int32).Value = nOpcion;
                Comando.Parameters.Add("nCodigo_al", MySqlDbType.Int32).Value = oAl.Codigo_al;
                Comando.Parameters.Add("cDescripcion_al", MySqlDbType.VarChar).Value = oAl.Descripcion_al;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo registrar los datos";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public string Eliminar_al(int Codigo_al)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("USP_Eliminar_al", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;

                Comando.Parameters.Add("nCodigo_al", MySqlDbType.Int32).Value = Codigo_al;


                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar los datos";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
