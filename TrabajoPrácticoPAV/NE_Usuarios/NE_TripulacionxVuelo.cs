using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPrácticoPAV.Backend;
using System.Data;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_TripulacionxVuelo
    {
        public int Pp_idTripulacion { get; set; }
        public int Pp_idVuelo { get; set; }
        Conexion_DB _BD = new Conexion_DB();
        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Tripulacion_X_Vuelo (idTripulacion, idVuelo)"
                                + " VALUES ("
                                + Pp_idTripulacion + ", "
                                + Pp_idVuelo + ")";
            _BD.Insertar(sqlInsertar, false);
        }
        public void Borrar()
        {
            string sqlDelete = "DELETE FROM Tripulacion_X_Vuelo WHERE idTripulacion = " + Pp_idTripulacion + " AND idVuelo = " + Pp_idVuelo;
            _BD.Borrar(sqlDelete, false);
        }
        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT * FROM Tripulacion_X_Vuelo ";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_x_id()
        {
            string sql = $"SELECT * FROM Tripulacion_X_Vuelo WHERE idTripulacion = " + Pp_idTripulacion + " AND idVuelo = " + Pp_idVuelo;
            return _BD.EjecutarSelect(sql);
        }
    }
}