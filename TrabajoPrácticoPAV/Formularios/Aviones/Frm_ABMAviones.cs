using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.NE_Aviones;
using TrabajoPrácticoPAV.Formularios;
using TrabajoPrácticoPAV.Clase;

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ABMAviones : Form
    {
        public Frm_ABMAviones()
        {
            InitializeComponent();
            NE_Avion aviones = new NE_Avion();
            DataTable tabla = new DataTable();
            tabla = aviones.RecuperarTodos();
            CargarGrilla(tabla);
        }


        private void CargarGrilla(DataTable tabla)
        {
            grid_aviones.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_aviones.Rows.Add();
                grid_aviones.Rows[i].Cells[0].Value = tabla.Rows[i]["numeroPorModelo"].ToString();
                grid_aviones.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grid_aviones.Rows[i].Cells[2].Value = tabla.Rows[i]["IdModelo"].ToString();

            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int current = grid_aviones.CurrentRow.Index;
          
            if (grid_aviones.CurrentCell.ColumnIndex == 3)
            {

               //MessageBox.Show( "Eliminar", grid_aviones.CurrentRow.Cells[0].Value.ToString());

               NE_Avion avion = new NE_Avion();
               string numeroModelo = grid_aviones.CurrentRow.Cells[0].Value.ToString();
               var idModelo = grid_aviones.Rows[current].Cells[2].Value;
               CargarGrilla(avion.Remover_avion(numeroModelo, idModelo));
               MessageBox.Show("Avion eliminado, Actualize la tabla");
               return;
            }
            if (grid_aviones.CurrentCell.ColumnIndex == 4)
            {      

                Frm_ModificarAvion modificar = new Frm_ModificarAvion();

                modificar.Pp_numeroSeleccionado = grid_aviones.CurrentRow.Cells[0].Value.ToString(); 
                modificar.Pp_idModeloSeleccionado = grid_aviones.Rows[current].Cells[2].Value; 
                modificar.ShowDialog();
                MessageBox.Show("Avion modificado, Actualize la tabla");
                return;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_AltaAviones alta = new Frm_AltaAviones();
            alta.ShowDialog();


        }

        private void Frm_ABMAviones_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            cmb_Modelo.CargarCombo();
        }


        private void btn_actualizar_Click(object sender, EventArgs e)
        {

            NE_Avion aviones = new NE_Avion();
            DataTable tabla = new DataTable();
            tabla = aviones.RecuperarTodos();
            CargarGrilla(tabla);

        }

        private void textBox_Aerolinea1_TextChanged(object sender, EventArgs e)
        {

        }


        private void cmb_Modelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            int modelo_up = int.Parse(cmb_Modelo.SelectedIndex.ToString()) + 1;
            NE_Avion avion = new NE_Avion();

            if (txt_numero.Text.Length > 4)
            {
                MessageBox.Show("El numero de avion debe tener 4 numeros");
            }
            if (txt_numero.Text == string.Empty && cmb_Modelo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar alguna opcion o ingresar numero de modelo");
            }

            if (cmb_Modelo.SelectedIndex != -1 && txt_numero.Text != "")
            {
                CargarGrilla(avion.Recuperar_Mixto(txt_numero.Text, modelo_up));
                return;
            }

            if (cmb_Modelo.SelectedIndex != -1)
            {
                CargarGrilla(avion.Recuperar_x_modelo(modelo_up));
                return;
            }

            if (txt_numero.Text != "")
            {
                CargarGrilla(avion.Recuperar_x_numero(txt_numero.Text));
                return;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void picBox_buscar_Click(object sender, EventArgs e)
        {
            int modelo_up = int.Parse(cmb_Modelo.SelectedIndex.ToString()) + 1;
            NE_Avion avion = new NE_Avion();

            if (txt_numero.Text.Length > 4)
            {
                MessageBox.Show("El numero de avion debe tener 4 numeros");
            }
            if (txt_numero.Text == string.Empty && cmb_Modelo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar alguna opcion o ingresar numero de modelo");
            }

            if (cmb_Modelo.SelectedIndex != -1 && txt_numero.Text != "")
            {
                CargarGrilla(avion.Recuperar_Mixto(txt_numero.Text, modelo_up));
                return;
            }

            if (cmb_Modelo.SelectedIndex != -1)
            {
                CargarGrilla(avion.Recuperar_x_modelo(modelo_up));
                return;
            }

            if (txt_numero.Text != "")
            {
                CargarGrilla(avion.Recuperar_x_numero(txt_numero.Text));
                return;
            }
        }

        private void picBox_actualizar_Click(object sender, EventArgs e)
        {
            NE_Avion aviones = new NE_Avion();
            DataTable tabla = new DataTable();
            tabla = aviones.RecuperarTodos();
            CargarGrilla(tabla);
        }

        private void picBox_agregar_Click(object sender, EventArgs e)
        {
            Frm_AltaAviones alta = new Frm_AltaAviones();
            alta.ShowDialog();
        }
    }
}
