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
    class NE_Asiento
    {
        Conexion_DB _BD = new Conexion_DB();
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

        public DataTable RecuperarXId(string id_Asiento)
        {
            string sql = "SELECT * FROM Asientos WHERE numeroAsiento =" + id_Asiento;
            return _BD.EjecutarSelect(sql);
        }

        public void Insertar(Control.ControlCollection controles)
        {
            _BD.Insertar(tratamiento.CostructorInsert("Asientos", controles), false);
        }

        public void Modificar(Control.ControlCollection controles)
        {
            _BD.Modificar(tratamiento.CostructorUpdateDelete("Asientos", controles, true), false);
        }
        public void Borrar(Control.ControlCollection controles)
        {
            _BD.Borrar(tratamiento.CostructorUpdateDelete("Asientos", controles, false), false);
        }
        public void Borrar(string id_Asiento)
        {
            string sqlDelete = @"DELETE FROM Asientos WHERE numeroAsiento = " + id_Asiento;
            _BD.Borrar(sqlDelete, false);
        }
        public string BuscarModelo(string idModelo)
        {
            return _BD.EjecutarSelect($"SELECT nombre FROM modelo WHERE idModelo = " +
                        $"{idModelo}").Rows[0]["nombre"].ToString();
        }
        public string BuscarClase(string idClase)
        {
            return _BD.EjecutarSelect($"SELECT nombre FROM Tipo_Asiento WHERE idTipo = " +
                        $"{idClase}").Rows[0]["nombre"].ToString();
        }

        public void CargarGrilla_asientos(DataGridView_Aerolinea grilla_ABMAsiento, string join, Control.ControlCollection controls)
        {

            string sql = tratamiento.ConstructorSelect(controls, join, "Asientos");
            MessageBox.Show(sql);
            DataTable tabla = _BD.EjecutarSelect(sql);

            grilla_ABMAsiento.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla_ABMAsiento.Rows.Add();

                grilla_ABMAsiento.Rows[i].Cells[0].Value = tabla.Rows[i]["numeroAsiento"].ToString();
                grilla_ABMAsiento.Rows[i].Cells[1].Value = BuscarModelo(tabla.Rows[i]["idModelo"].ToString());
                grilla_ABMAsiento.Rows[i].Cells[2].Value = tabla.Rows[i]["numeroPorModelo"].ToString();
                grilla_ABMAsiento.Rows[i].Cells[3].Value = BuscarClase(tabla.Rows[i]["tipoAsiento"].ToString());
                grilla_ABMAsiento.Rows[i].Cells[4].Value = tabla.Rows[i]["estado"].ToString();
            }
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron Asientos para ese filtro.");
            }

        }

    }
}
