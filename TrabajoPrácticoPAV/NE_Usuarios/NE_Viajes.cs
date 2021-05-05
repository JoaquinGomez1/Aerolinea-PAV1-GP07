<<<<<<< HEAD
﻿using System.Data;
=======
﻿using System;
using System.Data;
using System.Windows.Forms;
>>>>>>> a26b86a37370bee6d4be2245e8c524893959a9e0
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
<<<<<<< HEAD
=======

        public void InsertViaje(Viaje Viaje)
        {
            string sql = @"INSERT INTO Viaje(horarioPresencia, horarioSalida, horarioLlegada, duracionEstimada) 
                        VALUES(" + $"'{Viaje.HorarioPresencia}', '{Viaje.HorarioSalida}', '{Viaje.HorarioLlegada}', '{Viaje.DuracionEstimada}'" + ")";

            _DB.Insertar(sql);
        }

        public Viaje GetViajePorId(string id)
        {
            string sql = $"SELECT * FROM Viaje WHERE numeroDeViaje = {id}";
            DataTable valores = _DB.EjecutarSelect(sql);

            Viaje viaje = new Viaje()
            {
                NumeroDeViaje = Int32.Parse(valores.Rows[0]["numeroDeViaje"].ToString()),
                HorarioLlegada = valores.Rows[0]["horarioLlegada"].ToString(),
                HorarioSalida = valores.Rows[0]["horarioSalida"].ToString(),
                HorarioPresencia = valores.Rows[0]["horarioPresencia"].ToString(),
                DuracionEstimada = Int32.Parse(valores.Rows[0]["duracionEstimada"].ToString()),
            };

            return viaje;
        }

        public void EliminarFila(Object valorCelda)
        {
            string sql = $"DELETE FROM Viaje WHERE numeroDeViaje = {valorCelda}";
            _DB.Borrar(sql);
        }

        public void ModificarPorId(Viaje viaje)
        {
            string sql = $"UPDATE Viaje SET horarioSalida = '{viaje.HorarioSalida}', horarioLlegada = '{viaje.HorarioLlegada}', horarioPresencia = '{viaje.HorarioPresencia}', duracionEstimada = '{viaje.DuracionEstimada}' WHERE numeroDeViaje = {viaje.NumeroDeViaje}";
            _DB.Modificar(sql);
        }

        public string determinarEstimado(string horarioLlegada, string horarioSalida)
        /// <summary>Retorna un estimado de tiempo que es resultante de restar dos objetos dateTime.</summary> 
        {
            ManejoDeTiempos Tiempo = new ManejoDeTiempos();

            bool esSalidaMenorALlegada = String.Compare(horarioLlegada, horarioSalida) == -1;

            // Ej: Salida 23:00hs Llegada 01:00
            if (esSalidaMenorALlegada)
                return Tiempo.FormatearIntMilitarAString(Tiempo.calcularDiferenciaDelDia(horarioLlegada, horarioSalida));

            // Ej: Salida 18:00hs Llegada 19:00
            string horarioResultado = Tiempo.RestarDateTimes(horarioLlegada, horarioSalida);
            return horarioResultado;
        }
>>>>>>> a26b86a37370bee6d4be2245e8c524893959a9e0
    }
}
