using System;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;
using System.Runtime.InteropServices;
using static TrabajoPrácticoPAV.Clase.Tratamientos_Especiales;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.Formularios.Facturaciones
{
    public partial class Frm_MostrarFacturacion : Form
    {
        public string Id_reserva { get; set; }
        private NE_Facturacion facturacion = new NE_Facturacion();
        private Conexion_DB _BD = new Conexion_DB();
        public DataTable pasajero { get; set; }
        public DataTable vuelo { get; set; }

        #region Movimiento de la barra

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion Movimiento de la barra

        public Frm_MostrarFacturacion()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_MostrarFacturacion_Load(object sender, EventArgs e)
        {
            Estilo.FormatearEstilo(this.Controls);
            this.BackColor = Estilo.ColorFondoForms;

            grid_vuelo.Formatear();
            cmb_formaPago.CargarCombo();
            cmb_formaPago.SelectedIndex = -1;
            btn_GenerarFactura.Enabled = false;

            pasajero = facturacion.RecuperarPasajero(Id_reserva);
            vuelo = facturacion.RecuperarVueloxReserva(Id_reserva);
            MostrarDatos(pasajero, vuelo);
        }

        private void MostrarDatos(DataTable pasajero, DataTable vuelo)
        {
            txt_numeroReserva.Text = Id_reserva;
            txt_numeroDoc.Text = pasajero.Rows[0][0].ToString();
            txt_tipoDoc.Text = pasajero.Rows[0][1].ToString();
            txt_nombre.Text = pasajero.Rows[0][2].ToString();
            txt_apellido.Text = pasajero.Rows[0][3].ToString();
            txt_fechaPago.Text = facturacion.RecuperarFechaActual();

            if (vuelo.Rows.Count != 0)
                facturacion.CargarGrillaVuelos(vuelo, grid_vuelo);
            else
            {
                MessageBox.Show("No hay facturas para la reserva.");
                this.Close();
            }
        }

        private void cmb_formaPago_SelectedValueChanged(object sender, EventArgs e)
        {
            btn_GenerarFactura.Enabled = true;
        }

        private void btn_GenerarFactura_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales Tratamiento = new Tratamientos_Especiales();

            if (Tratamiento.Validar(this.Controls) == Resultado.correcto)
                facturacion.Insertar($"{txt_numeroReserva.Text}, {cmb_formaPago.SelectedValue}");
        }
    }
}