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
using TrabajoPrácticoPAV.NE_Usuarios;
using static TrabajoPrácticoPAV.Clase.Tratamientos_Especiales;

namespace TrabajoPrácticoPAV.Formularios.Tripulacion.Cargo_Tripulacion
{
    public partial class Frm_ABMCargoTripulacion : Form
    {

        private readonly NE_CargoTripulacion _NE = new NE_CargoTripulacion();
        private readonly Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
        private int IdCargoSeleccionado { get; set; }

        public Frm_ABMCargoTripulacion()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_CargoTripulacion_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            bool esValido = tratamientos.Validar(panel_registrar.Controls) == Resultado.correcto;
            if (esValido)
            {
                _NE.InsertCargo(txt_nombre_register.Text);
                CargarDataGrid();
            }
        }

        private void CargarDataGrid()
        {
            DataTable tabla = _NE.GetTodosLosCargos();
            CargarGridTripulantes(tabla);
        }

        private void CargarGridTripulantes(DataTable tabla)
        {
            grid_tripulantes.Rows.Clear();
            if (tabla.Rows.Count == 0)
            {
                grid_tripulantes.Rows.Clear();
                return;
            }

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_tripulantes.Rows.Add();

                // Columna del DGrid --- nombre de columna de SQL
                grid_tripulantes.Rows[i].Cells[0].Value = tabla.Rows[i]["idCargoTripulacion"].ToString();
                grid_tripulantes.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            bool esValido = tratamientos.Validar(panel_modify.Controls) == Resultado.correcto;
            if (esValido)
            {
                _NE.ModificarCargo(txt_nombre_modify.Text, IdCargoSeleccionado);
                CargarDataGrid();
            }
        }

        private void grid_tripulantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexCeldaModificar = 2;
            int indexCeldaEliminar = 3;

            bool rowVacia = grid_tripulantes.CurrentRow.Cells[0].Value == null;
            if (rowVacia) return;

            if (grid_tripulantes.CurrentCell.ColumnIndex == indexCeldaModificar)
            {
                panel_modify.Visible = true;
                lbl_title_modify.Visible = true;

                // Lo seteo ahora para despues poder tomar el valor al hacer click en modificar
                IdCargoSeleccionado = Int32.Parse(grid_tripulantes.CurrentRow.Cells[0].Value.ToString());

                txt_nombre_modify.Text = grid_tripulantes.CurrentRow.Cells[1].Value.ToString();
            }

            if (grid_tripulantes.CurrentCell.ColumnIndex == indexCeldaEliminar)
            {
                int idTripulacion = Int32.Parse(grid_tripulantes.CurrentRow.Cells[0].Value.ToString());
                _NE.EliminarCargo(idTripulacion);

                grid_tripulantes.Rows.Remove(grid_tripulantes.CurrentRow);
            }
        }
    }
}
