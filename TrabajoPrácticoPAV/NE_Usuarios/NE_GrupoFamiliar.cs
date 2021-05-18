using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_GrupoFamiliar
    {
        Conexion_DB _BD = new Conexion_DB();
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();

        public void CargarGrilla(string sql, DataGridView_Aerolinea grid)
        {
            DataTable tabla = _BD.EjecutarSelect(sql);

            grid.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                //Recupera los tipos y números de documento de cada pasajero de la relación para mostrar en su lugar, sus nombres
                string tipoDoc1 = tabla.Rows[i]["tipoDocPrimerPasajero"].ToString();
                string tipoDoc2 = tabla.Rows[i]["tipoDocSegundoPasajero"].ToString();
                string numeroDoc1 = tabla.Rows[i]["numerodocPrimerPasajero"].ToString();
                string numeroDoc2 = tabla.Rows[i]["numerodocSegundoPasajero"].ToString();

                //Completa la tabla con nombres y apellidos en lugar de tipo y numero de documento
                grid.Rows.Add();
                grid.Rows[i].Cells[0].Value = tipoDoc1;
                grid.Rows[i].Cells[1].Value = numeroDoc1;
                grid.Rows[i].Cells[2].Value = tipoDoc2;
                grid.Rows[i].Cells[3].Value = numeroDoc2;
                grid.Rows[i].Cells[4].Value = RecuperarNombrePasajero(tipoDoc1, numeroDoc1);
                grid.Rows[i].Cells[5].Value = RecuperarApellidoPasajero(tipoDoc1, numeroDoc1);
                grid.Rows[i].Cells[6].Value = tabla.Rows[i]["tipoParentesco"].ToString();
                grid.Rows[i].Cells[7].Value = RecuperarNombrePasajero(tipoDoc2, numeroDoc2);
                grid.Rows[i].Cells[8].Value = RecuperarApellidoPasajero(tipoDoc2, numeroDoc2);
            }
        }

        /// <summary>
        /// Recupera el nombre del Pasajero pasando el tipoDoc y numeroDoc como strings 
        /// </summary>
        public string RecuperarNombrePasajero(string tipoDoc, string numeroDoc)
        {
            string sql = $"SELECT nombre FROM Pasajero WHERE tipoDoc = {tipoDoc} AND " +
                $"numeroDoc = {numeroDoc}";
            return _BD.EjecutarSelect(sql).Rows[0]["nombre"].ToString();
        }

        /// <summary>
        /// Recupera el apellido del Pasajero pasando el tipoDoc y numeroDoc como strings 
        /// </summary>
        public string RecuperarApellidoPasajero(string tipoDoc, string numeroDoc)
        {
            string sql = $"SELECT apellido FROM Pasajero WHERE tipoDoc = {tipoDoc} AND " +
                $"numeroDoc = {numeroDoc}";
            return  _BD.EjecutarSelect(sql).Rows[0]["apellido"].ToString();
        }


        /// <summary>
        /// Construye un select con join doble a la tabla Pasajero desde la tabla Familiar_X_Pasajero
        /// Busca por parámetros de pasajeros aquellos que participen en una relación como primer o segundo miembro
        /// </summary>
        public string ConstructorSelect(Control.ControlCollection controles)
        {
            bool todos = false;
            string sql = "SELECT DISTINCT fp.*FROM Familiar_X_Pasajero fp JOIN Pasajero p ON(p.tipoDoc = fp.tipoDocPrimerPasajero AND p.numeroDoc = fp.numerodocPrimerPasajero)"
                + "OR(p.tipoDoc = fp.tipoDocSegundoPasajero AND p.numeroDoc = fp.numerodocSegundoPasajero)";
            string condiciones = "";

            foreach (var item in controles)
            {
                string condicion = "";
                if (item.GetType().ToString() == "TrabajoPrácticoPAV.Clase.TextBox_Aerolinea")
                {
                    TextBox_Aerolinea txt = (TextBox_Aerolinea)item;
                    if(txt.Text != "")
                        condicion = $" p.{txt.Pp_NombreCampo} LIKE {_TE.FormatearDato(txt.Text, true)}";

                }
                if (item.GetType().ToString() == "TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea")
                {
                    MaskedTextBox_Aerolinea txt = (MaskedTextBox_Aerolinea)item;
                    if (txt.Text != "")
                        condicion = $" p.{txt.Pp_NombreCampo} LIKE {_TE.FormatearDato(txt.Text, true)}";
                }
                if (item.GetType().ToString() == "TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea")
                {
                    ComboBox_Aerolinea cmb = (ComboBox_Aerolinea)item;
                    if (cmb.SelectedIndex != -1)
                        condicion = $" p.{cmb.Pp_NombreCampoInsert} = {_TE.FormatearDato(cmb.SelectedValue.ToString(),false)}";
                }
                if (item.GetType().ToString() == "System.Windows.Forms.CheckBox")
                {
                    CheckBox chb = (CheckBox)item;
                    if (chb.Checked)
                        todos = true;
                }
                if (condiciones == "" && condicion != "")
                    condiciones += $" WHERE {condicion}";
                else if (condicion != "")
                    condiciones += condicion;
            }
            if (todos)
                condiciones = "";
            return $"{sql} {condiciones}";
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


        private void CargarGrillaPasajero(string sql, DataGridView_Aerolinea grid)
        {
            DataTable tabla = _BD.EjecutarSelect(sql);
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
    }
}
