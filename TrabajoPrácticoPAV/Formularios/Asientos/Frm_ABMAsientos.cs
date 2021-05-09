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
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.Formularios.Asientos
{
    public partial class Frm_ABMAsientos : Form
    {
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

           string sql = tratamiento.ConstructorSelect(this.Controls, "");
            CargarGrilla_asientos(sql);
            //if (chk_asientos.Checked == false && cmb_NumeroAvion.SelectedIndex == -1 && cmb_Modelo.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Debe seleccionar alguna opción");
            //}
            //if (chk_asientos.Checked == true)
            //{
            //    DataTable tabla = new DataTable();
            //    tabla = asiento.BuscarTodos();
            //    CargarGrilla_asientos(tabla);
            //    return;
            //}
            //if (chk_asientos.Checked == false
            //    && cmb_NumeroAvion.SelectedIndex != -1
            //    && cmb_Modelo.SelectedIndex != -1)
            //{
            //    CargarGrilla_asientos(asiento.Recuperar_Mixto((cmb_NumeroAvion.SelectedValue.ToString()), cmb_Modelo.SelectedValue.ToString()));
            //    return;
            //}
            //if (cmb_Modelo.SelectedIndex != -1)
            //{
            //    CargarGrilla_asientos(asiento.RecuprarXmodelo(cmb_Modelo.SelectedValue.ToString()));
            //    return;
            //}
            //if (cmb_NumeroAvion.SelectedIndex != -1)
            //{
            //    CargarGrilla_asientos(asiento.RecuperarXavion(cmb_NumeroAvion.SelectedValue.ToString()));
            //}
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
                //grilla_ABMAsiento.Rows[i].Cells[1].Value = tabla.Rows[i]["n_modelo"].ToString();
                grilla_ABMAsiento.Rows[i].Cells[1].Value = tabla.Rows[i]["idModelo"].ToString();
                grilla_ABMAsiento.Rows[i].Cells[2].Value = tabla.Rows[i]["numeroPorModelo"].ToString();
                //grilla_ABMAsiento.Rows[i].Cells[3].Value = tabla.Rows[i]["n_Asiento"].ToString();
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
            string CondicionAvion = @" JOIN Modelo ON Modelo.idModelo " +
                       @"= Avion.idModelo WHERE Modelo.idModelo = " + cmb_Modelo.SelectedValue;
            cmb_NumeroAvion.CargarComboJoin(CondicionAvion);
            chk_asientos.Checked = false;
        }

        private void cmb_NumeroAvion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string condicionClase = @"JOIN Asientos ON Tipo_Asiento.idTipo" +
                              @"= Asientos.tipoAsiento WHERE Asientos.numeroPorModelo = " + cmb_NumeroAvion.SelectedValue;
            cmb_Clase.CargarComboJoin(condicionClase);
            chk_asientos.Checked = false;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            cmb_Modelo.SelectedIndex = -1;
            cmb_NumeroAvion.SelectedIndex = -1;
            cmb_Clase.SelectedIndex = -1;
            chk_asientos.Checked = false;
            grilla_ABMAsiento.Rows.Clear();
        }
    }
}
