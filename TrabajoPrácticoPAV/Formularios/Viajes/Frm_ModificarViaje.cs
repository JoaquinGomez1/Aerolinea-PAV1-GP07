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
using TrabajoPrácticoPAV.Clase.Modelos;
using TrabajoPrácticoPAV.NE_Usuarios;


namespace TrabajoPrácticoPAV.Formularios.Viajes
{
    public partial class Frm_ModificarViaje : Form
    {
        private readonly NE_Viajes NE_Viajes = new NE_Viajes();
        private Viaje ViajeSeleccionado { get; set; }
        private readonly ManejoDeTiempos _Tiempo = new ManejoDeTiempos();

        public Frm_ModificarViaje()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            panel1.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void numero_viaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valorSeleccionado = cmb_numero_viaje.SelectedValue.ToString();
            Viaje miViaje = NE_Viajes.GetViajePorId(valorSeleccionado);
            ViajeSeleccionado = miViaje;

            // Actualizar la vista del formulario
            mtb_llegada.Text = miViaje.HorarioLlegada;
            mtb_horario_salida.Text = miViaje.HorarioSalida;
            mtb_horario_presencia.Text = miViaje.HorarioPresencia;
            lbl_duracionEstimada.Text = _Tiempo.FormatearIntMilitarAString(miViaje.DuracionEstimada);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Viajes.ModificarViaje(ViajeSeleccionado);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtb_salida_TextChanged(object sender, EventArgs e)
        {
            ControladorDeHorarios();
        }

        private void mtb_llegada_TextChanged(object sender, EventArgs e)
        {
            ControladorDeHorarios();

        }

        private void ControladorDeHorarios()
        {
            // Esta función va a ser ejecutada cada vez que se ingresen cambios en alguno de los MaskedTextBox de horarios de salida o llegada.
            ManejoDeTiempos Tiempo = new ManejoDeTiempos();
            if (ViajeSeleccionado == null)
            {
                return;
            }
            string horarioLlegada = mtb_llegada.Text;
            string horarioSalida = mtb_horario_salida.Text;

            bool ambosCompletados = horarioLlegada.Length == 5 && horarioSalida.Length == 5;
            bool esHorarioValido = Tiempo.esHorarioValido(horarioSalida) && Tiempo.esHorarioValido(horarioLlegada) && Tiempo.esHorarioValido(mtb_horario_presencia.Text);

            if (ambosCompletados && esHorarioValido)
            {
                string tiempoEstimado = NE_Viajes.determinarEstimado(horarioLlegada, horarioSalida);
                ViajeSeleccionado = new Viaje()
                {
                    HorarioSalida = horarioSalida,
                    HorarioLlegada = horarioLlegada,
                    HorarioPresencia = mtb_horario_presencia.Text,
                    DuracionEstimada = _Tiempo.convertirAIntMilitar(tiempoEstimado),
                    NumeroDeViaje = ViajeSeleccionado.NumeroDeViaje,
                };
                lbl_duracionEstimada.Text = tiempoEstimado;
            }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            cmb_numero_viaje.CargarCombo();
        }
    }
}
