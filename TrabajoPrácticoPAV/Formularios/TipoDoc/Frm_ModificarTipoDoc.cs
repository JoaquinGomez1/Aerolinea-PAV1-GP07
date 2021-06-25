using System;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.TipoDoc
{
    public partial class Frm_ModificarTipoDoc : Form
    {
        public string Pp_documento { get; set; }
        public object Pp_id_documento { get; set; }

        public Frm_ModificarTipoDoc()
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Frm_ModificarTipoDoc_Load(object sender, EventArgs e)
        {
            txt_documento.Text = Pp_documento;
        }

        private void textBox_Aerolinea1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_documento.Text == "")
            {
                MessageBox.Show("Por favor ingrese un tipo de documento valido");
                return;
            }
            NE_TipoDoc tipo = new NE_TipoDoc();
            tipo.Pp_nombre_Tipo_Doc = txt_documento.Text;
            tipo.Pp_id_TipoDoc = Pp_id_documento;
            tipo.Editar();
            this.Close();
        }
    }
}