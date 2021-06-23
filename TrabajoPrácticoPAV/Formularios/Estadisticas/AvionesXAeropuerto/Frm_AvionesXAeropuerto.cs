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

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.AvionesXAeropuerto
{
    public partial class Frm_AvionesXAeropuerto : Form
    {
        DataTable tabla = new DataTable();
        NE_Avion avion = new NE_Avion();

        public Frm_AvionesXAeropuerto()
        {
            InitializeComponent();
        }

        private void Frm_AvionesXAeropuerto_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            this.rp_aero.RefreshReport();
        }

        private void ArmarReporteAvionXAero()
        {
            ReportDataSource datos = new ReportDataSource("Aeropuerto", tabla);
            rp_aero.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.AvionesXAeropuerto.Reporte_AvionesAeropuerto.rdlc";
            rp_aero.LocalReport.DataSources.Clear();
            rp_aero.LocalReport.DataSources.Add(datos);
            rp_aero.RefreshReport();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if ((btn_todo.Checked == false) && (btn_rangoAv.Checked == false))
            {
                MessageBox.Show("Seleccione una opción");
                return;
            }
            if (btn_rangoAv.Checked)
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

                tabla = avion.RecuperarAvionesAeropuerto_SegunId(desde, hasta);
                if (tabla.Rows.Count != 0)
                    ArmarReporteAvionXAero();
                else
                {
                    rp_aero.LocalReport.DataSources.Clear();
                    rp_aero.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }

            else if (btn_todo.Checked)
            {
                tabla = avion.RecuperarAvionesAeropuerto();
                if (tabla.Rows.Count != 0)
                {
                    
                    ArmarReporteAvionXAero();
                }
                else
                {
                    rp_aero.LocalReport.DataSources.Clear();
                    rp_aero.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }


        }
    }
}
