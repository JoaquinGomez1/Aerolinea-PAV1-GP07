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
using TrabajoPrácticoPAV.Formularios;
using TrabajoPrácticoPAV.NE_Usuarios;
using TrabajoPrácticoPAV.Formularios.Vuelo;

namespace TrabajoPrácticoPAV.Formularios.Modelo
{
    public partial class Frm_ABMmodelo : Form
    {
        public string Id_modelo{ get; set; }
        NE_Modelo modelo = new NE_Modelo();

        public Frm_ABMmodelo()
        {
            InitializeComponent();
        }
        private void Frm_ABMmodelo_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            chk_modelo.Checked = false;
            grilla_modelos.Rows.Clear();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

            string sql = tratamiento.ConstructorSelect(this.Controls, "", "Modelo");
            Cargar_grilla_modelos(sql);
        }
        private void Cargar_grilla_modelos(string sql)
        {
            Conexion_DB _BD = new Conexion_DB();
            DataTable tabla = _BD.EjecutarSelect(sql);

            grilla_modelos.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla_modelos.Rows.Add();
                grilla_modelos.Rows[i].Cells[0].Value = tabla.Rows[i]["nombre"].ToString();
                grilla_modelos.Rows[i].Cells[1].Value = tabla.Rows[i]["idModelo"].ToString();
            }
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron Asientos para ese filtro.");
            }

        }

        private void grilla_modelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_eliminar.Enabled = true;
            btn_modificar.Enabled = true;
            Id_modelo = grilla_modelos.CurrentRow.Cells[1].Value.ToString();
        }

        private void grilla_modelos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_ConsultaModelo consultaModelo = new Frm_ConsultaModelo();
            consultaModelo.Id_modelo = Id_modelo;
            consultaModelo.ShowDialog();
            
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Frm_AltaModelo altaModelo = new Frm_AltaModelo();
            altaModelo.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_ModificarModelo ModificarModelo = new Frm_ModificarModelo();
            ModificarModelo.Id_Modelo = Id_modelo;
            ModificarModelo.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_BajaModelo eliminarModelo = new Frm_BajaModelo();
            eliminarModelo.Id_modelo = Id_modelo;
            eliminarModelo.ShowDialog();
        }
    }
}
