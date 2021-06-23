using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Backend;
using System.Data;
using System.Windows.Forms;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_Facturacion
    {
        Conexion_DB _BD = new Conexion_DB();
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
        NE_Tramos tramo = new NE_Tramos();

        public DataTable RecuperarPasajero(string reserva)
        {
            return _BD.EjecutarSelect(@"SELECT R.numeroDocTitular, R.tipoDocTitular, P.nombre, P.apellido "
                                    + " FROM Reserva R JOIN Pasajero P ON R.numeroDocTitular = P.numeroDoc "
                                    + " AND R.tipoDocTitular = P.tipoDoc WHERE numeroDeReserva = " + reserva);
        }

        public DataTable RecuperarVueloxReserva(string reserva)
        {
            return _BD.EjecutarSelect(@"SELECT V.idVuelo, V.codigoAeropuertoDestino, V.codigoAeropuertoSalida"
                                      + " FROM Reserva R JOIN Viaje_X_Tramo VT ON R.numeroDeViaje = VT.numeroDeViaje "
                                      + " JOIN Vuelo V ON V.codigoAeropuertoDestino = VT.codigoAeropuertoDestino"
                                      + " AND V.codigoAeropuertoSalida = VT.codigoAeropuertoSalida "
                                      + " WHERE R.numeroDeReserva = " + reserva);
        }

        public DataTable RecuperarFactura(string numeroDeReserva)
        {
            return _BD.EjecutarSelect($"SELECT TOP 1 * FROM Factura WHERE numeroDeReserva = {numeroDeReserva}");
        }
        public void Insertar(string valores)
        {
            string sql = $"INSERT INTO Factura (fechaPago, numeroDeReserva, idTipoPago) VALUES "
                            + $"(CONVERT(DATE, GETDATE(), 110), {valores})";
            _BD.Insertar(sql, false);
        }
        public void CargarGrillaVuelos(DataTable vuelo, DataGridView_Aerolinea grid_vuelo)
        {
            for (int i = 0; i < vuelo.Rows.Count; i++)
            {
                grid_vuelo.Rows.Add();
                grid_vuelo.Rows[i].Cells[0].Value = vuelo.Rows[i]["idVuelo"].ToString();
                grid_vuelo.Rows[i].Cells[1].Value = tramo.BuscarNombreAeropuerto(vuelo.Rows[i]["codigoAeropuertoSalida"].ToString());
                grid_vuelo.Rows[i].Cells[2].Value = tramo.BuscarNombreAeropuerto(vuelo.Rows[i]["codigoAeropuertoDestino"].ToString());
            }
        }

        public string RecuperarFechaActual()
        {
            return _BD.EjecutarSelect("SELECT CONVERT(DATE, GETDATE(), 110)").Rows[0][0].ToString();
        }

        public void Eliminar(string idFactura)
        {
            string sql = $"DELETE FROM Factura WHERE idFactura = {idFactura}";
            _BD.Borrar(sql, false);
        }
        public DataTable Reporte_Factura_Todas()
        {
            return _BD.EjecutarSelect("SELECT idFactura, fechaPago, idTipoPago, numeroDeReserva FROM Factura");
        }
        public DataTable Reporte_Factura_PorID(int idFactura)
        {
            return _BD.EjecutarSelect("SELECT idFactura, fechaPago, idTipoPago, numeroDeReserva FROM Factura WHERE idFactura = " + idFactura);
        }
        public DataTable Reporte_Factura_PorFecha(string fechaDesde, string fechaHasta)
        {
            return _BD.EjecutarSelect("SELECT * FROM Factura WHERE fechaPago BETWEEN '" + fechaDesde + "' AND '" + fechaHasta + "'");
        }
        public DataTable RecuperarFacturasXMesTodas()
        {
            return _BD.EjecutarSelect("SELECT idFactura, fechaPago FROM Factura");
        }
        public DataTable RecuperarFacturasXMes(int Mes)
        {
            return _BD.EjecutarSelect("SELECT idFactura, fechaPago FROM Factura where MONTH(fechaPago) = " + Mes);

        }
        public DataTable RecuperarFacturasXPagoTodas()
        {
            return _BD.EjecutarSelect("SELECT Factura.idFactura, Tipo_Pago.descripcion from Factura inner join Tipo_Pago on Factura.idTipoPago = Tipo_Pago.idTipoPago");
        }

        public DataTable RecuperarFacturasXPago(int TipoPago)
        {
            return _BD.EjecutarSelect("SELECT Factura.idFactura, Tipo_Pago.descripcion from Factura inner join Tipo_Pago on Factura.idTipoPago = Tipo_Pago.idTipoPago where Factura.idTipoPago = " + TipoPago);
        }
    }
}