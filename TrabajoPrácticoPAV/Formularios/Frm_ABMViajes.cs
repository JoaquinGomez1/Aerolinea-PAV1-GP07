using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ABMViajes : Form
    {
        //private string duracionEstimadaDelViaje;
        //private string horarioSalidaDelViaje;
        //private string horarioLlegadaDelViaje;

        public Frm_ABMViajes()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ABMViajes_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            // En este caso solo me interesa delegar la tarea de comparación a la hora de determinar el estimado
            determinarEstimado();
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            determinarEstimado();

        }

        private void determinarEstimado()
        {
            string horarioLlegada = maskedTextBox2.Text;
            string horarioSalida = maskedTextBox1.Text;

            bool llegadaCompletada = horarioLlegada.Length == 5;
            bool salidaCompletada = horarioSalida.Length == 5;
            bool ambosCamposCompletados = llegadaCompletada && salidaCompletada;

            bool esSalidaMenorALlegada = String.Compare(horarioLlegada, horarioSalida) == -1;

            if (ambosCamposCompletados)
            {
                int horarioLlegadaMilitar = convertirAIntMilitar(horarioLlegada);
                int horarioSalidaMilitar = convertirAIntMilitar(horarioSalida);

                if (esSalidaMenorALlegada)
                {
                    int duracionEstimadaActual = calcularDiferenciaDelDia(horarioLlegadaMilitar, horarioSalidaMilitar);
                    lbl_duracionEstimada.Text = FormatearIntMilitarAString(duracionEstimadaActual);
                }

                if (!esSalidaMenorALlegada)
                {
                    int duracionEstimadaActual = horarioLlegadaMilitar - horarioSalidaMilitar;
                    lbl_duracionEstimada.Text = FormatearIntMilitarAString(duracionEstimadaActual);
                }
            }

        }

        public int convertirAIntMilitar(string horario)
        {
            // Suponiendo que tenemos un horario X, convertimos esto en un horario militar.
            // Ej: 01:40hs = 0140 
            string horasDelHorario = $"{horario[0]}{horario[1]}"; // 01
            string minutosDelHorario = $"{horario[3]}{horario[4]}"; // 40

            string temp = $"{horasDelHorario}{minutosDelHorario}"; // 0140
            return Int32.Parse(temp); // -> convierto a int
        }

        public int calcularDiferenciaDelDia(int horarioInicial, int horarioFinal)
        {
            horarioInicial += 2400;
            horarioInicial -= horarioFinal;
            return horarioInicial;
        }

        public string FormatearIntMilitarAString(int IntMilitar)
        {

            string StringMilitar = IntMilitar.ToString();
            if (StringMilitar.Length > 4) { return ""; }

            if (StringMilitar.Length == 3)
            {

                StringMilitar = $"0{StringMilitar}";
            }

            if (StringMilitar.Length == 2)
            {
                StringMilitar = $"00{StringMilitar}";
            }

            if (StringMilitar.Length == 1)
            {
                StringMilitar = $"000{StringMilitar}";
            }

            return $"{StringMilitar[0]}{StringMilitar[1]}:{StringMilitar[2]}{StringMilitar[3]}hs";
        }
    }
}
