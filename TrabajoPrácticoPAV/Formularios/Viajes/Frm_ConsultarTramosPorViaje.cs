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
    public partial class Frm_ConsultarTramosPorViaje : Form
    {

        private readonly NE_Tramos _NE_Tramos = new NE_Tramos();
        private readonly NE_Viajes _NE_Viajes = new NE_Viajes();
        private string numeroDeViajeActual = "";

        public Frm_ConsultarTramosPorViaje()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string codigo = Mtxt_codigo.Text;

            if (codigo == "")
            {
                MessageBox.Show("Debe indicar un codigo de viaje");
                return;
            }

            numeroDeViajeActual = codigo;
            DataTable Tramos = _NE_Viajes.GetTramosPorViaje(Mtxt_codigo.Text);

            lbl_cant_tramos.Text = Tramos.Rows.Count.ToString();

            CargarGrilla(Tramos);
        }

        private void CargarGrilla(DataTable datos)
        {
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                grid_tramoViaje.Rows.Add();
                grid_tramoViaje.Rows[i].Cells[0].Value = _NE_Tramos.BuscarNombreAeropuerto(datos.Rows[i]["codigoAeropuertoSalida"].ToString());
                grid_tramoViaje.Rows[i].Cells[1].Value = _NE_Tramos.BuscarNombreAeropuerto(datos.Rows[i]["codigoAeropuertoDestino"].ToString());
                grid_tramoViaje.Rows[i].Cells[2].Value = datos.Rows[i]["duracion"].ToString();
                grid_tramoViaje.Rows[i].Cells[3].Value = datos.Rows[i]["distancia"].ToString();
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (numeroDeViajeActual != "")
            {
                var selectedRow = grid_tramoViaje.CurrentRow;
                Tramo tramo = new Tramo()
                {
                    codigoAeropuertoSalida = _NE_Tramos.BuscarCodigoAeropuerto(selectedRow.Cells[0].Value.ToString()),
                    codigoAeropuertoDestino = _NE_Tramos.BuscarCodigoAeropuerto(selectedRow.Cells[1].Value.ToString()),
                };
                _NE_Viajes.EliminarTramoDeViaje(tramo, numeroDeViajeActual);

                grid_tramoViaje.Rows.Remove(selectedRow);
            }
        }
    }
}
