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

namespace TrabajoPrácticoPAV.Formularios.TipoDoc
{
    public partial class Frm_ModificarTipoDoc : Form
    { 
        public string Pp_documento {get; set;}
        public object Pp_id_documento { get; set; }
        public Frm_ModificarTipoDoc()
        {
            InitializeComponent();
        }

        private void Frm_ModificarTipoDoc_Load(object sender, EventArgs e)
        {
            
            txt_documento.Text = Pp_documento;

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            NE_TipoDoc tipo = new NE_TipoDoc();
            tipo.Pp_nombre_Tipo_Doc = txt_documento.Text;
            tipo.Pp_id_TipoDoc = Pp_id_documento;
            tipo.Borrar();
        }

        private void textBox_Aerolinea1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_TipoDoc tipo = new NE_TipoDoc();
            tipo.Pp_nombre_Tipo_Doc = txt_documento.Text;
            tipo.Pp_id_TipoDoc = Pp_id_documento;
            tipo.Editar();
        }
    }
}
