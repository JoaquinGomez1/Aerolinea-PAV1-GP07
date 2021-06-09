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

namespace TrabajoPrácticoPAV.Formularios.Listados.Avion_Por_Modelo
{
    public partial class Frm_AvionPorModelo : Form
    {
        private readonly NE_Avion _NE = new NE_Avion();
        public Frm_AvionPorModelo()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_ListadoReservasPorPasajero_Load(object sender, EventArgs e)
        {

        }

        // Carga Report Viewer
        private void ArmarReporteUsuario(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("Ds_AvionPorModelo", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Avion_Por_Modelo.ReporteAvionPorModelo.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }

        private DataTable determineDataSet()
        {
            string nDocumento = Mtxt_documento.Text;
            string nReserva = Mtxt_reserva.Text;
            DataTable table = _NE.RecuperarTodos();

            if (Rb_documento.Checked)
            {
                if (nDocumento != "")
                {
                    //table = _NE.GetReservaPorParametro("numeroDoc", nDocumento);
                }
                else
                {
                    MessageBox.Show("Cargue el documento correctamente");
                    return new DataTable();
                }
            }

            if (Rb_reserva.Checked)
            {
                if (nReserva != "")
                {

                    // table = _NE.GetReservaPorParametro("numeroDeReserva", nReserva);
                }
                else
                {
                    MessageBox.Show("Cargue un numero de reserva");
                    return new DataTable();
                }
            }
            return table;
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            DataTable dataSet = determineDataSet();
            ArmarReporteUsuario(dataSet);
        }
    }
}
