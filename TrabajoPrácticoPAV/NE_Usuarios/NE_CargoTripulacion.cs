using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPrácticoPAV.Backend;

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

        public void ModificarCargo(string nombre, int id)
        {
            string sql = $"UPDATE Cargo_Tripulacion SET nombre = '{nombre}' WHERE idCargoTripulacion = ${id}";
            _DB.Modificar(sql, true);
        }

        public void EliminarCargo(int id)
        {
            string sql = $"DELETE FROM Cargo_Tripulacion WHERE idCargoTripulacion = {id}";
            _DB.Borrar(sql, true);
        }
    }
}
