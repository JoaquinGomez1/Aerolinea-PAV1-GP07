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

        private DataTable determineDataSet(bool shouldGetAll)
        {
            string initialDate = maskedTextBox_Aerolinea1.Text;
            string finalDate = maskedTextBox_Aerolinea2.Text;
            return shouldGetAll ? _NE.GetViajesPorMes() : _NE.GetViajesPorMes(initialDate, finalDate);
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            bool shouldGetAll = rbu_Todos.Checked;
            if (!shouldGetAll && !AreMonthsValid(maskedTextBox_Aerolinea1.Text, maskedTextBox_Aerolinea2.Text))
                return;

            DataTable tabla = determineDataSet(shouldGetAll);
            ArmarReporteUsuario(tabla);
        }

        private bool AreMonthsValid(string month1, string month2)
        {
            int month1Int, month2Int;
            try
            {
                month1Int = Int32.Parse(month1);
                month2Int = Int32.Parse(month2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                return false;
            }

            if (month1Int > 12 || month1Int < 1 || month2Int > 12 || month2Int < 1) return false;

            return true;
        }
    }
}