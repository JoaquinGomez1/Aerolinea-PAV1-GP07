using System.Data;
using System.Globalization;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase.Modelos;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_Reserva
    {
        private readonly Conexion_DB _DB = new Conexion_DB();

        public DataTable GetTodos()
        {
            string sql = "SELECT * FROM RESERVA";
            return _DB.EjecutarSelect(sql);
        }

        public Pasajero GetPasajero(string numeroDoc, string tipoDoc)
        {
            DataTable result = GetDataTablePasajero(numeroDoc, tipoDoc);
            if (result.Rows.Count < 1)
            {
                MessageBox.Show("No se encontró ningun pasajero con esas características");
                return new Pasajero() { };
            }

            return new Pasajero()
            {
                numeroDoc = result.Rows[0]["numeroDoc"].ToString(),
                tipoDoc = result.Rows[0]["tipoDoc"].ToString(),
                nombre = result.Rows[0]["nombre"].ToString(),
                apellido = result.Rows[0]["apellido"].ToString(),
                numeroCalle = result.Rows[0]["numeroCalle"].ToString(),
                calle = result.Rows[0]["calle"].ToString(),
                idCiudad = result.Rows[0]["idCiudad"].ToString(),
                fechaNacimiento = result.Rows[0]["fechaNacimiento"].ToString(),
            };
        }

        public DataTable GetDataTablePasajero(string numeroDoc, string tipoDoc)
        {
            string sql = $"SELECT * FROM Pasajero WHERE numeroDoc = {numeroDoc} AND tipoDoc = {tipoDoc}";
            DataTable result = _DB.EjecutarSelect(sql);
            return result;
        }

        public DataTable GetDataTableReserva(string numeroReserva)
        {
            string sql = $"SELECT * FROM Reserva WHERE numeroDeReserva = {numeroReserva}";
            DataTable result = _DB.EjecutarSelect(sql);
            return result;
        }

        public Reserva GetPasajeroPorReserva(string numeroReserva)
        {
            DataTable result = GetDataTableReserva(numeroReserva);
            if (result.Rows.Count < 1)
            {
                MessageBox.Show("No se encontró ninguna reserva con ese numero");
                return new Reserva() { };
            }

            return new Reserva()
            {
                numeroDocTitular = result.Rows[0]["numeroDocTitular"].ToString(),
                tipoDocTitular = result.Rows[0]["tipoDocTitular"].ToString(),
            };
        }

        public DataTable GetPasajeroPorDoc(string numReserva)
        {
            //Reserva reserva = GetPasajeroPorReserva(numReserva);
            string sql = $"SELECT * FROM Pasajero JOIN Reserva ON Reserva.numeroDocTitular = Pasajero.numeroDoc AND Reserva.tipoDocTitular = Pasajero.tipoDoc WHERE Reserva.numeroDeReserva = {numReserva}";
            DataTable result = _DB.EjecutarSelect(sql);
            return result;
        }

        public decimal BuscarCosto(string clase)
        {
            string sql = $"SELECT * FROM Tipo_Asiento WHERE nombre = '{clase}'";
            DataTable result = _DB.EjecutarSelect(sql);

            decimal value = decimal.Parse($"{result.Rows[0]["costo"]}", NumberStyles.Currency);

            return value;
        }

        public DataTable GetTodosLosPasajeros(string numeroReserva)
        {
            string sql = $"SELECT * FROM RESERVAS_X_Pasajero JOIN Pasajero ON RESERVAS_X_Pasajero.tipoDoc = Pasajero.tipoDoc AND Reservas_X_Pasajero.numeroDoc = Pasajero.numeroDoc WHERE numeroDeReserva = {numeroReserva}";
            return _DB.EjecutarSelect(sql);
        }

        public void EliminarReserva(string id)
        {
            string sql = $"DELETE FROM Reserva WHERE numeroDeReserva = {id}";
            _DB.Borrar(sql, false);
        }

        public void InsertarReserva(Reserva reserva)
        {
            string sql = $"INSERT INTO Reserva " +
                         $"(fechaReserva, fechaSalida, confirmacion, numeroDeViaje, " +
                         $"numeroDocTitular, tipoDocTitular, precio) " +
                         $"VALUES ('{reserva.fechaDeReserva}','{reserva.fechaDeSalida}',0," +
                         $"{reserva.numeroDeViaje},{reserva.numeroDocTitular},{reserva.tipoDocTitular},{reserva.precio})";
            _DB.Insertar(sql, false);
        }

        public void Insertar_RXP(Pasajero pasajero, Reserva reserva, string tipo_clase,
                                int numero_asiento, string numeroModelo, string idModelo, string fechaVen)
        {

            string sql = $"INSERT INTO Reservas_X_Pasajero " +
                        $"(tipoDoc, numeroDoc, numeroDeReserva, fechaHoraVencimiento, " +
                        $"tipoClase, numeroAsiento, numeroPorModelo, idModelo) VALUES " +
                        $"({pasajero.tipoDoc}, {pasajero.numeroDoc},{reserva.numeroDeReserva},'{fechaVen}'," +
                        $"{tipo_clase},{numero_asiento},{numeroModelo},{idModelo})";
            //_DB.InicioTransaccion();
            _DB.Insertar(sql, true);

        }

        public void ModificarReserva(Reserva reserva)
        {
            string sql = $"UPDATE Reserva SET fechaDeSalida = {reserva.fechaDeSalida}, numeroDeViaje = {reserva.numeroDeViaje}, precio = {reserva.precio} WHERE numeroDeReserva = {reserva.numeroDeReserva}";
            _DB.Modificar(sql, false);
        }

        public string Numero_reserva()
        {
            string sql = "SELECT TOP 1 numeroDeReserva FROM Reserva ORDER BY numeroDeReserva DESC";
            return _DB.EjecutarSelect(sql).Rows[0][0].ToString();

        }


        //public void Eliminar_Asientos_Usados (DataTable asientos)
        //{
        //    DataTable asientos = new DataTable();
        //    string sql = "SELECT numeroAsiento, numeroPorModelo FROM Resercas_X_Pasajero WHERE "

        //}



        public DataTable Buscar_Asientos(string viaje)
        {
            DataTable tramo = new DataTable();
            DataTable avion = new DataTable();
            DataTable asientos = new DataTable();

            tramo = Buscar_Tramo(viaje);
            avion = Buscar_Avion(tramo);
            asientos = Buscar_Asiento_X_Vuelo(avion);

            return asientos;
        }


        public DataTable Buscar_Tramo(string viaje)
        {
            string sql = "SELECT VP.codigoAeropuertoDestino, VP.codigoAeropuertoSalida FROM Viaje_X_Tramo VP WHERE " +
                         " VP.numeroDeViaje = " + viaje + " AND VP.orden = 1";
            return _DB.EjecutarSelect(sql);

        }

        public DataTable Buscar_Avion(DataTable tramos)
        {
            string destino = tramos.Rows[0]["codigoAeropuertoDestino"].ToString();
            string salida = tramos.Rows[0]["codigoAeropuertoSalida"].ToString();

            string sql = "SELECT V.idModelo, V.numeroPorModelo FROM Vuelo V WHERE" +
                         " V.codigoAeropuertoDestino='" + destino + "' AND " +
                         " V.codigoAeropuertoSalida='" + salida + "'";
            return _DB.EjecutarSelect(sql);


        }
        public DataTable Buscar_Asiento_X_Vuelo(DataTable vuelo)
        {
            string idModelo = vuelo.Rows[0]["idModelo"].ToString();
            string numeroPorModelo = vuelo.Rows[0]["numeroPorModelo"].ToString();
            string sql = "SELECT A.numeroAsiento, A.numeroPorModelo, A.idModelo FROM Asientos A WHERE A.numeroPorModelo = " + numeroPorModelo +
                        " AND A.idModelo = " + idModelo;
            MessageBox.Show(sql);
            return (_DB.EjecutarSelect(sql));
        }
    }
}
