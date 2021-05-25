using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPrácticoPAV.Clase
{
    class DataGridView_Aerolinea : DataGridView
    {
        public string Pp_FormatoGrid { get; set; }
        public string Pp_NombreTabla { get; set; }
   
        ///El formato se pasa de la siguiente forma ("NombreDelCampoEnLaBD, NombreAMostrarEnLaGrid, Ancho; ...")
        
        public void Formatear()
        {
            string[] datos_columna = Pp_FormatoGrid.Split(';');
            for (int i = 0; i < datos_columna.Length; i++)
            {
                string[] datos = datos_columna[i].Split(',');
                this.Columns.Add(datos[0].ToString(), datos[1].ToString());
                this.Columns[i].Width = int.Parse(datos[2].ToString());
            }
        }
    }
}
