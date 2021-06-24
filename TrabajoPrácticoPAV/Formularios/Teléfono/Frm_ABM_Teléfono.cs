using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Clase.Modelos;
using TrabajoPrácticoPAV.Formularios.Viajes;
using TrabajoPrácticoPAV.NE_Usuarios;
using static TrabajoPrácticoPAV.Clase.Tratamientos_Especiales;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.Formularios.Teléfono
{
    public partial class Frm_ABM_Teléfono : Form
    {
        Conexion_DB _BD = new Conexion_DB();
        NE_Telefonos telefono = new NE_Telefonos();
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();
        DataTable tabla = new DataTable();

        public string Pp_numeroTelefono { get; set; }
        public int Pp_tipoDoc { get; set; }
        public int Pp_numeroDoc { get; set; }

        public Frm_ABM_Teléfono()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_ABM_Teléfono_Load(object sender, EventArgs e)
        {
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Frm_Alta alta = new Frm_Alta();
            alta.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_ModificacionTelefono modificar = new Frm_ModificacionTelefono();
            modificar.Pp_numeroTelefono = Pp_numeroTelefono;
            modificar.Pp_tipoDoc = Pp_tipoDoc;
            modificar.Pp_numeroDoc= Pp_numeroDoc;
            modificar.ShowDialog();
            dataGrid_telefonos.Rows.Clear();
        }
        private void CargarGrilla(DataTable tabla)
        {
            dataGrid_telefonos.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dataGrid_telefonos.Rows.Add();
                dataGrid_telefonos.Rows[i].Cells[0].Value = tabla.Rows[i]["numeroTelefono"].ToString();
                dataGrid_telefonos.Rows[i].Cells[1].Value = tabla.Rows[i]["tipoDoc"].ToString();
                dataGrid_telefonos.Rows[i].Cells[2].Value = tabla.Rows[i]["numeroDoc"].ToString();
            }
            if (dataGrid_telefonos.Rows.Count == 0)
            {
                MessageBox.Show("No se han recuperado valores");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (chk_todos.Checked)
            {
                CargarGrilla(telefono.RecuperarTodos());
                return;
            }
            if (txt_nroTelefono.Pp_Text != "")
            {
                CargarGrilla(telefono.Recuperar_x_numero());
                return;
            }
        }

        private void dataGrid_telefonos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pp_numeroTelefono = dataGrid_telefonos.CurrentRow.Cells[0].Value.ToString();
            Pp_tipoDoc = int.Parse(dataGrid_telefonos.CurrentRow.Cells[1].Value.ToString());
            Pp_numeroDoc = int.Parse(dataGrid_telefonos.CurrentRow.Cells[2].Value.ToString());
            btn_modificar.Enabled = true;
            btn_eliminar.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_Borrar_Telefono borrar = new Frm_Borrar_Telefono();
            borrar.Pp_numeroTelefono = Pp_numeroTelefono;
            borrar.ShowDialog();
            dataGrid_telefonos.Rows.Clear();
        }
    }
}
