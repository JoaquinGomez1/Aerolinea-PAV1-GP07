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

namespace TrabajoPrácticoPAV.Formularios.Asientos
{
    public partial class Frm_ABMAsientos : Form
    {
        public string Id_Asiento { get; set; }
        public Frm_ABMAsientos()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ABMAsientos_Load(object sender, EventArgs e)
        {
            cmb_Modelo.CargarCombo();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_Asiento asiento = new NE_Asiento();
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();

           string sql = tratamiento.ConstructorSelect(this.Controls, "", "Asientos");
           CargarGrilla_asientos(sql);
        }
        private void CargarGrilla_asientos(string sql)
        {
            Conexion_DB _BD = new Conexion_DB();
            DataTable tabla = _BD.EjecutarSelect(sql);

            grilla_ABMAsiento.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla_ABMAsiento.Rows.Add();
                grilla_ABMAsiento.Rows[i].Cells[0].Value = tabla.Rows[i]["numeroAsiento"].ToString();
                grilla_ABMAsiento.Rows[i].Cells[1].Value = tabla.Rows[i]["idModelo"].ToString();
                grilla_ABMAsiento.Rows[i].Cells[2].Value = tabla.Rows[i]["numeroPorModelo"].ToString();
                grilla_ABMAsiento.Rows[i].Cells[3].Value = tabla.Rows[i]["tipoAsiento"].ToString();
                grilla_ABMAsiento.Rows[i].Cells[4].Value = tabla.Rows[i]["estado"].ToString();
            }
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron Asientos para ese filtro.");
            }

        }

        private void cmb_Modelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_NumeroAvion.SelectedIndex = -1;
            cmb_Clase.SelectedIndex = -1;
            chk_asientos.Checked = false;
            string CondicionAvion = @" JOIN Modelo ON Modelo.idModelo " +
                       @"= Avion.idModelo WHERE Modelo.idModelo = " + cmb_Modelo.SelectedValue;
            cmb_NumeroAvion.CargarComboJoin(CondicionAvion);
            
        }

        private void cmb_NumeroAvion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_Clase.SelectedIndex = -1;
            chk_asientos.Checked = false;
            string condicionClase = @"JOIN Asientos ON Tipo_Asiento.idTipo" +
                              @"= Asientos.tipoAsiento WHERE Asientos.numeroPorModelo = " + cmb_NumeroAvion.SelectedValue;
            cmb_Clase.CargarComboJoin(condicionClase);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            cmb_Modelo.SelectedIndex = -1;
            cmb_NumeroAvion.SelectedIndex = -1;
            cmb_Clase.SelectedIndex = -1;
            chk_asientos.Checked = false;
            grilla_ABMAsiento.Rows.Clear();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Frm_AltaAsientos alta = new Frm_AltaAsientos();
            alta.ShowDialog();
        }

        private void grilla_ABMAsiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NE_Vuelos NegoVuelo = new NE_Vuelos();
            btn_eliminar.Enabled = true;
            btn_modificar.Enabled = true;
            Id_Asiento = grilla_ABMAsiento.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_ModificarAsiento modificarAsiento = new Frm_ModificarAsiento();
            modificarAsiento.Id_Asiento = Id_Asiento;
            modificarAsiento.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_BajaAsiento borrarasiento = new Frm_BajaAsiento();
            borrarasiento.Id_asiento = Id_Asiento;
            borrarasiento.ShowDialog();
        }

        private void grilla_ABMAsiento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_ConsultarAsiento consultaAsiento = new Frm_ConsultarAsiento();
            consultaAsiento.Id_asiento = Id_Asiento;
            consultaAsiento.ShowDialog();

        }
    }
}
