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
using static TrabajoPrácticoPAV.Clase.Tratamientos_Especiales;
using TrabajoPrácticoPAV.Clase.Modelos;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Reservas
{
    public partial class Frm_CargarPasajerosPorReserva : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);
        private readonly Tratamientos_Especiales _TE = new Tratamientos_Especiales();
        private readonly NE_Clientes _NE_Pasajeros = new NE_Clientes();

        public Frm_CargarPasajerosPorReserva()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_CargarPasajerosPorReserva_Load(object sender, EventArgs e)
        {
            cmb_tipoDoc.CargarCombo();
        }

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (grid_pasajeros.CurrentRow == null)
                return;

            int index = grid_pasajeros.CurrentRow.Index;
            grid_pasajeros.Rows.Remove(grid_pasajeros.CurrentRow);
            Frm_ABMReservas.ObserverListaPasajeros.RemoveAt(index);

            if (grid_pasajeros.Rows.Count >= 1)
                ActualizarNombreTitular();

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

        private void ActualizarNombreTitular()
        {
            lbl_titularReserva.Text = $"{grid_pasajeros.Rows[0].Cells[0].Value} {grid_pasajeros.Rows[0].Cells[1].Value}";
        }

        private void EliminarDatosPasajeroBuscado()
        {
            lbl_nombre.Text = "???";
            lbl_apellido.Text = "???";
            lbl_nDoc.Text = "???";
            lbl_tipoDoc.Text = "???";
            lbl_fechaNacimiento.Text = "???";
        }

        private void button_Aerolinea2_Click(object sender, EventArgs e)
        {
            if (_TE.Validar(this.panel1.Controls) == Resultado.error) return;
            Pasajero pasajeroBuscado = new NE_Reserva().GetPasajero(Mtxt_numeroDoc.Text, cmb_tipoDoc.SelectedValue.ToString());
            if (pasajeroBuscado.numeroDoc == null || pasajeroBuscado.numeroDoc == "")
            {
                return;
            }

            // A partir de aca está todo validado
            Frm_ABMReservas.ObserverListaPasajeros.Add(pasajeroBuscado); // Agrega a la lista de pasajeros
            agregarPasajeroAGrilla(pasajeroBuscado, grid_pasajeros);
            EliminarDatosPasajeroBuscado();
            if (grid_pasajeros.Rows.Count == 1)
            {
                ActualizarNombreTitular();
            }
        }

        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
            if (_TE.Validar(this.panel1.Controls) == Resultado.error) return;
            Pasajero pasajeroBuscado = new NE_Reserva().GetPasajero(Mtxt_numeroDoc.Text, cmb_tipoDoc.SelectedValue.ToString());
            if (pasajeroBuscado.numeroDoc == null || pasajeroBuscado.numeroDoc == "")
            {
                return;
            }
            actualizarDatosPasajero(pasajeroBuscado);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos cargados correctamente"); // Mensaje fantasma
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}
