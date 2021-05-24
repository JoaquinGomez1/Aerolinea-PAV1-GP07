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
        private readonly Tratamientos_Especiales _TE = new Tratamientos_Especiales();
        private readonly NE_Clientes _NE_Pasajeros = new NE_Clientes();

        public Frm_ABMReservas()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ABMReservas_Load(object sender, EventArgs e)
        {
            // Cargar la fecha actual
            lbl_currentDate.Text = DateTime.UtcNow.ToString("dd-MM-yyyy");
            cmb_claseAsiento.CargarCombo();
            cmb_tipoDoc.CargarCombo();
            grid_pasajeros.Formatear();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            modificarReserva.ShowDialog();
        }

        private void actualizarDatosPasajero(Pasajero pasajero)
        {
            lbl_nombre.Text = pasajero.nombre;
            lbl_apellido.Text = pasajero.apellido;
            lbl_nDoc.Text = pasajero.numeroDoc;
            lbl_tipoDoc.Text = _NE_Pasajeros.BuscarNombreDoc(pasajero.tipoDoc);
            lbl_fechaNacimiento.Text = pasajero.fechaNacimiento;
        }


        private void agregarPasajeroAGrilla(Pasajero pasajero, DataGridView grid)
        {
            grid.Rows.Add();
            int lastRowIndex = grid.Rows.Count - 1;

            grid.Rows[lastRowIndex].Cells[0].Value = pasajero.nombre;
            grid.Rows[lastRowIndex].Cells[1].Value = pasajero.apellido;
            grid.Rows[lastRowIndex].Cells[2].Value = pasajero.tipoDoc;
            grid.Rows[lastRowIndex].Cells[3].Value = pasajero.numeroDoc;
        }

        private void EliminarDatosPasajeroBuscado()
        {
            lbl_nombre.Text = "???";
            lbl_apellido.Text = "???";
            lbl_nDoc.Text = "???";
            lbl_tipoDoc.Text = "???";
            lbl_fechaNacimiento.Text = "???";
        }

        private void grid_pasajeros_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Establece el nombre y apellido del primer agregado
        }

        private void ActualizarNombreTitular()
        {
            lbl_titularReserva.Text = $"{grid_pasajeros.Rows[0].Cells[0].Value} {grid_pasajeros.Rows[0].Cells[1].Value}";
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (_TE.Validar(this.panel1.Controls) == Resultado.error) return;
            Pasajero pasajeroBuscado = new NE_Reserva().GetPasajero(Mtxt_numeroDoc.Text, cmb_tipoDoc.SelectedValue.ToString());
            if (pasajeroBuscado.numeroDoc == null || pasajeroBuscado.numeroDoc == "")
            {
                return;
            }
            agregarPasajeroAGrilla(pasajeroBuscado, grid_pasajeros);
            EliminarDatosPasajeroBuscado();
            if (grid_pasajeros.Rows.Count == 1)
            {
                ActualizarNombreTitular();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (_TE.Validar(this.panel1.Controls) == Resultado.error) return;
            Pasajero pasajeroBuscado = new NE_Reserva().GetPasajero(Mtxt_numeroDoc.Text, cmb_tipoDoc.SelectedValue.ToString());
            if (pasajeroBuscado.numeroDoc == null || pasajeroBuscado.numeroDoc == "")
            {
                return;
            }
            actualizarDatosPasajero(pasajeroBuscado);
        }
    }
}
