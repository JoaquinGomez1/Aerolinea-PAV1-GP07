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
using TrabajoPrácticoPAV.Clase.Modelos;
using TrabajoPrácticoPAV.Formularios.Viajes;
using TrabajoPrácticoPAV.NE_Usuarios;
using static TrabajoPrácticoPAV.Clase.Tratamientos_Especiales;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.Formularios.Tripulacion_x_vuelo
{
    public partial class Frm_ABM_TripulacionxVuelo : Form
       
    {
        Conexion_DB _BD = new Conexion_DB();
        NE_TripulacionxVuelo tripulacionxVuelo = new NE_TripulacionxVuelo();
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();
        DataTable tabla = new DataTable();


        public int Pp_idTripulacion { get; set; }
        public int Pp_idVuelo { get; set; }
        public Frm_ABM_TripulacionxVuelo()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (chk_todos.Checked)
            {
                CargarGrilla(tripulacionxVuelo.RecuperarTodos());
                return;
            }
            if (txt_idTripulacion.Text != "" && txt_idVuelo.Text != "")
            {
                tripulacionxVuelo.Pp_idTripulacion = int.Parse(txt_idTripulacion.Text);
                tripulacionxVuelo.Pp_idVuelo = int.Parse(txt_idVuelo.Text);

                CargarGrilla(tripulacionxVuelo.Recuperar_x_id());
                return;
            } 
        }

        private void Frm_ABM_TripulacionxVuelo_Load(object sender, EventArgs e)
        {
            btn_eliminar.Enabled = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void CargarGrilla(DataTable tabla)
        {
            dataGrid_tripulacionxVuelo.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dataGrid_tripulacionxVuelo.Rows.Add();
                dataGrid_tripulacionxVuelo.Rows[i].Cells[0].Value = tabla.Rows[i]["idTripulacion"].ToString();
                dataGrid_tripulacionxVuelo.Rows[i].Cells[1].Value = tabla.Rows[i]["idVuelo"].ToString();
            }
            if (dataGrid_tripulacionxVuelo.Rows.Count == 0)
            {
                MessageBox.Show("No se han recuperado valores");
            }
        }

        private void dataGrid_tripulacionxVuelo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pp_idTripulacion = int.Parse(dataGrid_tripulacionxVuelo.CurrentRow.Cells[0].Value.ToString());
            Pp_idVuelo = int.Parse(dataGrid_tripulacionxVuelo.CurrentRow.Cells[1].Value.ToString());
            btn_eliminar.Enabled = true;
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_Eliminar_TripulacionxVuelo borrar = new Frm_Eliminar_TripulacionxVuelo();
            borrar.Pp_idTripulacion = Pp_idTripulacion;
            borrar.Pp_idVuelo = Pp_idVuelo;
            borrar.ShowDialog();
            dataGrid_tripulacionxVuelo.Rows.Clear();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Frm_Alta_TripulacionxVuelo alta = new Frm_Alta_TripulacionxVuelo();
            alta.ShowDialog();
        }
    }
}

