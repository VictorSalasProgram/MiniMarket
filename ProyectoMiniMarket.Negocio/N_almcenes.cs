using System.Data.SqlClient;
using ProyectoMiniMarket.Entidades;
using ProyectoMiniMarket.Datos;
using System.Data;

namespace ProyectoMiniMarket.Negocio
{
    public class N_almacenes
    {
        public static DataTable Listado_al(string cTexto)
        {
            D_almacenes Datos = new D_almacenes();
            return Datos.Listado_al(cTexto);
        }
        public static string Guardar_al(int nOpcion, E_almacenes oAl)
        {
            D_almacenes Datos = new D_almacenes();
            return Datos.Guardar_al(nOpcion, oAl);
        }
        public static string Eliminar_al(int Codigo_al)
        {
            D_almacenes Datos = new D_almacenes();
            return Datos.Eliminar_al(Codigo_al);
        }
    }
}
