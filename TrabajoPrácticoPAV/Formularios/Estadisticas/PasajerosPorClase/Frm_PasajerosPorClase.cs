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
using TrabajoPrácticoPAV.Clase;
using Microsoft.Reporting.WinForms;

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.PasajerosPorViaje
{
    public partial class Frm_PasajerosPorViaje : Form
    {
        Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
        NE_Clientes pasajero = new NE_Clientes();
        public Frm_PasajerosPorViaje()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_PasajerosPorViaje_Load(object sender, EventArgs e)
        {
            DataTable tabla = determineDataSet();
            this.rv_pasajerosPorViaje.RefreshReport();


            if (tabla.Rows.Count != 0)
                CargarEstadisticaPasajerosPorClase(tabla);
            else
            {
                rv_pasajerosPorViaje.LocalReport.DataSources.Clear();
                rv_pasajerosPorViaje.RefreshReport();
                MessageBox.Show("No se encontraron resultados para la búsqueda");
            }
        }

        public void CargarEstadisticaPasajerosPorClase(DataTable tabla)
        {
            ReportDataSource datos = new ReportDataSource("Ds_EstadisticaPasajerosPorClase", tabla);
            rv_pasajerosPorViaje.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.PasajerosPorClase.EstadisticaPasajerosPorClase.rdlc";
            rv_pasajerosPorViaje.LocalReport.DataSources.Clear();
            rv_pasajerosPorViaje.LocalReport.DataSources.Add(datos);
            rv_pasajerosPorViaje.RefreshReport();
        }

        private DataTable determineDataSet()
        {
            return pasajero.RecuperarPasajerosPorClase();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
