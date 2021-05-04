using System.Data;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_Viajes
    {
        private readonly Conexion_DB _DB = new Conexion_DB();

        public DataTable GetTodosLosViajes()
        {
            string sql = "SELECT * FROM Viaje";
            DataTable resultadoSelect = _DB.EjecutarSelect(sql);

            return resultadoSelect;
        }
    }
}
