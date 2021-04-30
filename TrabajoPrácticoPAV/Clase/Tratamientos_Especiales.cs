using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Formularios;

namespace TrabajoPrácticoPAV.Clase
{
    class Tratamientos_Especiales
    {
        public enum Resultado { correcto, error }

        public Resultado Validar(Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox_Aerolinea")
                {
                    if (((TextBox_Aerolinea)item).Text == "")
                    {
                        MessageBox.Show(((TextBox_Aerolinea)item).Pp_MensajeError);
                        ((TextBox_Aerolinea)item).Focus();
                        return Resultado.error;
                    }
                    
                    return Resultado.correcto;
                }
                if (item.GetType().Name == "ComboBox_Aerolinea")
                {
                    if (((ComboBox_Aerolinea)item).SelectedIndex == -1)
                    {
                        MessageBox.Show(((ComboBox_Aerolinea)item).Pp_MensajeError);
                        ((ComboBox_Aerolinea)item).Focus();
                        return Resultado.error;
                    }

                    return Resultado.correcto;
                }
            }

            // Retornar error por defecto para no tener problemas con condiciones no manejadas
            return Resultado.error; 
        }
        public string CostructorInsert(string NombreTabla, Control.ControlCollection controles)
        {
            string sql = "INSERT INTO " + NombreTabla + " (";
            string columna = "";
            string tipoDatoColumna = "";
            string valorColumna = "";
            string paqueteColumnas = "";
            string paqueteValores = "";
            DataTable Estructura = new DataTable();

            Estructura = BuscarEstructuraTabla(NombreTabla);

            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                columna = Estructura.Columns[i].Caption;
                tipoDatoColumna = Estructura.Columns[i].DataType.Name;
                valorColumna = BuscarColumnaEnControles(columna, controles);
                if (valorColumna != string.Empty)
                {
                    valorColumna = FormatearDato(valorColumna, tipoDatoColumna);

                    if (paqueteColumnas == "")
                    {
                        paqueteColumnas = columna;
                        paqueteValores = valorColumna;
                    }
                    else
                    {
                        paqueteColumnas += ", " + columna;
                        paqueteValores += ", " + valorColumna;
                    }
                }
            }

            sql += paqueteColumnas + ") VALUES (" + paqueteValores + ")";
            //MessageBox.Show(sql);
            return sql;
        }
        private DataTable BuscarEstructuraTabla(string NombreTabla)
        {
            Conexion_DB _BD = new Conexion_DB();
            return _BD.EjecutarSelect("SELECT TOP 1 * FROM " + NombreTabla);
        }
        private string BuscarColumnaEnControles(string campo, Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox_Aerolinea")
                {
                    if (((TextBox_Aerolinea)item).Pp_NombreCampo == campo)
                    {
                        return ((TextBox_Aerolinea)item).Text;
                    }
                }
                if (item.GetType().Name == "ComboBox_Aerolinea")
                {
                    if (((ComboBox_Aerolinea)item).Pp_NombreCampo == campo)
                    {
                        return ((ComboBox_Aerolinea)item).SelectedValue.ToString();
                    }
                }
            }
            return "";

        }
        private string FormatearDato(string valorColumna, string tipoDatoColumna)
        {
            switch (tipoDatoColumna)
            {
                case "String":
                    return "'" + valorColumna + "'";
                case "Int16":
                case "Int32":
                case "Int64":
                    return valorColumna;
                default:
                    return valorColumna;
            }
        }


    }
}
