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
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.FacturasXPago
{
    public partial class Frm_FacturasXPago : Form
    {
        NE_Facturacion facturas = new NE_Facturacion();

        public Frm_FacturasXPago()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Frm_FacturasXPago_Load(object sender, EventArgs e)
        {

            this.rv_1.RefreshReport();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (rb_1.Checked == true)
            {
                ArmarReporteUsuario01(facturas.RecuperarFacturasXPagoTodas());
            }
            else if (rb_2.Checked == true)
            {
                if (cmb_Pagos.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un Mes");
                }
                else
                {
                    int Pago = cmb_Pagos.SelectedIndex + 1;
                    MessageBox.Show(Pago.ToString());
                    ArmarReporteUsuario01(facturas.RecuperarFacturasXPago(Pago));
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Opcion");
            }
        }
        private void ArmarReporteUsuario01(DataTable tabla) // Aca hay algo mal 
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("Ds_FacturasXPago", tabla);
            rv_1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.FacturasXPago.ReporteFacturasXPago.rdlc";
            rv_1.LocalReport.DataSources.Clear();
            rv_1.LocalReport.DataSources.Add(PaqueteDatos);
            rv_1.RefreshReport();
        }
    }
}
