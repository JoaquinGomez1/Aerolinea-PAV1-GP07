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
using System.Runtime.InteropServices;
using TrabajoPrácticoPAV.NE_Usuarios;
using TrabajoPrácticoPAV.Clase.Modelos;

namespace TrabajoPrácticoPAV.Formularios.Reservas
{
    public partial class Frm_ModificarReserva : Form
    {
        private readonly NE_Reserva _NE = new NE_Reserva();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);
        public Frm_ABMReservas frm_reserva { get; set; }

        public Frm_ModificarReserva()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_ModificarReserva_Load(object sender, EventArgs e)
        {
            cmb_claseAsiento.CargarCombo();
            cmb_tipoDoc.CargarCombo();
            cmb_numReserva.CargarCombo();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmb_numReserva_TextChanged(object sender, EventArgs e)
        {
            if (cmb_numReserva.Text != null) {
                DataTable result = _NE.GetDataTableReserva(cmb_numReserva.Text.ToString());
                Reserva reserva = new Reserva()
                {
                    numeroDeViaje = result.Rows[0]["numeroDeViaje"].ToString(),
                    numeroDocTitular = result.Rows[0]["numeroDocTitular"].ToString(),
                    tipoDocTitular = result.Rows[0]["tipoDocTitular"].ToString(),
                };

                lbl_numViaje.Text = reserva.numeroDeViaje.ToString();
                mtxt_numDoc.Text = reserva.numeroDocTitular.ToString();
                cmb_tipoDoc.Text = reserva.tipoDocTitular.ToString();

                _NE.ModificarReserva(reserva);



            }

        }
    }
}
