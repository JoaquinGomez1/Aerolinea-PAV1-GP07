using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Listados.Viajes
{
    public partial class Frm_ListadoViajes : Form
    {
        NE_Viajes viajes = new NE_Viajes();
        public Frm_ListadoViajes()
        {
            InitializeComponent();
        }

        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
            if (rbu04.Checked == true)
            {
                MessageBox.Show("True");
                ArmarReporteUsuario01(viajes.RecuperarViajes());
            }
        }

        private void Frm_ListadoViajes_Load(object sender, EventArgs e)
        {

        }

        private void rv_01_Load(object sender, EventArgs e)
        {

        }

        private void ArmarReporteUsuario01(DataTable tabla) // Aca hay algo mal 
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("Ds_Viajes", tabla);
            rv_01.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Viajes.ReporteViajes.rdlc";
            rv_01.LocalReport.DataSources.Clear();
            rv_01.LocalReport.DataSources.Add(PaqueteDatos);
            rv_01.RefreshReport();
        }
    }
}
