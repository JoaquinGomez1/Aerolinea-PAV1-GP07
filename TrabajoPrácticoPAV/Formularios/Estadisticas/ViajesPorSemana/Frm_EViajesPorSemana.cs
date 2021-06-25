using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesPorSemana
{
    public partial class Frm_EViajesPorSemana : Form
    {
        private readonly NE_Viajes _NE = new NE_Viajes();

        public Frm_EViajesPorSemana()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_EViajesPorSemana_Load(object sender, EventArgs e)
        {
            DataTable tabla = determineDataSet();
            ArmarReporteUsuario(tabla);
            this.reportViewer1.RefreshReport();
        }

        private void ArmarReporteUsuario(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("Ds_ViajesPorSemana", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesPorSemana.Estadistica_ViajesPorSemana.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }

        private DataTable determineDataSet()
        {
            return _NE.GetViajesPorSemana();
        }

        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}