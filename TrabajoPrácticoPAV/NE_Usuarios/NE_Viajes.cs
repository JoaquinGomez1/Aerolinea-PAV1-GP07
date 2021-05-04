using System.Data;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase.Modelos;

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

        public void InsertViaje(Viaje Viaje)
        {
            string sql = @"INSERT INTO Viaje(horarioPresencia, horarioSalida, horarioLlegada, duracionEstimada) 
                        VALUES(" + $"'{Viaje.HorarioPresencia}', '{Viaje.HorarioSalida}', '{Viaje.HorarioLlegada}', '{Viaje.DuracionEstimada}'" + ")";

            _DB.Insertar(sql);
        }
    }
}
