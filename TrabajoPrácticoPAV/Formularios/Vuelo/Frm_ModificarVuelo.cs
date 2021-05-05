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

        public Frm_ModificarVuelo()
        {
            InitializeComponent();
        }

        private void Frm_ModificarVuelo_Load(object sender, EventArgs e)
        {
            cmb_numAvion.CargarCombo();
            cmb_nomModelo.CargarCombo();
            cmb_AeropDestino.CargarCombo();
            cmb_AeropSalida.CargarCombo();

            NE_Vuelos vuelo = new NE_Vuelos();
            MostrarDatos(vuelo.RecuperarXId(Id_vuelo));

        }
        private void MostrarDatos(DataTable tabla)
        {
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
            Tratamientos_Especiales Tratamiento = new Tratamientos_Especiales();
            Conexion_DB _BD = new Conexion_DB();
            if (Tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {

                Tratamiento.Validar(this.Controls);

                string sql = Tratamiento.CostructorUpdateDelete("Vuelo", this.Controls, true);
                _BD.Insertar(sql);

                //NE_Vuelos vuelo = new NE_Vuelos()

                //{
                //    Pp_duracionEst = txt_duracionestimada.Text,
                //    Pp_numPorModelo = cmb_numAvion.SelectedValue.ToString(),
                //    Pp_modelo = cmb_nomModelo.SelectedValue.ToString(),
                //    Pp_id_vuelo = Id_vuelo,
                //};

                // string sql = Tratamiento.CostructorInsert("Vuelo", this.Controls);
                //// _BD.Insertar(sql);

                // vuelo.Modificar(this.Controls);
            }
            else
            {
                return;
            }
        }


    }
}
