using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            avion.Pp_numero_modelo = int.Parse(txt_numero.Text.ToString());
            avion.Pp_id_modelo = int.Parse(cmb_Modelo.SelectedValue.ToString());

            avion.Insertar();

            this.Close();

        }

        private void Frm_AltaAviones_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
