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

namespace TrabajoPrácticoPAV.Formularios.Aeropuertos
{
    public partial class Frm_Mostrar_Aeropuerto : Form
    {
        public string Id_codigo { get; set; }
        public Frm_Mostrar_Aeropuerto()
        {
            InitializeComponent();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_codigo.Text = tabla.Rows[0]["codigo"].ToString();
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
            cmb_ciudad.SelectedValue = int.Parse(tabla.Rows[0]["idCiudad"].ToString());
        }

        private void Frm_Mostrar_Aeropuerto_Load(object sender, EventArgs e)
        {
            cmb_ciudad.CargarCombo();

            NE_Aeropuertos aeropuerto = new NE_Aeropuertos();
            MostrarDatos(aeropuerto.Recuperar_por_Codigo(Id_codigo));
        }
    }
}
