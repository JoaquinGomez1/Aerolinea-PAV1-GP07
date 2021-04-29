using System;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;
using static TrabajoPrácticoPAV.Clase.Tratamientos_Especiales;

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ABMViajes : Form
    {

        public Frm_ABMViajes()
        {
            InitializeComponent();
        }

        private int duracionEstimada { get; set; }

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
                    duracionEstimada = duracionEstimadaActual;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
            Resultado esFormularioValido = tratamientos.Validar(this.Controls);

            if (esFormularioValido == Resultado.correcto)
            {
                DateTime horarioPresencia = ParseTime(Mtxt_presencia.Text);
                DateTime horarioSalida = ParseTime(maskedTextBox1.Text);
                DateTime horarioLlegada = ParseTime(maskedTextBox2.Text);

                Conexion_DB _DB = new Conexion_DB();
                string sql = @"INSERT INTO Viajes(horarioPresencia, horarioSalida, horarioLlegada, duracionEstimada) 
                            VALUES(" + $"{horarioPresencia} {horarioSalida} {horarioLlegada} {duracionEstimada}" + ")";

                _DB.Insertar(sql);
            }
        }

        // Funcion lambda que convierte un formato de horas y minutos a un objeto DateTime 
        // El parametro tiene que seguir la siguiente estructura:  "14:00" 
        // Documentación oficial del método: https://docs.microsoft.com/en-us/dotnet/api/system.datetime.parseexact?view=net-5.0
        private DateTime ParseTime(string horasYMin) => DateTime.ParseExact(horasYMin, "H:mm", null, System.Globalization.DateTimeStyles.None);
    }
}
