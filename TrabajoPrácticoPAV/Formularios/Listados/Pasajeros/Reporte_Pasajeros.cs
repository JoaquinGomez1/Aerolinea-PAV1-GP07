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

namespace TrabajoPrácticoPAV.Formularios.Listados.Pasajeros
{
    public partial class Reporte_Pasajeros : Form
    {
        NE_Clientes pasajero = new NE_Clientes();
        DataTable tabla = new DataTable();

        public Reporte_Pasajeros()
        {
            InitializeComponent();
            cmb_ciudad.CargarCombo(); 
        }

        private void Reporte_Pasajeros_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            tabla = pasajero.buscar_todos();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (rbu01.Checked)
            {
                string desde = "";
                string hasta = "";

                if (Txt_Desde.Text == "")
                    desde = "0";
                else
                    desde = Txt_Desde.Text;
                if (Txt_Hasta.Text == "")
                    hasta = "99999999";
                else
                    hasta = Txt_Hasta.Text;

                tabla = pasajero.buscar_por_ranngo_dni(desde, hasta);

                if (tabla.Rows.Count != 0)
                    ArmarReportePasajero(tabla);
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados");
                }

            }
            else if (rbu02.Checked)
            {
                if (txt_apellido.Text != "")
                {
                    tabla = pasajero.buscar_por_apellido(txt_apellido.Text);
                    if (tabla.Rows.Count != 0)
                        ArmarReportePasajero(tabla);
                    else
                    {
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.RefreshReport();
                        MessageBox.Show("No se encontraron resultados para la búsqueda");
                    }

                }
                else
                {
                    MessageBox.Show("Ingrese un apellido");
                }
                

            }
            else if (rbu03.Checked)
            {
                if (cmb_ciudad.SelectedIndex != -1)
                {
                    tabla = pasajero.buscar_por_ciudad(cmb_ciudad.SelectedValue.ToString());
                    if (tabla.Rows.Count != 0)
                        ArmarReportePasajero(tabla);
                    else
                    {
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.RefreshReport();
                        MessageBox.Show("No se encontraron resultados para la búsqueda");
                    }
                }

                else
                {
                    MessageBox.Show("Seleccione ciudad");
                }

            }
            else if (rbu04.Checked)
            {
                tabla = pasajero.buscar_todos();
                if (tabla.Rows.Count != 0)
                    ArmarReportePasajero(tabla);
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    MessageBox.Show("No se encontraron resultados para la búsqueda");
                }
            }
            else
            {
                MessageBox.Show("No seleccionó ninguna opción");
            }
        }
    
        private void ArmarReportePasajero(DataTable tabla)
        {
            ReportDataSource datos = new ReportDataSource("RepoPasajero", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Pasajeros.ReportePasajero.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();
            cmb_ciudad.SelectedIndex = -1;
        }
    }
}
