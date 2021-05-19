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
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.Formularios.Modelo
{
    public partial class Frm_BajaModelo : Form
    {
        public string Id_modelo { get; set; }
        NE_Modelo modelo = new NE_Modelo();

        public Frm_BajaModelo()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_BajaModelo_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            MostrarDatos(modelo.RecuperarXId(Id_modelo));
        }
        private void MostrarDatos(DataTable tabla)
        {
            txt_codigoModelo.Text = tabla.Rows[0]["idModelo"].ToString();
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                modelo.Borrar(Id_modelo);
                //MessageBox.Show("Se borró correctamente el modelo");
                this.Close();

            }
        }
    
    }
}
