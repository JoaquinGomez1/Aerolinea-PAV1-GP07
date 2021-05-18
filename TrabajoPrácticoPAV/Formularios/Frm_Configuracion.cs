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
            if(Estilo.TemaActual != Cmb_Temas.SelectedItem.ToString())
            {
                Estilo.EstiloDebeActualizar = true;
                Estilo.TemaActual = Cmb_Temas.SelectedItem.ToString();
                Estilo.EstablecerTema(Estilo.TemaActual);
            }
            this.Close();
        }

        private void Frm_Configuracion_Load(object sender, EventArgs e)
        {
            Cmb_Temas.SelectedItem = Estilo.TemaActual;
        }

        private void Cmb_Temas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PanelEjemplo.BackColor = Estilo.ColorFondo;
            Estilo.FormatearEstilo(PanelEjemplo.Controls);
        }


    }
}
