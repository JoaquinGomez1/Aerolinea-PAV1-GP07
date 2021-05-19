using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.NE_Usuarios;
using TrabajoPrácticoPAV.Formularios.Aviones;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ABMAviones : Form
    {
        Conexion_DB _BD = new Conexion_DB();
        public string Id_numero { get; set; }
        public string Id_modelo { get; set; }
        public string Nombre { get; set; }
        public Frm_ABMAviones()
        {
            InitializeComponent();
            //NE_Avion aviones = new NE_Avion();
            //DataTable tabla = new DataTable();
            //tabla = aviones.RecuperarTodos();
            //CargarGrilla(tabla);
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void CargarGrilla(DataTable tabla)
        {
            grid_aviones.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_aviones.Rows.Add();
                grid_aviones.Rows[i].Cells[0].Value = tabla.Rows[i]["numeroPorModelo"].ToString();
                grid_aviones.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grid_aviones.Rows[i].Cells[2].Value = tabla.Rows[i]["idModelo"].ToString();

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void Frm_ABMAviones_Load(object sender, EventArgs e)
        {
            cmb_Modelo.CargarCombo();
            btn_eliminar.Enabled = false;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
//            int modelo_up = int.Parse(cmb_Modelo.SelectedIndex.ToString()) + 1;
            NE_Avion avion = new NE_Avion();
            DataTable tabla = new DataTable();

            if (txt_numero.Text.Length > 4)
            {
                MessageBox.Show("El numero de avion debe tener 4 numeros máximo");
            }
            if (txt_numero.Text == string.Empty && cmb_Modelo.SelectedIndex == -1 &&  !chk_todos.Checked)
            {
                MessageBox.Show("Seleccionar alguna opcion de búsqueda");
            }

            if (cmb_Modelo.SelectedIndex != -1 && txt_numero.Text != "")
            {
                //              CargarGrilla(avion.Recuperar_Mixto(txt_numero.Text, modelo_up));
                CargarGrilla(avion.Recuperar_Mixto(txt_numero.Text, cmb_Modelo.Text));
                return;
            }

            if (cmb_Modelo.SelectedIndex != -1)
            {
                CargarGrilla(avion.Recuperar_x_modelo(cmb_Modelo.Text));
                return;
            }

            if (txt_numero.Text != "")
            {
                CargarGrilla(avion.Recuperar_x_numero(txt_numero.Text));
                return;
            }
            if (chk_todos.Checked)
            {
                CargarGrilla(avion.RecuperarTodos());
                return;
            }

        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Frm_AltaAviones alta = new Frm_AltaAviones();
            alta.ShowDialog();
            grid_aviones.Rows.Clear();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            grid_aviones.Rows.Clear();
            txt_numero.Text = "";
            cmb_Modelo.Text = "";
            chk_todos.Checked = false;
            btn_eliminar.Enabled = false;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_Borrar_Avion borrar = new Frm_Borrar_Avion();
            borrar.Id_numero = Id_numero;
            borrar.Id_modelo = Id_modelo;
            borrar.Nombre = Nombre;
            borrar.ShowDialog();
            grid_aviones.Rows.Clear();
        }

        private void btn_deseleccionar_Click(object sender, EventArgs e)
        {
            cmb_Modelo.SelectedIndex = -1;
        }

        private void chk_todos_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_todos.Checked)
            {
                txt_numero.Text = "";
                cmb_Modelo.SelectedIndex = -1;
            }
            else
            {
                cmb_Modelo.CargarCombo();
            }
        }

        private void grid_aviones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int current = grid_aviones.CurrentRow.Index;

            if (grid_aviones.CurrentCell.ColumnIndex != 0)
            {
                btn_eliminar.Enabled = true;
                //MessageBox.Show( "Eliminar", grid_aviones.CurrentRow.Cells[0].Value.ToString());

                NE_Avion avion = new NE_Avion();
                Id_numero = grid_aviones.CurrentRow.Cells[0].Value.ToString();
                Nombre = grid_aviones.CurrentRow.Cells[1].Value.ToString();
                Id_modelo = grid_aviones.CurrentRow.Cells[2].Value.ToString();

///                CargarGrilla(avion.Remover_avion(Id_numero, Id_modelo));
                ///MessageBox.Show("Avion eliminado, Actualice la tabla");
                return;
            }
        }

        private void grid_aviones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_numero = grid_aviones.CurrentRow.Cells["numero"].Value.ToString();
            Id_modelo = grid_aviones.CurrentRow.Cells["idModelo"].Value.ToString();
            Nombre = grid_aviones.CurrentRow.Cells["nombre"].Value.ToString();
            btn_eliminar.Enabled = true;
        }
    }
}
