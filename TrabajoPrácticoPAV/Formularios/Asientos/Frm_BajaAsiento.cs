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

namespace TrabajoPrácticoPAV.Formularios.Asientos
{
    public partial class Frm_BajaAsiento : Form
    {
        public string Id_asiento { get; set; }

        NE_Asiento asiento = new NE_Asiento();
        public Frm_BajaAsiento()
        {
            InitializeComponent();
        }
        
        private void Frm_BajaAsiento_Load(object sender, EventArgs e)
        {
            cmb_nombreModelo.CargarCombo();
            cmb_numeroAvion.CargarCombo();
            cmb_clase.CargarCombo();

            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            MostrarDatos(asiento.RecuperarXId(Id_asiento));
        }
        private void MostrarDatos(DataTable tabla)
        {
            txt_idasiento.Text = tabla.Rows[0]["numeroAsiento"].ToString();
            cmb_nombreModelo.SelectedValue = int.Parse(tabla.Rows[0]["idModelo"].ToString());
            cmb_numeroAvion.SelectedValue = int.Parse(tabla.Rows[0]["numeroPorModelo"].ToString());
            txt_estado.Text = tabla.Rows[0]["estado"].ToString();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrarAsiento_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                asiento.Borrar(this.Controls);
                this.Close();

            }
        }
    }
}
