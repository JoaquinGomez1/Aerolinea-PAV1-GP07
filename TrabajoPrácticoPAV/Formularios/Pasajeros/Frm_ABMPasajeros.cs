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

namespace TrabajoPrácticoPAV.Formularios.Pasajeros
{
    public partial class Frm_ABMPasajeros : Form
    {
        Conexion_DB _DB = new Conexion_DB();
        NE_Clientes _NE = new NE_Clientes();
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();

        public Frm_ABMPasajeros()
        {
            InitializeComponent();
        }

        private void Frm_ABMPasajeros_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            Cmb_TipoDoc.CargarCombo();
            Grid_Pasajero.Formatear();

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string join = $" JOIN Tipo_Documento ON Pasajero.tipoDoc = Tipo_Documento.tipoDoc ";
            string sql = _TE.ConstructorSelect(this.Controls, join);
            _NE.CargarGrilla(sql, Grid_Pasajero);
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Frm_AltaPasajero alta = new Frm_AltaPasajero();
            alta.ShowDialog();
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_Apellido.Text = "";
            Txt_nombre.Text = "";
            Cmb_TipoDoc.SelectedIndex = -1;
            Grid_Pasajero.Rows.Clear();
            chk_Todos.Checked = false;
            Msktxt_NumeroDOC.Text = "";
        }

        private void Grid_Pasajero_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Btn_Eliminar.Enabled = true;
            Btn_Modificar.Enabled = true;
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Frm_ModificaionPasajero modif = new Frm_ModificaionPasajero();
            modif.tipoDoc = _NE.BuscarIdTipoDoc(Grid_Pasajero.CurrentRow.Cells["tipoDoc"].Value.ToString());
            modif.numeroDoc = Grid_Pasajero.CurrentRow.Cells["numeroDoc"].Value.ToString();

            modif.ShowDialog();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Frm_BajaPasajero baja = new Frm_BajaPasajero();
            baja.tipoDoc = _NE.BuscarIdTipoDoc(Grid_Pasajero.CurrentRow.Cells["tipoDoc"].Value.ToString());
            baja.numeroDoc = Grid_Pasajero.CurrentRow.Cells["numeroDoc"].Value.ToString();
            


            baja.ShowDialog();
        }

        private void Grid_Pasajero_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_MostrarPasajero mostrar = new Frm_MostrarPasajero();
            mostrar.tipoDoc = _NE.BuscarIdTipoDoc(Grid_Pasajero.CurrentRow.Cells["tipoDoc"].Value.ToString());
            mostrar.numeroDoc = Grid_Pasajero.CurrentRow.Cells["numeroDoc"].Value.ToString();

            mostrar.ShowDialog();
        }
    }
}
