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

namespace TrabajoPrácticoPAV.Formularios.Listados.Avion_Por_Modelo
{
    public partial class Frm_AvionPorModelo : Form
    {
        private readonly NE_Avion _NE = new NE_Avion();
        Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
        DataTable tabla = new DataTable();

        public Frm_AvionPorModelo()
        {
            InitializeComponent();

        }
        private void Frm_AvionPorModelo_Load(object sender, EventArgs e)
        {
            cmb_idModelo.CargarCombo();
            cmb_numModelo.CargarCombo();
            this.rv_avionPorModelo.RefreshReport();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            tabla = _NE.RecuperarTodos();
        }

        // Carga Report Viewer
        private void ArmarReporteUsuario(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("Ds_AvionPorModelo", tabla);
            rv_avionPorModelo.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Avion_Por_Modelo.ReporteAvionPorModelo.rdlc";
            rv_avionPorModelo.LocalReport.DataSources.Clear();
            rv_avionPorModelo.LocalReport.DataSources.Add(PaqueteDatos);
            rv_avionPorModelo.RefreshReport();
        }

        private DataTable determineDataSet()
        {
            string numModelo = cmb_numModelo.Text;
            string idModelo = cmb_idModelo.Text;
            DataTable table = _NE.RecuperarTodos();

            if (Rb_Todos.Checked)
            {
                table = _NE.RecuperarTodos();
                if (tabla.Rows.Count != 0)
                   ArmarReporteUsuario(table);
                else
                {
                    rv_avionPorModelo.LocalReport.DataSources.Clear();
                    rv_avionPorModelo.RefreshReport();
                    MessageBox.Show("No se encontraron resultados para la búsqueda");
                }
            }

            if (Rb_numModelo.Checked)
            {
                if (numModelo != null)
                {
                    table = _NE.RecuperarPorNumModelo(numModelo);
                    if (tabla.Rows.Count != 0)
                        ArmarReporteUsuario(table);
                    else
                    {
                        rv_avionPorModelo.LocalReport.DataSources.Clear();
                        rv_avionPorModelo.RefreshReport();
                        MessageBox.Show("No se encontraron resultados para la búsqueda");
                    }
                }
            }

            if (Rb_idModelo.Checked)
            {
                if (idModelo != null)
                {

                    table = _NE.RecuperarPorIdModelo(idModelo);
                    if (tabla.Rows.Count != 0)
                        ArmarReporteUsuario(table);
                    else
                    {
                        rv_avionPorModelo.LocalReport.DataSources.Clear();
                        rv_avionPorModelo.RefreshReport();
                        MessageBox.Show("No se encontraron resultados para la búsqueda");
                    }
                }

            }
            return table;
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            DataTable dataSet = determineDataSet();
            ArmarReporteUsuario(dataSet);
        }


    }
}
