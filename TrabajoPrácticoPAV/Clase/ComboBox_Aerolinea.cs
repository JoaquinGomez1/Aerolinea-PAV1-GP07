using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.Clase
{
    class ComboBox_Aerolinea : ComboBox
    {
        public string Pp_PkTabla { get; set; }
        public string Pp_NombreCampo { get; set; }
        public string Pp_MensajeError { get; set; }
        public string Pp_NombreTabla { get; set; }
        public bool Pp_CampoAceptaNull { get; set; }

        Conexion_DB _BD = new Conexion_DB();

        public void CargarCombo()
        {
            string sql = "SELECT " + Pp_PkTabla + ", " + Pp_NombreCampo + " FROM " + Pp_NombreTabla;
            this.DisplayMember = Pp_NombreCampo;
            this.ValueMember = Pp_PkTabla;
            this.DataSource = _BD.EjecutarSelect(sql);
            if (this.Pp_CampoAceptaNull == true)
            {
                this.SelectedIndex = -1;
                this.Text =  "Seleccionar " + Pp_NombreTabla + " ...";
            }
            else
            {
                this.SelectedIndex = 0;
            }
        }

        public void CargarComboDependiente(string dependencia)
        {
            string sql = "SELECT " + Pp_PkTabla + ", " + Pp_NombreCampo + " FROM " + Pp_NombreTabla;
            this.DisplayMember = Pp_NombreCampo;
            this.ValueMember = Pp_PkTabla;
            this.DataSource = _BD.EjecutarSelect(sql);
            if (this.Pp_CampoAceptaNull == true)
            {
                this.SelectedIndex = -1;
            }
            else
            {
                this.SelectedIndex = 0;
            }
        }
    }
}
