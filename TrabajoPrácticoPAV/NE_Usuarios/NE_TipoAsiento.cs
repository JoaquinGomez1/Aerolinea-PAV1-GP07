using System.Data;
using TrabajoPrácticoPAV.Clase;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_TipoAsiento
    {
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
        Conexion_DB _BD = new Conexion_DB();

        public DataTable RecuperarXId(string idTipo)
        {
            string sql = "SELECT * FROM Tipo_Asiento WHERE idTipo =" + idTipo;
            return _BD.EjecutarSelect(sql);
        }

        public void Insertar(Control.ControlCollection controles)
        {
            _BD.Insertar(tratamiento.CostructorInsert("Tipo_Asiento", controles), false);
        }

        public void Modificar(Control.ControlCollection controles)
        {
            _BD.Modificar(tratamiento.CostructorUpdateDelete("Tipo_Asiento", controles, true), false);
        }
        public void Borrar(Control.ControlCollection controles)
        {
            _BD.Borrar(tratamiento.CostructorUpdateDelete("Tipo_Asiento", controles, false), false);
        }

        public void CargarGrilla(DataGridView_Aerolinea grid, string join, Control.ControlCollection controls)
        {
            string sql = tratamiento.ConstructorSelect(controls, "", "Tipo_Asiento");
            DataTable tabla = _BD.EjecutarSelect(sql);
            grid.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid.Rows.Add();
                grid.Rows[i].Cells[0].Value = (tabla.Rows[i]["idTipo"].ToString());
                grid.Rows[i].Cells[1].Value = (tabla.Rows[i]["nombre"].ToString());
                grid.Rows[i].Cells[2].Value = tabla.Rows[i]["costo"].ToString();

            }
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron clases para los asientos.");
            }

        }
    }
}
