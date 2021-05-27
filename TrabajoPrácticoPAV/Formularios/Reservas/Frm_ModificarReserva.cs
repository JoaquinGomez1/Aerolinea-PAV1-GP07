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
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace TrabajoPrácticoPAV.Formularios.Reservas
{
    public partial class Frm_ModificarReserva : Form
    {
        private readonly NE_Reserva _NE_Reserva = new NE_Reserva();
        private decimal precio;
        private Viaje ViajeSeleccionado;
        private readonly NE_Viajes _NE_Viaje = new NE_Viajes();
        private readonly NE_Reserva _NE = new NE_Reserva();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);
        public Frm_ABMReservas frm_reserva { get; set; }
        public static ObservableCollection<Pasajero> ObserverListaPasajeros;

        private Pasajero _pasajeroTitular;
        private Pasajero pasajeroTitular
        {
            get { return _pasajeroTitular; }
            set
            {
                // Lo que se encuentra en esta parte se ejecuta cada vez que cambia el valor de pasajeroTitular
                _pasajeroTitular = value;
                actualizarCantidadPasajeros($"{ObserverListaPasajeros.Count}");
                actualizarLabelTitular();
            }
        }

        private void actualizarLabelTitular()
        {
            bool titularNoEsNull = _pasajeroTitular != null;
            cmb_tipoDoc.Text = titularNoEsNull ? pasajeroTitular.tipoDoc : "???";
            mtxt_numDoc.Text = titularNoEsNull ? pasajeroTitular.numeroDoc : "???";
        }


        public Frm_ModificarReserva()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            ObserverListaPasajeros = new ObservableCollection<Pasajero>();
            ObserverListaPasajeros.CollectionChanged += listChanged;
        }

        private void Frm_ModificarReserva_Load(object sender, EventArgs e)
        {
            cmb_claseAsiento.CargarCombo();
            cmb_tipoDoc.CargarCombo();
            cmb_numReserva.CargarCombo();
            cmb_origen.CargarCombo();
            cmb_destino.CargarCombo();
        }

        private void listChanged(object sender, NotifyCollectionChangedEventArgs args)
        {
            int cantPasajeros = 0;
            // El pasajero titular es el primero en cargarse a la lista
            if (txt_cantPasajeros.Text != null)
            { cantPasajeros = Int32.Parse(txt_cantPasajeros.ToString()); }

            if (cantPasajeros == 0)
                pasajeroTitular = null;
            else
                pasajeroTitular = ObserverListaPasajeros[0];

            if (cantPasajeros != 0)
            {
                int precioInt = Decimal.ToInt32(precio) * cantPasajeros;
                actualizarLabelPrecio(precioInt); 
            }
            actualizarCantidadPasajeros($"{ObserverListaPasajeros.Count}");
        }

        private void actualizarCantidadPasajeros(string cantPasajeros) => txt_cantPasajeros.Text = cantPasajeros;

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
                    fechaDeSalida = result.Rows[0]["fechaSalida"].ToString(),
                    numeroDeViaje = result.Rows[0]["numeroDeViaje"].ToString(),
                    numeroDocTitular = result.Rows[0]["numeroDocTitular"].ToString(),
                    tipoDocTitular = result.Rows[0]["tipoDocTitular"].ToString(),
                    precio = Decimal.ToInt32((decimal)result.Rows[0]["precio"]),
            };

                lbl_numViaje.Text = reserva.numeroDeViaje.ToString();
                mtxt_numDoc.Text = reserva.numeroDocTitular.ToString();
                cmb_tipoDoc.Text = reserva.tipoDocTitular.ToString();
                mtxt_fechaViaje.Text = reserva.fechaDeSalida.ToString();
                lbl_precio.Text = reserva.precio.ToString();

            }

        }

        private void cmb_origen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_origen.SelectedIndex == -1) return; // No ejecutar si no se seleccionó nada

            // Controlo que el otro comboBox se haya cargado también
            if (cmb_destino.SelectedIndex != -1) eventoCargado();
        }

        private void cmb_destino_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_destino.SelectedIndex == -1) return; // No ejecutar si no se seleccionó nada

            if (cmb_origen.SelectedIndex != -1) eventoCargado();
        }

        private void eventoCargado()
        {

            Viaje numeroViajeQueCoincide = _NE_Viaje.ViajeQueCoinciden($"{cmb_origen.SelectedValue}", $"{cmb_destino.SelectedValue}");
            if (numeroViajeQueCoincide == null)
                return;

            Viaje viaje = _NE_Viaje.GetViajePorId(numeroViajeQueCoincide.NumeroDeViaje.ToString());

            if (viaje != null)
            {
                actualizarDatosDelViaje(viaje);
                ViajeSeleccionado = viaje;
            }
        }

        private void actualizarDatosDelViaje(Viaje viaje)
        {
            lbl_numViaje.Text = viaje.NumeroDeViaje.ToString();
        }

        private void actualizarLabelPrecio(int precio)
        {
            string precioStr = $"{precio}";
            //string precioFinal = precioStr.Substring(0, precioStr.Length - 2);
            lbl_precio.Text = $"{precioStr}";
        }

        private void cmb_claseAsiento_TextChanged_1(object sender, EventArgs e)
        {
            string clase = cmb_claseAsiento.Text;

            if (cmb_claseAsiento.Text != null)
            {
                precio = _NE_Reserva.BuscarCosto(clase);
                int cantPasajeros = 0;
                Int32.TryParse(txt_cantPasajeros.Text.ToString(), out cantPasajeros);
                int precioInt = Decimal.ToInt32(precio) * cantPasajeros;
                actualizarLabelPrecio(precioInt);
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            double valdec = Convert.ToDouble(lbl_precio.Text);

            Reserva reserva = new Reserva()
            {
                numeroDeReserva = cmb_numReserva.Text,
                fechaDeSalida = mtxt_fechaViaje.Text.ToString(),
                numeroDeViaje = lbl_numViaje.Text,
                numeroDocTitular = mtxt_numDoc.Text,
                tipoDocTitular = cmb_tipoDoc.Text,
                precio = valdec,

            };
            _NE.ModificarReserva(reserva);
        }
    }
}
