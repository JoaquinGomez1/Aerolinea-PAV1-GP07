using System;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Clase.Modelos;
using TrabajoPrácticoPAV.NE_Usuarios;
using static TrabajoPrácticoPAV.Clase.Tratamientos_Especiales;

namespace TrabajoPrácticoPAV.Formularios.Tripulacion
{
    public partial class Frm_ABMTripulacion : Form
    {
        private readonly NE_Tripulacion _NE = new NE_Tripulacion();
        private readonly Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
        private int idTripulanteAModificar { get; set; }

        public Frm_ABMTripulacion()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_Tripulacion_Load(object sender, EventArgs e)
        {

            cmb_cargo_register.CargarCombo();

            DataTable TableTripulantes = _NE.GetTodosLosTripulantes();
            CargarDataGrid(TableTripulantes);
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            bool esValido = tratamientos.Validar(panel_registrar.Controls) == Resultado.correcto;
            if (esValido)
            {
                Tripulante tripulante = new Tripulante()
                {
                    Nombre = txt_nombre_register.Text,
                    Apellido = txt_apellido_register.Text,
                    IdCargo = Int32.Parse(cmb_cargo_register.SelectedValue.ToString()),
                };

                _NE.InsertTripulante(tripulante);
                CargarDataGrid();
            }
        }

        private void CargarDataGrid(DataTable tabla)
        {
            CargarGridTripulantes(tabla);
        }

        private void CargarDataGrid()
        {
            DataTable tabla = _NE.GetTodosLosTripulantes();
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
                grid_tripulantes.Rows[i].Cells[0].Value = tabla.Rows[i]["idTripulacion"].ToString();
                grid_tripulantes.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grid_tripulantes.Rows[i].Cells[2].Value = tabla.Rows[i]["apellido"].ToString();
                grid_tripulantes.Rows[i].Cells[3].Value = tabla.Rows[i]["nombreCargo"].ToString();
                // Celda invisible que contiene el dato de idCargoTripulación
                grid_tripulantes.Rows[i].Cells[4].Value = tabla.Rows[i]["idCargoTripulacion"].ToString();
            }
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        
        private void btn_modify_Click(object sender, EventArgs e)
        {
            bool esValido = tratamientos.Validar(panel_modify.Controls) == Resultado.correcto;
            if (esValido)
            {
                Tripulante tripulante = new Tripulante()
                {
                    Id = idTripulanteAModificar,
                    Nombre = txt_nombre_modify.Text,
                    Apellido = txt_apellido_modify.Text,
                    IdCargo = Int32.Parse(cmb_cargo_modify.SelectedValue.ToString()),
                };
                _NE.ModificarTripulante(tripulante);
                CargarDataGrid();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            cmb_cargo_modify.CargarCombo();
            panel_modify.Visible = true;
            lbl_title_modify.Visible = true;

            //string valorSeleccionado = grid_ciudades.CurrentRow.Cells[0].Value.ToString();
            //CiudadObj ciudad = _NE.GetCiudadPorId(valorSeleccionado);
            // CiudadSeleccionada = ciudad;

            DataGridViewRow fila = grid_tripulantes.CurrentRow;

           Tripulante tripulante = new Tripulante()
            {
                Id = Int32.Parse(fila.Cells[0].Value.ToString()),
                Nombre = fila.Cells[1].Value.ToString(),
                Apellido = fila.Cells[2].Value.ToString(),
                IdCargo = Int32.Parse(fila.Cells[4].Value.ToString()),
            };

            idTripulanteAModificar = tripulante.Id;
            txt_nombre_modify.Text = tripulante.Nombre;
            txt_apellido_modify.Text = tripulante.Apellido;
            cmb_cargo_modify.SelectedValue = tripulante.IdCargo;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (grid_tripulantes.CurrentRow == null)
                return;

            string idTripulacion = grid_tripulantes.CurrentRow.Cells[0].Value.ToString();
            _NE.EliminarTripulante(idTripulacion);

            grid_tripulantes.Rows.Remove(grid_tripulantes.CurrentRow);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre_register.Text;
            string apellido = txt_apellido_register.Text;
            string cargo = "";
            if (cmb_cargo_register.SelectedIndex != -1)
            {
                cargo = cmb_cargo_register.SelectedValue.ToString();
            }

            DataTable tabla = _NE.GetTripulante(nombre,apellido,cargo);
            if (tabla != null)
            { CargarGridTripulantes(tabla); }
            else { MessageBox.Show("Complete los campos para realizar la busqueda"); }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
