using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;
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

        public void InsertViaje(Viaje Viaje, int cantTramos)
        {
            // Devuelve el numero de viaje insertado
            string sql = @"INSERT INTO Viaje(horarioPresencia, horarioSalida, horarioLlegada, duracionEstimada, cantidadTramos) 
                        VALUES(" + $"'{Viaje.HorarioPresencia}', '{Viaje.HorarioSalida}', '{Viaje.HorarioLlegada}', '{Viaje.DuracionEstimada}', {cantTramos}" + ") "
                       ;

            _DB.Insertar(sql, true);
        }

        public string GetIdentityDeViaje()
        {
            string identityQuery = "SELECT TOP 1 numeroDeViaje FROM Viaje ORDER BY numeroDeViaje DESC";
            DataTable table = _DB.EjecutarSelect(identityQuery);

            return table.Rows[0][0].ToString();
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

        public void EliminarFila(string numeroDeViaje)
        {
            string sql = $"DELETE FROM Viaje WHERE numeroDeViaje = {numeroDeViaje}";
            _DB.Borrar(sql, false);
        }

        public void ModificarViaje(Viaje viaje)
        {
            string sql = $"UPDATE Viaje SET horarioSalida = '{viaje.HorarioSalida}', horarioLlegada = '{viaje.HorarioLlegada}', horarioPresencia = '{viaje.HorarioPresencia}', duracionEstimada = '{viaje.DuracionEstimada}' WHERE numeroDeViaje = {viaje.NumeroDeViaje}";
            _DB.Modificar(sql, false);
        }

        public DataTable GetTramosPorViaje(string numeroDeViaje)
        {
            // TODO: Cambiar consulta y traer unicamente los datos de viaje y los de tramo.
            // Retorna un datatable haciendo join de las tablas de tramo y TramoxViaje en base al numeroDeViaje provisto
            string sql = $"SELECT * FROM Viaje_X_Tramo JOIN Tramo ON Tramo.codigoAeropuertoDestino = Viaje_X_Tramo.codigoAeropuertoDestino AND Tramo.codigoAeropuertoDestino = Viaje_X_Tramo.codigoAeropuertoDestino WHERE numeroDeViaje = {numeroDeViaje}";
            return _DB.EjecutarSelect(sql);
        }


        public void CargarTramosPorViaje(List<Tramo> tramos, string numeroDeViaje)
        {
            // Carga todos los tramos segun el numero de viaje correspondiente
            for (int i = 0; i < tramos.Count; i++)
            {
                Tramo tramo = tramos[i];
                string sql = $"INSERT INTO Viaje_X_Tramo(codigoAeropuertoDestino, codigoAeropuertoSalida, orden, numeroDeViaje) VALUES('{tramo.codigoAeropuertoDestino}', '{tramo.codigoAeropuertoSalida}', {i + 1}, {numeroDeViaje})";
                _DB.Insertar(sql, true);
            };
        }


        public void EliminarTramoDeViaje(Tramo tramo, string numeroDeViaje, bool silenciosa = false)
        {
            string sql = $"DELETE FROM Viaje_X_Tramo WHERE codigoAeropuertoDestino = '{ tramo.codigoAeropuertoDestino }' AND codigoAeropuertoSalida = '{tramo.codigoAeropuertoSalida}' AND numeroDeViaje = {numeroDeViaje}";
            _DB.Borrar(sql, silenciosa);
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


        public Viaje ViajeQueCoinciden(string codSalida, string codDestino)
        {
            string sql = $"SELECT TOP 1 * FROM Viaje_X_Tramo JOIN Viaje ON Viaje_X_Tramo.numeroDeViaje = Viaje.numeroDeViaje WHERE (Viaje_X_Tramo.orden = 1 AND Viaje_X_Tramo.codigoAeropuertoSalida = '{codSalida}') AND (Viaje_X_Tramo.orden = Viaje.cantidadTramos AND Viaje_X_Tramo.codigoAeropuertoDestino = '{codDestino}') ";
            DataTable table = _DB.EjecutarSelect(sql);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró ningun viaje con esos parámetros");
                return null;
            }

            Viaje viaje = new Viaje()
            {
                NumeroDeViaje = Int32.Parse(table.Rows[0]["numeroDeViaje"].ToString()),
                HorarioPresencia = table.Rows[0]["horarioPresencia"].ToString(),
                HorarioLlegada = table.Rows[0]["horarioLlegada"].ToString(),
                HorarioSalida = table.Rows[0]["horarioSalida"].ToString(),
                DuracionEstimada = Int32.Parse(table.Rows[0]["duracionEstimada"].ToString()),
                CantidadTramos = Int32.Parse(table.Rows[0]["cantidadTramos"].ToString())
            };

            return viaje;
        }
    }
}
