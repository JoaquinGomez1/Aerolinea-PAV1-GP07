using System;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase.Modelos;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_Ciudad
    {
        private readonly Conexion_DB _DB = new Conexion_DB();

        public DataTable GetTodosLasCiudades()
        {
            string sql = @"SELECT idCiudad, nombreCiudad, Ciudad.idProvincia AS idProvincia, nombreProvincia
                         FROM Ciudad
                         JOIN Provincia ON
                         Ciudad.idProvincia = Provincia.idProvincia";
            DataTable resultadoSelect = _DB.EjecutarSelect(sql);
            return resultadoSelect;
        }

        public void InsertCiudad(CiudadObj Ciudad)
        {
            string sql = @"INSERT INTO Ciudad(nombreCiudad, idProvincia) 
                        VALUES(" + $"'{Ciudad.Nombre}', {Ciudad.IdProvincia})";

            _DB.Insertar(sql, false);
        }

        public CiudadObj GetCiudadPorId(string id)
        {
            string sql = $"SELECT * FROM Ciudad WHERE idCiudad = {id}";
            DataTable valores = _DB.EjecutarSelect(sql);

            CiudadObj ciudad = new CiudadObj()
            {
                Id = Int32.Parse(valores.Rows[0]["idCiudad"].ToString()),
                Nombre = valores.Rows[0]["nombre"].ToString(),
                Provincia = valores.Rows[0]["nombreProvincia"].ToString(),
                IdProvincia = Int32.Parse(valores.Rows[0]["idProvincia"].ToString()),
            };

            return ciudad;
        }

        public void ModificarCiudad(CiudadObj ciudad)
        {
            string sql = $"UPDATE Ciudad SET nombreCiudad = '{ciudad.Nombre}', idProvincia = {ciudad.IdProvincia} WHERE idCiudad = {ciudad.Id}";
            _DB.Modificar(sql, true);
        }

        public void EliminarCiudad(CiudadObj Ciudad)
        {
            EliminarCiudades($"{Ciudad.Id}");
        }

        public void EliminarCiudad(int idCiudad)
        {
            EliminarCiudades($"{idCiudad}");
        }

        public void EliminarCiudad(string idCiudad)
        {
            EliminarCiudades(idCiudad);
        }

        private void EliminarCiudades(string idCiudad)
        {

            string sql = $"DELETE FROM Ciudad WHERE idCiudad = {idCiudad}";
            _DB.Borrar(sql, true);
        }
    }
}
