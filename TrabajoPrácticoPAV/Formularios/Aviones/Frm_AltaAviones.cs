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
    public partial class Frm_AltaAviones : Form
    {
        public Frm_AltaAviones()
        {
            InitializeComponent();
        }

        private void Frm_AltaAviones_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            cmb_Modelo.CargarCombo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            NE_Avion avion = new NE_Avion();
            if (txt_numero.Text.Length > 4 | cmb_Modelo.SelectedIndex == -1 | txt_numero.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un numero de 4 digitos y seleccionar un modelo de avion");
                return;
            }
            avion.Pp_numero_modelo = int.Parse(txt_numero.Text.ToString());
            avion.Pp_id_modelo = int.Parse(cmb_Modelo.SelectedValue.ToString());

            avion.Insertar();

            this.Close();

        }

        private void Frm_AltaAviones_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void cmb_Modelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
