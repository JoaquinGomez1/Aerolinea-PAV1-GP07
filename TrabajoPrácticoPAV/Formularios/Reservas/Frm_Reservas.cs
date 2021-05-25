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
        private readonly Tratamientos_Especiales _TE = new Tratamientos_Especiales();
        private readonly NE_Clientes _NE_Pasajeros = new NE_Clientes();
        private readonly NE_Reserva _NE = new NE_Reserva();

        public Frm_ABMReservas()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
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
                decimal precio = _NE.BuscarCosto(clase);
                string precioStr = $"{precio}";
                string precioFinal = precioStr.Substring(0, precioStr.Length - 2);
                lbl_precio.Text = $"${precioFinal}";
            }
        }
    }
}