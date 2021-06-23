using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Clase.Modelos;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    internal class NE_Viajes
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
            // IMPORTANTE.
            // La consulta que hace esta función está mal. Solo devuelve el numero de viaje
            // Si estan conectados por solo UN tramo.
            // hay que modificar la consulta para que devuelva viajes conectados por mas de un tramo
            // Para simplificar solo deberia devolver 1 Viaje (el primero que encuentre)
            string sql = $"SELECT * FROM (SELECT Viaje_X_Tramo.numeroDeViaje as nViaj, orden, codigoAeropuertoSalida, codigoAeropuertoDestino FROM Viaje_X_Tramo JOIN Viaje ON Viaje_X_Tramo.numeroDeViaje = Viaje.numeroDeViaje WHERE (Viaje_X_Tramo.orden = 1 AND Viaje_X_Tramo.codigoAeropuertoSalida = '{codSalida}')) t1 JOIN (SELECT Viaje_X_Tramo.numeroDeViaje as nViaj, orden, codigoAeropuertoSalida, codigoAeropuertoDestino FROM Viaje_X_Tramo JOIN Viaje ON Viaje_X_Tramo.numeroDeViaje = Viaje.numeroDeViaje WHERE (Viaje_X_Tramo.orden = Viaje.cantidadTramos AND Viaje_X_Tramo.codigoAeropuertoDestino = '{codDestino}')) t2 ON t1.nViaj = t2.nViaj";
            DataTable table = _DB.EjecutarSelect(sql);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró ningun viaje con esos parámetros");
                return null;
            }

            Viaje viaje = new Viaje()
            {
                NumeroDeViaje = Int32.Parse(table.Rows[0]["nViaj"].ToString()),
            };

            return viaje;
        }

        public DataTable RecuperarViajes()
        {
            DataTable table = new DataTable();
            string sql = $"select numeroDeViaje, horarioLlegada, horarioSalida, cantidadTramos, duracionEstimada from Viaje order by   horarioSalida,  numeroDeViaje, horarioLlegada";
            table = _DB.EjecutarSelect(sql);
            return table;
        }

        public DataTable RecuperarViajesXHorarioSalida(string horarioDesde, string horarioHasta)
        {
            DataTable tabla = new DataTable();
            string sql = $"select numeroDeViaje, horarioLlegada, horarioSalida, cantidadTramos, duracionEstimada from Viaje  where horarioSalida >= ' {horarioDesde} ' and horarioSalida <= ' {horarioHasta} ' order by  numeroDeViaje,horarioLlegada";
            tabla = _DB.EjecutarSelect(sql);
            return tabla;
        }

        public DataTable RecuperarViajesXHorarioLlegada(string horarioDesde, string horarioHasta)
        {
            DataTable tabla = new DataTable();
            string sql = $"select numeroDeViaje, horarioLlegada, horarioSalida, cantidadTramos, duracionEstimada from Viaje  where horarioLlegada >= ' {horarioDesde} ' and horarioLlegada <= ' {horarioHasta} ' order by  numeroDeViaje,horarioLlegada";
            tabla = _DB.EjecutarSelect(sql);
            return tabla;
        }

        public DataTable RecuperarViajesXFecha(string fecha)
        {
            DataTable table = new DataTable();

            string sql = $"select numeroDeViaje, fechaSalida  from Reserva where fechaSalida = ' {fecha}   'order by fechaSalida, numeroDeViaje";
            return table;
        }

        public DataTable GetViajesPorMes()
        {
            // Busca en reservas porque es lo único que tiene fecha en la tabla y una reserva tiene un solo viaje asi que es casi lo
            string sql = "SELECT MONTH(fechaSalida) as Mes, COUNT( * ) as Cantidad, COUNT( * ) * 100 / (SELECT COUNT( * ) FROM RESERVA) as Porcentaje FROM Reserva Group By MONTH(fechaSalida)";
            return _DB.EjecutarSelect(sql);
        }

        public DataTable GetViajesPorMes(string initialDate, string finalDate)
        {
            // Busca en reservas porque es lo único que tiene fecha en la tabla y una reserva tiene un solo viaje asi que es casi lo
            string sql = $"SELECT MONTH(fechaSalida) as Mes, COUNT( * ) as Cantidad, COUNT( * ) * 100 / (SELECT COUNT( * ) FROM RESERVA WHERE {initialDate} <= MONTH(fechaSalida) AND {finalDate} >= MONTH(fechaSalida)) as Porcentaje FROM Reserva WHERE {initialDate} <= MONTH(fechaSalida) AND {finalDate} >= MONTH(fechaSalida)  Group By MONTH(fechaSalida)";
            return _DB.EjecutarSelect(sql);
        }

        public DataTable GetViajesPorSemana()
        {
            string sql = "SELECT DATENAME(DW, fechaSalida) as Dia, COUNT( * ) as Cantidad, COUNT( * ) * 100 / (SELECT COUNT( * ) FROM RESERVA) as Porcentaje FROM Reserva Group By DATENAME(DW,fechaSalida)";
            return _DB.EjecutarSelect(sql);
        }
    }
}