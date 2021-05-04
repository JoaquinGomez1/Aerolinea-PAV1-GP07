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
                }

                if (item.GetType().Name == "ComboBox_Aerolinea")
                {
                    if (((ComboBox_Aerolinea)item).SelectedIndex == -1)
                    {
                        MessageBox.Show(((ComboBox_Aerolinea)item).Pp_MensajeError);
                        ((ComboBox_Aerolinea)item).Focus();
                        return Resultado.error;
                    }
                }
            }
            return Resultado.correcto;
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

        public string CostructorUpdate(string NombreTabla, Control.ControlCollection controles)
        {
            string sql = $"UPDATE {NombreTabla}";
            string condiciones = "";
            string cambios = "";
            string tipoDatoColumna = "";
            string columna = "";
            string valorColumna = "";
            DataTable Estructura = new DataTable();

            Estructura = BuscarEstructuraTabla(NombreTabla);

            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                valorColumna = "";
                columna = Estructura.Columns[i].Caption;
                valorColumna = BuscarColumnaEnControlesSegunPk(columna, controles, false);
                tipoDatoColumna = Estructura.Columns[i].DataType.ToString();

                if (valorColumna != "")
                {
                    valorColumna = FormatearDato(valorColumna, tipoDatoColumna);
                    if (cambios == "")
                        cambios += $" SET {columna} = {valorColumna}";
                    else
                        cambios += $", {columna} = {valorColumna}";
                }
            }
            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                valorColumna = "";
                columna = Estructura.Columns[i].Caption;
                valorColumna = BuscarColumnaEnControlesSegunPk(columna, controles, true);
                tipoDatoColumna = Estructura.Columns[i].DataType.ToString();

                if (valorColumna != "")
                {
                    valorColumna = FormatearDato(valorColumna, tipoDatoColumna);
                    if (condiciones == "")
                        condiciones += $" WHERE {columna} = {valorColumna}";
                    else
                        condiciones += $" AND {columna} = {valorColumna}";
                }
            }
            return $"{sql}{cambios}{condiciones}";
        }

        public DataTable BuscarEstructuraTabla(string NombreTabla)
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
                    TextBox_Aerolinea txt = (TextBox_Aerolinea)item;

                    if (txt.Pp_NombreCampo == campo)
                        return txt.Text;
                }
                if (item.GetType().Name == "ComboBox_Aerolinea")
                {
                    ComboBox_Aerolinea cmb = (ComboBox_Aerolinea)item;

                    if (cmb.Pp_NombreCampoInsert == campo)
                        return cmb.SelectedValue.ToString();
                }
            }
            return "";

        }
        private string BuscarColumnaEnControlesSegunPk(string campo, Control.ControlCollection controles, bool BuscaPk)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox_Aerolinea")
                {
                    TextBox_Aerolinea txt = (TextBox_Aerolinea)item;

                    //El operador ^ es un OR exclusivo y al estar negado 
                    //la condición solo entra si ambos son V o ambos son F
                    if (txt.Pp_NombreCampo == campo)
                        if(txt.Pp_EsPk == BuscaPk)
                        return txt.Text;
                }
                if (item.GetType().Name == "ComboBox_Aerolinea")
                {
                    ComboBox_Aerolinea cmb = (ComboBox_Aerolinea)item;
                    //MessageBox.Show($"{cmb.Pp_NombreCampo} ha dado {cmb.Pp_EsPk} en buscaPK {BuscaPk} para espk y {!(cmb.Pp_EsPk == false ^ BuscaPk)} para la condición");
                    if (cmb.Pp_NombreCampoInsert == campo)
                    {
                        if(cmb.Pp_EsPk == BuscaPk)
                            return cmb.SelectedValue.ToString();
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
                case "System.String":
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
