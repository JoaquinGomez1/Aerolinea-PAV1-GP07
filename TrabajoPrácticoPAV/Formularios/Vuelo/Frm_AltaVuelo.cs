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
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.Formularios.Vuelo
{
    public partial class Frm_AltaVuelo : Form
    {
        NE_Vuelos vuelo = new NE_Vuelos();
        public Frm_AltaVuelo()
        {
            InitializeComponent();
        }

        private void Frm_AltaVuelo_Load(object sender, EventArgs e)
        {
            cmb_nomModelo.CargarCombo();
            cmb_AeropDestino.CargarCombo();
            cmb_AeropSalida.CargarCombo();

            this.BackColor = Estilo.ColorFondoForms;
                Estilo.FormatearEstilo(this.Controls);
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales Tratamiento = new Tratamientos_Especiales();
            
            if (Tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                Conexion_DB _BD = new Conexion_DB();
                Tratamiento.Validar(this.Controls);
                if (cmb_AeropSalida.SelectedIndex != cmb_AeropDestino.SelectedIndex)
                {
                    string sql = Tratamiento.CostructorInsert("Vuelo", this.Controls);
                    _BD.Insertar(sql);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El aeropuerto de salida no puede ser igual al aeropuerto de destino. Seleccione otro");
                }
            }
            else
            {
                return;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_nomModelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //MessageBox.Show("descomentar esta parte");
            string Condicion = @" JOIN Modelo ON Modelo.idModelo " +
                    @"= Avion.idModelo WHERE Avion.idModelo = " + cmb_nomModelo.SelectedValue;
            cmb_numAvion.CargarComboJoin(Condicion);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }   
}
