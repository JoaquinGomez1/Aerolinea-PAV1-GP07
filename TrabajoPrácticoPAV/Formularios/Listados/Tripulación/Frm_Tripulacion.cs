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
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Listados.Tripulación
{
    public partial class Frm_Tripulacion : Form
    {
        NE_Tripulacion tripulacion = new NE_Tripulacion();
        public Frm_Tripulacion()
        {
            InitializeComponent();
        }

        private void Frm_Tripulacion_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }

      

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            DataTable tabla = tripulacion.RecuperarTripulantes();
            ArmarReporteUsuario01(tabla);

        }

        private void ArmarReporteUsuario01(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("TripulacionXCargo", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formulario.Listados.Tripulación.ReporteTripulacion.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport(); 
        }
    }
}
