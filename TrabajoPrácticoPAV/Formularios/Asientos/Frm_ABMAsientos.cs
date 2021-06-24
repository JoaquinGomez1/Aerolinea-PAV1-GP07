using System;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Asientos
{
    public partial class Frm_ABMAsientos : Form
    {
        public string Id_Asiento { get; set; }
        private NE_Asiento NEasiento = new NE_Asiento();

        public Frm_ABMAsientos()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
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
            string join = $" JOIN Modelo ON  modelo.idModelo = Asientos.idModelo ";

            if (chk_asientos.Checked == false && cmb_Modelo.SelectedIndex == -1 && cmb_NumeroAvion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar alguna opción");
            }
            else
            {
                NEasiento.CargarGrilla_asientos(grilla_ABMAsiento, join, this.Controls);
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
            NEasiento.CargarGrilla_asientos(grilla_ABMAsiento, "", this.Controls);
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
        }

        private void grilla_ABMAsiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_eliminar.Enabled = true;
            btn_modificar.Enabled = true;
            Id_Asiento = grilla_ABMAsiento.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_ModificarAsiento modificarAsiento = new Frm_ModificarAsiento();
            modificarAsiento.Id_Asiento = Id_Asiento;
            modificarAsiento.ShowDialog();
            NEasiento.CargarGrilla_asientos(grilla_ABMAsiento, "", this.Controls);
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_BajaAsiento borrarasiento = new Frm_BajaAsiento();
            borrarasiento.Id_asiento = Id_Asiento;
            borrarasiento.ShowDialog();
            NEasiento.CargarGrilla_asientos(grilla_ABMAsiento, "", this.Controls);
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
        }

        private void grilla_ABMAsiento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_ConsultarAsiento consultaAsiento = new Frm_ConsultarAsiento();
            consultaAsiento.Id_asiento = Id_Asiento;
            consultaAsiento.ShowDialog();
        }
    }
}