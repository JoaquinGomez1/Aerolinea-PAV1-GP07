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
using TrabajoPrácticoPAV.Formularios.Listados.Aeropuertos;

namespace TrabajoPrácticoPAV.Formularios.Listados.Pasajeros
{
    public partial class Frm_ReporteFamiliareXPasajero : Form
    {
        NE_GrupoFamiliar grupo = new NE_GrupoFamiliar();

        public Frm_ReporteFamiliareXPasajero()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);


            reportViewer1.RefreshReport();
            DataTable tabla = new DataTable();
            tabla = grupo.RecuperarTodos();
            ArmarReporteAeropuertos(tabla);
        }

        private void Frm_ReporteFamiliareXPasajero_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);


            //reportViewer1.RefreshReport();
            //DataTable tabla = new DataTable();
            //tabla = grupo.RecuperarTodos();
            //ArmarReporteAeropuertos(tabla);

        }
        private void ArmarReporteAeropuertos(DataTable table)
        {
            MessageBox.Show("tabla " + table.Rows.Count);
            ReportDataSource datos = new ReportDataSource("FamiliarXPasajero", table);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Pasajeros.ReporteFamiliareXPasajero.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datos);
            reportViewer1.RefreshReport();

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
           
            //reportViewer1.RefreshReport();
            //DataTable tabla = new DataTable();
            //tabla = grupo.RecuperarTodos();
            //ArmarReporteAeropuertos(tabla);
        }
    }
}
