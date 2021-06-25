using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Teléfono
{
    public partial class Frm_Borrar_Telefono : Form
    {
        public string Pp_numeroTelefono { get; set; }
        public int Pp_tipoDoc { get; set; }
        public int Pp_numeroDoc { get; set; }
        NE_Telefonos telefono = new NE_Telefonos();
        public Frm_Borrar_Telefono()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
            telefono.Pp_numeroTelefono = Pp_numeroTelefono;
            
            if (MessageBox.Show("¿Está seguro de Borrar el teléfono?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                telefono.Borrar();
                this.Close();
            }
        }

        private void Frm_Borrar_Telefono_Load(object sender, EventArgs e)
        {
            telefono.Pp_numeroTelefono = Pp_numeroTelefono;
            MostrarDatos(telefono.Recuperar_x_numero());
        }
        private void MostrarDatos(DataTable tabla)
        {
            if (tabla.Rows.Count > 0)
            {
                txt_nroTelefono.Text = tabla.Rows[0]["numeroTelefono"].ToString();
                txt_tipoDoc.Text = tabla.Rows[0]["tipoDoc"].ToString();
                txt_nroDoc.Text = tabla.Rows[0]["numeroDoc"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró un teléfono con los filtros especificados");
            }
        }
    }
}
