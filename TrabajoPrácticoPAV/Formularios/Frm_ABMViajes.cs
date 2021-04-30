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
            string horarioLlegada = Mtxt_horarioLlegada.Text;
            string horarioSalida = Mtxt_horarioSalida.Text;

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

        public bool ValidarHorario(int horario, bool horarioDefasado)
        {
            string horariodeString = FormatearIntMilitarAString(horario);
            string horasDelHorario = $"{horariodeString[0]}{horariodeString[1]}";
            string minutosDelHorario = $"{horariodeString[3]}{horariodeString[4]}";
            int horasDelHorarioInt = int.Parse(horasDelHorario.ToString());
            int minutosDelHorarioInt = int.Parse(minutosDelHorario.ToString());
            if (horasDelHorarioInt > 23)
            { horarioDefasado = true; };
            if (minutosDelHorarioInt > 60)
            { horarioDefasado = true; };
            return horarioDefasado;
        }
        
        // Funcion lambda que convierte un formato de horas y minutos a un objeto DateTime 
        // El parametro tiene que seguir la siguiente estructura:  "14:00" 
        // Documentación oficial del método: https://docs.microsoft.com/en-us/dotnet/api/system.datetime.parseexact?view=net-5.0
        private DateTime ParseTime(string horasYMin) => DateTime.ParseExact(horasYMin, "H:mm", null, System.Globalization.DateTimeStyles.None);


        private void button2_Click_1(object sender, EventArgs e){
            Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
            Resultado esFormularioValido = tratamientos.Validar(this.Controls);

            bool ErrorTextMask = false;

            if (Mtxt_presencia.MaskCompleted == false)
                { ErrorTextMask = true;}

            if (Mtxt_horarioSalida.MaskCompleted == false)
                { ErrorTextMask = true;}

            if (Mtxt_horarioLlegada.MaskCompleted == false)
                { ErrorTextMask = true;}

            if (ErrorTextMask == true)
                { MessageBox.Show("Complete todos los campos");
                return;}

            //Verificacion de que la espera entre el horario de presencia y el horario de salida no supere las 4hs.
            //Se hace esta comparacion para luego poder calcular la espera en el aeropuerto incluso si transcurre en dos dias diferentes.
            // Ejemplo: Horario de presencia = 23:00hs, Horario de Salida = 01:00hs, Espera estimada = 2hs (en vez de -22hs).
            bool esPresenciaMenorASalida = String.Compare(Mtxt_horarioSalida.Text, Mtxt_presencia.Text) == -1;

            int horariopresenciaMilitar = convertirAIntMilitar(Mtxt_presencia.Text);
            int horarioSalidaMilitar = convertirAIntMilitar(Mtxt_horarioSalida.Text);

            if (esPresenciaMenorASalida)
            {
                int esperaEstimadaActual = calcularDiferenciaDelDia(horarioSalidaMilitar, horariopresenciaMilitar);
                if (esperaEstimadaActual > 0400)
                { MessageBox.Show("El horario de espera en el aeropuerto no debe superar las 4hs"); };
            }

            if (!esPresenciaMenorASalida)
            {
                int esperaEstimadaActual =  horarioSalidaMilitar - horariopresenciaMilitar;
                if (esperaEstimadaActual > 0400)
                { MessageBox.Show("El horario de espera en el aeropuerto no debe superar las 4hs"); };
            }

            //Determina si los horarios ingresados superan las 24hs o los 60 min
            bool horarioDefasado = false;
            int horariodePresencia = convertirAIntMilitar(Mtxt_presencia.Text);
            horarioDefasado = ValidarHorario(horariodePresencia, horarioDefasado);

            int horariodeSalida = convertirAIntMilitar(Mtxt_horarioSalida.Text);
            horarioDefasado = ValidarHorario(horariodeSalida, horarioDefasado);

            int horariodeLlegada = convertirAIntMilitar(Mtxt_horarioLlegada.Text);
            horarioDefasado = ValidarHorario(horariodeLlegada, horarioDefasado);

            if (horarioDefasado == true)
            { MessageBox.Show("El horario ingresado no debe superar las 24hs ni los 60min"); };

            if (esFormularioValido == Resultado.correcto)
        {
            DateTime horarioPresencia = ParseTime(Mtxt_presencia.Text);
            DateTime horarioSalida = ParseTime(Mtxt_horarioSalida.Text);
            DateTime horarioLlegada = ParseTime(Mtxt_horarioLlegada.Text);

            Conexion_DB _DB = new Conexion_DB();
            string sql = @"INSERT INTO Viajes(horarioPresencia, horarioSalida, horarioLlegada, duracionEstimada) 
                        VALUES(" + $"{horarioPresencia} {horarioSalida} {horarioLlegada} {duracionEstimada}" + ")";

            _DB.Insertar(sql);
        }
    }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
