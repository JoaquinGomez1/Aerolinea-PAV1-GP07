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

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ABMVuelo : Form
    {
        public string Id_Vuelo { get; set; }
        public Frm_ABMVuelo()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ABMVuelo_Load(object sender, EventArgs e)
        {
            cmb_nomModelo.CargarCombo();

            this.BackColor = Estilo.ColorFondoForms;
                Estilo.FormatearEstilo(this.Controls);
        }
        

        private void btn_consultar1_Click(object sender, EventArgs e)
        {
            NE_Vuelos vuelo = new NE_Vuelos();

            if (chk_box.Checked == false && cmb_NumAvion.SelectedIndex == -1 && cmb_nomModelo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar alguna opción");
            }
            if (chk_box.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = vuelo.RecuperarTodos();
                CargarGrilla_vuelo1(tabla);
                return;
            }
            if (chk_box.Checked == false
                && cmb_NumAvion.SelectedIndex != -1
                && cmb_nomModelo.SelectedIndex != -1)
            {
                CargarGrilla_vuelo1(vuelo.Recuperar_Mixto((cmb_NumAvion.SelectedValue.ToString()), cmb_nomModelo.SelectedValue.ToString()));
                return;
            }
            if (cmb_nomModelo.SelectedIndex != -1)
            {
                CargarGrilla_vuelo1(vuelo.RecuprarXmodelo(cmb_nomModelo.SelectedValue.ToString()));
                return;
            }
            if (cmb_NumAvion.SelectedIndex != -1)
            {
                CargarGrilla_vuelo1(vuelo.RecuperarXavion(cmb_NumAvion.SelectedValue.ToString()));
            }
        }
        private void CargarGrilla_vuelo1(DataTable tabla)
        {
            grilla_ABM_vuelo1.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla_ABM_vuelo1.Rows.Add();
                grilla_ABM_vuelo1.Rows[i].Cells[0].Value = tabla.Rows[i]["duracionEstimada"].ToString();
                grilla_ABM_vuelo1.Rows[i].Cells[1].Value = tabla.Rows[i]["n_modelo"].ToString();
                grilla_ABM_vuelo1.Rows[i].Cells[2].Value = tabla.Rows[i]["codigoAeropuertoDestino"].ToString();
                grilla_ABM_vuelo1.Rows[i].Cells[3].Value = tabla.Rows[i]["codigoAeropuertoSalida"].ToString();
                grilla_ABM_vuelo1.Rows[i].Cells[4].Value = tabla.Rows[i]["idVuelo"].ToString();
            }
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron vuelos.");
            }
        }

        private void btn_registrar1_Click(object sender, EventArgs e)
        {
            Frm_AltaVuelo altavuelo = new Frm_AltaVuelo();
            altavuelo.ShowDialog();
        }

        private void grilla_ABM_vuelo1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NE_Vuelos NegoVuelo = new NE_Vuelos();
            btn_borrar1.Enabled = true;
            btn_modificar1.Enabled = true;
            Id_Vuelo = grilla_ABM_vuelo1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_modificar1_Click(object sender, EventArgs e)
        {
            Frm_ModificarVuelo modificarVuelo = new Frm_ModificarVuelo();
            modificarVuelo.Id_vuelo = Id_Vuelo;
            modificarVuelo.ShowDialog();
        }

        private void btn_borrar1_Click(object sender, EventArgs e)
        {
            Frm_BorrarVuelo borrarvuelo = new Frm_BorrarVuelo();
            borrarvuelo.Id_vuelo = Id_Vuelo;
            borrarvuelo.ShowDialog();
        }

        private void btn_limpiar1_Click_1(object sender, EventArgs e)
        {
            cmb_nomModelo.SelectedIndex = -1;
            cmb_NumAvion.SelectedIndex = -1;
            chk_box.Checked = false;
            grilla_ABM_vuelo1.Rows.Clear();
        }
       
        private void cmb_NumAvion_SelectedIndexChanged(object sender, EventArgs e)
        {
            chk_box.Checked = false;
        }
        
        private void cmb_nomModelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //MessageBox.Show("Descomentar esta parte");
            string Condicion = @" JOIN Modelo ON Modelo.idModelo " +
                    @"= Avion.idModelo WHERE Avion.idModelo = " + cmb_nomModelo.SelectedValue;
            cmb_NumAvion.CargarComboJoin(Condicion);
            chk_box.Checked = false;
        }

        private void grilla_ABM_vuelo1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_ConsultarVuelo consulta = new Frm_ConsultarVuelo();
            consulta.Id_vuelo1 = grilla_ABM_vuelo1.CurrentRow.Cells[4].Value.ToString();
            consulta.ShowDialog();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
