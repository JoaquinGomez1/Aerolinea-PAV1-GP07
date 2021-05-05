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

        public Frm_ModificarViaje()
        {
            InitializeComponent();
        }

        private void numero_viaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valorSeleccionado = cmb_numero_viaje.SelectedValue.ToString();
            Viaje miViaje = NE_Viajes.GetViajePorId(valorSeleccionado);
            ViajeSeleccionado = miViaje;
            ManejoDeTiempos Tiempo = new ManejoDeTiempos();

            mtb_llegada.Text = miViaje.HorarioLlegada;
            mtb_salida.Text = miViaje.HorarioSalida;
            mtb_presencia.Text = miViaje.HorarioPresencia;
            lbl_duracionEstimada.Text = Tiempo.FormatearIntMilitarAString(miViaje.DuracionEstimada);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NE_Viajes.ModificarPorId(ViajeSeleccionado);
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
            string horarioLlegada = mtb_llegada.Text;
            string horarioSalida = mtb_salida.Text;

            bool ambosCompletados = horarioLlegada.Length == 5 && horarioSalida.Length == 5;
            bool esHorarioValido = Tiempo.esHorarioValido(horarioSalida) && Tiempo.esHorarioValido(horarioLlegada) && Tiempo.esHorarioValido(mtb_presencia.Text);

            if (ambosCompletados && esHorarioValido)
            {
                string tiempoEstimado = NE_Viajes.determinarEstimado(horarioLlegada, horarioSalida);

                ViajeSeleccionado.DuracionEstimada = Tiempo.convertirAIntMilitar(tiempoEstimado);
                ViajeSeleccionado.HorarioLlegada = horarioLlegada;
                ViajeSeleccionado.HorarioPresencia = mtb_presencia.Text;
                ViajeSeleccionado.HorarioSalida = horarioSalida;

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
    }
}
