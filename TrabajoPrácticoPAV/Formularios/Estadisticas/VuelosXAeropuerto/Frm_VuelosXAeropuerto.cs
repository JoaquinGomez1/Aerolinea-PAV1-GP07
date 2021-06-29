using Microsoft.Reporting.WinForms;
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
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.VuelosXAeropuerto
{
    public partial class Frm_VuelosXAeropuerto : Form
    {
        NE_Vuelos vuelo = new NE_Vuelos();
        DataTable tabla = new DataTable();

        public Frm_VuelosXAeropuerto()
        {
            InitializeComponent();
        }

        private void Frm_VuelosXAeropuerto_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.RefreshReport();

            tabla = vuelo.Estadistica_RecuperarPorcentajes();
            ArmarReporte();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void ArmarReporte()
        {
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.VuelosXAeropuerto.Reporte_VuelosXAeropuerto.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();
        }

        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
