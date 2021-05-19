using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase.Modelos;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_CargoTripulacion
    {
        private readonly Conexion_DB _DB = new Conexion_DB();

        public DataTable GetTodosLosCargos()
        {
            string sql = @"SELECT * FROM Cargo_Tripulacion";
            DataTable resultadoSelect = _DB.EjecutarSelect(sql);
            return resultadoSelect;
        }

        public void InsertCargo(string nombre)
        {
            string sql = @"INSERT INTO Cargo_Tripulacion(nombre) 
                        VALUES(" + $"'{nombre}')";

            _DB.Insertar(sql, true);
        }

        public DataTable GetCargoPorId(string id)
        {
            string sql = $"SELECT * FROM Cargo_Tripulacion WHERE idCargoTripulacion = {id}";
            DataTable valores = _DB.EjecutarSelect(sql);

            return valores;
        }

        public DataTable GetCargo(string nombre)
        {
            if (nombre != "")
            {
                string sql = $"SELECT * FROM Cargo_Tripulacion idCargoTripulacion WHERE nombre='{nombre}'";
                DataTable resultadoSelect = _DB.EjecutarSelect(sql);
                return resultadoSelect;
            }

            else
            {
                DataTable resultadoSelect = null;
                return resultadoSelect;
            }
        }

        public void ModificarCargo(CargoTripulacion cargoTripulacion)
        {
            string sql = $"UPDATE Cargo_Tripulacion SET nombre = '{cargoTripulacion.Nombre}' WHERE idcargoTripulacion = {cargoTripulacion.Id}";
            _DB.Modificar(sql, true);
        }

        public void EliminarCargo(string idCargo)
        {
            EliminarCargos(idCargo);
        }

        private void EliminarCargos(string idCargo)
        {

            string sql = $"DELETE FROM Cargo_Tripulacion WHERE idCargoTripulacion = {idCargo}";
            _DB.Borrar(sql, true);
        }
    }
}
