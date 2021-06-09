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

namespace TrabajoPrácticoPAV.Formularios.Listados.Asientos
{
    public partial class Frm_ReporteAsientoXAvion : Form
    {
        Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
        NE_Asiento asiento = new NE_Asiento();
        DataTable tabla = new DataTable();

        public Frm_ReporteAsientoXAvion()
        {
            InitializeComponent();
        }

        private void Frm_ReporteAsientoXAvion_Load(object sender, EventArgs e)
        {
            Rbu_Avion.Checked = true;
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            cmb_Modelo.CargarCombo();
            this.reportViewer1.RefreshReport();
        }

        private void ArmarReporteAsiento()
        {
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Asientos.Reporte_AsientoXAvion.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();
        }

        private void Btn_Buscar_Click_1(object sender, EventArgs e)
        {
            if (Rbu_Avion.Checked)
            {
                if (Txt_Numero.Text == "" || cmb_Modelo.SelectedIndex == -1)
                {
                    MessageBox.Show("Elija un modelo y escriba por favor un número de modelo");
                    return;
                }

                tabla = asiento.Reporte_RecuperarPorAvion(cmb_Modelo.Text.ToString(), Txt_Numero.Text);
                if (tabla.Rows.Count != 0)
                    ArmarReporteAsiento();
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

                tabla = asiento.Reporte_RecuperarRangoAsiento(desde, hasta);
                if (tabla.Rows.Count != 0)
                    ArmarReporteAsiento();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }

            if (Rbu_Todos.Checked)
            {
                tabla = asiento.Reporte_RecuperarTodos();
                if (tabla.Rows.Count != 0)
                    ArmarReporteAsiento();
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
