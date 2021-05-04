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

            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            cmb_Modelo.CargarCombo();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int modelo_up = int.Parse(cmb_Modelo.SelectedIndex.ToString()) + 1;
            NE_Avion avion = new NE_Avion();
            if (txt_Numero.Text == string.Empty && cmb_Modelo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar alguna opcion o ingresar numero de modelo");
            }

            if (cmb_Modelo.SelectedIndex != -1 && txt_Numero.Text != "")
            {
                CargarGrilla(avion.Recuperar_Mixto(txt_Numero.Text, modelo_up));
            }

            if (cmb_Modelo.SelectedIndex != -1)
            {
                //recuperar por modelo
            }

            if (txt_Numero.Text != "")
            {
                //Recuperar por numero
            }

            MessageBox.Show(modelo_up.ToString());



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
    }
}
