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
using TrabajoPrácticoPAV.Formularios;
using TrabajoPrácticoPAV.NE_Usuarios;
using Microsoft.Reporting.WinForms;
namespace TrabajoPrácticoPAV.Formularios.Listados.Aeropuertos
{
    public partial class Frm_ReporteAeroPais : Form
    {
        Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
        NE_Aeropuertos aeropuerto = new NE_Aeropuertos();
        DataTable tabla = new DataTable();
        string restriccion = "";


        public Frm_ReporteAeroPais()
        {
            InitializeComponent();
            //tabla = aeropuerto.Reporte_recuperarTodos();
            //ArmarReporteAeropuertos();
        }
        

        private void Frm_ReporteAeroPais_Load_1(object sender, EventArgs e)
        {
            //InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            tabla = aeropuerto.Reporte_recuperarTodos();
            //ArmarReporteAeropuertos();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("f " + rbu04.Checked);
            //if (rbu04.Checked == true)
            //{
            tabla = aeropuerto.Reporte_recuperarTodos();
                ArmarReporteAeropuertos();
            //}
        }
        public void ArmarReporteAeropuertos() 
        {
            MessageBox.Show("tabla " + tabla.Rows.Count);
            ReportDataSource datos = new ReportDataSource("DataSet01", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Aeropuertos.ReporteAeroPais.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();

        }

        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
           
            tabla = aeropuerto.Reporte_recuperarTodos();
            ArmarReporteAeropuertos();
        }
    }
}
