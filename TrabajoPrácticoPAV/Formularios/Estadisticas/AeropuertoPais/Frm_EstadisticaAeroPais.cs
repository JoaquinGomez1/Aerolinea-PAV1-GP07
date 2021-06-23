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

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.AeropuertoPais
{
    public partial class Frm_EstadisticaAeroPais : Form
    {
        Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
        NE_Aeropuertos aeropuerto = new NE_Aeropuertos();
        DataTable tabla = new DataTable();

        public Frm_EstadisticaAeroPais()
        {
            InitializeComponent();
        }

        private void Frm_EstadisticaAeroPais_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            Rbutodos.Checked = true;
            this.reportViewer1.RefreshReport();
        }

        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
            if (Rbutodos.Checked == true)
            {
                tabla = aeropuerto.Reporte_EstadisticarecuperarTodos();
                string parametro = "Cantidad de aeropuertos por ciudad";
                if (tabla.Rows.Count != 0)
                    ArmarEstadisticaAeropuertoXpais(parametro);
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
                    tabla = aeropuerto.Reporte_recuperarXletra(txt_letra.Text);
                    string parametro = "Cantidad de Aeropuertos que contienen '" + txt_letra.Text+" '";
                    if (tabla.Rows.Count != 0)
                        ArmarEstadisticaAeropuertoXpais(parametro);
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
            else if (Rbu_ciudad.Checked == true)
            {
                if (txt_ciudad.Text != "")
                {
                    tabla = aeropuerto.Reporte_recuperarXciudad(txt_ciudad.Text);
                    string parametro = "Cantidad de Aeropuertos en la ciudad '" + txt_ciudad.Text+"'";
                    if (tabla.Rows.Count != 0)
                        ArmarEstadisticaAeropuertoXpais(parametro);
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
        public void ArmarEstadisticaAeropuertoXpais(string parametro)
        {
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.AeropuertoPais.Reporte_AeroPais.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("Rp01", parametro);
            reportViewer1.LocalReport.SetParameters(parametros);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();

        }

        
    }
}
