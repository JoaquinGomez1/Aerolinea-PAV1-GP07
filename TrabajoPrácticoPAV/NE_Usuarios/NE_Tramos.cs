using TrabajoPrácticoPAV.Clase;
using System.Data;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_Tramos
    {
        Conexion_DB _BD = new Conexion_DB();

        public void CargarGrilla(string sql, DataGridView_Aerolinea grid)
        {
            DataTable tabla = _BD.EjecutarSelect(sql);
            grid.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid.Rows.Add();
                grid.Rows[i].Cells[0].Value = BuscarNombreAeropuerto(tabla.Rows[i]["codigoAeropuertoSalida"].ToString());
                grid.Rows[i].Cells[1].Value = BuscarNombreAeropuerto(tabla.Rows[i]["codigoAeropuertodestino"].ToString());
                grid.Rows[i].Cells[2].Value = tabla.Rows[i]["duracion"].ToString();
                grid.Rows[i].Cells[3].Value = tabla.Rows[i]["distancia"].ToString();
            }

        }

        public DataTable buscar_todos_tramos()
        {
            string sql = "SELECT v.numeroDeViaje, v.orden, a1.nombre as 'AeropuertoSalida', a2.nombre as 'AeropuertoDestino' FROM Viaje_X_Tramo v " +
                "JOIN Aeropuerto a1 ON v.codigoAeropuertoSalida=a1.codigo " +
                "JOIN Aeropuerto a2 ON v.codigoAeropuertoDestino=a2.codigo";
            return _BD.EjecutarSelect(sql);
        }

        public string BuscarCodigoAeropuerto(string nombreAeropuerto)
        {
            return _BD.EjecutarSelect($"SELECT codigo FROM Aeropuerto WHERE nombre = " +
                $"'{nombreAeropuerto}'").Rows[0]["codigo"].ToString();
        }

        public string BuscarNombreAeropuerto(string codigoAeropuerto)
        {
            return _BD.EjecutarSelect($"SELECT nombre FROM Aeropuerto WHERE codigo = " +
                $"'{codigoAeropuerto}'").Rows[0]["nombre"].ToString();
        }

        public DataTable RecuperarTodos()
        {
            string sql = @"select codigoAeropuertoSalida, codigoAeropuertoDestino, duracion, distancia FROM Tramo";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarPorCodigoSalida(string codigoSalida)
        {
            string sql = $"SELECT * FROM Tramo WHERE codigoAeropuertoSalida = '{codigoSalida}'";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarPorCodigoDestino(string codigoDestino)
        {
            string sql = $"SELECT * FROM Tramo WHERE codigoAeropuertoDestino = '{codigoDestino}'";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarPorDistancia(int distancia)
        {
            string sql = $"SELECT * FROM Tramo WHERE distancia = {distancia}";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarPorDistanciaMayor(int distancia)
        {
            string sql = $"SELECT * FROM Tramo WHERE distancia > {distancia}";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarPorDistanciaMenor(int distancia)
        {
            string sql = $"SELECT * FROM Tramo WHERE distancia < {distancia}";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarPorDuracion(int duracion)
        {
            string sql = $"SELECT * FROM Tramo WHERE duracion = {duracion}";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable buscar_por_ranngo_viaje(string desde, string hasta)
        {
            string sql = "SELECT v.numeroDeViaje, v.orden, a1.nombre as 'AeropuertoSalida', a2.nombre as 'AeropuertoDestino' FROM Viaje_X_Tramo v " +
                "JOIN Aeropuerto a1 ON v.codigoAeropuertoSalida=a1.codigo " +
                "JOIN Aeropuerto a2 ON v.codigoAeropuertoDestino=a2.codigo" +
                " WHERE v.numeroDeViaje BETWEEN " + desde + " AND " + hasta;
            return _BD.EjecutarSelect(sql);
        }

        public DataTable buscar_por_aeropuerto_salida(string id)
        {
            string sql = "SELECT v.numeroDeViaje, v.orden, a1.nombre as 'AeropuertoSalida', a2.nombre as 'AeropuertoDestino' FROM Viaje_X_Tramo v " +
                "JOIN Aeropuerto a1 ON v.codigoAeropuertoSalida=a1.codigo " +
                "JOIN Aeropuerto a2 ON v.codigoAeropuertoDestino=a2.codigo" +
                " WHERE  v.codigoAeropuertoSalida = '" + id + "'";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable buscar_por_aeropuerto_destino(string id)
        {
            string sql = "SELECT v.numeroDeViaje, v.orden, a1.nombre as 'AeropuertoSalida', a2.nombre as 'AeropuertoDestino' FROM Viaje_X_Tramo v " +
                "JOIN Aeropuerto a1 ON v.codigoAeropuertoSalida=a1.codigo " +
                "JOIN Aeropuerto a2 ON v.codigoAeropuertoDestino=a2.codigo" +
                " WHERE  v.codigoAeropuertoDestino = '" + id + "'";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarPorDuracionMayor(int duracion)
        {
            string sql = $"SELECT * FROM Tramo WHERE duracion > {duracion}";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarPorDuracionMenor(int duracion)
        {
            string sql = $"SELECT * FROM Tramo WHERE duracion < {duracion}";
            return _BD.EjecutarSelect(sql);
        }

    }
}
