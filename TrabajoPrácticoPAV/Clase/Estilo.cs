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
        static public Color ColorFondo = Color.FromArgb(159, 133, 74);
        static public Color ColorBoton = Color.FromArgb(159, 133, 74);
        static public Color ColorBotonPress = Color.FromArgb(228, 195, 123);
        static public Color ColorBarra = Color.FromArgb(26, 32, 40);
        static public Color ColorFondoForms = Color.FromArgb(242, 227, 187);
        static public Color ColorLetraBoton = Color.FromArgb(0, 0, 0);
        static public bool EstiloDebeActualizar = false;

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
                        break;
                    case "TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea":
                    case "System.Windows.Forms.CheckBox":
                    case "TrabajoPrácticoPAV.Clase.ComboBox":
                    case "TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea":
                    case "System.Windows.Forms.Label":
                    case "System.Windows.Forms.TextBox":
                    case "TrabajoPrácticoPAV.Clase.TextBox_Aerolinea":
                    case "TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea":
                    case "System.Windows.Forms.MonthCalendar":
                    case "System.Windows.Forms.DataGridView":
                    case "System.Windows.Forms.PictureBox":
                        break;
                    default:
                        MessageBox.Show($"{nombreControl} es un control no admitido, agregar en ESTILOS");
                        break;
                }
            }
        }


    }
}
