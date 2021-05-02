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
    }
}
