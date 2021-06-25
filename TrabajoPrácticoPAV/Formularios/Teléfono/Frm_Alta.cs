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

namespace TrabajoPrácticoPAV.Formularios.Teléfono
{
    public partial class Frm_Alta : Form
    {
        public Frm_Alta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

            telefono.Insertar();
            this.Close();
        }
    }
}
