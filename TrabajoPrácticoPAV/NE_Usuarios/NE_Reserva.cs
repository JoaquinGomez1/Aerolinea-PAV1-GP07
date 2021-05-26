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

        public DataTable GetTodosLosPasajeros(string numeroDeReserva)
        {
            string sql = $"SELECT * FROM Reservas_X_Pasajero " +
                         $"JOIN Pasajero ON Pasajero.tipoDoc = Reservas_X_Pasajero.tipoDoc " +
                         $"AND Pasajero.numeroDoc = Reservas_X_Pasajero.numeroDoc WHERE numeroDeReserva = {numeroDeReserva}";
            return _DB.EjecutarSelect(sql);
        }

        public void EliminarReserva(string id)
        {
            string sql = $"DELETE FROM Reserva WHERE numeroDeReserva = {id}";
            _DB.Borrar(sql, false);
        }
    }
}
