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
using TrabajoPrácticoPAV.NE_Aviones;



namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ModificarAvion : Form
    {
        public string Pp_numeroSeleccionado { get; set; } 

        public object Pp_idModeloSeleccionado { get; set; }
        public Frm_ModificarAvion()
        {
            InitializeComponent();
        }

        private void textBox_Aerolinea1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Modelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_ModificarAvion_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            cmb_Modelo.CargarCombo();
            txt_Numero.Text = Pp_numeroSeleccionado;
            cmb_Modelo.SelectedIndex = int.Parse(Pp_idModeloSeleccionado.ToString()) - 1;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            NE_Avion avion = new NE_Avion();
            string numero = txt_Numero.Text;
            var idModelo = cmb_Modelo.SelectedIndex.ToString();
            avion.Editar_avion(numero,  idModelo);
        }
    }
}
