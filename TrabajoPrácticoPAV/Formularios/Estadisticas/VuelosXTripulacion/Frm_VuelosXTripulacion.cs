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

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.VuelosXTripulacion
{
    public partial class Frm_VuelosXTripulacion : Form
    {
        DataTable tabla = new DataTable();
        NE_Vuelos vuelo = new NE_Vuelos();

        public Frm_VuelosXTripulacion()
        {
            InitializeComponent();
        }

        private void Frm_VuelosXTripulacion_Load(object sender, EventArgs e)
        {
            rbu_Todos.Checked = true;
            Estilo.FormatearEstilo(this.Controls);
            this.BackColor = Estilo.ColorFondoForms;

            cmb_cargo.CargarCombo();
            this.reportViewer1.RefreshReport();
        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.RefreshReport();
            if (rbu_Todos.Checked)
                tabla = vuelo.Estadistica_VuelosXTodosTripulantes();
            else if (rbu_Cargo.Checked)
                tabla = vuelo.Estadistica_VuelosXTripulantesCargo(int.Parse(cmb_cargo.SelectedValue.ToString()));

            ArmarReporte();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void ArmarReporte()
        {
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.VuelosXTripulacion.Reporte_VuelosXTripulacion.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();
        }
    }
}
