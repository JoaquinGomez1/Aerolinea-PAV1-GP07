using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TrabajoPrácticoPAV.Clase;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_Vuelos
    {
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
        Conexion_DB _BD = new Conexion_DB();

        public DataTable RecuperarXId(string id_vuelo)
        {
            string sql = "SELECT * FROM vuelo WHERE idVuelo =" + id_vuelo;
            return _BD.EjecutarSelect(sql);
        }

        public void CargarGrilla_vuelo1( DataGridView_Aerolinea grilla_ABM_vuelo1, string join, Control.ControlCollection controls)
        {
            string sql = tratamiento.ConstructorSelect(controls, join, "Vuelo");
            DataTable tabla = _BD.EjecutarSelect(sql);

            grilla_ABM_vuelo1.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla_ABM_vuelo1.Rows.Add();
                grilla_ABM_vuelo1.Rows[i].Cells[0].Value = BuscarModelo(tabla.Rows[i]["idModelo"].ToString());
                grilla_ABM_vuelo1.Rows[i].Cells[1].Value = tabla.Rows[i]["numeroPorModelo"].ToString();
                grilla_ABM_vuelo1.Rows[i].Cells[2].Value = BuscarAeropuerto(tabla.Rows[i]["codigoAeropuertoDestino"].ToString());
                grilla_ABM_vuelo1.Rows[i].Cells[3].Value = BuscarAeropuerto(tabla.Rows[i]["codigoAeropuertoSalida"].ToString());
                grilla_ABM_vuelo1.Rows[i].Cells[4].Value = tabla.Rows[i]["idVuelo"].ToString();
            }
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron vuelos.");
            }
        }
        public void Insertar(Control.ControlCollection controles)
        {
            _BD.Insertar(tratamiento.CostructorInsert("Vuelo", controles), false);
        }

        public void Modificar(Control.ControlCollection controles)
        {
            _BD.Modificar(tratamiento.CostructorUpdateDelete("Vuelo", controles, true), false);
        }
        public void Borrar(Control.ControlCollection controles)
        {
            _BD.Borrar(tratamiento.CostructorUpdateDelete("Vuelo", controles, false), false);
        }
        public void Borrar(string id_vuelo)
        {
            string sqlDelete = @"DELETE FROM vuelo WHERE idVuelo = " + id_vuelo;
            _BD.Borrar(sqlDelete, false);
        }

        public string BuscarModelo(string idModelo)
        {
            return _BD.EjecutarSelect($"SELECT nombre FROM modelo WHERE idModelo = " +
                        $"{idModelo}").Rows[0]["nombre"].ToString();
        }
        public string BuscarAeropuerto(string codigoAeropuerto)
        {
            return _BD.EjecutarSelect($"SELECT nombre FROM Aeropuerto WHERE codigo = " +
                $"'{codigoAeropuerto}'").Rows[0]["nombre"].ToString();
        }

    }
}
