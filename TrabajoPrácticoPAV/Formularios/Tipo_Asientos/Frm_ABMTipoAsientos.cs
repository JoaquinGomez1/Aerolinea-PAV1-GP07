﻿using System;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Tipo_Asientos
{
    public partial class Frm_ABMTipoAsientos : Form

    {
        public string Id_Tipo { get; set; }
        private NE_TipoAsiento TA = new NE_TipoAsiento();

        public Frm_ABMTipoAsientos()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

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
            TA.CargarGrilla(grid_TipoAsiento, "", this.Controls);
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Frm_AltaTipoAsiento altaTA = new Frm_AltaTipoAsiento();
            altaTA.ShowDialog();
            TA.CargarGrilla(grid_TipoAsiento, "", this.Controls);
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_ModificarTipoAsiento modificarTA = new Frm_ModificarTipoAsiento();
            modificarTA.Pp_nombre = grid_TipoAsiento.CurrentRow.Cells[1].Value.ToString();
            modificarTA.Pp_costo = grid_TipoAsiento.CurrentRow.Cells[2].Value;
            modificarTA.Id_Tipo = Id_Tipo;
            modificarTA.ShowDialog();
            TA.CargarGrilla(grid_TipoAsiento, "", this.Controls);
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_BajaTipoAsientos bajaTA = new Frm_BajaTipoAsientos();
            bajaTA.Pp_nombreBaja = grid_TipoAsiento.CurrentRow.Cells[1].Value.ToString();
            bajaTA.Id_Tipo = Id_Tipo;
            bajaTA.Pp_costo = grid_TipoAsiento.CurrentRow.Cells[2].Value;
            bajaTA.ShowDialog();
            TA.CargarGrilla(grid_TipoAsiento, "", this.Controls);
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
        }

        private void grid_TipoAsiento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_ConsultarTipoAsiento consultaTA = new Frm_ConsultarTipoAsiento();
            consultaTA.Pp_nombre = grid_TipoAsiento.CurrentRow.Cells[1].Value.ToString();
            consultaTA.Id_Tipo = Id_Tipo;
            consultaTA.Pp_costo = grid_TipoAsiento.CurrentRow.Cells[2].Value;
            consultaTA.ShowDialog();
        }

        private void grid_TipoAsiento_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btn_eliminar.Enabled = true;
            btn_modificar.Enabled = true;
            Id_Tipo = grid_TipoAsiento.CurrentRow.Cells[0].Value.ToString();
        }
    }
}