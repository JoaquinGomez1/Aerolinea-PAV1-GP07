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

        private void Btn_Forest_Click(object sender, EventArgs e)
        {
            Estilo.ColorFondo = Color.FromArgb(220, 223, 228);
            Estilo.ColorBoton = Color.FromArgb(102, 107, 58);
            Estilo.ColorBotonPress = Color.FromArgb(173, 171, 118);
            Estilo.ColorBarra = Color.FromArgb(43, 61, 31);
            Estilo.EstiloDebeActualizar = true;
        }

        private void Btn_Mostaza_Click(object sender, EventArgs e)
        {
            Estilo.ColorBoton = Color.FromArgb(159, 133, 74);
            Estilo.ColorBarra = Color.FromArgb(15, 33, 26);
            Estilo.ColorBotonPress = Color.FromArgb(228, 195, 123);
            Estilo.ColorFondo = Color.FromArgb(159, 133, 74);
            Estilo.EstiloDebeActualizar = true;
        }

        private void Btn_BlueB_Click(object sender, EventArgs e)
        {
            Estilo.ColorFondo = Color.FromArgb(186, 119, 53);
            Estilo.ColorBoton = Color.FromArgb(2, 79, 148);
            Estilo.ColorBotonPress = Color.FromArgb(133, 170, 197);
            Estilo.ColorBarra = Color.FromArgb(5, 8, 70);
            Estilo.EstiloDebeActualizar = true;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
