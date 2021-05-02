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


        public string ConstructorSelect(Control.ControlCollection controles)
        {
            string tablas = "";
            string[] todasTablas;
            string sql = "SELECT ";
            string nombreTablaGrid = "";
            string condiciones = "";
            string atributosTabla = "";

            foreach (var control in controles)
            {
                //SELECT ATRIBUTOS FROM TABLA
                if (control.GetType().ToString() == "TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea")
                {
                    DataGridView_Aerolinea grid = ((DataGridView_Aerolinea)control);
                    nombreTablaGrid = grid.Pp_NombreTabla;
                    atributosTabla += ExtraerColumnasGrid(grid) + " FROM " + grid.Pp_NombreTabla + " " + grid.Pp_NombreTabla;
                }

                //Evaluación TEXTBOX
                if (control.GetType().ToString() == "TrabajoPrácticoPAV.Clase.TextBox_Aerolinea")
                {
                    TextBox_Aerolinea txt = (TextBox_Aerolinea)control;

                    //Crea la condición que se va a asignar
                    string condicion = txt.Pp_NombreTabla + "." + txt.Pp_NombreCampo + " = " + txt.Text;

                    if (txt.Text != "")
                    {
                        //Guardar el nombre de las tablas
                        if (tablas == "")
                            tablas = txt.Pp_NombreTabla;
                        else
                            tablas += "," + txt.Pp_NombreTabla;

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
                    if (txt.Text != string.Empty)
                    {
                        //Crea la condición que se va a asignar
                        string condicion = txt.Pp_NombreTabla + "." + txt.Pp_NombreCampo + " = " + txt.Text;

                        //Guardar el nombre de las tablas
                        if (tablas == "")
                            tablas = txt.Pp_NombreTabla;
                        else
                            tablas += "," + txt.Pp_NombreTabla;
                        
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
                        string condicion = cmb.Pp_NombreTabla + "." + cmb.Pp_PkTabla +
                                    " = " + cmb.SelectedValue.ToString();

                        //Guardar el nombre de la tabla que interviene
                        if (tablas == "")
                            tablas = cmb.Pp_NombreTabla;
                        else
                            tablas += "," + cmb.Pp_NombreTabla;

                        //Asigna la primer condición
                        if (condiciones == "")
                            condiciones += " WHERE " + condicion;

                        //Asigna condiciones subsiguientes
                        else
                            condiciones += " AND " + condicion;
                    }
                }
            }

            #region CreadorDeJOIN
            todasTablas = tablas.Split(',');
            todasTablas = todasTablas.Distinct().ToArray();

            string join = "";

            if (todasTablas.Length > 1)
            {
                DataTable EstructuraTablaGrid = BuscarEstructuraTabla(nombreTablaGrid);
                DataTable EstructuraTabla = new DataTable();
                foreach (string tabla in todasTablas)
                {
                    if (tabla != nombreTablaGrid)
                    {
                        MessageBox.Show(tabla + "!=" + nombreTablaGrid);
                        EstructuraTabla = BuscarEstructuraTabla(tabla);
                        for (int i = 0; i < EstructuraTablaGrid.Columns.Count; i++)
                        {
                            for (int j = 0; j < EstructuraTabla.Columns.Count; j++)
                            {
                                string nombreColumnaTabla = EstructuraTabla.Columns[j].Caption;
                                string nombreColumnaTablaGrid = EstructuraTablaGrid.Columns[i].Caption;

                                if (nombreColumnaTabla == nombreColumnaTablaGrid)
                                    join += " JOIN " + tabla + " " + tabla + " ON "
                                        + tabla + "." + nombreColumnaTabla + " = " + nombreTablaGrid + "."
                                        + nombreColumnaTablaGrid + " ";

                            }
                        }
                    }
                }
            }

            sql += atributosTabla + join + condiciones;
            return sql;

            #endregion
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
    }
}
