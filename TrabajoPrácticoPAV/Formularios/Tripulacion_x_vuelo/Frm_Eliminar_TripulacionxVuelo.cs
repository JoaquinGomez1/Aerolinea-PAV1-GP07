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
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Tripulacion_x_vuelo
{
    public partial class Frm_Eliminar_TripulacionxVuelo : Form
    {
        public int Pp_idTripulacion { get; set; }
        public int Pp_idVuelo { get; set; }
        NE_TripulacionxVuelo tripulacionxVuelo = new NE_TripulacionxVuelo();
        public Frm_Eliminar_TripulacionxVuelo()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frm_Modificar_TripulacionxVuelo_Load(object sender, EventArgs e)
        {
            tripulacionxVuelo.Pp_idTripulacion = Pp_idTripulacion;
            tripulacionxVuelo.Pp_idVuelo = Pp_idVuelo;
            MostrarDatos(tripulacionxVuelo.Recuperar_x_id());
        }
        private void MostrarDatos(DataTable tabla)
        {
            if (tabla.Rows.Count > 0)
            {
                txt_idTripulacion.Text = tabla.Rows[0]["idTripulacion"].ToString();
                txt_idVuelo.Text = tabla.Rows[0]["idVuelo"].ToString();
            }
            else
            {
                MessageBox.Show("No se han recuperado valores con estos ID");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            tripulacionxVuelo.Pp_idTripulacion = Pp_idTripulacion;
            tripulacionxVuelo.Pp_idVuelo = Pp_idVuelo;

            if (MessageBox.Show("¿Está seguro de Borrar la tripulación por vuelo?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                tripulacionxVuelo.Borrar();
                this.Close();
            }
        }
    }
}