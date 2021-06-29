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

namespace TrabajoPrácticoPAV.Formularios.Tripulacion_x_vuelo
{
    public partial class Frm_Alta_TripulacionxVuelo : Form
    {
        public Frm_Alta_TripulacionxVuelo()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            NE_TripulacionxVuelo tripulacionxVuelo = new NE_TripulacionxVuelo();
            if (txt_idTripulacion.Text == " " |  txt_idVuelo.Text == " ")
            {
                MessageBox.Show("Debe ingresar un número de teléfono, tipo de documento y número de documento");
                return;
            }
            tripulacionxVuelo.Pp_idTripulacion = int.Parse(txt_idTripulacion.Text.ToString());
            tripulacionxVuelo.Pp_idVuelo = int.Parse(txt_idVuelo.Text.ToString());

            tripulacionxVuelo.Insertar();
            this.Close();
        }
    }
}
