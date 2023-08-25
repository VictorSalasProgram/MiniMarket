using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyectoMiniMarket.Entidades;
using ProyectoMiniMarket.Datos;

namespace ProyectoMiniMarket.Negocio
{
    public class N_unidades_medidas
    {
        public static DataTable Listado_um(string cTexto)
        {
            D_unidades_medidas Datos = new D_unidades_medidas();
            return Datos.Listado_um(cTexto);
        }
        public static string Guardar_um(int nOpcion, E_unidades_medidas uOm)
        {
            D_unidades_medidas Datos = new D_unidades_medidas();
            return Datos.Guardar_um(nOpcion, uOm);
        }
        public static string Eliminar_ma(int Codigo_ma)
        {
            D_unidades_medidas Datos = new D_unidades_medidas();
            return Datos.Eliminar_um(Codigo_ma);
        }
    }
}
