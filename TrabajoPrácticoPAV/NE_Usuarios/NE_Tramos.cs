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

        public string Constructor_select(CheckBox todos,ComboBox_Aerolinea destino, ComboBox_Aerolinea salida, string NombreTabla)
        {
            string sql = "SELECT * FROM " + NombreTabla;

            if (todos.Checked)
                return sql;

            //Verifica que ambos Aeropuertos estén seleccionados
            if (destino.SelectedIndex != -1 && salida.SelectedIndex != -1)
            {
                sql += $" t INNER JOIN Aeropuerto a ON t.codigoAeropuertoDestino=a.codigo " +
                    $"WHERE t.codigoAeropuertoDestino = '{destino.SelectedValue.ToString()}' " +
                    $"AND t.codigoAeropuertoSalida = '{salida.SelectedValue.ToString()}'";
                return sql;
            }
            else
            {
                //Verifica que destino esté seleccionado
                if (destino.SelectedIndex != -1 && salida.SelectedIndex == -1)
                {
                    sql += $" t INNER JOIN Aeropuerto a ON t.codigoAeropuertoDestino=a.codigo " +
                        $"WHERE t.codigoAeropuertoDestino = '{destino.SelectedValue.ToString()}'";
                    return sql;
                }

                //Verifica que salida esté seleccionado
                if (destino.SelectedIndex == -1 && salida.SelectedIndex != -1)
                {
                    sql += $" t INNER JOIN Aeropuerto a ON t.codigoAeropuertoSalida=a.codigo " +
                        $"WHERE t.codigoAeropuertoDestino = '{salida.SelectedValue.ToString()}'";
                    return sql;
                }
                else
                    MessageBox.Show("Por favor seleccione al menos un Aeropuerto");
                    salida.Focus();
            }
            return "";
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
