using System;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.TipoDoc
{
    public partial class Frm_ABMTipoDoc : Form
    {
        public Frm_ABMTipoDoc()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_ABMTipoDoc_Load(object sender, EventArgs e)
        {
            cmb_tipoDoc.CargarCombo();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_AltaTipoDoc alta = new Frm_AltaTipoDoc();
            alta.ShowDialog();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            cmb_tipoDoc.SelectedIndex = -1;
            cmb_tipoDoc.CargarCombo();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (cmb_tipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento a modificar");
                return;
            }
            Frm_ModificarTipoDoc modificar = new Frm_ModificarTipoDoc();
            modificar.Pp_documento = cmb_tipoDoc.Text;
            modificar.Pp_id_documento = cmb_tipoDoc.SelectedValue;
            modificar.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            NE_TipoDoc tipo = new NE_TipoDoc();
            tipo.Pp_nombre_Tipo_Doc = cmb_tipoDoc.Text;
            tipo.Pp_id_TipoDoc = cmb_tipoDoc.SelectedValue;
            tipo.Borrar();
        }
    }
}