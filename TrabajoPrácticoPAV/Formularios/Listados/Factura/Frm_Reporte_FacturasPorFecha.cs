using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.NE_Usuarios;
using Microsoft.Reporting.WinForms;
using static TrabajoPrácticoPAV.Clase.Tratamientos_Especiales;
using System.Globalization;
using System.Runtime.InteropServices;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;


namespace TrabajoPrácticoPAV.Formularios.Listados.Factura
{
    public partial class Frm_Reporte_FacturasPorFecha : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        NE_Facturacion facturacion = new NE_Facturacion();
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();
        public Frm_Reporte_FacturasPorFecha()
        {
            InitializeComponent();
        }
        private void Frm_Reporte_FacturasPorFecha_Load(object sender, EventArgs e)
        {
            this.rv_Facturas.RefreshReport();
        }
        private void Calcular_Datos()
        {
            if (txt_idFactura.Pp_Text == "" && (txt_fecha_desde.Text == ""
                && txt_fecha_hasta.Text == "" ) && rb_buscarTodas.Checked == false)
            {
                MessageBox.Show("No ha seleccionado ninguna restricción para la búsqueda");
                return;
            }

            DataTable tabla = new DataTable();
            if (rb_buscarTodas.Checked == true)
            {
                tabla = facturacion.Reporte_Factura_Todas();
                Armar_Reporte_Factura(tabla);
                return;
            }
            if (rb_buscarPorId.Checked == true )
            {
                if(txt_idFactura.Pp_Text == "")
                {
                    MessageBox.Show("Debe ingresar el id de factura para realizar la búsqueda");
                    return;
                }
                else
                {
                    tabla = facturacion.Reporte_Factura_PorID(int.Parse(txt_idFactura.Pp_Text));
                    Armar_Reporte_Factura(tabla);
                }
            }
            if (rb_buscarPorFechas.Checked == true)
            {
                Resultado validarFechaDesde = _TE.ValidarFecha(txt_fecha_desde.Text);
                Resultado validarFechaHasta = _TE.ValidarFecha(txt_fecha_hasta.Text);
                if (validarFechaDesde == Resultado.error | validarFechaHasta == Resultado.error)
                {
                    MessageBox.Show("Debe ingresar los valores en fecha desde y hasta en el formato 'aaaa-mm-dd'");
                    return;
                }
                else
                {
                    tabla = facturacion.Reporte_Factura_PorFecha(txt_fecha_desde.Text, txt_fecha_hasta.Text);
                    Armar_Reporte_Factura(tabla);
                }
            }
        }
        private void Armar_Reporte_Factura(DataTable tabla)
        {
            ReportDataSource paqueteDatos = new ReportDataSource("DataSet_FacturaPorFecha", tabla);
            rv_Facturas.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Listado_FacturaPorFecha.rdlc";
            rv_Facturas.LocalReport.DataSources.Clear();
            rv_Facturas.LocalReport.DataSources.Add(paqueteDatos);
            rv_Facturas.RefreshReport();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Calcular_Datos();
        }
    }
}
