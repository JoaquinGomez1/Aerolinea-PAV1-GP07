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
            if (Cmb_Temas.SelectedItem.ToString() == "Snowy Forest")
            {
                Estilo.ColorFondo = Color.FromArgb(240, 240, 240);
                Estilo.ColorBoton = Color.FromArgb(102, 107, 58);
                Estilo.ColorBotonPress = Color.FromArgb(173, 171, 118);
                Estilo.ColorBarra = Color.FromArgb(43, 61, 31);
                Estilo.ColorLetraBoton = Color.FromArgb(0, 0, 0);
                Estilo.ColorFondoForms = Color.FromArgb(220, 223, 228);
                Estilo.ColorLetrasLabel = Color.FromArgb(0, 0, 0);
                Estilo.EstiloDebeActualizar = true;
                PanelEjemplo.BackColor = Estilo.ColorFondo;
                Estilo.FormatearEstilo(PanelEjemplo.Controls);
            }

            else if (Cmb_Temas.SelectedItem.ToString() == "Mostaza Classic")
            {
                Estilo.ColorFondo = Color.FromArgb(159, 133, 74);
                Estilo.ColorBoton = Color.FromArgb(159, 133, 74);
                Estilo.ColorBotonPress = Color.FromArgb(228, 195, 123);
                Estilo.ColorBarra = Color.FromArgb(15, 33, 26);
                Estilo.ColorLetraBoton = Color.FromArgb(0, 0, 0);
                Estilo.ColorFondoForms = Color.FromArgb(242, 227, 187);
                Estilo.ColorLetrasLabel = Color.FromArgb(0, 0, 0);
                Estilo.EstiloDebeActualizar = true;
                PanelEjemplo.BackColor = Estilo.ColorFondo;
                Estilo.FormatearEstilo(PanelEjemplo.Controls);
            }

            else if (Cmb_Temas.SelectedItem.ToString() == "Blueberry Honey")
            {
                Estilo.ColorFondo = Color.FromArgb(186, 119, 53);
                Estilo.ColorBoton = Color.FromArgb(2, 79, 148);
                Estilo.ColorBotonPress = Color.FromArgb(133, 170, 197);
                Estilo.ColorBarra = Color.FromArgb(5, 8, 70);
                Estilo.ColorLetraBoton = Color.FromArgb(255, 255, 255);
                Estilo.ColorFondoForms = Color.FromArgb(159, 237, 212);
                Estilo.ColorLetrasLabel = Color.FromArgb(255, 255, 255);
                Estilo.EstiloDebeActualizar = true;
                PanelEjemplo.BackColor = Estilo.ColorFondo;
                Estilo.FormatearEstilo(PanelEjemplo.Controls);
            }

            else if (Cmb_Temas.SelectedItem.ToString() == "Obsidian Black")
            {
                Estilo.ColorFondo = Color.FromArgb(68, 83, 94);
                Estilo.ColorBoton = Color.FromArgb(0, 0, 0);
                Estilo.ColorBotonPress = Color.FromArgb(33, 43, 50);
                Estilo.ColorBarra = Color.FromArgb(0, 0, 0);
                Estilo.ColorLetraBoton = Color.FromArgb(255, 255, 255);
                Estilo.ColorFondoForms = Color.FromArgb(97, 96, 99);
                Estilo.ColorLetrasLabel = Color.FromArgb(255, 255, 255);
                Estilo.EstiloDebeActualizar = true;
                PanelEjemplo.BackColor = Estilo.ColorFondo;
                PanelEjemplo.BackColor = Estilo.ColorFondo;
                Estilo.FormatearEstilo(PanelEjemplo.Controls);
            }
        }


    }
}
