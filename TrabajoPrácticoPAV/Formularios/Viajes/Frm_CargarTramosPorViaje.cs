using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Clase.Modelos;
using TrabajoPrácticoPAV.NE_Usuarios;
using System.Runtime.InteropServices;

namespace TrabajoPrácticoPAV.Formularios.Viajes
{
    public partial class Frm_CargarTramosPorViaje : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private List<Tramo> TramosDelViaje = Frm_ABMViajes.TramosDelViaje;
        private readonly NE_Tramos _NE_Tramo = new NE_Tramos();

        public Frm_CargarTramosPorViaje()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }


        private void Frm_CargarTramosPorViaje_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM TRAMO";
            _NE_Tramo.CargarGrilla(sql, grid_tramos);
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection selectedRowCells = grid_tramos.CurrentRow.Cells;
            Tramo tramo = new Tramo()
            {
                codigoAeropuertoSalida = _NE_Tramo.BuscarCodigoAeropuerto(selectedRowCells[0].Value.ToString()),
                codigoAeropuertoDestino = _NE_Tramo.BuscarCodigoAeropuerto(selectedRowCells[1].Value.ToString()),
                duracion = Int32.Parse(selectedRowCells[2].Value.ToString()),
                distancia = Int32.Parse(selectedRowCells[3].Value.ToString()),
            };

            // Verifica que no haya elementos repetidos, en caso de ser así retorna null
            int cantidadTramosDelViaje = TramosDelViaje.Count;
            TramosDelViaje.Add(tramo);
            // Implementación con linq para agrupar elementos con los mismos parametros pasados aca abajo
            TramosDelViaje = TramosDelViaje.GroupBy(i => new { i.codigoAeropuertoDestino, i.codigoAeropuertoSalida, i.duracion }).Select(g => g.First()).ToList();
            if (cantidadTramosDelViaje == TramosDelViaje.Count)
            {
                MessageBox.Show("No se pueden cargar elementos repetidos");
                return;
            }


            grid_tramoViaje.Rows.Add();

            int cantidadDeFilas = grid_tramoViaje.Rows.Count; // Count me devuelve la cantidad empezando de 1 
            int indiceRow = cantidadDeFilas - 1; // Resto uno para que lo trabaje la máquina

            // El orden es importante 

            // NO usar cargarTramosDelViaje()
            grid_tramoViaje.Rows[indiceRow].Cells[0].Value = _NE_Tramo.BuscarNombreAeropuerto(tramo.codigoAeropuertoSalida);
            grid_tramoViaje.Rows[indiceRow].Cells[1].Value = _NE_Tramo.BuscarNombreAeropuerto(tramo.codigoAeropuertoDestino);
            grid_tramoViaje.Rows[indiceRow].Cells[2].Value = tramo.duracion;
            grid_tramoViaje.Rows[indiceRow].Cells[3].Value = tramo.distancia;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int indexCurrentRow = grid_tramoViaje.CurrentRow.Index;
            grid_tramoViaje.Rows.Remove(grid_tramoViaje.CurrentRow);

            // Elimino de la lista de tramos de viaje segun el índice donde se encontraba la fila seleccionada
            TramosDelViaje.RemoveAt(indexCurrentRow);

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Frm_ABMViajes.TramosDelViaje = this.TramosDelViaje;
            this.Close();
        }

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
