using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Backend;
using System.Data;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_Facturacion
    {
        Conexion_DB _BD = new Conexion_DB();
        public DataTable RecuperarPasajero(string reserva)
        {
            return _BD.EjecutarSelect(@"SELECT R.numeroDocTitular, R.tipoDocTitular, P.nombre, P.apellido "
                                    + " FROM Reserva R JOIN Pasajero P ON R.numeroDocTitular = P.numeroDoc "
                                    + " AND R.tipoDocTitular = P.tipoDoc WHERE numeroDeReserva = " + reserva);
        }
        
        public DataTable RecuperarVueloxReserva(string reserva)
        {
            return _BD.EjecutarSelect(@"SELECT V.idVuelo, V.codigoAeropuertoDestino, V.codigoAeropuertoSalida"
                                      + " FROM Reserva R JOIN Viaje_X_Tramo VT ON R.numeroDeViaje= VT.numeroDeViaje "
                                      + " JOIN Vuelo V ON V.codigoAeropuertoDestino = VT.codigoAeropuertoDestino"
                                      + " AND V.codigoAeropuertoSalida = VT.codigoAeropuertoSalida " 
                                      + " WHERE R.numeroDeReserva = " + reserva);
        }
    }
}
