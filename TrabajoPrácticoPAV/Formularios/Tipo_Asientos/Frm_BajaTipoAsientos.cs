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
        public string Id_Tipo { get; set; }
        public Frm_BajaTipoAsientos()
        {
            InitializeComponent();
        }

        private void Frm_BajaTipoAsientos_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            txt_nombreBaja.Text = Pp_nombreBaja;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Conexion_DB _BD = new Conexion_DB();

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales _TE = new Tratamientos_Especiales();
            string sql = _TE.CostructorUpdateDelete("Tipo_Asiento", this.Controls, false);
            _BD.Borrar(sql, true);
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
