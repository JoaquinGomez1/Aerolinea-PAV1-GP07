using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.Formularios.Tipo_Asientos
{
    public partial class Frm_BajaTipoAsientos : Form
    {
        public string Pp_nombreBaja { get; set; }
        public object Pp_costo { get; set; }
        public string Id_Tipo { get; set; }
        Conexion_DB _BD = new Conexion_DB();
        public Frm_BajaTipoAsientos()
        {
            InitializeComponent();
        }

        private void Frm_BajaTipoAsientos_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            txt_ID.Text = Id_Tipo;
            txt_nombreBaja.Text = Pp_nombreBaja;
            txt_Costo.Text = Pp_costo.ToString(); ;
        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            Tratamientos_Especiales _TE = new Tratamientos_Especiales();
            string sql = _TE.CostructorUpdateDelete("Tipo_Asiento", this.Controls, false);
            _BD.Borrar(sql, true);
            this.Close();
        }
    }
}
