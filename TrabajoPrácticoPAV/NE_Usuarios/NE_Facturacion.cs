﻿using TrabajoPrácticoPAV.Clase;
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

        internal DataTable RecuperarPorPasajero(string tipoDoc, string numeroDoc)
        {
            return _BD.EjecutarSelect("SELECT f.idFactura, f.fechaPago, tp.descripcion as idTipoPago, f.numeroDeReserva, " +
                                    "r.numeroDocTitular, doc.nombreTipoDoc as tipoDoc " +
                                    "FROM Factura f JOIN Tipo_Pago tp ON tp.idTipoPago=f.idTipoPago " +
                                    "JOIN Reserva r ON r.numeroDeReserva=f.numeroDeReserva " +
                                    "JOIN Tipo_Documento doc ON r.tipoDocTitular=doc.tipoDoc " +
                                    "WHERE r.numeroDocTitular = " + numeroDoc +
                                    " AND r.tipoDocTitular=" + tipoDoc);
        }

        public void Insertar(string valores)
        {
            string sql = $"INSERT INTO Factura (fechaPago, numeroDeReserva, idTipoPago) VALUES "
                            + $"(CONVERT(DATE, GETDATE(), 110), {valores})";
            
            _BD.InicioTransaccion();
            _BD.Insertar(sql, false);

            if (_BD.FinalTransaccion() != Conexion_DB.EstadoTransaccion.correcto)
            {
               MessageBox.Show("No se realizó la grabación de los datos, hubo un error");
            }
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

        internal DataTable RecuperarPorRangoDoc(string desde, string hasta)
        {
            return _BD.EjecutarSelect("SELECT f.idFactura, f.fechaPago, tp.descripcion as idTipoPago, f.numeroDeReserva, " +
                                     "r.numeroDocTitular, doc.nombreTipoDoc as tipoDoc " +
                                     "FROM Factura f JOIN Tipo_Pago tp ON tp.idTipoPago=f.idTipoPago " +
                                     "JOIN Reserva r ON r.numeroDeReserva=f.numeroDeReserva " +
                                     "JOIN Tipo_Documento doc ON r.tipoDocTitular=doc.tipoDoc " +
                                     "WHERE r.numeroDocTitular BETWEEN (" + desde + ") AND (" + hasta + ")");
        }

        public string RecuperarFechaActual()
        {
            return _BD.EjecutarSelect("SELECT CONVERT(DATE, GETDATE(), 110)").Rows[0][0].ToString();
        }

        public void Eliminar(string idFactura)
        {
            string sql = $"DELETE FROM Factura WHERE idFactura = {idFactura}";
            
            _BD.InicioTransaccion();
            _BD.Borrar(sql, false); ;

            if (_BD.FinalTransaccion() != Conexion_DB.EstadoTransaccion.correcto)
            {

                MessageBox.Show("No se realizó la grabación de los datos, hubo un error");
            }

        }
        public DataTable Reporte_Factura_Todas()
        {
            return _BD.EjecutarSelect("SELECT idFactura, fechaPago, idTipoPago, numeroDeReserva FROM Factura");
        }

        internal DataTable RecuperarFacturaTodos()
        {
            return _BD.EjecutarSelect("SELECT f.idFactura, f.fechaPago, tp.descripcion as idTipoPago, f.numeroDeReserva, " +
                                    "r.numeroDocTitular, doc.nombreTipoDoc as tipoDoc " +
                                    "FROM Factura f JOIN Tipo_Pago tp ON tp.idTipoPago=f.idTipoPago " +
                                    "JOIN Reserva r ON r.numeroDeReserva=f.numeroDeReserva " +
                                    "JOIN Tipo_Documento doc ON r.tipoDocTitular=doc.tipoDoc");
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
            return _BD.EjecutarSelect("SELECT COUNT(*) as valor, MONTH(fechaPago) as denominacion From Factura " +
                "f JOIN Tipo_Pago t ON t.idTipoPago = f.idTipoPago GROUP BY MONTH(f.fechaPago)");
        }
        public DataTable RecuperarFacturasXMes(string desde, string hasta)
        {
            return _BD.EjecutarSelect($"SELECT COUNT(*) as valor, MONTH(fechaPago) as denominacion From Factura f JOIN Tipo_Pago t ON t.idTipoPago = f.idTipoPago WHERE YEAR(f.fechaPago) BETWEEN {desde} AND {hasta} GROUP BY MONTH(f.fechaPago)");

        }
        public DataTable RecuperarFacturasXPagoTodas()
        {

            return _BD.EjecutarSelect("SELECT COUNT(*) as valor, Tipo_Pago.descripcion from Factura inner  " +
                                        $"join Tipo_Pago on Factura.idTipoPago = Tipo_Pago.idTipoPago" +
                                        $" GROUP BY factura.idTipoPago, Tipo_Pago.descripcion");
        }

        public DataTable RecuperarFacturasXPago(string annoDesde, string annoHasta)
        {
            string sql = "SELECT COUNT(*) as valor, Tipo_Pago.descripcion from Factura inner  " +
                                        $"join Tipo_Pago on Factura.idTipoPago = Tipo_Pago.idTipoPago WHERE YEAR(Factura.fechaPago) BETWEEN {annoDesde} AND {annoHasta}" +
                                        $" GROUP BY factura.idTipoPago, Tipo_Pago.descripcion";
            return _BD.EjecutarSelect(sql);
        }
    }
}