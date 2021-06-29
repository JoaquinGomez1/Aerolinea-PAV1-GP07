using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_Equipaje
    {
        Conexion_DB _DB = new Conexion_DB();

        public DataTable RecuperarEquipaje()
        {
            string sql = @"SELECT Equipaje.idEquipaje, Equipaje.tipoDoc, Equipaje.numeroDoc, Equipaje.peso
                         FROM Equipaje";
                   
            DataTable resultadoSelect = _DB.EjecutarSelect(sql);
            return resultadoSelect;
        }

        public DataTable RecuperarPorRango(string Desde, string Hasta)
        {
            string sql = @"SELECT e.idEquipaje, e.tipoDoc, e.numeroDoc, e.peso FROM Equipaje e                            
                           WHERE e.peso BETWEEN " + Desde + " AND " + Hasta;

            return _DB.EjecutarSelect(sql);
        }

        public DataTable RecuperarPorPasajero(string tipoDoc, string numeroDoc)
        {
            string sql = @"SELECT * FROM Equipaje WHERE tipoDoc = " + tipoDoc + " AND numeroDoc = " + numeroDoc;
            return _DB.EjecutarSelect(sql);
        }
    }
}
