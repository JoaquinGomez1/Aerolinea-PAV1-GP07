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

namespace TrabajoPrácticoPAV.Formularios.Pasajeros
{
    public partial class Frm_AltaPasajero : Form
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

        public Frm_AltaPasajero()
        {
            InitializeComponent();
        }

        private void Frm_AltaPasajero_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            Cmb_Pais.CargarCombo();

        }

        private void Cmb_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cmb_Pais.SelectedIndex != 0 && Cmb_Pais.SelectedIndex != -1)
            {
                MessageBox.Show(Cmb_Pais.SelectedIndex.ToString());
                string joinYCond = $" JOIN Pais ON Pais.idPais = Provincia.idPais WHERE Pais.idPais = {Cmb_Pais.SelectedValue} ";
                MessageBox.Show(joinYCond);
                Cmb_Provincia.CargarComboJoin(joinYCond);
            }
        }
    }
}
