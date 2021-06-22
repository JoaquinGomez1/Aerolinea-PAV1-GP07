using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesPorMes
{
    public partial class Frm_EViajesPorMes : Form
    {
        private readonly NE_Viajes _NE = new NE_Viajes();

        public Frm_EViajesPorMes()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        public void Frm_EViajesPorMes_Load(object sender, EventArgs e)
        {
            DataTable tabla = determineDataSet();
            ArmarReporteUsuario(tabla);
            this.reportViewer1.RefreshReport();
        }

        // Carga Report Viewer
        private void ArmarReporteUsuario(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("Ds_ViajesPorMes", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesPorMes.Estadistica_ViajesPorMes.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }

        private DataTable determineDataSet()
        {
            return _NE.GetViajesPorMes();
        }
    }
}