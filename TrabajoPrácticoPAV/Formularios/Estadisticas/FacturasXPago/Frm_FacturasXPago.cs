using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.FacturasXPago
{
    public partial class Frm_FacturasXPago : Form
    {
        private NE_Facturacion facturas = new NE_Facturacion();

        public Frm_FacturasXPago()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            this.CenterToScreen();
        }

        private void Frm_FacturasXPago_Load(object sender, EventArgs e)
        {
            rb_1.Checked = true;
            this.rv_1.RefreshReport();
            rv_1.LocalReport.DataSources.Clear();
            rv_1.RefreshReport();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (rb_1.Checked == true)
            {
                ArmarReporteUsuario01(facturas.RecuperarFacturasXPagoTodas());
            }
            else if (rb_2.Checked == true)
            {
                string desde = "";
                string hasta = "";

                if (msk_annoDesde.Text == "")
                    desde = "0";
                else
                    desde = msk_annoDesde.Text;
                if (msk_annoHasta.Text == "")
                    hasta = "99999";
                else
                    hasta = msk_annoHasta.Text;

                DataTable tabla = facturas.RecuperarFacturasXPago(desde, hasta);
                ArmarReporteUsuario01(tabla);
            }
        }

        private void ArmarReporteUsuario01(DataTable tabla) // Aca hay algo mal
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
            rv_1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.FacturasXPago.ReporteFacturaXPago.rdlc";
            rv_1.LocalReport.DataSources.Clear();
            rv_1.LocalReport.DataSources.Add(PaqueteDatos);
            rv_1.RefreshReport();
        }
    }
}