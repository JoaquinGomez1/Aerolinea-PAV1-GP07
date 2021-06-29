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
            if (txt_nroTelefono.Text == " " | txt_nroDoc.Text == " " | txt_tipoDoc.Text == " ")
            {
                MessageBox.Show("Debe ingresar un número de teléfono, tipo de documento y número de documento");
                return;
            }
            telefono.Pp_numeroTelefono = txt_nroTelefono.Text.ToString();
            telefono.Pp_tipoDoc = int.Parse(txt_tipoDoc.Text.ToString());
            telefono.Pp_numeroDoc = int.Parse(txt_nroDoc.Text.ToString());

            telefono.Modificar();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ModificacionTelefono_Load(object sender, EventArgs e)
        {
            Estilo.FormatearEstilo(this.Controls);
            this.BackColor = Estilo.ColorFondoForms;
            NE_Telefonos telefono = new NE_Telefonos();
            telefono.Pp_numeroTelefono = Pp_numeroTelefono;
            MostrarDatos(telefono.Recuperar_x_numero());
        }
        private void MostrarDatos(DataTable tabla)
        {
            if (tabla.Rows.Count > 0)
            {
                txt_nroTelefono.Text = tabla.Rows[0]["numeroTelefono"].ToString();
                txt_tipoDoc.Text = tabla.Rows[0]["tipoDoc"].ToString();
                txt_nroDoc.Text = tabla.Rows[0]["numeroDoc"].ToString();
            }
            else
            {
                MessageBox.Show("No se recuperó un teléfono con ese número");
            }
        }

    }
}
