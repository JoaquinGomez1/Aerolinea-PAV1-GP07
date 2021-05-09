using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_GrupoFamiliar
    {
        Conexion_DB _BD = new Conexion_DB();

        public void CargarGrilla(string sql, DataGridView_Aerolinea grid)
        {
            DataTable tabla = _BD.EjecutarSelect(sql);
            grid.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                string tipoDoc1 = tabla.Rows[i]["tipoDocumentoPrimerPasajero"].ToString();
                string tipoDoc2 = tabla.Rows[i]["tipoDocumentoSegundoPasajero"].ToString();
                string numeroDoc1 = tabla.Rows[i]["numeroDocumentoPrimerPasajero"].ToString();
                string numeroDoc2 = tabla.Rows[i]["numeroDocumentoSegundoPasajero"].ToString();

                grid.Rows.Add();
                grid.Rows[i].Cells[0].Value = RecuperarNombreUsuario(tipoDoc1, numeroDoc1);
                grid.Rows[i].Cells[1].Value = RecuperarApellidoUsuario(tipoDoc1, numeroDoc1);
                grid.Rows[i].Cells[2].Value = tabla.Rows[i]["tipoParentesco"].ToString();
                grid.Rows[i].Cells[3].Value = RecuperarNombreUsuario(tipoDoc2, numeroDoc2);
                grid.Rows[i].Cells[4].Value = RecuperarApellidoUsuario(tipoDoc2, numeroDoc2);
            }
        }

        private string RecuperarNombreUsuario(string numeroDoc, string tipoDoc)
        {
            string sql = $"SELECT nombre, apellido FROM Pasajeros WHERE idTipoDoc = {tipoDoc} AND " +
                $"numeroDoc = {numeroDoc}";
            return _BD.EjecutarSelect(sql).Rows[0]["nombre"].ToString();
        }

        private string RecuperarApellidoUsuario(string numeroDoc, string tipoDoc)
        {
            string sql = $"SELECT nombre, apellido FROM Pasajeros WHERE idTipoDoc = {tipoDoc} AND " +
                $"numeroDoc = {numeroDoc}";
            return  _BD.EjecutarSelect(sql).Rows[0]["apellido"].ToString();
        }
    }
}
