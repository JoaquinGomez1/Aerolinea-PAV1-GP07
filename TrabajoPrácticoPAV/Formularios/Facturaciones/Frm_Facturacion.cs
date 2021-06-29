﻿using System;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Facturaciones
{
    public partial class Frm_Facturacion : Form
    {
        public string Id_reserva { get; set; }
        public string Forma_Pago { get; set; }
        public DataTable pasajero { get; set; }
        public DataTable vuelo { get; set; }

        private NE_Facturacion facturacion = new NE_Facturacion();

        public Frm_Facturacion()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Facturacion_Load(object sender, EventArgs e)
        {
            grid_vuelo.Formatear();
            btn_GenerarFactura.Enabled = false;
        }

        private void btn_buscarReserva_Click(object sender, EventArgs e)
        {
            grid_vuelo.Rows.Clear();
            Id_reserva = txt_numeroReserva.Text;
            pasajero = facturacion.RecuperarPasajero(txt_numeroReserva.Text);
            vuelo = facturacion.RecuperarVueloxReserva(txt_numeroReserva.Text);

            if (vuelo.Rows.Count != 0)
                facturacion.CargarGrillaVuelos(vuelo, grid_vuelo);
            if (pasajero.Rows.Count != 0)
            {
                txt_numeroDoc.Text = pasajero.Rows[0][0].ToString();
                txt_tipoDoc.Text = pasajero.Rows[0][1].ToString();
                txt_nombre.Text = pasajero.Rows[0][2].ToString();
                txt_apellido.Text = pasajero.Rows[0][3].ToString();
                btn_GenerarFactura.Enabled = true;
                btn_eliminar.Enabled = true;
                button_Aerolinea1.Enabled = true;
            }
            else
                MessageBox.Show("No se ha encontrado una reserva con el número de reserva ingresado.");

        }

        private void btn_GenerarFactura_Click(object sender, EventArgs e)
        {
            Frm_MostrarFacturacion mostrarFacturacion = new Frm_MostrarFacturacion();
            mostrarFacturacion.Id_reserva = Id_reserva;
            mostrarFacturacion.pasajero = pasajero;
            mostrarFacturacion.vuelo = vuelo;
            mostrarFacturacion.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_EliminarFactura eliminarFactura = new Frm_EliminarFactura();

            eliminarFactura.Id_reserva = Id_reserva;
            eliminarFactura.pasajero = pasajero;
            eliminarFactura.vuelo = vuelo;

            eliminarFactura.ShowDialog();
        }

        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
            Frm_ConsultarFactura consultarFactura = new Frm_ConsultarFactura();

            consultarFactura.Id_reserva = Id_reserva;
            consultarFactura.pasajero = pasajero;
            consultarFactura.vuelo = vuelo;

            consultarFactura.ShowDialog();
        }
    }
}