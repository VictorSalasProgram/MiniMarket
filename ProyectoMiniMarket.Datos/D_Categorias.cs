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
    public class D_Categorias
    {
        public DataTable Listado_ca(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection SQLCon = new MySqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("USP_Listado_ca", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("cTexto",MySqlDbType.VarChar).Value=cTexto;
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
                if(SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }
        public string Guardar_ca(int nOpcion, E_Categorias oCa)
        {
            string Rpta = "";
            MySqlConnection SqlCon  = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("USP_Guardar_ca", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nOpcion",MySqlDbType.Int32).Value=nOpcion;
                Comando.Parameters.Add("nCodigo_ca",MySqlDbType.Int32).Value=oCa.Codigo_ca;
                Comando.Parameters.Add("cDescripcion_ca", MySqlDbType.VarChar).Value = oCa.Descripcion_ca;
                
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo registrar los datos"; 
            }
            catch (Exception ex)
            {
                Rpta= ex.Message;
            }
            finally
            {
                if(SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public string Eliminar_ca(int Codigo_ca)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("USP_Eliminar_ca", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                
                Comando.Parameters.Add("nCodigo_ca", MySqlDbType.Int32).Value = Codigo_ca;
                

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
