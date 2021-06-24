using System;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;
using Microsoft.Reporting.WinForms;

namespace TrabajoPrácticoPAV.Formularios.Listados.Pasajeros
{
    public partial class Frm_ReporteFamiliareXPasajero : Form
    {
        private NE_GrupoFamiliar grupo = new NE_GrupoFamiliar();
        private DataTable tabla = new DataTable();

        public Frm_ReporteFamiliareXPasajero()
        {
            InitializeComponent();
        }

        private void Frm_ReporteFamiliareXPasajero_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            tabla = grupo.RecuperarTodos();
        }

        private void ArmarReportePasajeroxfamiliar()
        {
            MessageBox.Show("tabla " + tabla.Rows.Count);
            ReportDataSource datos = new ReportDataSource("FamiliarXPasajero", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Pasajeros.ReporteFamiliareXPasajero.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (rbu04.Checked == true)
            {
                tabla = grupo.RecuperarTodos();
                if (tabla.Rows.Count != 0)
                    ArmarReportePasajeroxfamiliar();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados para la búsqueda");
                }
            }
            else if (rbu01.Checked == true)
            {
                if (Msktxt_NumDocTitular.Text != "")
                {
                    tabla = grupo.Reporte_recuperarNumDocTitular(Msktxt_NumDocTitular.Text);
                    if (tabla.Rows.Count != 0)
                        ArmarReportePasajeroxfamiliar();
                    else
                    {
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.RefreshReport();
                        MessageBox.Show("No se encontraron resultados para la búsqueda");
                    }
                }
            }
            else if (rbu02.Checked == true)
            {
                if (Msktxt_NumDocFamiliar.Text != "")
                {
                    tabla = grupo.Reporte_recuperarNumDocFamiliar(Msktxt_NumDocFamiliar.Text);
                    if (tabla.Rows.Count != 0)
                        ArmarReportePasajeroxfamiliar();
                    else
                    {
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.RefreshReport();
                        MessageBox.Show("No se encontraron resultados para la búsqueda");
                    }
                }
            }
            else if (rbu03.Checked == true)
            {
                if (txt_parentesco.Text != "")
                {
                    tabla = grupo.Reporte_recuperarXParentesco(txt_parentesco.Text);
                    if (tabla.Rows.Count != 0)
                        ArmarReportePasajeroxfamiliar();
                    else
                    {
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.RefreshReport();
                        MessageBox.Show("No se encontraron resultados para la búsqueda");
                    }
                }
            }
            else
            {
                Tratamientos_Especiales Tratamiento = new Tratamientos_Especiales();
                if (Tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.error)
                {
                    MessageBox.Show("No realizo selección para la búsqueda");
                }
            }
        }
    }
}