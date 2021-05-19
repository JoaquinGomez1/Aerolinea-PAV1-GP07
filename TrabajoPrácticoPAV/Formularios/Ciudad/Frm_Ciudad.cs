using System;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Clase.Modelos;
using TrabajoPrácticoPAV.NE_Usuarios;
using static TrabajoPrácticoPAV.Clase.Tratamientos_Especiales;

namespace TrabajoPrácticoPAV.Formularios.Ciudad
{
    public partial class Frm_Ciudad : Form
    {
        private readonly NE_Ciudad _NE = new NE_Ciudad();
        private readonly Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
        private int idCiudadAModificar { get; set; }
        private CiudadObj CiudadSeleccionada { get; set; }

        public Frm_Ciudad()
        {

            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            InitializeComponent();
        }

        private void CargarDataGrid(DataTable tabla)
        {
            CargarGridCiudades(tabla);
        }

        private void CargarDataGrid()
        {
            DataTable tabla = _NE.GetTodosLasCiudades();
            CargarGridCiudades(tabla);
        }

        private void CargarGridCiudades(DataTable tabla)
        {
            grid_ciudades.Rows.Clear();
            if (tabla.Rows.Count == 0)
            {
                grid_ciudades.Rows.Clear();
                return;
            }

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_ciudades.Rows.Add();

                grid_ciudades.Rows[i].Cells[0].Value = tabla.Rows[i]["idCiudad"].ToString();
                grid_ciudades.Rows[i].Cells[1].Value = tabla.Rows[i]["nombreCiudad"].ToString();
                grid_ciudades.Rows[i].Cells[2].Value = tabla.Rows[i]["nombrePais"].ToString();
                grid_ciudades.Rows[i].Cells[3].Value = tabla.Rows[i]["nombreProvincia"].ToString();

                grid_ciudades.Rows[i].Cells[4].Value = tabla.Rows[i]["idProvincia"].ToString();
                grid_ciudades.Rows[i].Cells[5].Value = tabla.Rows[i]["idPais"].ToString();
            }
        }

        private void Frm_Ciudad_Load_1(object sender, EventArgs e)
        {
            comboBox_pais_register.CargarCombo();

            DataTable TableCiudades = _NE.GetTodosLasCiudades();
            CargarDataGrid(TableCiudades);
        }
 
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            bool esValido = tratamientos.Validar(panel_registrar.Controls) == Resultado.correcto;
            if (esValido)
            {
                CiudadObj ciudad = new CiudadObj()
                {
                    Nombre = txt_nombre_register.Text,
                    IdPais = Int32.Parse(comboBox_pais_register.SelectedValue.ToString()),
                    IdProvincia = Int32.Parse(comboBox_Aerolinea1.SelectedValue.ToString()),
                };

                _NE.InsertCiudad(ciudad);
                CargarDataGrid();
            }
        }

        
        private void btn_refrescar_Click_1(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
           
            comboBox_pais_modify.CargarCombo();
            panel_modify.Visible = true;
            lbl_title_modify.Visible = true;

            //string valorSeleccionado = grid_ciudades.CurrentRow.Cells[0].Value.ToString();
            //CiudadObj ciudad = _NE.GetCiudadPorId(valorSeleccionado);
            // CiudadSeleccionada = ciudad;

            DataGridViewRow fila = grid_ciudades.CurrentRow;

            CiudadObj ciudad = new CiudadObj()
            {
                Id = Int32.Parse(fila.Cells[0].Value.ToString()),
                Nombre = fila.Cells[1].Value.ToString(),
                IdProvincia = Int32.Parse(fila.Cells[4].Value.ToString()),
                IdPais = Int32.Parse(fila.Cells[5].Value.ToString()),
            };

            idCiudadAModificar = ciudad.Id;
            txt_nombre_modify.Text = ciudad.Nombre;
            comboBox_pais_modify.SelectedValue = ciudad.IdPais;
            comboBox_Aerolinea2.SelectedValue = ciudad.IdProvincia;


        }

        private void btn_modify_Click_1(object sender, EventArgs e)
        {
            bool esValido = tratamientos.Validar(panel_modify.Controls) == Resultado.correcto;
            if (esValido)
            {
                CiudadObj ciudad = new CiudadObj()
                {
                    Id = idCiudadAModificar,
                    Nombre = txt_nombre_modify.Text,
                    IdProvincia = Int32.Parse(comboBox_Aerolinea2.SelectedValue.ToString()),
                    IdPais = Int32.Parse(comboBox_pais_modify.SelectedValue.ToString()),

                };
                _NE.ModificarCiudad(ciudad);
                CargarDataGrid();
        };

        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (grid_ciudades.CurrentRow == null)
                return;

            string idCiudad = grid_ciudades.CurrentRow.Cells[0].Value.ToString();
            _NE.EliminarCiudad(idCiudad);

            grid_ciudades.Rows.Remove(grid_ciudades.CurrentRow);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre_register.Text;
            string pais = comboBox_pais_register.SelectedValue.ToString();
            string provincia = comboBox_Aerolinea1.SelectedValue.ToString();
            DataTable tabla = _NE.GetCiudad(nombre,pais,provincia);
            if (tabla != null)
            { CargarGridCiudades(tabla); }
            else { MessageBox.Show("Complete los campos para realizar la busqueda"); }
        }

        private void comboBox_pais_register_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_Aerolinea1.SelectedIndex = -1;
            string CondicionAvion = @" JOIN Pais ON Pais.idPais " +
                       @"= Provincia.idPais WHERE Pais.idPais = " + comboBox_pais_register.SelectedValue;
            comboBox_Aerolinea1.CargarComboJoin(CondicionAvion);
        }

        private void comboBox_pais_modify_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_Aerolinea2.SelectedIndex = -1;
            string CondicionAvion = @" JOIN Pais ON Pais.idPais " +
                       @"= Provincia.idPais WHERE Pais.idPais = " + comboBox_pais_modify.SelectedValue;
            comboBox_Aerolinea2.CargarComboJoin(CondicionAvion);
        }
    }
}
