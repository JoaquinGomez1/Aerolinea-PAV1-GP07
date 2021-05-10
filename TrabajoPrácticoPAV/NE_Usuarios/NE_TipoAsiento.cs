using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_TipoAsiento
    {
        Conexion_DB _BD = new Conexion_DB();
        public enum ResultadoValidacion { existe, no_existe }
        //public string BuscarTodos()
        //{
        //    string sql = "SELECT * FROM asientos WHERE idVuelo";
        //    return _BD.EjecutarSelect(sql);
        //}
        public DataTable RecuperarXId(string idTipo)
        {
            string sql = "SELECT * FROM Tipo_Asiento WHERE idTipo =" + idTipo;
            return _BD.EjecutarSelect(sql);
        }


        public void Borrar(string idTipo)
        {
            string sqlDelete = @"DELETE FROM Tipo_Asiento WHERE idTipo = " + idTipo;
            _BD.Borrar(sqlDelete, false);
        }
    }
}
