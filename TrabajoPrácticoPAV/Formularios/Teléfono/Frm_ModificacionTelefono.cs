using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.NE_Usuarios;
using TrabajoPrácticoPAV.Clase;

namespace TrabajoPrácticoPAV.Formularios.Teléfono
{
    public partial class Frm_ModificacionTelefono : Form
    {
        public string Pp_numeroTelefono { get; set; }
        public int Pp_tipoDoc { get; set; }
        public int Pp_numeroDoc { get; set; }
        public Frm_ModificacionTelefono()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            NE_Telefonos telefono = new NE_Telefonos();
            if (txt_nroTelefono.Pp_Text == " " | txt_nroDoc.Pp_Text == " " | txt_tipoDoc.Pp_Text == " ")
            {
                MessageBox.Show("Debe ingresar un número de teléfono, tipo de documento y número de documento");
                return;
            }
            telefono.Pp_numeroTelefono = txt_nroTelefono.Pp_Text.ToString();
            telefono.Pp_tipoDoc = int.Parse(txt_tipoDoc.Pp_Text.ToString());
            telefono.Pp_numeroDoc = int.Parse(txt_nroDoc.Pp_Text.ToString());

            telefono.Modificar();
            this.Close();
        }
        
    }
}
