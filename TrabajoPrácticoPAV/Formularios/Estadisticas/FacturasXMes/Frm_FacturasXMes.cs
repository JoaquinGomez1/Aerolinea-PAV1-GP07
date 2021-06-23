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

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.FacturasXMes
{

    public partial class Frm_FacturasXMes : Form
    {
        NE_Facturacion facturas = new NE_Facturacion();
        public Frm_FacturasXMes()
        {
            InitializeComponent();
        }

        private void Frm_FacturasXFecha_Load(object sender, EventArgs e)
        {

            this.rv_1.RefreshReport();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (rb_1.Checked == true)
            {
                ArmarReporteUsuario01(facturas.RecuperarFacturasXMesTodas());
            }
            else if (rb_2.Checked == true) {
                if(cmb_Meses.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un Mes");
                }
                else
                {
                    int Mes = cmb_Meses.SelectedIndex + 1 ;
                    MessageBox.Show(Mes.ToString());
                    ArmarReporteUsuario01(facturas.RecuperarFacturasXMes(Mes));
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Opcion");
            }
        }
        private void ArmarReporteUsuario01(DataTable tabla) // Aca hay algo mal 
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("Ds_FacturasXMes", tabla);
            rv_1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.FacturasXMes.ReporteFacturasXMes.rdlc";
            rv_1.LocalReport.DataSources.Clear();
            rv_1.LocalReport.DataSources.Add(PaqueteDatos);
            rv_1.RefreshReport();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
