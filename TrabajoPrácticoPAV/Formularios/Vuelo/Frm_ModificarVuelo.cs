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
    public partial class Frm_ModificarVuelo : Form
    {
        public string Id_vuelo { get; set; }
        NE_Vuelos vuelo = new NE_Vuelos();

        public Frm_ModificarVuelo()
        {
            InitializeComponent();
        }

        private void Frm_ModificarVuelo_Load(object sender, EventArgs e)
        {

            cmb_AeropDestino.CargarCombo();
            cmb_numAvion.CargarCombo();
            cmb_nomModelo.CargarCombo();
            cmb_AeropSalida.CargarCombo();

            this.BackColor = Estilo.ColorFondoForms;
                Estilo.FormatearEstilo(this.Controls);

            
            MostrarDatos(vuelo.RecuperarXId(Id_vuelo));
        }
        private void MostrarDatos(DataTable tabla)
        {
            txt_idVuelo.Text = tabla.Rows[0]["idVuelo"].ToString();
            // txt_duracionestimada.Text = tabla.Rows[0]["duracionEstimada"].ToString();
            cmb_nomModelo.SelectedValue = int.Parse(tabla.Rows[0]["idModelo"].ToString());
            cmb_numAvion.SelectedValue = int.Parse(tabla.Rows[0]["numeroPorModelo"].ToString());
            cmb_AeropSalida.SelectedValue = tabla.Rows[0]["codigoAeropuertoSalida"].ToString();
            cmb_AeropDestino.SelectedValue = tabla.Rows[0]["codigoAeropuertoDestino"].ToString();
           
        }

        private void button_Aerolinea2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ModificacionVuelo_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales Tratamiento = new Tratamientos_Especiales();

            if (cmb_AeropSalida.SelectedIndex != cmb_AeropDestino.SelectedIndex)
            {
                vuelo.Modificar(this.Controls);
                this.Close();
            }
        }

        private void cmb_nomModelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_numAvion.SelectedIndex = -1;
            string Condicion = @" JOIN Modelo ON Modelo.idModelo " +
                    @"= Avion.idModelo WHERE Avion.idModelo = " + cmb_nomModelo.SelectedValue;
            cmb_numAvion.CargarComboJoin(Condicion);
        }
        //private void cmb_nomModelo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //   
        //    string Condicion = @" JOIN Modelo ON Modelo.idModelo " +
        //              @"= Avion.idModelo";
        //    if (cmb_nomModelo.SelectedIndex != 0)
        //    {
        //         Condicion += @" WHERE Avion.idModelo = " + cmb_nomModelo.SelectedValue;

        //}
        //    cmb_numAvion.CargarComboJoin(Condicion);

        //}
        private void cmb_AeropSalida_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_AeropDestino.SelectedIndex = -1;
            string join = @" JOIN Tramo ON Tramo.codigoAeropuertoSalida " +
                    @"= aeropuerto.codigo WHERE Tramo.codigoAeropuertoDestino = '" + cmb_AeropSalida.SelectedValue + "'";
            cmb_AeropDestino.CargarComboJoin(join);
        }

        private void cmb_AeropSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            string join = @" JOIN Tramo ON Tramo.codigoAeropuertoSalida " +
                   @"= aeropuerto.codigo WHERE Tramo.codigoAeropuertoDestino = '" + cmb_AeropSalida.SelectedValue + "'";
            cmb_AeropDestino.CargarComboJoin(join);
        }
        
    }
}
