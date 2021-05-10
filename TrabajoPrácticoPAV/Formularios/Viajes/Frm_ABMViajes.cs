using System;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Clase.Modelos;
using TrabajoPrácticoPAV.Formularios.Viajes;
using TrabajoPrácticoPAV.NE_Usuarios;
using static TrabajoPrácticoPAV.Clase.Tratamientos_Especiales;

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ABMViajes : Form
    {

        public Frm_ABMViajes()
        {
            InitializeComponent();
        }

        private readonly NE_Viajes _NE_Viajes = new NE_Viajes();
        private int duracionEstimadaViaje { get; set; }
        private readonly ManejoDeTiempos Tiempo = new ManejoDeTiempos();

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ABMViajes_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            CargarTodos();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            // En este caso solo me interesa delegar la tarea de comparación a la hora de determinar el estimado
            string horarioLlegada = Mtxt_horarioLlegada.Text;
            string horarioSalida = Mtxt_horarioSalida.Text;
            mostrarDuracionEstimada(horarioLlegada, horarioSalida);
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            string horarioLlegada = Mtxt_horarioLlegada.Text;
            string horarioSalida = Mtxt_horarioSalida.Text;
            mostrarDuracionEstimada(horarioLlegada, horarioSalida);
        }

        public void mostrarDuracionEstimada(string horarioLlegada, string horarioSalida)
        {
            bool llegadaCompletada = horarioLlegada.Length == 5;
            bool salidaCompletada = horarioSalida.Length == 5;

            bool ambosCamposCompletados = llegadaCompletada && salidaCompletada;

            bool esHorarioValido = Tiempo.esHorarioValido(horarioSalida) && Tiempo.esHorarioValido(horarioLlegada);

            //if (!esHorarioValido)
            //{
            //    MessageBox.Show($"Salida: {horarioSalida}\n Llegada: {horarioLlegada} \n Presencia: {Mtxt_presencia.Text}");
            //}

            if (ambosCamposCompletados && esHorarioValido)
            {
                string durEstimada = _NE_Viajes.determinarEstimado(horarioLlegada, horarioSalida);
                lbl_duracionEstimada.Text = durEstimada;
                duracionEstimadaViaje = Tiempo.convertirAIntMilitar(durEstimada);
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            bool estanCamposCompletos = ValidarCamposCompletos() == Resultado.correcto;
            if (!estanCamposCompletos) return;

            bool esHorarioPresenciaCorrecto = VerificarHorarioPresencia() == Resultado.correcto;
            if (!esHorarioPresenciaCorrecto) return;

            bool noEstaHorarioDesfasado = VerificarHorarioDesfasado() == Resultado.correcto;
            if (!noEstaHorarioDesfasado) return;

            bool estaTodoCorrecto = estanCamposCompletos && esHorarioPresenciaCorrecto && noEstaHorarioDesfasado;

            if (estaTodoCorrecto)
            {
                Viaje myViaje = new Viaje()
                {
                    HorarioLlegada = Mtxt_horarioLlegada.Text,
                    HorarioSalida = Mtxt_horarioSalida.Text,
                    HorarioPresencia = Mtxt_presencia.Text,
                    DuracionEstimada = duracionEstimadaViaje
                };
                _NE_Viajes.InsertViaje(myViaje);
                // Permite refrescar los datos del data grid con lo que fue ingresado recientemente
                CargarTodos();
            }

            if (!estaTodoCorrecto)
            {
                MessageBox.Show("Ocurrio un error en la validación");
            }
        }

        private Resultado ValidarCamposCompletos()
        {
            bool ErrorTextMask = false;

            if (Mtxt_presencia.MaskCompleted == false)
            { ErrorTextMask = true; }

            if (Mtxt_horarioSalida.MaskCompleted == false)
            { ErrorTextMask = true; }

            if (Mtxt_horarioLlegada.MaskCompleted == false)
            { ErrorTextMask = true; }

            if (ErrorTextMask == true)
            {
                MessageBox.Show("Complete todos los campos");
                return Resultado.error;
            }
            return Resultado.correcto;
        }

        private Resultado VerificarHorarioDesfasado()
        {

            //Determina si los horarios ingresados superan las 24hs o los 60 min
            bool horarioDefasado = false;
            int horariodePresencia = Tiempo.convertirAIntMilitar(Mtxt_presencia.Text);
            horarioDefasado = Tiempo.ValidarHorario(horariodePresencia, horarioDefasado);

            int horariodeSalida = Tiempo.convertirAIntMilitar(Mtxt_horarioSalida.Text);
            horarioDefasado = Tiempo.ValidarHorario(horariodeSalida, horarioDefasado);

            int horariodeLlegada = Tiempo.convertirAIntMilitar(Mtxt_horarioLlegada.Text);
            horarioDefasado = Tiempo.ValidarHorario(horariodeLlegada, horarioDefasado);

            if (horarioDefasado)
            {
                MessageBox.Show("El horario ingresado no debe superar las 24hs ni los 60min");
                return Resultado.error;
            }

            return Resultado.correcto;
        }

        private Resultado VerificarHorarioPresencia()
        {
            //Verificacion de que la espera entre el horario de presencia y el horario de salida no supere las 4hs.
            //Se hace esta comparacion para luego poder calcular la espera en el aeropuerto incluso si transcurre en dos dias diferentes.
            // Ejemplo: Horario de presencia = 23:00hs, Horario de Salida = 01:00hs, Espera estimada = 2hs (en vez de -22hs).
            bool esPresenciaMenorASalida = String.Compare(Mtxt_horarioSalida.Text, Mtxt_presencia.Text) == -1;

            int horariopresenciaMilitar = Tiempo.convertirAIntMilitar(Mtxt_presencia.Text);
            int horarioSalidaMilitar = Tiempo.convertirAIntMilitar(Mtxt_horarioSalida.Text);

            if (esPresenciaMenorASalida)
            {
                int esperaEstimadaActual = Tiempo.calcularDiferenciaDelDia(Mtxt_horarioSalida.Text, Mtxt_presencia.Text);
                if (esperaEstimadaActual > 400)
                {
                    MessageBox.Show("El horario de espera en el aeropuerto no debe superar las 4hs");
                    return Resultado.error;
                };
            }

            if (!esPresenciaMenorASalida)
            {
                int esperaEstimadaActual = horarioSalidaMilitar - horariopresenciaMilitar;
                if (esperaEstimadaActual > 400)
                {
                    MessageBox.Show("El horario de espera en el aeropuerto no debe superar las 4hs");
                    return Resultado.error;
                }
            }
            return Resultado.correcto;
        }

        private void CargarTodos()
        {
            DataTable todosLosViajes = _NE_Viajes.GetTodosLosViajes();
            this.datagrid_viajes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.datagrid_viajes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.datagrid_viajes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CargarDataGrid(todosLosViajes);
        }


        private void CargarDataGrid(DataTable tabla)
        {
            datagrid_viajes.Rows.Clear();
            if (tabla.Rows.Count == 0)
            {
                datagrid_viajes.Rows.Clear();
                return;
            }

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                var duracionEstimadaDeViaje = Tiempo.FormatearIntMilitarAString((int)tabla.Rows[i]["duracionEstimada"]);

                datagrid_viajes.Rows.Add();

                // Columna del DGrid --- nombre de columna de SQL
                datagrid_viajes.Rows[i].Cells[0].Value = tabla.Rows[i]["numeroDeViaje"].ToString();
                datagrid_viajes.Rows[i].Cells[1].Value = tabla.Rows[i]["horarioPresencia"].ToString();
                datagrid_viajes.Rows[i].Cells[2].Value = tabla.Rows[i]["horarioSalida"].ToString();
                datagrid_viajes.Rows[i].Cells[3].Value = tabla.Rows[i]["horarioLlegada"].ToString();
                datagrid_viajes.Rows[i].Cells[4].Value = duracionEstimadaDeViaje;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar1_Click(object sender, EventArgs e)
        {
            Frm_ModificarViaje modificarViaje = new Frm_ModificarViaje();
            modificarViaje.ShowDialog();
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            CargarTodos();
        }

        private readonly NE_Viajes NE_Viajes = new NE_Viajes();

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (datagrid_viajes.CurrentRow == null)
                return;

            string idDeFilaSeleccionada = datagrid_viajes.CurrentRow.Cells[0].Value.ToString();
            NE_Viajes.EliminarFila(idDeFilaSeleccionada);

            datagrid_viajes.Rows.Remove(datagrid_viajes.CurrentRow);
        }
    }
}
