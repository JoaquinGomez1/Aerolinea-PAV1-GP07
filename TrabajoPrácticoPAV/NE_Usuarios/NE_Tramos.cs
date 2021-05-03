using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPrácticoPAV.Clase;
using System.Windows.Forms;


namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_Tramos
    {
        public string Constructor_select(CheckBox todos,ComboBox_Aerolinea destino, ComboBox_Aerolinea salida, TextBox_Aerolinea codigo , string NombreTabla)
        {
            string sql = "SELECT * FROM " + NombreTabla;

            if (todos.Checked)
            {
                return sql;
            }

            if (codigo.Text != String.Empty)
            {
                sql += " WHERE idTramo= " + codigo.Text;
                return sql;
            }

            if (destino.SelectedIndex != -1 && salida.SelectedIndex != -1)
            {
                sql += @" t INNER JOIN Aeropuerto a ON t.codigoAeropuertoDestino=a.codigo"
                        + " WHERE t.codigoAeropuertoDestino = '" + destino.SelectedValue.ToString()
                        + "' AND t.codigoAeropuertoSalida = '" + salida.SelectedValue.ToString() + "'";
                return sql;
            }
            else
            {
                if (destino.SelectedIndex != -1 && salida.SelectedIndex == -1)
                {
                    sql += @" t INNER JOIN Aeropuerto a ON t.codigoAeropuertoDestino=a.codigo"
                        + " WHERE t.codigoAeropuertoDestino = '" + destino.SelectedValue.ToString()+"'";
                    return sql;
                }
                if (destino.SelectedIndex == -1 && salida.SelectedIndex != -1)
                {
                    sql += @" t INNER JOIN Aeropuerto a ON t.codigoAeropuertoSalida=a.codigo"
                        + " WHERE t.codigoAeropuertoSalida = '" + salida.SelectedValue.ToString() + "'";
                }
            }

            return sql;
        }
    }
}
