using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;
using static TrabajoPrácticoPAV.Formularios.Estadisticas.PasajerosMayores.Ds_EstadisticaPasajerosMayores;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_Clientes
    {

        Conexion_DB _BD = new Conexion_DB();

        public void InsertarTelefonos(DataGridView_Aerolinea grid, string numeroDoc, string tipoDoc)
        {
            if (grid.Rows.Count > 1)
                for (int i = 0; i < grid.Rows.Count - 1; i++)
                {
                    string sql = $"INSERT INTO Telefono(numeroTelefono, tipoDoc, numeroDoc) VALUES(" +
                        $"'{grid.Rows[i].Cells[0].Value.ToString()}', {tipoDoc}, {numeroDoc})";

                    _BD.Insertar(sql, true);
                }
        }

        public string BuscarNombreDoc(string idTipoDoc)
        {
            return _BD.EjecutarSelect($"SELECT nombreTipoDoc FROM Tipo_Documento WHERE TipoDoc = " +
                        $"{idTipoDoc}").Rows[0]["nombreTipoDoc"].ToString();
        }

        public string BuscarIdTipoDoc(string nombreDoc)
        {
            return _BD.EjecutarSelect($"SELECT tipoDoc FROM Tipo_Documento WHERE nombreTipoDoc = " +
                        $"'{nombreDoc}'").Rows[0]["tipoDoc"].ToString();
        }

        public void CargarGrilla(string sql, DataGridView_Aerolinea grid)
        {
            DataTable tabla = _BD.EjecutarSelect(sql);
            if (tabla.Rows.Count < 1) MessageBox.Show($"No se encontró ningun pasajero con esos datos");
            grid.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid.Rows.Add();
                grid.Rows[i].Cells[0].Value = tabla.Rows[i]["nombre"].ToString();
                grid.Rows[i].Cells[1].Value = tabla.Rows[i]["apellido"].ToString();
                grid.Rows[i].Cells[2].Value = BuscarNombreDoc(tabla.Rows[i]["tipoDoc"].ToString());
                grid.Rows[i].Cells[3].Value = tabla.Rows[i]["numeroDoc"].ToString();
            }
        }

        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT 'Mayores' as descripcion, COUNT(numeroDoc) as cantidad FROM Pasajero WHERE DATEDIFF(year, fechaNacimiento, GETDATE()) >= 18 
            UNION 
            SELECT 'Menores' as descripcion, COUNT(numeroDoc) as cantidad FROM Pasajero WHERE DATEDIFF(year, fechaNacimiento, GETDATE()) < 18
             ";
            return _BD.EjecutarSelect(sql);
        }

    }
}
