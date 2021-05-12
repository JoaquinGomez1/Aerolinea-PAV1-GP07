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
using TrabajoPrácticoPAV.Clase;

namespace TrabajoPrácticoPAV.Formularios.Aeropuertos
{
    public partial class Frm_ABM_Aeropuerto : Form
    {
        public string Id_codigo { get; set; }
        public Frm_ABM_Aeropuerto()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
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

            if (chk_todos.Checked == false && cmb_codigos.SelectedIndex == -1 && txt_nombre.Text == "")
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
              Frm_Alta_Aeropuerto alta = new Frm_Alta_Aeropuerto();
              alta.ShowDialog();
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
            Id_codigo = grid_aeropuertos.CurrentRow.Cells["codigo"].Value.ToString();
            Frm_Modificación_Aeropuerto modificar = new Frm_Modificación_Aeropuerto();
            modificar.Id_codigo = Id_codigo;
            //modificar.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
                if (Id_codigo != "")
                {
                    Frm_Modificación_Aeropuerto modificar = new Frm_Modificación_Aeropuerto();
                    modificar.Id_codigo = Id_codigo;
                    modificar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se encontró un aeropuerto con los filtros especificados");
                }
         }

        private void grid_aeropuertos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_Mostrar_Aeropuerto mostrar = new Frm_Mostrar_Aeropuerto();
            mostrar.Id_codigo = grid_aeropuertos.CurrentRow.Cells["codigo"].Value.ToString();
            mostrar.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_Borrar_Aeropuerto borrar = new Frm_Borrar_Aeropuerto();
            borrar.Id_codigo = Id_codigo;
            borrar.ShowDialog();
        }
    }
}
