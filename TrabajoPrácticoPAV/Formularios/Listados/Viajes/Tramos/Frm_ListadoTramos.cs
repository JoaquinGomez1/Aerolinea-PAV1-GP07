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
using Microsoft.Reporting.WinForms;

namespace TrabajoPrácticoPAV.Formularios.Listados.Viajes.Tramos
{
    public partial class Frm_ListadoTramos : Form
    {
        Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
        DataTable tabla = new DataTable();
        NE_Tramos tramo = new NE_Tramos();

        public Frm_ListadoTramos()
        {
            InitializeComponent();
        }

        private void Frm_ListadoTramos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD3K6G07_2021DataSet1.Tramo' Puede moverla o quitarla según sea necesario.
            //this.tramoTableAdapter.Fill(this.bD3K6G07_2021DataSet1.Tramo);

            this.rv_tramos.RefreshReport();
            cmb_origen.CargarCombo();
            cmb_destino.CargarCombo();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            tabla = tramo.RecuperarTodos();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
        
            if (rbu_todos.Checked == true)
            {
                tabla = tramo.RecuperarTodos();
                if (tabla.Rows.Count != 0)
                    CargarListadoTramos();
                else
                {
                    rv_tramos.LocalReport.DataSources.Clear();
                    rv_tramos.RefreshReport();
                    MessageBox.Show("No se encontraron resultados para la búsqueda");
                }
            }
            else if (rbu_origen.Checked == true)
            {
                if (cmb_origen.Text != null)
                {
                    tabla = tramo.RecuperarPorCodigoSalida(cmb_origen.Text);
                    if (tabla.Rows.Count != 0)
                        CargarListadoTramos();
                    else
                    {
                        rv_tramos.LocalReport.DataSources.Clear();
                        rv_tramos.RefreshReport();
                        MessageBox.Show("No se encontraron resultados para la búsqueda");
                    }
                }

            }
            else if (rbu_destino.Checked == true)
            {
                if (cmb_destino.Text != null)
                {
                    tabla = tramo.RecuperarPorCodigoDestino(cmb_destino.Text);
                    if (tabla.Rows.Count != 0)
                        CargarListadoTramos();
                    else
                    {
                        rv_tramos.LocalReport.DataSources.Clear();
                        rv_tramos.RefreshReport();
                        MessageBox.Show("No se encontraron resultados para la búsqueda");
                    }
                }

            }
            else if (rbu_duracion.Checked == true)
            {
                if (txt_duracion.Text != "")
                {
                    tabla = tramo.RecuperarPorDuracion(Int32.Parse(txt_duracion.Text));
                    if (tabla.Rows.Count != 0)
                        CargarListadoTramos();
                    else
                    {
                        rv_tramos.LocalReport.DataSources.Clear();
                        rv_tramos.RefreshReport();
                        MessageBox.Show("No se encontraron resultados para la búsqueda");
                    }
                }
            }
            else if (rbu_distancia.Checked == true)
            {
                if (txt_distancia.Text != "")
                {
                    tabla = tramo.RecuperarPorDuracion(Int32.Parse(txt_distancia.Text));
                    if (tabla.Rows.Count != 0)
                        CargarListadoTramos();
                    else
                    {
                        rv_tramos.LocalReport.DataSources.Clear();
                        rv_tramos.RefreshReport();
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
        public void CargarListadoTramos()
        {
            ReportDataSource datos = new ReportDataSource("Ds_ReporteTramos", tabla);
            rv_tramos.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Viajes.Tramos.ReporteTramos.rdlc";
            rv_tramos.LocalReport.DataSources.Clear();
            rv_tramos.LocalReport.DataSources.Add(datos);
            rv_tramos.RefreshReport();
        }
    }
}
