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
using TrabajoPrácticoPAV.Formularios;

namespace TrabajoPrácticoPAV.Formularios.Aeropuertos
{
    public partial class Frm_ABM_Aeropuerto : Form
    {
        public string Codigo_aeropuerto { get; set; }
        public Frm_ABM_Aeropuerto()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarGrilla(DataTable tabla)
        {
            grid_aeropuertos.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_aeropuertos.Rows.Add();
                grid_aeropuertos.Rows[i].Cells[0].Value = tabla.Rows[i]["codigo"].ToString();
                grid_aeropuertos.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grid_aeropuertos.Rows[i].Cells[2].Value = tabla.Rows[i]["idCiudad"].ToString();
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            NE_Aeropuertos aeropuerto = new NE_Aeropuertos();

            if (chk_todos.Checked == false &&  cmb_codigos.SelectedIndex == -1 && txt_nombre.Text == "")
            {
                MessageBox.Show("Debe indicar alguna opción para la búsqueda de aeropuertos");
            }
            if (chk_todos.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = aeropuerto.RecuperarTodos();
                CargarGrilla(tabla);
                return;
            }
            if (chk_todos.Checked == false
                && cmb_codigos.SelectedIndex != -1
                && txt_nombre.Text != "")
            {
                CargarGrilla(aeropuerto.Recuperar_por_CodigoYNombre(txt_nombre.Text, cmb_codigos.SelectedValue.ToString()));
                return;
            }
            if (cmb_codigos.SelectedIndex != -1)
            {
                CargarGrilla(aeropuerto.Recuperar_por_Codigo(cmb_codigos.SelectedValue.ToString()));
                return;
            }
            if (txt_nombre.Text != "")
            {
                CargarGrilla(aeropuerto.Recuperar_por_PatronNombre(txt_nombre.Text));
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
      ///      Frm_Mostrar_Aeropuerto alta = new Frm_Mostrar_Aeropuerto();
          ///  alta.ShowDialog();
        }

        private void pic_deseleccionar_Click(object sender, EventArgs e)
        {
            cmb_codigos.SelectedIndex = -1;
        }

        private void Frm_ABM_Aeropuerto_Load(object sender, EventArgs e)
        {
            cmb_codigos.CargarCombo();
        }

        private void grid_aeropuertos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Codigo_aeropuerto = grid_aeropuertos.CurrentRow.Cells["codigo"].Value.ToString();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
      ///      Frm_Modificacion_Aeropuerto modificar = new Frm_Modificacion_Aeropuerto();
       ///     modificar.Codigo_aeropuerto = Codigo_aeropuerto;
          ///  modificar.ShowDialog();
        }
    }
}
