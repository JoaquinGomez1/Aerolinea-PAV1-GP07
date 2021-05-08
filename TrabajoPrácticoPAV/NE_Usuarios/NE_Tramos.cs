using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPrácticoPAV.Clase;
using System.Windows.Forms;
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
    }
}
