using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TrabajoPrácticoPAV.Clase;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_Asiento
    {
        Conexion_DB _BD = new Conexion_DB();
        public DataTable RecuperarXId(string id_Asiento)
        {
            string sql = "SELECT * FROM Asientos WHERE numeroAsiento =" + id_Asiento;
            return _BD.EjecutarSelect(sql);
        }
        
        public void Borrar(string id_Asiento)
        {
            string sqlDelete = @"DELETE FROM Asientos WHERE numeroAsiento = " + id_Asiento;
            _BD.Borrar(sqlDelete, false);
        }
        public string BuscarModelo(string idModelo)
        {
            return _BD.EjecutarSelect($"SELECT nombre FROM modelo WHERE idModelo = " +
                        $"{idModelo}").Rows[0]["nombre"].ToString();
        }
        public string BuscarClase(string idClase)
        {
            return _BD.EjecutarSelect($"SELECT nombre FROM Tipo_Asiento WHERE idTipo = " +
                        $"{idClase}").Rows[0]["nombre"].ToString();
        }
    }
}
