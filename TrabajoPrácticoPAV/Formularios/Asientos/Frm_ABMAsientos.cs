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
            string condicionAvion = "";
            string condicionClase = "";
            cmb_Modelo.CargarCombo();
            cmb_NumeroAvion.CargarComboJoin(condicionAvion);
            cmb_Clase.CargarComboJoin(condicionClase);

        
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_Asiento asiento = new NE_Asiento();

            if (chk_asientos.Checked == false && cmb_NumeroAvion.SelectedIndex == -1 && cmb_Modelo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar alguna opción");
            }
            if (chk_asientos.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = asiento.RecuperarTodos();
                CargarGrilla_asientos(tabla);
                return;
            }
            if (chk_asientos.Checked == false
                && cmb_NumeroAvion.SelectedIndex != -1
                && cmb_Modelo.SelectedIndex != -1)
            {
                CargarGrilla_asientos(asiento.Recuperar_Mixto((cmb_NumeroAvion.SelectedValue.ToString()), cmb_Modelo.SelectedValue.ToString()));
                return;
            }
            if (cmb_Modelo.SelectedIndex != -1)
            {
                CargarGrilla_asientos(asiento.RecuprarXmodelo(cmb_Modelo.SelectedValue.ToString()));
                return;
            }
            if (cmb_NumeroAvion.SelectedIndex != -1)
            {
                CargarGrilla_asientos(asiento.RecuperarXavion(cmb_NumeroAvion.SelectedValue.ToString()));
            }
        }
        private void CargarGrilla_asientos(DataTable tabla)
        {

        }
    }
}
