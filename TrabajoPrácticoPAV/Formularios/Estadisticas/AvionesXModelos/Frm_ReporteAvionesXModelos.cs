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

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.AvionesXModelos
{
    public partial class Frm_ReporteAvionesXModelos : Form
    {
        DataTable tabla = new DataTable();
        NE_Avion avion = new NE_Avion();

        public Frm_ReporteAvionesXModelos()
        {
            InitializeComponent();
           
        }

        private void Frm_ReporteAvionesXModelos_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            this.reportViewer1.RefreshReport();
        }

        private void ArmarReporteAvion()
        {
            ReportDataSource datos = new ReportDataSource("Aviones", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.AvionesXModelos.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
             if(btn_todos.Checked==false && btn_rango.Checked==false)
            {
                MessageBox.Show("Seleccione una opción");
                return;
            }
            else if (btn_rango.Checked)
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

                tabla = avion.RecuperarAvionesPorRango(desde, hasta);
                if (tabla.Rows.Count != 0)
                    ArmarReporteAvion();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }

            else if (btn_todos.Checked)
            {
                tabla = avion.RecuperarTodosReporte();
                if (tabla.Rows.Count != 0)
                    ArmarReporteAvion();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }
        

        }
    }
}
