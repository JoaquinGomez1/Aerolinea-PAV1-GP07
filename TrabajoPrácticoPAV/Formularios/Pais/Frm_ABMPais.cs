﻿using System;
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

namespace TrabajoPrácticoPAV.Formularios.Pais
{
    public partial class Frm_ABMPais : Form
    {
        Conexion_DB _BD = new Conexion_DB();
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();
        NE_pais pais = new NE_pais();

        public Frm_ABMPais()
        {
            InitializeComponent();
        }

        private void Frm_ABMPais_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            grid_paises.Formatear();

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (pais.verificar_seleccion(txt_Nombre, txt_IdPais, chb_todos_tramo))
            {
                DataTable tabla = new DataTable();
                string join = "";
                string sql = _TE.ConstructorSelect(this.Controls, join);
                CargarGrilla(_BD.EjecutarSelect(sql));
                Btn_Modificar.Enabled = false;
                Btn_Eliminar.Enabled = false;
            }

        }
        private void CargarGrilla(DataTable tabla)
        {            
            grid_paises.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_paises.Rows.Add();
                grid_paises.Rows[i].Cells[0].Value = tabla.Rows[i]["idPais"].ToString();
                grid_paises.Rows[i].Cells[1].Value = tabla.Rows[i]["nombrePais"].ToString();
            }

        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_IdPais.Text = "";
            txt_Nombre.Text = "";
            grid_paises.Rows.Clear();
            chb_todos_tramo.Checked = false;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;

        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            Frm_AltaPais pais = new Frm_AltaPais();
            pais.ShowDialog();
        }

        private void grid_paises_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Btn_Modificar.Enabled = true;
            Btn_Eliminar.Enabled = true;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Frm_BajaPais baja_pais = new Frm_BajaPais();
            baja_pais.id_pais = grid_paises.CurrentRow.Cells["idPais"].Value.ToString();
            baja_pais.nombre_pais = grid_paises.CurrentRow.Cells["nombrePais"].Value.ToString();
            baja_pais.ShowDialog();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Frm_ModificarPais modificar_pais = new Frm_ModificarPais();
            modificar_pais.id_pais = grid_paises.CurrentRow.Cells["idPais"].Value.ToString();
            modificar_pais.nombre_pais = grid_paises.CurrentRow.Cells["nombrePais"].Value.ToString();
            modificar_pais.ShowDialog();

        }
    }
}
