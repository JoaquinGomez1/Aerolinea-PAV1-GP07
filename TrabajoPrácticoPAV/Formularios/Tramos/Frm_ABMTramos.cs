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
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Formularios.Tramos;
using System.Runtime.InteropServices;

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ABMTramos : Form
    {
        NE_Tramos _NE = new NE_Tramos();
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();

        public Frm_ABMTramos()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ABMTramos_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            grid_tramos.Formatear();
            cmb_ADestino.CargarCombo();
            cmb_ASalida.CargarCombo();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string sql = _TE.ConstructorSelect(this.Controls, "");
            _NE.CargarGrilla(sql, grid_tramos);
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            Frm_AltaTramo tramo = new Frm_AltaTramo();
            tramo.ShowDialog();
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            cmb_ADestino.SelectedIndex = -1;
            cmb_ASalida.SelectedIndex = -1;
            chb_todos_tramo.Checked = false;
            grid_tramos.Rows.Clear();
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid_tramos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Btn_Modificar.Enabled = true;
            Btn_Eliminar.Enabled = true;
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            string codigoASalida = _NE.BuscarCodigoAeropuerto(
                grid_tramos.CurrentRow.Cells["codigoAeropuertoSalida"].Value.ToString());

            string codigoADestino =_NE.BuscarCodigoAeropuerto(
                grid_tramos.CurrentRow.Cells["codigoAeropuertoDestino"].Value.ToString());

            Frm_ModificacionTramo modif = new Frm_ModificacionTramo();
            modif.codigoASalida = codigoASalida;
            modif.codigoADestino = codigoADestino;

            modif.ShowDialog();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            string codigoASalida = _NE.BuscarCodigoAeropuerto(
            grid_tramos.CurrentRow.Cells["codigoAeropuertoSalida"].Value.ToString());

            string codigoADestino = _NE.BuscarCodigoAeropuerto(
                grid_tramos.CurrentRow.Cells["codigoAeropuertoDestino"].Value.ToString());

            Frm_BajaTramo elim = new Frm_BajaTramo();
            elim.codigoASalida = codigoASalida;
            elim.codigoADestino = codigoADestino;
            elim.ShowDialog();
        }

        private void grid_tramos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string codigoASalida = _NE.BuscarCodigoAeropuerto(
                grid_tramos.CurrentRow.Cells["codigoAeropuertoSalida"].Value.ToString());

            string codigoADestino = _NE.BuscarCodigoAeropuerto(
                grid_tramos.CurrentRow.Cells["codigoAeropuertoDestino"].Value.ToString());

            Frm_ConsultaTramo consulta = new Frm_ConsultaTramo();
            consulta.codigoADestino = codigoADestino;
            consulta.codigoASalida = codigoASalida;
            consulta.ShowDialog();
        }
     }
}
