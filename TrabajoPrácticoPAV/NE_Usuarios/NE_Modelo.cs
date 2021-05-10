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
    class NE_Modelo
    {
        Conexion_DB _BD = new Conexion_DB();
        public enum ResultadoValidacion { existe, no_existe }
     
        public DataTable RecuperarXId(string id_Modelo)
        {
            string sql = "SELECT * FROM modelo WHERE idModelo =" + id_Modelo;
            return _BD.EjecutarSelect(sql);
        }
        public void Borrar(string id_Modelo)
        {
            string sqlDelete = @"DELETE FROM modelo WHERE idModelo = " + id_Modelo;
            _BD.Borrar(sqlDelete, false);
        }
    }
}
