using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Listados.Reservas
{
    public partial class Frm_Reservas : Form
    {
        private readonly NE_Reserva _NE_Reserva = new NE_Reserva();

        public Frm_Reservas()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_ListadoReservasPorPasajero_Load(object sender, EventArgs e)
        {
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dataSet = determineDataSet();
            ArmarReporteUsuario(dataSet);
        }

        // Carga Report Viewer
        private void ArmarReporteUsuario(DataTable tabla) // Aca hay algo mal
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("ReservasPorPasajeros", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Reservas.ReporteReservasPorPasajeros.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }

        private DataTable determineDataSet()
        {
            string nDocumento = Mtxt_documento.Text;
            string nReserva = Mtxt_reserva.Text;
            DataTable table = _NE_Reserva.getTodosReservasPorPasajero();

            if (Rb_documento.Checked)
            {
                if (nDocumento != "" && nDocumento.Length == 8)
                    table = _NE_Reserva.GetReservaPorParametro("numeroDoc", nDocumento);
                else
                {
                    MessageBox.Show("Cargue el documento correctamente");
                    return new DataTable();
                }
            }

            if (Rb_reserva.Checked)
            {
                if (nReserva != "")
                    table = _NE_Reserva.GetReservaPorParametro("numeroDeReserva", nReserva);
                else
                {
                    MessageBox.Show("Cargue un numero de reserva");
                    return new DataTable();
                }
            }
            return table;
        }

        private void Mtxt_documento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Mtxt_reserva_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            DataTable dataSet = determineDataSet();
            ArmarReporteUsuario(dataSet);
        }
    }
}