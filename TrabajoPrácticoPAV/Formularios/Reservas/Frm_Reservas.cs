using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Clase.Modelos;
using TrabajoPrácticoPAV.Formularios.Reservas;
using TrabajoPrácticoPAV.NE_Usuarios;
using static TrabajoPrácticoPAV.Clase.Tratamientos_Especiales;

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ABMReservas : Form
    {
        private readonly Frm_ModificarReserva modificarReserva = new Frm_ModificarReserva();
        private readonly Frm_CargarPasajerosPorReserva cargarPasajero = new Frm_CargarPasajerosPorReserva();
        private readonly Frm_ConsultarPasajerosPorReserva consultarPasajero = new Frm_ConsultarPasajerosPorReserva();
        private readonly NE_Reserva _NE_Reserva = new NE_Reserva();
        private readonly NE_Viajes _NE_Viaje = new NE_Viajes();

        private readonly Tratamientos_Especiales _TE = new Tratamientos_Especiales();
        private Viaje ViajeSeleccionado;
        public static ObservableCollection<Pasajero> ObserverListaPasajeros;

        // NO borrar _pasajeroTitular porque se genera un ciclo infinito
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

        private decimal precio;

        public Frm_ABMReservas()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            ObserverListaPasajeros = new ObservableCollection<Pasajero>();
            ObserverListaPasajeros.CollectionChanged += listChanged;
            //            cargarPasajero.FormClosed += CargarPasajeroClosed;
        }

        private void Frm_ABMReservas_Load(object sender, EventArgs e)
        {
            // Cargar la fecha actual
            lbl_currentDate.Text = DateTime.UtcNow.ToString("dd-MM-yyyy");
            cmb_claseAsiento.CargarCombo();
            cmb_origen.CargarCombo();
            cmb_destino.CargarCombo();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            modificarReserva.ShowDialog();
        }

        private void btn_cargarPasajeros_Click(object sender, EventArgs e)
        {
            cargarPasajero.ShowDialog();
        }

        private void btn_consultarPasajeros_Click(object sender, EventArgs e)
        {
            consultarPasajero.ShowDialog();
        }

        private void cmb_claseAsiento_TextChanged(object sender, EventArgs e)
        {
            string clase = cmb_claseAsiento.Text;

            if (cmb_claseAsiento.Text != null)
            {
                precio = _NE_Reserva.BuscarCosto(clase);
                actualizarLabelPrecio(precio);
            }
        }

        private void listChanged(object sender, NotifyCollectionChangedEventArgs args)
        {
            // El pasajero titular es el primero en cargarse a la lista
            int cantPasajeros = ObserverListaPasajeros.Count;

            if (cantPasajeros == 0)
                pasajeroTitular = null;
            else
                pasajeroTitular = ObserverListaPasajeros[0];

            if (cantPasajeros != 0) actualizarLabelPrecio(precio * cantPasajeros);
            actualizarCantidadPasajeros($"{ObserverListaPasajeros.Count}");
        }

        private void actualizarCantidadPasajeros(string cantPasajeros) => lbl_cantPasajeros.Text = cantPasajeros;
        private void actualizarLabelTitular()
        {
            bool titularNoEsNull = _pasajeroTitular != null;
            lbl_nombreTitular.Text = titularNoEsNull ? pasajeroTitular.nombre : "???";
            lbl_docTitular.Text = titularNoEsNull ? pasajeroTitular.numeroDoc : "???";
            MessageBox.Show($"No es null: { titularNoEsNull }");
        }

        private void actualizarLabelPrecio(decimal precio)
        {
            string precioStr = $"{precio}";
            string precioFinal = precioStr.Substring(0, precioStr.Length - 2);
            lbl_precio.Text = $"${precioFinal}";
        }

        private void button_Aerolinea3_Click(object sender, EventArgs e)
        {
            Resultado esValidoTE = _TE.Validar(this.panel_registro.Controls);
            bool tieneTitular = pasajeroTitular != null;
            bool tienePasajeros = ObserverListaPasajeros.Count >= 1;

            if (esValidoTE == Resultado.correcto && tieneTitular && tienePasajeros)
            {
                // Ejecutar en caso valido
                MessageBox.Show("Formulario Válido");
            }
        }

        private void cmb_origen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_origen.SelectedIndex == -1) return; // No ejecutar si no se seleccionó nada

            if (cmb_destino.SelectedIndex != -1) eventoCargado();
        }

        private void cmb_destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_destino.SelectedIndex == -1) return; // No ejecutar si no se seleccionó nada

            if (cmb_origen.SelectedIndex != -1) eventoCargado();
        }

        private void eventoCargado()
        {
            Viaje viaje = _NE_Viaje.ViajeQueCoinciden($"{cmb_origen.SelectedValue}", $"{cmb_destino.SelectedValue}");

            if (viaje != null)
            {
                actualizarDatosDelViaje(viaje);
                ViajeSeleccionado = viaje;
            }
        }

        private void actualizarDatosDelViaje(Viaje viaje)
        {
            lbl_numeroViaje.Text = viaje.NumeroDeViaje.ToString();
        }

        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
            DataTable tabla = _NE_Reserva.GetTodos();
            CargarGrilla(tabla);
        }

        private void CargarGrilla(DataTable tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_reservas.Rows.Add();
                grid_reservas.Rows[i].Cells[0].Value = tabla.Rows[i]["numeroDeReserva"].ToString();
                grid_reservas.Rows[i].Cells[1].Value = tabla.Rows[i]["fechaReserva"].ToString();
                grid_reservas.Rows[i].Cells[2].Value = tabla.Rows[i]["fechaSalida"].ToString();
                grid_reservas.Rows[i].Cells[3].Value = tabla.Rows[i]["numeroDeViaje"].ToString();
                grid_reservas.Rows[i].Cells[4].Value = tabla.Rows[i]["precio"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esperando implementación");
        }
        //private void CargarPasajeroClosed(object sender, EventArgs e)
        //{

        //}
    }
}