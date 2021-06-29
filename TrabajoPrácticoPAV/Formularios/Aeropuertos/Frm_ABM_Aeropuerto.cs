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
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.Formularios.Aeropuertos
{
    public partial class Frm_ABM_Aeropuerto : Form
    {

        Conexion_DB _BD = new Conexion_DB();

        public string Id_codigo { get; set; }
        public Frm_ABM_Aeropuerto()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;

            NE_Aeropuertos aeropuerto = new NE_Aeropuertos();
            Tratamientos_Especiales _TE = new Tratamientos_Especiales();

            CargarGrilla(_TE.ConstructorSelect(this.Controls, "JOIN Ciudad ON Ciudad.idCiudad = Aeropuerto.idCiudad", "Aeropuerto"));
        }


        private void CargarGrilla(string sql)
        {
            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            grid_aeropuertos.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_aeropuertos.Rows.Add();
                grid_aeropuertos.Rows[i].Cells[0].Value = tabla.Rows[i]["codigo"].ToString();
                grid_aeropuertos.Rows[i].Cells[1].Value = tabla.Rows[i]["nombre"].ToString();
                grid_aeropuertos.Rows[i].Cells[2].Value = tabla.Rows[i]["nombreCiudad"].ToString();
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
            grid_aeropuertos.Rows.Clear();
        }

        private void Frm_ABM_Aeropuerto_Load(object sender, EventArgs e)
        {
            grid_aeropuertos.Pp_FormatoGrid = "codigo,Código, 50;nombre,Nombre, 250;nombreCiudad,Ciudad,150";
            grid_aeropuertos.Formatear();
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
        }

        private void grid_aeropuertos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                Id_codigo = grid_aeropuertos.CurrentRow.Cells[0].Value.ToString();
                btn_modificar.Enabled = true;
                btn_eliminar.Enabled = true;   
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
                Frm_Modificación_Aeropuerto modificar = new Frm_Modificación_Aeropuerto();
                modificar.Id_codigo = Id_codigo;
                modificar.ShowDialog();
            grid_aeropuertos.Rows.Clear();
        }

        private void grid_aeropuertos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_Mostrar_Aeropuerto mostrar = new Frm_Mostrar_Aeropuerto();
            mostrar.Id_codigo = grid_aeropuertos.CurrentRow.Cells["codigo"].Value.ToString();
            MessageBox.Show(grid_aeropuertos.CurrentRow.Cells["codigo"].Value.ToString());
            mostrar.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_Borrar_Aeropuerto borrar = new Frm_Borrar_Aeropuerto();
            borrar.Id_codigo = Id_codigo;
            borrar.ShowDialog();
            grid_aeropuertos.Rows.Clear();
        }

        private void btn_limpiarr_Click(object sender, EventArgs e)
        {
            grid_aeropuertos.Rows.Clear();
            txt_Codigo.Text = "";
            txt_Nombre.Text = "";
            chk_todos.Checked = false;
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
        }

        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
    }
}
