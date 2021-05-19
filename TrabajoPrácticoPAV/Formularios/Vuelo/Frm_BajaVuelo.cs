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
using System.Runtime.InteropServices;

namespace TrabajoPrácticoPAV.Formularios.Vuelo
{
    public partial class Frm_BorrarVuelo : Form
    {
        public string Id_vuelo { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        NE_Vuelos vuelo = new NE_Vuelos();

        public Frm_BorrarVuelo()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_BorrarVuelo_Load(object sender, EventArgs e)
        {
            cmb_numAvion.CargarCombo();
            cmb_nomModelo.CargarCombo();
            cmb_AeropDestino.CargarCombo();
            cmb_AeropSalida.CargarCombo();

            this.BackColor = Estilo.ColorFondoForms;
                Estilo.FormatearEstilo(this.Controls);

            MostrarDatos(vuelo.RecuperarXId(Id_vuelo));
        }
        private void MostrarDatos( DataTable tabla)
        {
            txt_idVuelo.Text = tabla.Rows[0]["idVuelo"].ToString();
           // txt_duracionestimada.Text = tabla.Rows[0]["duracionEstimada"].ToString();
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
            
            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                vuelo.Borrar(this.Controls);
                this.Close();
            }
        }

     
    }
}
