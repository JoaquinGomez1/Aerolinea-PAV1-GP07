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
    class NE_Clientes
    {

        private Conexion_DB _DB = new Conexion_DB();

        public void CargarGrilla(string sql, DataGridView_Aerolinea grid)
        {
            DataTable tabla = _DB.EjecutarSelect(sql);
            grid.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid.Rows.Add();
                grid.Rows[i].Cells[0].Value = tabla.Rows[i]["nombre"].ToString();
                grid.Rows[i].Cells[1].Value = tabla.Rows[i]["apellido"].ToString();
                grid.Rows[i].Cells[2].Value = tabla.Rows[i]["tipoDoc"].ToString();
                grid.Rows[i].Cells[3].Value = tabla.Rows[i]["numeroDoc"].ToString();
            }

    }
}
}
