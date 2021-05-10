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

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_Configuracion : Form
    {
        public Frm_Configuracion()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Estilo.MenuLateral = Cmb_MenuLateral.SelectedIndex;
            this.Close();
        }

        private void Frm_Configuracion_Load(object sender, EventArgs e)
        {
            Cmb_Temas.SelectedItem = Estilo.TemaActual;
            Cmb_MenuLateral.SelectedIndex = Estilo.MenuLateral;
        }

        private void Cmb_MenuLateral_SelectedIndexChanged(object sender, EventArgs e)
        {
            Estilo.MenuLateral = Cmb_MenuLateral.SelectedIndex;
        }

        private void Cmb_Temas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Estilo.TemaActual = Cmb_Temas.SelectedItem.ToString();
            Estilo.EstablecerTema(Estilo.TemaActual);

            PanelEjemplo.BackColor = Estilo.ColorFondo;
            Estilo.FormatearEstilo(PanelEjemplo.Controls);
        }


    }
}
