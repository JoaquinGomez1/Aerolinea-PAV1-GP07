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


namespace TrabajoPrácticoPAV.Formularios.TipoDoc
{
    
    public partial class Frm_AltaTipoDoc : Form
    {
        public Frm_AltaTipoDoc()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            NE_TipoDoc tipo = new NE_TipoDoc();
            tipo.Pp_nombre_Tipo_Doc = txt_nombre.Text;
            tipo.Insertar();
            MessageBox.Show( "El tipo: " + tipo.Pp_nombre_Tipo_Doc + ", ha sido correctamente agregado");
            this.Close();
        }

        private void Frm_AltaTipoDoc_Load(object sender, EventArgs e)
        {

        }
    }
}
