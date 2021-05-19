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
using TrabajoPrácticoPAV.Clase.Modelos;
using static TrabajoPrácticoPAV.Clase.Tratamientos_Especiales;

namespace TrabajoPrácticoPAV.Formularios.Tripulacion.Cargo_Tripulacion
{
    public partial class Frm_ABMCargoTripulacion : Form
    {

        private readonly NE_CargoTripulacion _NE = new NE_CargoTripulacion();
        private readonly Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
        private int idTripulanteAModificar { get; set; }
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
                CargoTripulacion cargoTripulacion = new CargoTripulacion()
                {
                    Id = idTripulanteAModificar,
                    Nombre = txt_nombre_modify.Text,
                };
                _NE.ModificarCargo(cargoTripulacion);

                CargarDataGrid();
            }
        }


        private void btn_editar_Click(object sender, EventArgs e)
        {

            panel_modify.Visible = true;
            lbl_title_modify.Visible = true;

            //string valorSeleccionado = grid_ciudades.CurrentRow.Cells[0].Value.ToString();
            //CiudadObj ciudad = _NE.GetCiudadPorId(valorSeleccionado);
            // CiudadSeleccionada = ciudad;

            DataGridViewRow fila = grid_tripulantes.CurrentRow;

           CargoTripulacion cargoTripulacion = new CargoTripulacion()
            {
                Id = Int32.Parse(fila.Cells[0].Value.ToString()),
                Nombre = fila.Cells[1].Value.ToString(),
            };

            idTripulanteAModificar = cargoTripulacion.Id;
            txt_nombre_modify.Text = cargoTripulacion.Nombre;
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if (grid_tripulantes.CurrentRow == null)
                return;

            string idCargo = grid_tripulantes.CurrentRow.Cells[0].Value.ToString();
            _NE.EliminarCargo(idCargo);

            grid_tripulantes.Rows.Remove(grid_tripulantes.CurrentRow);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre_register.Text;
            DataTable tabla = _NE.GetCargo(nombre);
            if (tabla != null)
            { CargarGridTripulantes(tabla); }
            else { MessageBox.Show("Complete el nombre del cargo para realizar la busqueda"); }
        }

        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
