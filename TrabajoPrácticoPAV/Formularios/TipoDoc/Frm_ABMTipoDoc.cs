using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPrácticoPAV.Formularios.TipoDoc
{
    public partial class Frm_ABMTipoDoc : Form
    {
        public Frm_ABMTipoDoc()
        {
            InitializeComponent();
            this.CenterToScreen();
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
    }
}
