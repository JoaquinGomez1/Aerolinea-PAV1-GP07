using System;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;
using TrabajoPrácticoPAV.Backend;
using System.Runtime.InteropServices;

namespace TrabajoPrácticoPAV.Formularios.Vuelo
{
    public partial class Frm_AltaVuelo : Form
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

        NE_Vuelos vuelo = new NE_Vuelos();
        public Frm_AltaVuelo()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_AltaVuelo_Load(object sender, EventArgs e)
        {
            cmb_nomModelo.CargarCombo();
            cmb_AeropSalida.CargarCombo();


            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }
        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_nomModelo_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            string Condicion = @" JOIN Modelo ON Modelo.idModelo " +
                   @"= Avion.idModelo WHERE Avion.idModelo = " + cmb_nomModelo.SelectedValue;
            cmb_numAvion.CargarComboJoin(Condicion);
        }

        private void cmb_AeropSalida_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string join = @" JOIN Tramo ON Tramo.codigoAeropuertoSalida " +
                    @"= aeropuerto.codigo WHERE Tramo.codigoAeropuertoDestino = '" + cmb_AeropSalida.SelectedValue + "'";
            cmb_AeropDestino.CargarComboJoin(join);
        }

        private void btn_Registrar_Click_1(object sender, EventArgs e)
        {
            Tratamientos_Especiales Tratamiento = new Tratamientos_Especiales();

            if (Tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                Tratamiento.Validar(this.Controls);
                if (cmb_AeropSalida.SelectedIndex != cmb_AeropDestino.SelectedIndex)
                {
                    vuelo.Insertar(this.Controls);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El aeropuerto de salida no puede ser igual al aeropuerto de destino. Seleccione otro");
                }
            }

        }
    }
}
