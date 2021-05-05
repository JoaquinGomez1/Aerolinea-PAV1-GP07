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
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.Formularios.Vuelo
{
    public partial class Frm_BorrarVuelo : Form
    {
        public string Id_vuelo { get; set; }

        public Frm_BorrarVuelo()
        {
            InitializeComponent();
        }

        private void Frm_BorrarVuelo_Load(object sender, EventArgs e)
        {
            cmb_numAvion.CargarCombo();
            cmb_nomModelo.CargarCombo();
            cmb_AeropDestino.CargarCombo();
            cmb_AeropSalida.CargarCombo();

            NE_Vuelos vuelo = new NE_Vuelos();
            MostrarDatos(vuelo.RecuperarXId(Id_vuelo));
        }
        private void MostrarDatos( DataTable tabla)
        {
            txt_idVuelo.Text = tabla.Rows[0]["idVuelo"].ToString();
            txt_duracionestimada.Text = tabla.Rows[0]["duracionEstimada"].ToString();
            cmb_numAvion.SelectedValue = int.Parse(tabla.Rows[0]["numeroPorModelo"].ToString());
            cmb_nomModelo.SelectedValue = int.Parse(tabla.Rows[0]["idModelo"].ToString());
            cmb_AeropDestino.SelectedValue = tabla.Rows[0]["codigoAeropuertoDestino"].ToString();
            cmb_AeropSalida.SelectedValue = tabla.Rows[0]["codigoAeropuertoSalida"].ToString();

        }

        private void button_Aerolinea2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ModificacionVuelo_Click(object sender, EventArgs e)
        {
            NE_Vuelos vuelo = new NE_Vuelos();
            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                vuelo.Borrar(Id_vuelo);
                MessageBox.Show("Se borró correctamente el vuelo");
                this.Close();
            }
        }
    }
}
