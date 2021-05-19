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
using static TrabajoPrácticoPAV.Clase.Tratamientos_Especiales;
using System.Runtime.InteropServices;
using TrabajoPrácticoPAV.Formularios.Viajes;
using static TrabajoPrácticoPAV.Clase.Modelos.Viaje;


namespace TrabajoPrácticoPAV.Formularios.Viajes
{

    public partial class Frm_ModificarViaje : Form
    {
        [DllImport("user32.DLL", EntryPoint = "CargarTodos")]
        private extern static void CargarTodos();
        private static readonly DataGridView datagrid_viajes = new DataGridView();
        private readonly NE_Viajes NE_Viajes = new NE_Viajes();
        private Viaje ViajeSeleccionado { get; set; }
        private readonly Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();

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
            ManejoDeTiempos Tiempo = new ManejoDeTiempos();
            DataGridViewRow fila = datagrid_viajes.CurrentRow;
            if (fila == null) { MessageBox.Show("fila es null"); };

            Viaje myviaje = new Viaje()
            {
                NumeroDeViaje = Int32.Parse(fila.Cells[0].Value.ToString()),
                HorarioPresencia = fila.Cells[1].Value.ToString(),
                HorarioSalida = fila.Cells[2].Value.ToString(),
                HorarioLlegada = fila.Cells[3].Value.ToString(),
                DuracionEstimada = Int32.Parse(fila.Cells[4].Value.ToString()),
            };

            mtb_llegada.Text = myviaje.HorarioLlegada;
            mtb_horario_salida.Text = myviaje.HorarioSalida;
            mtb_horario_presencia.Text = myviaje.HorarioPresencia;
            lbl_duracionEstimada.Text = Tiempo.FormatearIntMilitarAString(myviaje.DuracionEstimada);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool esValido = tratamientos.Validar(panel1.Controls) == Resultado.correcto;
            if (esValido)
            {
                Viaje myviaje = new Viaje()
                {
                    NumeroDeViaje = Int32.Parse(cmb_numero_viaje.SelectedValue.ToString()),
                    HorarioPresencia = mtb_horario_presencia.Text,
                    HorarioSalida = mtb_horario_salida.Text,
                    HorarioLlegada = mtb_llegada.Text,
                    DuracionEstimada = Int32.Parse(lbl_duracionEstimada.Text),

                };
                NE_Viajes.ModificarPorId(myviaje);
                CargarTodos();
            }
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
