using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Facturaciones
{
    public partial class Frm_ConsultarFactura : Form
    {
        public string Id_reserva { get; set; }
        NE_Facturacion facturacion = new NE_Facturacion();
        Conexion_DB _BD = new Conexion_DB();
        public DataTable pasajero { get; set; }
        public DataTable vuelo { get; set; }
        public DataTable factura { get; set; }

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
        #endregion
        public Frm_ConsultarFactura()
        {
            InitializeComponent();
        }

        private void Frm_ConsultarFactura_Load(object sender, EventArgs e)
        {
            Estilo.FormatearEstilo(this.Controls);
            this.BackColor = Estilo.ColorFondoForms;

            grid_vuelo.Formatear();
            cmb_formaPago.CargarCombo();

            pasajero = facturacion.RecuperarPasajero(Id_reserva);
            vuelo = facturacion.RecuperarVueloxReserva(Id_reserva);
            factura = facturacion.RecuperarFactura(Id_reserva);
            if (factura.Rows.Count != 0)
            {
                MostrarDatos(pasajero, vuelo);
            }
            else
            {
                MessageBox.Show("No hay facturas para la reserva.");
                return;
            }
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarDatos(DataTable pasajero, DataTable vuelo)
        {
            txt_numeroReserva.Text = Id_reserva;
            txt_numeroDoc.Text = pasajero.Rows[0][0].ToString();
            txt_tipoDoc.Text = pasajero.Rows[0][1].ToString();
            txt_nombre.Text = pasajero.Rows[0][2].ToString();
            txt_apellido.Text = pasajero.Rows[0][3].ToString();
            txt_fechaPago.Text = facturacion.RecuperarFechaActual();
            cmb_formaPago.SelectedValue = factura.Rows[0][2].ToString();
            txt_numeroFactura.Text = factura.Rows[0][0].ToString();

            if (vuelo.Rows.Count != 0)
            {
                facturacion.CargarGrillaVuelos(vuelo, grid_vuelo);
            }
        }
        private void Btn_EliminarFactura_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
