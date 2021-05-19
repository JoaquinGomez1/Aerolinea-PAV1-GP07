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
        NE_Vuelos vuelo = new NE_Vuelos();

        public Frm_ABMVuelo()
        {
            InitializeComponent();
        }

        private void Frm_ABMVuelo_Load(object sender, EventArgs e)
        {
            cmb_nomModelo.CargarCombo();

            this.BackColor = Estilo.ColorFondoForms;
                Estilo.FormatearEstilo(this.Controls);
        }
        

        private void btn_consultar1_Click(object sender, EventArgs e)
        {
            if (chk_box.Checked == false && cmb_NumAvion.SelectedIndex == -1 && cmb_nomModelo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar alguna opción");
            }
            else
            {
                
                vuelo.CargarGrilla_vuelo1( grilla_ABM_vuelo1, "", this.Controls);
            }
        }
       

        private void btn_registrar1_Click(object sender, EventArgs e)
        {
            Frm_AltaVuelo altavuelo = new Frm_AltaVuelo();
            altavuelo.ShowDialog();
            vuelo.CargarGrilla_vuelo1(grilla_ABM_vuelo1, "", this.Controls);
            btn_borrar1.Enabled = false;
            btn_modificar1.Enabled = false;
        }

        private void grilla_ABM_vuelo1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_borrar1.Enabled = true;
            btn_modificar1.Enabled = true;
            Id_Vuelo = grilla_ABM_vuelo1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_modificar1_Click(object sender, EventArgs e)
        {
            Frm_ModificarVuelo modificarVuelo = new Frm_ModificarVuelo();
            modificarVuelo.Id_vuelo = Id_Vuelo;
            modificarVuelo.ShowDialog();
            vuelo.CargarGrilla_vuelo1(grilla_ABM_vuelo1, "", this.Controls);
            btn_borrar1.Enabled = false;
            btn_modificar1.Enabled = false;
        }

        private void btn_borrar1_Click(object sender, EventArgs e)
        {
            Frm_BorrarVuelo borrarvuelo = new Frm_BorrarVuelo();
            borrarvuelo.Id_vuelo = Id_Vuelo;
            borrarvuelo.ShowDialog();
            vuelo.CargarGrilla_vuelo1(grilla_ABM_vuelo1, "", this.Controls);
            btn_borrar1.Enabled = false;
            btn_modificar1.Enabled = false;
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
