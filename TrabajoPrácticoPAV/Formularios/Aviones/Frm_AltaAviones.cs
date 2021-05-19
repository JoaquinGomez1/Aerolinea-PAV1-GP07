using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_AltaAviones : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Frm_AltaAviones()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        private void Frm_AltaAviones_Load(object sender, EventArgs e)
        {
            Estilo.FormatearEstilo(this.Controls);
            this.BackColor = Estilo.ColorFondoForms;

            this.BackColor = Estilo.ColorFondoForms;
            cmb_Modelo.CargarCombo();
           
        }

        private void btn_registrar_Click(object sender, EventArgs e)
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
