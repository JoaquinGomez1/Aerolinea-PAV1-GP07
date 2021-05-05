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





        public string ConstructorSelect(Control.ControlCollection controles, string join)
        {
            string sql = "SELECT ";
            string condiciones = "";
            string atributosTabla = "";

            foreach (var control in controles)
            {
                //SELECT ATRIBUTOS FROM TABLA
                if (control.GetType().ToString() == "TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea")
                {
                    DataGridView_Aerolinea grid = ((DataGridView_Aerolinea)control);
                    atributosTabla += $"{ExtraerColumnasGrid(grid)} FROM {grid.Pp_NombreTabla} {grid.Pp_NombreTabla}";
                }

                //Evaluación TEXTBOX
                if (control.GetType().ToString() == "TrabajoPrácticoPAV.Clase.TextBox_Aerolinea")
                {
                    TextBox_Aerolinea txt = (TextBox_Aerolinea)control;

                    //Crea la condición que se va a asignar
                    string condicion = $"{txt.Pp_NombreTabla}.{txt.Pp_NombreCampo}={FormatearDato(txt.Text)}";

                    if (txt.Text != "")
                    {
                        if (condiciones == "")
                            condiciones += " WHERE " + condicion;
                        else
                            condiciones += " AND " + condicion;
                    }
                }

                //Evaluación MASKEDTEXTBOX
                if (control.GetType().ToString() == "TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea")
                {
                    MaskedTextBox_Aerolinea txt = (MaskedTextBox_Aerolinea)control;

                    if (txt.Text != "")
                    {
                        //Crea la condición que se va a asignar
                        string condicion = $"{txt.Pp_NombreTabla}.{txt.Pp_NombreCampo}={FormatearDato(txt.Text)}";


                        //Asigna la primer condición
                        if (condiciones == "")
                            condiciones += " WHERE " + condicion;

                        //Asigna condiciones subsiguientes
                        else
                            condiciones += " AND " + condicion;
                    }
                }

                //Evaluación COMBOBOX
                if (control.GetType().ToString() == "TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea")
                {
                    ComboBox_Aerolinea cmb = (ComboBox_Aerolinea)control;
                    if (cmb.SelectedIndex != -1)
                    {
                        //Crea la condición que se va a asignar
                        string condicion = $"{cmb.Pp_NombreTabla}.{cmb.Pp_PkTabla}=" +
                            $"{FormatearDato(cmb.SelectedValue.ToString())}";

                        //Asigna la primer condición
                        if (condiciones == "")
                            condiciones += " WHERE " + condicion;

                        //Asigna condiciones subsiguientes
                        else
                            condiciones += " AND " + condicion;
                    }
                }
            }

            sql += atributosTabla + join + condiciones;
            Clipboard.SetText(sql);
            return sql;
        }

        private object FormatearDato(string dato)
        {
            try
            {
                int entero = int.Parse(dato);
                return entero;
            }
            catch (Exception)
            {
                return $"'{dato}'";
                throw;
            }
        }

        private string ExtraerColumnasGrid(DataGridView_Aerolinea grid)
        {
            string nombresColumnas = "";
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                if (nombresColumnas == "")
                {
                    nombresColumnas += grid.Pp_NombreTabla + "." + grid.Columns[i].Name.ToString();
                }
                else
                    nombresColumnas += ", " + grid.Pp_NombreTabla + "." + grid.Columns[i].Name.ToString();
            }
            return nombresColumnas;
        }


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

        //Dependiendo de la variable esUpdate va a generar una consulta de actualización o de borrado
        //MUY IMPORTANTE: En el diseño completar la propiedad Pp_EsPk de los controles
        public string CostructorUpdateDelete(string NombreTabla, Control.ControlCollection controles, bool esUpdate)
        {
            string sql = "";
            if (esUpdate)
                sql = $"UPDATE {NombreTabla}";
            else
                sql = $"DELETE FROM {NombreTabla}";
            string condiciones = "";
            string cambios = "";
            string tipoDatoColumna = "";
            string columna = "";
            string valorColumna = "";
            DataTable Estructura = new DataTable();

            Estructura = BuscarEstructuraTabla(NombreTabla);

            if (esUpdate)
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
                        if (txt.Pp_EsPk == BuscaPk)
                            return txt.Text;
                }
                if (item.GetType().Name == "ComboBox_Aerolinea")
                {
                    ComboBox_Aerolinea cmb = (ComboBox_Aerolinea)item;
                    //MessageBox.Show($"{cmb.Pp_NombreCampo} ha dado {cmb.Pp_EsPk} en buscaPK {BuscaPk} para espk y {!(cmb.Pp_EsPk == false ^ BuscaPk)} para la condición");
                    if (cmb.Pp_NombreCampoInsert == campo)
                    {
                        if (cmb.Pp_EsPk == BuscaPk)
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
