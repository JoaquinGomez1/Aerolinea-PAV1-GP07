﻿using System;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase.Modelos;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_Tripulacion
    {
        private readonly Conexion_DB _DB = new Conexion_DB();

        public DataTable GetTodosLosTripulantes()
        {
            string sql = @"SELECT idTripulacion, Tripulacion.nombre AS nombre, apellido, Tripulacion.idCargoTripulacion AS idCargoTripulacion, Cargo_Tripulacion.nombre AS nombreCargo
                         FROM Tripulacion 
                         JOIN Cargo_Tripulacion ON
                         Tripulacion.idCargoTripulacion = Cargo_Tripulacion.idCargoTripulacion";
            DataTable resultadoSelect = _DB.EjecutarSelect(sql);
            return resultadoSelect;
        }

        public void InsertTripulante(Tripulante Tripulante)
        {
            string sql = @"INSERT INTO Tripulacion(nombre, apellido, idCargoTripulacion) 
                        VALUES(" + $"'{Tripulante.Nombre}', '{Tripulante.Apellido}', {Tripulante.IdCargo})";

            _DB.Insertar(sql, false);
        }

        public Tripulante GetTripulantePorId(string id)
        {
            string sql = $"SELECT * FROM Tripulacion WHERE idTripulacion = {id}";
            DataTable valores = _DB.EjecutarSelect(sql);

            Tripulante tripulante = new Tripulante()
            {
                Id = Int32.Parse(valores.Rows[0]["idTripulacion"].ToString()),
                Nombre = valores.Rows[0]["nombre"].ToString(),
                Apellido = valores.Rows[0]["apellido"].ToString(),
                Cargo = valores.Rows[0]["nombreCargo"].ToString(),
                IdCargo = Int32.Parse(valores.Rows[0]["idCargoTripulacion"].ToString()),
            };

            return tripulante;
        }

        public void ModificarTripulante(Tripulante tripulante)
        {
            string sql = $"UPDATE Tripulacion SET nombre = '{tripulante.Nombre}', apellido = '{tripulante.Apellido}', idCargoTripulacion = {tripulante.IdCargo} WHERE idTripulacion = {tripulante.Id}";
            _DB.Modificar(sql, true);
        }

        // Overrides para eliminar por Tripulante o id (int o string)

        public void EliminarTripulante(string idTripulante)
        {
            EliminarTripulacion(idTripulante);
        }

        private void EliminarTripulacion(string idTripulante)
        {
            string sql = $"DELETE FROM Tripulacion WHERE idTripulacion = {idTripulante}";
            _DB.Borrar(sql, true);
        }

        public DataTable GetTodosTripulantesPorVuelo()
        {
            string sql = "SELECT tv.idVuelo, tv.idTripulacion,t.nombre,t.apellido, t.idCargoTripulacion, " +
                        "(SELECT nombre FROM Cargo_Tripulacion WHERE t.idCargoTripulacion = idCargoTripulacion) as nombreCargo, " +
                        "v.codigoAeropuertoSalida, v.codigoAeropuertoDestino, v.idModelo, v.duracionEstimada " +
                        "FROM Tripulacion_X_Vuelo tv  " +
                        "JOIN Tripulacion t ON tv.idTripulacion = t.idTripulacion " +
                        "JOIN Vuelo v ON v.idVuelo = tv.idVuelo";
            return _DB.EjecutarSelect(sql);
        }

        public DataTable GetTripulacionEnVueloPorParametro(string parametro, string cargo)
        {
            string sql = "SELECT * FROM Tripulacion_X_Vuelo " +
                        "JOIN Tripulacion on Tripulacion_X_Vuelo.idTripulacion = Tripulacion.idTripulacion " +
                        "JOIN Vuelo ON Vuelo.idVuelo = Tripulacion_X_Vuelo.idVuelo " +
                        $"WHERE {parametro} = {cargo}";
            return _DB.EjecutarSelect(sql);
        }

        public DataTable GetTripulante(string nombre, string apellido, string cargo)
        {

            if (nombre != "" && apellido != "")
            {
                string sql = $"SELECT idTripulacion, Tripulacion.nombre AS nombre, apellido, Tripulacion.idCargoTripulacion AS idCargoTripulacion, Cargo_Tripulacion.nombre AS nombreCargo FROM Tripulacion JOIN Cargo_Tripulacion on Tripulacion.idCargoTripulacion = Cargo_Tripulacion.idCargoTripulacion WHERE (Tripulacion.nombre='{nombre}') AND (apellido='{apellido}') AND (Tripulacion.idCargoTripulacion={cargo})";
                DataTable resultadoSelect = _DB.EjecutarSelect(sql);
                return resultadoSelect;
            }

            if (nombre != "" && apellido == "")
            {
                string sql = $"SELECT idTripulacion, Tripulacion.nombre AS nombre, apellido, Tripulacion.idCargoTripulacion AS idCargoTripulacion, Cargo_Tripulacion.nombre AS nombreCargo FROM Tripulacion JOIN Cargo_Tripulacion on Tripulacion.idCargoTripulacion = Cargo_Tripulacion.idCargoTripulacion WHERE (Tripulacion.nombre='{nombre}') AND (Tripulacion.idCargoTripulacion={cargo})";
                DataTable resultadoSelect = _DB.EjecutarSelect(sql);
                return resultadoSelect;
            }

            if (nombre == "" && apellido != "")
            {
                string sql = $"SELECT idTripulacion, Tripulacion.nombre AS nombre, apellido, Tripulacion.idCargoTripulacion AS idCargoTripulacion, Cargo_Tripulacion.nombre AS nombreCargo FROM Tripulacion JOIN Cargo_Tripulacion on Tripulacion.idCargoTripulacion = Cargo_Tripulacion.idCargoTripulacion WHERE (apellido='{apellido}') AND (Tripulacion.idCargoTripulacion={cargo})";
                DataTable resultadoSelect = _DB.EjecutarSelect(sql);
                return resultadoSelect;
            }

            if (nombre == "" && apellido == "")
            {
                string sql = $"SELECT idTripulacion, Tripulacion.nombre AS nombre, apellido, Tripulacion.idCargoTripulacion AS idCargoTripulacion, Cargo_Tripulacion.nombre AS nombreCargo FROM Tripulacion JOIN Cargo_Tripulacion on Tripulacion.idCargoTripulacion = Cargo_Tripulacion.idCargoTripulacion WHERE Tripulacion.idCargoTripulacion={cargo}";
                DataTable resultadoSelect = _DB.EjecutarSelect(sql);
                return resultadoSelect;
            }

            else
            {
                DataTable resultadoSelect = null;
                return resultadoSelect;
            }


        }
        public DataTable RecuperarTripulantes()
        {
            string sql = @"SELECT Tripulacion.idTripulacion, Tripulacion.nombre AS nombre, Tripulacion.apellido AS apellido, Cargo_Tripulacion.nombre AS cargo
                         FROM Tripulacion 
                         JOIN Cargo_Tripulacion ON
                         Tripulacion.idCargoTripulacion = Cargo_Tripulacion.idCargoTripulacion";
            DataTable resultadoSelect = _DB.EjecutarSelect(sql);
            return resultadoSelect;
        }

        public DataTable RecuperarPorRango(string Desde, string Hasta)
        {
            string sql = @"SELECT idTripulacion, t.nombre, apellido, c.nombre as cargo FROM Tripulacion t 
                           JOIN Cargo_Tripulacion c ON c.idCargoTripulacion = t.idCargoTripulacion 
                           WHERE t.idTripulacion BETWEEN " + Desde + " AND " + Hasta;

            return _DB.EjecutarSelect(sql);
        }

        public DataTable RecuperarPorCargo(string idCargo)
        {
            string sql = @"SELECT idTripulacion, t.nombre, apellido, c.nombre as cargo FROM Tripulacion t 
                           JOIN Cargo_Tripulacion c ON c.idCargoTripulacion = t.idCargoTripulacion 
                           WHERE t.idCargoTripulacion = " + idCargo;

            return _DB.EjecutarSelect(sql);
        }
        public DataTable Reporte_EstadisticarecuperarTodos()
        {
            string sql = @"SELECT c.nombre as denominacion, " +
                        @" COUNT(*)*100/(SELECT COUNT(*) FROM tripulacion) as valor " +
                        @"FROM tripulacion t JOIN Cargo_Tripulacion c ON t.idCargoTripulacion = c.idCargoTripulacion " +
                        @"GROUP BY c.idCargoTripulacion, c.nombre";
            return _DB.EjecutarSelect(sql);
        }
        public DataTable Reporte_recuperarXCargoLetra(string letra)
        {
            string sql = @"SELECT c.nombre as denominacion,COUNT(*)*100/(SELECT COUNT(*) FROM tripulacion) as valor " +
                        @"FROM tripulacion t JOIN Cargo_Tripulacion c ON t.idCargoTripulacion = c.idCargoTripulacion where c.nombre like '" + letra + "%' " +
                        @"GROUP BY c.idCargoTripulacion, c.nombre";
            return _DB.EjecutarSelect(sql);
        }
        public DataTable Reporte_recuperarXNombreTrip(string letra)
        {
            string sql = @"SELECT c.nombre as denominacion,COUNT(*)*100/(SELECT COUNT(*) FROM tripulacion) as valor " +
                        @"FROM tripulacion t JOIN Cargo_Tripulacion c ON t.idCargoTripulacion = c.idCargoTripulacion where t.nombre like '" + letra + "%' " +
                        @"GROUP BY c.idCargoTripulacion, c.nombre";
            return _DB.EjecutarSelect(sql);
        }
    }
}
