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
        }
        

        private void Frm_ReporteAeroPais_Load_1(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            cmb_pais.CargarCombo();
            tabla = aeropuerto.Reporte_recuperarTodos();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            tabla = aeropuerto.Reporte_recuperarTodos();
                ArmarReporteAeropuertos();

        }
        public void ArmarReporteAeropuertos() 
        {
            ReportDataSource datos = new ReportDataSource("DataSet01", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Aeropuertos.ReporteAeroPais.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();

        }

        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
            if (rbu04.Checked == true)
            {
                tabla = aeropuerto.Reporte_recuperarTodos();
                if (tabla.Rows.Count != 0)
                    ArmarReporteAeropuertos();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados para la búsqueda");
                }
            }
            else if (rbu01.Checked == true)
            {
                if (Txt_nombres.Text != "")
                {
                    MessageBox.Show("entro");
                    tabla = aeropuerto.Reporte_recuperarXNonmbre(Txt_nombres.Text);
                    if (tabla.Rows.Count != 0)
                        ArmarReporteAeropuertos();
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
                if (txt_codigodesde.Text != "" && txt_codigohasta.Text != "")
                {
                    tabla = aeropuerto.Reporte_recuperarXCodigoRango(txt_codigodesde.Text, txt_codigohasta.Text);
                    MessageBox.Show("entro");
                    if (tabla.Rows.Count != 0)
                    {
                        MessageBox.Show("entro");
                        ArmarReporteAeropuertos();
                    }
                    else
                    {
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.RefreshReport();
                        MessageBox.Show("No se encontraron resultados para la búsqueda");
                    }
                }

            }
            //else if (rbu03.Checked == true)
            //{
            //    if (cmb_ciudad.Text != "" && )
            //    {
            //        tabla = aeropuerto.Reporte_recuperarXciudad(cmb_ciudad.Text);
            //        if (tabla.Rows.Count != 0)
            //            ArmarReporteAeropuertos();
            //        else
            //        {
            //            reportViewer1.LocalReport.DataSources.Clear();
            //            reportViewer1.RefreshReport();
            //            MessageBox.Show("No se encontraron resultados para la búsqueda");
            //        }
            //    }
            //}
            else if (rbu03.Checked == true)
            {
                if (cmb_pais.SelectedIndex != -1)
                {
                    tabla = aeropuerto.Reporte_recuperarXpais(cmb_pais.SelectedValue.ToString());
                    if (tabla.Rows.Count != 0)
                        ArmarReporteAeropuertos();
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

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_ciudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
