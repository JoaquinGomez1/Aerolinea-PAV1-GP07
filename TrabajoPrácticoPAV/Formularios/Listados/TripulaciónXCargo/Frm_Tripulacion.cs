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

namespace TrabajoPrácticoPAV.Formularios.Listados.Tripulación
{
    public partial class Frm_Tripulacion : Form
    {
        NE_Tripulacion tripulacion = new NE_Tripulacion();
        DataTable tabla = new DataTable();

        public Frm_Tripulacion()
        {
            InitializeComponent();
        }

        private void Frm_Tripulacion_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            cmb_Cargo.CargarCombo();

        }

      

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            
            
            //MessageBox.Show(tabla.Rows.Count.ToString());
            if (rbu_Cargo.Checked)
            {           
                tabla = tripulacion.RecuperarPorCargo(cmb_Cargo.SelectedValue.ToString());
                if (tabla.Rows.Count != 0)
                    ArmarReporteTripulacion01();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }
            if (rbu_RangoId.Checked)
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

                tabla = tripulacion.RecuperarPorRango(desde, hasta);
                if (tabla.Rows.Count != 0)
                    ArmarReporteTripulacion01();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }
            if (rbu_Todos.Checked)
            {
                tabla = tripulacion.RecuperarTripulantes();
                if (tabla.Rows.Count != 0)
                    ArmarReporteTripulacion01();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }
        }

        private void ArmarReporteTripulacion01()
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("Ds_TripulacionXCargo", tabla);            
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.TripulaciónXCargo.ReporteTripulacion.rdlc";   
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport(); 
        }
    }
}
