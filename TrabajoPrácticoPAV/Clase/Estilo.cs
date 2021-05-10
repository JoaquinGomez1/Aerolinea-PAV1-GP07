using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPrácticoPAV.Clase
{

    class Estilo
    {
        static public int MenuLateral = 1;
        static public string TemaActual = "Mostaza Classic"; // <- Tema por defecto
        static public Color ColorFondo = Color.FromArgb(159, 133, 74);
        static public Color ColorBoton = Color.FromArgb(159, 133, 74);
        static public Color ColorBotonPress = Color.FromArgb(228, 195, 123);
        static public Color ColorBarra = Color.FromArgb(26, 32, 40);
        static public Color ColorFondoForms = Color.FromArgb(242, 227, 187);
        static public Color ColorLetraBoton = Color.FromArgb(0, 0, 0);
        static public Color ColorLetrasLabel = Color.FromArgb(0, 0, 0);
        static public bool EstiloDebeActualizar = false;
        static public Color FormActivo = Color.FromArgb(207, 168, 81); // <- Se activa cuando el formulario está activo en el Frm Principal

        static public readonly List<string> ListaDeTemas = new List<string>() { "Mostaza Classic", "Snowy Forest", "Blueberry Honey", "Obsidian Black" };

        static public void FormatearEstilo(Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                string nombreControl = item.GetType().ToString();
                switch (nombreControl)
                {
                    case "TrabajoPrácticoPAV.Clase.Button_Aerolinea":
                        ((Button_Aerolinea)item).BackColor = Estilo.ColorBoton;
                        ((Button)item).ForeColor = Estilo.ColorLetraBoton;
                        break;
                    case "System.Windows.Forms.Button":
                        ((Button)item).BackColor = Estilo.ColorBoton;
                        ((Button)item).ForeColor = Estilo.ColorLetraBoton;
                        break;
                    case "System.Windows.Forms.Panel":
                        if (((Panel)item).Name == "BarraSuperior")
                            ((Panel)item).BackColor = Estilo.ColorBarra;
                        Estilo.FormatearEstilo(((Panel)item).Controls);
                        break;
                    case "System.Windows.Forms.Label":
                        if (((Label)item).Name == "Titulo")
                            ((Label)item).ForeColor = Color.FromArgb(255, 255, 255);
                        else
                            ((Label)item).ForeColor = Estilo.ColorLetrasLabel;
                        break;
                    case "TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea":
                    case "System.Windows.Forms.CheckBox":
                    case "TrabajoPrácticoPAV.Clase.ComboBox":
                    case "TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea":
                    case "System.Windows.Forms.TextBox":
                    case "TrabajoPrácticoPAV.Clase.TextBox_Aerolinea":
                    case "TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea":
                    case "System.Windows.Forms.MonthCalendar":
                    case "System.Windows.Forms.DataGridView":
                    case "System.Windows.Forms.PictureBox":
                    case "System.Windows.Forms.MaskedTextBox":
                        break;
                    default:
                        MessageBox.Show($"{nombreControl} es un control no admitido, agregar en ESTILOS");
                        break;
                }
            }
        }


        static public void EstablecerTema(string nombreTema)
        {
            if (EsTemaValido(nombreTema))
            {
                switch (nombreTema)
                {
                    case "Snowy Forest":
                        Estilo.ColorFondo = Color.FromArgb(240, 240, 240);
                        Estilo.ColorBoton = Color.FromArgb(102, 107, 58);
                        Estilo.ColorBotonPress = Color.FromArgb(173, 171, 118);
                        Estilo.ColorBarra = Color.FromArgb(43, 61, 31);
                        Estilo.ColorLetraBoton = Color.FromArgb(0, 0, 0);
                        Estilo.ColorFondoForms = Color.FromArgb(220, 223, 228);
                        Estilo.ColorLetrasLabel = Color.FromArgb(0, 0, 0);
                        Estilo.FormActivo = Color.FromArgb(105, 153, 75);
                        Estilo.EstiloDebeActualizar = true;
                        break;
                    case "Blueberry Honey":
                        Estilo.ColorFondo = Color.FromArgb(186, 119, 53);
                        Estilo.ColorBoton = Color.FromArgb(2, 79, 148);
                        Estilo.ColorBotonPress = Color.FromArgb(133, 170, 197);
                        Estilo.ColorBarra = Color.FromArgb(5, 8, 70);
                        Estilo.ColorLetraBoton = Color.FromArgb(255, 255, 255);
                        Estilo.ColorFondoForms = Color.FromArgb(159, 237, 212);
                        Estilo.ColorLetrasLabel = Color.FromArgb(255, 255, 255);
                        Estilo.FormActivo = Color.FromArgb(17, 163, 189);
                        Estilo.EstiloDebeActualizar = true;
                        break;
                    case "Obsidian Black":
                        Estilo.ColorFondo = Color.FromArgb(68, 83, 94);
                        Estilo.ColorBoton = Color.FromArgb(0, 0, 0);
                        Estilo.ColorBotonPress = Color.FromArgb(33, 43, 50);
                        Estilo.ColorBarra = Color.FromArgb(0, 0, 0);
                        Estilo.ColorLetraBoton = Color.FromArgb(255, 255, 255);
                        Estilo.ColorFondoForms = Color.FromArgb(97, 96, 99);
                        Estilo.ColorLetrasLabel = Color.FromArgb(255, 255, 255);
                        Estilo.EstiloDebeActualizar = true;
                        Estilo.FormActivo = Color.FromArgb(107, 107, 107);
                        break;
                    default: // <- Caso default es el tema "Mostaza classic"
                        Estilo.ColorFondo = Color.FromArgb(159, 133, 74);
                        Estilo.ColorBoton = Color.FromArgb(159, 133, 74);
                        Estilo.ColorBotonPress = Color.FromArgb(228, 195, 123);
                        Estilo.ColorBarra = Color.FromArgb(15, 33, 26);
                        Estilo.ColorLetraBoton = Color.FromArgb(0, 0, 0);
                        Estilo.ColorFondoForms = Color.FromArgb(242, 227, 187);
                        Estilo.ColorLetrasLabel = Color.FromArgb(0, 0, 0);
                        Estilo.FormActivo = Color.FromArgb(207, 168, 81);
                        Estilo.EstiloDebeActualizar = true;
                        break;
                }
            }
            else
            {
                MessageBox.Show($"El tema: {nombreTema} que quieres establecer no existe");
            }

        }

        static public bool EsTemaValido(string nombreTema) => ListaDeTemas.Contains(nombreTema);
    }
}
