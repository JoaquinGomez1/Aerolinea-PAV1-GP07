using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Listados.Aeropuertos
{
    public partial class Frm_ReporteVueloXAeropuerto : Form
    {
        private NE_Vuelos vuelo = new NE_Vuelos();
        private DataTable tabla = new DataTable();

        public Frm_ReporteVueloXAeropuerto()
        {
            InitializeComponent();
        }

        private void Frm_ReporteVueloXAeropuerto_Load(object sender, EventArgs e)
        {
            Rbu_Nombre.Checked = true;
            this.reportViewer1.RefreshReport();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (Rbu_Nombre.Checked)
            {
                if (Txt_Nombre.Text == "")
                {
                    MessageBox.Show("Escriba por favor un nombre de búsqueda");
                    return;
                }

                tabla = vuelo.Reporte_RecuperarXNombreAeropuerto(Txt_Nombre.Text);
                if (tabla.Rows.Count != 0)
                    ArmarReporteVuelo();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }
            if (Rbu_Codigo.Checked)
            {
                if (Txt_Codigo.Text == "")
                {
                    MessageBox.Show("Escriba por favor un código de búsqueda");
                    return;
                }

                tabla = vuelo.Reporte_RecuperarXCodigoAeropuerto(Txt_Codigo.Text);
                if (tabla.Rows.Count != 0)
                    ArmarReporteVuelo();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }
            if (Rbu_Numero.Checked)
            {
                string desde = "";
                string hasta = "";

                if (Txt_Desde.Text == "")
                    desde = "0";
                else
                    desde = Txt_Desde.Text;
                if (Txt_Hasta.Text == "")
                    hasta = "99999";
                else
                    hasta = Txt_Hasta.Text;

                tabla = vuelo.Reporte_RecuperarXIdVuelo(desde, hasta);
                if (tabla.Rows.Count != 0)
                    ArmarReporteVuelo();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }
            if (Rbu_Todos.Checked)
            {
                tabla = vuelo.Reporte_RecuperarTodos();
                if (tabla.Rows.Count != 0)
                    ArmarReporteVuelo();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }
        }

        public void ArmarReporteVuelo()
        {
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Vuelos.Reporte_VuelosXAeropuerto.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();
        }
    }
}