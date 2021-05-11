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
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Tipo_Asientos
{
    public partial class Frm_ABMTipoAsientos : Form

    {   public string Id_Tipo { get; set; }
        public Frm_ABMTipoAsientos()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();

        private void Frm_ABMTipoAsientos_Load(object sender, EventArgs e)
        {
            grid_TipoAsiento.Pp_FormatoGrid = "idTipo, ID, 50;nombre, Clase, 100;costo, Costo, 100";
            grid_TipoAsiento.Formatear();

            cmb_Clase.CargarCombo();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            grid_TipoAsiento.Rows.Clear();
            cmb_Clase.SelectedIndex = -1;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string sql = _TE.ConstructorSelect(this.Controls, "", "Tipo_Asiento");
            CargarGrilla(sql, grid_TipoAsiento);
        }
        Conexion_DB _BD = new Conexion_DB();

        private void CargarGrilla(string sql, DataGridView_Aerolinea grid)
        {
            DataTable tabla = _BD.EjecutarSelect(sql);
            grid.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid.Rows.Add();
                grid.Rows[i].Cells[0].Value = (tabla.Rows[i]["idTipo"].ToString());
                grid.Rows[i].Cells[1].Value = (tabla.Rows[i]["nombre"].ToString());
                grid.Rows[i].Cells[2].Value = tabla.Rows[i]["costo"].ToString();

            }
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron vuelos.");
            }

        }

        private void grid_TipoAsiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NE_TipoAsiento NegoVuelo = new NE_TipoAsiento();
            btn_eliminar.Enabled = true;
            btn_modificar.Enabled = true;
            Id_Tipo = grid_TipoAsiento.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Frm_AltaTipoAsiento altaTA = new Frm_AltaTipoAsiento();
            altaTA.ShowDialog();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_ModificarTipoAsiento modificarTA = new Frm_ModificarTipoAsiento();
            modificarTA.Pp_nombre = grid_TipoAsiento.CurrentRow.Cells[1].Value.ToString();
            modificarTA.Pp_costo = grid_TipoAsiento.CurrentRow.Cells[2].Value;
            modificarTA.Id_Tipo = Id_Tipo;
            modificarTA.ShowDialog();
            //MessageBox.Show(modificarTA.Pp_nombre + modificarTA.Pp_costo);
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_BajaTipoAsientos bajaTA = new Frm_BajaTipoAsientos();
            bajaTA.Pp_nombreBaja = grid_TipoAsiento.CurrentRow.Cells[1].Value.ToString();
            //bajaTA.Id_Tipo = Id_Tipo;
            //MessageBox.Show(bajaTA.Pp_nombreBaja);
            bajaTA.ShowDialog();
        }

        
    }

   
}