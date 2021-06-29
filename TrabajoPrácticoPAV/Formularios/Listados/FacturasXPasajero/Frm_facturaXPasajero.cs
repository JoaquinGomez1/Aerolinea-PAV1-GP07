using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Listados.FacturasXPasajero
{
    public partial class Frm_facturaXPasajero : Form
    {
        private DataTable tabla = new DataTable();
        private NE_Facturacion factura = new NE_Facturacion();

        public Frm_facturaXPasajero()
        {
            InitializeComponent();
        }

        private void Frm_facturaXPasajero_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            this.reportViewer1.RefreshReport();
            cmb_TipoDoc.CargarCombo();
        }

        private void ArmarReporteEquipaje01()
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("facturaPasajero", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.FacturasXPasajero.Rp_FxP.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (rbu_Pasajero.Checked == false && rbu_Rango.Checked == false && rbu_Todos.Checked == false)
            {
                MessageBox.Show("Seleccione una opción");
                return;
            }
            else if ((rbu_Pasajero.Checked && cmb_TipoDoc.SelectedIndex != -1) && (rbu_Pasajero.Checked && msk_NroDoc.Text != ""))
            {
                tabla = factura.RecuperarPorPasajero(cmb_TipoDoc.SelectedValue.ToString(), msk_NroDoc.Text);
                if (tabla.Rows.Count != 0)
                    ArmarReporteEquipaje01();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }
            else if ((rbu_Pasajero.Checked && cmb_TipoDoc.SelectedIndex == -1) || (rbu_Pasajero.Checked && msk_NroDoc.Text != " "))
            {
                MessageBox.Show("Ingrese los parametros a buscar.");
                return;
            }
            else if (rbu_Rango.Checked)
            {
                string desde = "";
                string hasta = "";

                if (txt_Desde.Text == "")
                    desde = "0";
                else
                    desde = txt_Desde.Text;
                if (txt_Hasta.Text == "")
                    hasta = "99999999";
                else
                    hasta = txt_Hasta.Text;

                tabla = factura.RecuperarPorRangoDoc(desde, hasta);
                if (tabla.Rows.Count != 0)
                    ArmarReporteEquipaje01();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }
            else if (rbu_Todos.Checked)
            {
                tabla = factura.RecuperarFacturaTodos();
                if (tabla.Rows.Count != 0)
                    ArmarReporteEquipaje01();
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }
            }
        }
    }
}