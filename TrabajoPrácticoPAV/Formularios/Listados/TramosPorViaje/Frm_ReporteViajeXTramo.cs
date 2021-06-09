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

namespace TrabajoPrácticoPAV.Formularios.Listados.Tramos_por_viaje
{
    public partial class Frm_ReporteViajeXTramo : Form
    {
        NE_Tramos tramos = new NE_Tramos();
        private object cmb_Modelo;

        public Frm_ReporteViajeXTramo()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            if (rb_Todos.Checked==true)
            {
                tabla = tramos.buscar_todos_tramos();
                if (tabla.Rows.Count != 0)
                    ArmarReporteTramos(tabla);
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }               
            }

            else if (rb_NumViaje.Checked==true)
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

                tabla = tramos.buscar_por_ranngo_viaje(desde, hasta);

                if (tabla.Rows.Count != 0)
                    ArmarReporteTramos(tabla);
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }
            
            else if (rbr_AeroSalida.Checked == true)
            {
                if (cmb_aeropuertoSalida.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un aeropuerto de salida");
                }
                else
                {
                    tabla = tramos.buscar_por_aeropuerto_salida(cmb_aeropuertoSalida.SelectedValue.ToString());
                    if (tabla.Rows.Count != 0)
                    {
                        ArmarReporteTramos(tabla);
                        cmb_aeropuertoSalida.SelectedValue = -1;
                    }

                    else
                    {
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.RefreshReport();
                        MessageBox.Show("No se encontraron resultados");
                        cmb_aeropuertoSalida.SelectedValue = -1;
                    }

                }
                
            }

            else if (rb_AeroDestino.Checked == true)
            {
                if (cmb_aeropuertoDestino.SelectedIndex == -1 )
                {
                    MessageBox.Show("Seleccione un aeropuerto de destino");
                }
                else
                {
                    tabla = tramos.buscar_por_aeropuerto_destino(cmb_aeropuertoDestino.SelectedValue.ToString());
                    if (tabla.Rows.Count != 0)
                    {
                        ArmarReporteTramos(tabla);
                        cmb_aeropuertoDestino.SelectedValue = -1;
                    }

                    else
                    {
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.RefreshReport();
                        MessageBox.Show("No se encontraron resultados");
                        cmb_aeropuertoDestino.SelectedValue = -1;
                    }
                }
               
            }

            else
            {
                MessageBox.Show("Seleccione una opción");
            }


        }
   
        private void ArmarReporteTramos(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DS_ViajeXTramo", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.TramosPorViaje.Rpr_ViajeXTramos.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }

        private void Frm_ReporteViajeXTramo_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);           
            //this..RefreshReport();
            cmb_aeropuertoDestino.CargarCombo();
            cmb_aeropuertoSalida.CargarCombo();
            this.reportViewer1.RefreshReport();
        }
    }
}
