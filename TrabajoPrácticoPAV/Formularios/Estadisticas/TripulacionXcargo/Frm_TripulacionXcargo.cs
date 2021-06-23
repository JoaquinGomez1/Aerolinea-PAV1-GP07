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
using TrabajoPrácticoPAV.Formularios;

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.TripulacionXcargo
{
    public partial class Frm_TripulacionXcargo : Form
    {
        Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
        NE_Tripulacion tripulacion = new NE_Tripulacion();
        DataTable tabla = new DataTable();
        string parametro;
        public Frm_TripulacionXcargo()
        {
            InitializeComponent();
        }

        private void Frm_TripulacionXcargo_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            Rbutodos.Checked = true;
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

        }
        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
            if (Rbutodos.Checked == true)
            {
                tabla = tripulacion.Reporte_EstadisticarecuperarTodos();
                parametro = "Porcentaje de tripulacion por cargos ";
                if (tabla.Rows.Count != 0)
                    ArmarEstadisticaTripulacionXcargo(parametro);
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados para la búsqueda");
                }
            }
            else if (Rbu_porLetra.Checked == true)
            {
                if (txt_letra.Text != "")
                {
                    tabla = tripulacion.Reporte_recuperarXCargoLetra(txt_letra.Text);
                    parametro = "Porcentaje de cargos que empiecen con la letra " + Rbu_porLetra.Text;
                    if (tabla.Rows.Count != 0)
                        ArmarEstadisticaTripulacionXcargo(parametro);
                    else
                    {
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.RefreshReport();
                        MessageBox.Show("No se encontraron resultados para la búsqueda");
                    }
                }
                else
                    MessageBox.Show("Por favor ingrese un nombre para realizar la búsqueda");
            }
            else if (Rbu_tripulacion.Checked == true)
            {
                if (txt_nombreT.Text != "")
                {
                    tabla = tripulacion.Reporte_recuperarXNombreTrip(txt_nombreT.Text);
                    parametro = "Porcentaje de tripulantes con cargos que contengan " + txt_nombreT.Text;
                    if (tabla.Rows.Count != 0)
                        ArmarEstadisticaTripulacionXcargo(parametro);
                    else
                    {
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.RefreshReport();
                        MessageBox.Show("No se encontraron resultados para la búsqueda");
                    }
                }
                else
                    MessageBox.Show("Por favor ingrese un nombre para realizar la búsqueda");
            }
            else
            {
                Tratamientos_Especiales Tratamiento = new Tratamientos_Especiales();
                if (Tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.error)
                    MessageBox.Show("No realizo selección para la búsqueda");
            }
        }
        

        
        public void ArmarEstadisticaTripulacionXcargo(string parametro)
        {
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.TripulacionXcargo.Reporte_TripulacionPorVuelo.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("Rp01", parametro);
            reportViewer1.LocalReport.SetParameters(parametros);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();

        }
        
    }
}
