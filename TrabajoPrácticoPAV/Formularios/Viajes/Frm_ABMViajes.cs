using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Clase.Modelos;
using TrabajoPrácticoPAV.Formularios.Viajes;
using TrabajoPrácticoPAV.NE_Usuarios;
using static TrabajoPrácticoPAV.Clase.Tratamientos_Especiales;

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ABMViajes : Form
    {
        public static List<Tramo> TramosDelViaje = new List<Tramo>();
        private readonly NE_Viajes _NE_Viajes = new NE_Viajes();
        private int duracionEstimadaViaje { get; set; }
        private readonly ManejoDeTiempos Tiempo = new ManejoDeTiempos();

        // Al abrir este formulario creo también estos dos formularios que dependen del principal
        private readonly Frm_CargarTramosPorViaje frm = new Frm_CargarTramosPorViaje();
        private readonly Frm_ModificarViaje modificarViaje = new Frm_ModificarViaje();

        public Frm_ABMViajes()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            frm.FormClosed += new FormClosedEventHandler(Form_Closed);
            modificarViaje.FormClosed += new FormClosedEventHandler(Form_ModificarClosed);
        }

        private void Frm_ABMViajes_Load(object sender, EventArgs e)
        {
            CargarTodos();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            // En este caso solo me interesa delegar la tarea de comparación a la hora de determinar el estimado

            string horarioSalida = Mtxt_horarioSalida.Text;

            if (Mtxt_horarioSalida.Text.Length == 5)
            {
                actualizarHorarioLlegada();
                mostrarDuracionEstimada(horarioSalida);
            }
        }

        public void mostrarDuracionEstimada(string horarioSalida)
        {
            string horarioLlegada = calcularLlegada().ToString().Substring(0, 5);
            bool salidaCompletada = horarioSalida.Length == 5;

            bool esHorarioValido = Tiempo.esHorarioValido(horarioSalida);
            bool hayTramosCargados = TramosDelViaje.Count >= 1;

            if (salidaCompletada && esHorarioValido && hayTramosCargados)
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

            bool existeAlMenosUnTramo = TramosDelViaje.Count >= 1;
            if (!existeAlMenosUnTramo)
            {
                MessageBox.Show("Tiene que cargar al menos un tramo");
                return;
            }

            bool estaTodoCorrecto = estanCamposCompletos && esHorarioPresenciaCorrecto && noEstaHorarioDesfasado && existeAlMenosUnTramo;


            if (estaTodoCorrecto)
            {
                Viaje myViaje = new Viaje()
                {
                    HorarioLlegada = lbl_horarioLlegada.Text,
                    HorarioSalida = Mtxt_horarioSalida.Text,
                    HorarioPresencia = Mtxt_presencia.Text,
                    DuracionEstimada = duracionEstimadaViaje
                };
                _NE_Viajes.InsertViaje(myViaje, TramosDelViaje.Count);
                string numeroViajeInsertado = _NE_Viajes.GetIdentityDeViaje();
                _NE_Viajes.CargarTramosPorViaje(TramosDelViaje, numeroViajeInsertado);

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
            if (!Mtxt_horarioSalida.MaskCompleted || !Mtxt_presencia.MaskCompleted)
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

        public void CargarTodos()
        {
            // Carga todos los datos de vuelta a la grilla
            DataTable todosLosViajes = _NE_Viajes.GetTodosLosViajes();
            this.datagrid_viajes.Columns[0].Width = 50;
            this.datagrid_viajes.Columns[1].Width = 200;
            this.datagrid_viajes.Columns[2].Width = 200;
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

        private void btn_modificar1_Click(object sender, EventArgs e) => modificarViaje.ShowDialog();
        private void btn_refrescar_Click(object sender, EventArgs e) => CargarTodos();

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (datagrid_viajes.CurrentRow == null)
                return;

            string idDeFilaSeleccionada = datagrid_viajes.CurrentRow.Cells[0].Value.ToString();
            _NE_Viajes.EliminarFila(idDeFilaSeleccionada);

            datagrid_viajes.Rows.Remove(datagrid_viajes.CurrentRow);
        }


        // Esta funcion es llamada cuando el frm creado en el constructor es cerrado
        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Tramos cargados correctamente");
            lbl_tramosCargados.Text = $"{TramosDelViaje.Count}";
            actualizarHorarioLlegada();

            string horarioSalida = Mtxt_horarioSalida.Text;
            mostrarDuracionEstimada(horarioSalida);
        }

        private void Form_ModificarClosed(object sender, FormClosedEventArgs e) => CargarTodos();
        private void button5_Click(object sender, EventArgs e) => frm.ShowDialog();


        private string obtenerSumaDeTiempoDeTramos()
        {
            int sumDeDuraciones = TramosDelViaje.Sum((x) => x.duracion);
            string horarioLlegada = TimeSpan.FromMinutes(sumDeDuraciones).ToString();
            return horarioLlegada.Substring(0, 5);
        }

        private TimeSpan calcularLlegada()
        {
            // Devuelve un TimeSpan de formato "HH:MM:SS"
            // Agregando la suma de duraciones de los tramos a la llegada

            int sumDeDuraciones = TramosDelViaje.Sum((x) => x.duracion);
            TimeSpan horarioLlegada = TimeSpan.FromMinutes(sumDeDuraciones);
            string horarioSalida = Mtxt_horarioSalida.Text;

            bool horarioSalidaCompleto = horarioSalida.Length == 5;
            if (horarioSalidaCompleto)
            {
                TimeSpan tiempoSalida = TimeSpan.Parse(horarioSalida);
                return horarioLlegada.Add(tiempoSalida);
            }
            return horarioLlegada;
        }

        private string actualizarHorarioLlegada()
        {
            string horarioSalida = Mtxt_horarioSalida.Text;
            bool salidaCompletada = horarioSalida.Length == 5;
            string horarioLlegada = obtenerSumaDeTiempoDeTramos();

            bool hayViajesCargados = TramosDelViaje.Count >= 1;

            if (salidaCompletada && hayViajesCargados) // Solo actualizar el lbl cuando la salida esté completada
                lbl_horarioLlegada.Text = calcularLlegada().ToString().Substring(0, 5);

            return horarioLlegada;
        }

        private void btn_consultar_tramos_Click(object sender, EventArgs e)
        {
            Frm_ConsultarTramosPorViaje consultarTramosPorViaje = new Frm_ConsultarTramosPorViaje();
            consultarTramosPorViaje.ShowDialog();
        }
    }
}
