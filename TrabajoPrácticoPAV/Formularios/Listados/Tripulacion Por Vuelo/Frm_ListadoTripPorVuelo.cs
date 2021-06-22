using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Listados.Tripulacion_Por_Vuelo
{
    public partial class Frm_ListadoTripPorVuelo : Form
    {
        private readonly NE_Tripulacion _NE = new NE_Tripulacion();
        public Frm_ListadoTripPorVuelo()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dataSet = determineDataSet();
            ArmarReporteUsuario(dataSet);
        }

        // Carga Report Viewer
        private void ArmarReporteUsuario(DataTable tabla) // Aca hay algo mal 
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("Ds_TripulacionPorVuelo", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Tripulacion_Por_Vuelo.ReporteTripulacionPorVuelo.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }

        private DataTable determineDataSet()
        {
            string idTripulante = Mtxt_tripulante.Text;
            string idVuelo = Mtxt_vuelo.Text;
            DataTable table = _NE.GetTodosTripulantesPorVuelo();

            if (Rb_tripulante.Checked)
            {
                if (idTripulante != "")
                    table = _NE.GetTripulacionEnVueloPorParametro("idTripulacion", idTripulante);
                else
                {
                    MessageBox.Show("Cargue el Id del tripulante correctamente");
                    return new DataTable();
                }
            }

            if (Rb_Vuelo.Checked)
            {
                if (idVuelo != "")
                    table = _NE.GetTripulacionEnVueloPorParametro("idVuelo", idVuelo);
                else
                {
                    MessageBox.Show("Cargue el Id del vuelo correctamente");
                    return new DataTable();
                }
            }
            return table;
        }
    }
}
