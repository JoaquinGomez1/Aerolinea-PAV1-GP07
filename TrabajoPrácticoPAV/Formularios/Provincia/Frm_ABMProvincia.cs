using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Provincia
{
    public partial class Frm_ABMProvincia : Form
    {
        Conexion_DB _BD = new Conexion_DB();
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();


        public Frm_ABMProvincia()
        {
            InitializeComponent();
        }

        private void Frm_ABMProvincia_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            grid_provincias.Formatear();
            cmb_Pais.CargarCombo();

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_idProvincia.Text = "";
            txt_Nombre.Text = "";
            grid_provincias.Rows.Clear();
            chb_todos.Checked = false;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (verificar_seleccion(cmb_Pais, txt_Nombre, txt_idProvincia, chb_todos))
            {
                DataTable tabla = new DataTable();
                string join = " JOIN Pais ON Provincia.idPais = Pais.idPais ";
                string sql = _TE.ConstructorSelect(this.Controls, join, "Provincia");
                CargarGrilla(sql, grid_provincias);
                Btn_Modificar.Enabled = false;
                Btn_Eliminar.Enabled = false;
            }

        }

        private void CargarGrilla(string sql, DataGridView_Aerolinea grid)
        {

            DataTable tabla = _BD.EjecutarSelect(sql);

            grid.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid.Rows.Add();

                grid.Rows[i].Cells[0].Value = buscar_nombre_pais(tabla.Rows[i]["idPais"].ToString());
                grid.Rows[i].Cells[1].Value = tabla.Rows[i]["idProvincia"].ToString();
                grid.Rows[i].Cells[2].Value = tabla.Rows[i]["nombreProvincia"].ToString();
            }
        }

        private string buscar_nombre_pais(string id_pais)
        {
            string sql = $"SELECT nombrePais FROM Pais WHERE idPais={id_pais}";
            return _BD.EjecutarSelect(sql).Rows[0]["nombrePais"].ToString();
        }

        public string buscar_id_pais(string nombre_pais)
        {
            string sql = $"SELECT idPais FROM Pais WHERE nombrePais='{nombre_pais}'";
            return _BD.EjecutarSelect(sql).Rows[0]["idPais"].ToString();
        }

        private bool verificar_seleccion(ComboBox_Aerolinea pais, TextBox_Aerolinea nombre, MaskedTextBox_Aerolinea id, CheckBox todos)
        {
            if (pais.SelectedIndex == -1 & nombre.Text == "" & id.Text == "" & todos.Checked == false)
            {
                MessageBox.Show("Debe ingresar al menos un dato o seleccionar todos");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            Frm_AltaProvincia Alta_Provincia = new Frm_AltaProvincia();
            Alta_Provincia.ShowDialog();
        }

        private void grid_provincias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Btn_Modificar.Enabled = true;
            Btn_Eliminar.Enabled = true;
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {

            Frm_ModificarProvincia Modificar_provincia = new Frm_ModificarProvincia();

            string id_pais = buscar_id_pais(grid_provincias.CurrentRow.Cells["idPais"].Value.ToString());
            Modificar_provincia.pais_provincia = id_pais;
            Modificar_provincia.id_provincia = grid_provincias.CurrentRow.Cells["idProvincia"].Value.ToString();
            Modificar_provincia.nombreProvincia = grid_provincias.CurrentRow.Cells["nombreProvincia"].Value.ToString();

            Modificar_provincia.ShowDialog();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Frm_BajaProvincia Baja_Provincia = new Frm_BajaProvincia();

            string id_pais = buscar_id_pais(grid_provincias.CurrentRow.Cells["idPais"].Value.ToString());
            Baja_Provincia.pais_provincia = id_pais;
            Baja_Provincia.id_provincia = grid_provincias.CurrentRow.Cells["idProvincia"].Value.ToString();
            Baja_Provincia.nombreProvincia = grid_provincias.CurrentRow.Cells["nombreProvincia"].Value.ToString();

            Baja_Provincia.ShowDialog();

        }
    }
}
