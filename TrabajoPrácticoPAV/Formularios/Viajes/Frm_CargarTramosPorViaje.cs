using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Clase.Modelos;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Viajes
{
    public partial class Frm_CargarTramosPorViaje : Form
    {
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

            if (TramosDelViaje.Count >= 1)
            {
                cargarTramosDelViaje(Frm_ABMViajes.TramosDelViaje);
            }
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
                codigoAeropuertoSalida = selectedRowCells[0].Value.ToString(),
                codigoAeropuertoDestino = selectedRowCells[1].Value.ToString(),
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
            grid_tramoViaje.Rows[indiceRow].Cells[0].Value = tramo.codigoAeropuertoSalida;
            grid_tramoViaje.Rows[indiceRow].Cells[1].Value = tramo.codigoAeropuertoDestino;
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


        class compareDuplicateElements : IEqualityComparer<Tramo>
        {
            public bool Equals(Tramo x, Tramo y)
            {
                bool igualDestino = x.codigoAeropuertoDestino.Equals(y.codigoAeropuertoDestino);
                bool igualSalida = x.codigoAeropuertoSalida.Equals(y.codigoAeropuertoSalida);
                bool igualDuracion = x.duracion.Equals(y.duracion);

                return igualDestino && igualSalida && igualDuracion;
            }

            public int GetHashCode(Tramo obj)
            {
                return obj.codigoAeropuertoSalida.GetHashCode();
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Frm_ABMViajes.TramosDelViaje = this.TramosDelViaje;
            this.Close();
        }

        private void cargarTramosDelViaje(List<Tramo> listTramos)
        {
            // Solo deben cargarse la misma cantidad de elementos que tenga la lista
            if (grid_tramoViaje.Rows.Count == listTramos.Count) return;

            for (int i = 0; i < listTramos.Count; i++)
            {
                Tramo tramo = listTramos[i];

                grid_tramoViaje.Rows.Add();
                grid_tramoViaje.Rows[i].Cells[0].Value = tramo.codigoAeropuertoSalida;
                grid_tramoViaje.Rows[i].Cells[1].Value = tramo.codigoAeropuertoDestino;
                grid_tramoViaje.Rows[i].Cells[2].Value = tramo.duracion;
                grid_tramoViaje.Rows[i].Cells[3].Value = tramo.distancia;
            }
        }
    }
}
