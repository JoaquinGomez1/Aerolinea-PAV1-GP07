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

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.ReservasMes
{
    public partial class Frm_EReservasMes : Form
    {
        DataTable tabla = new DataTable();
        public Frm_EReservasMes()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_EReservasMes_Load(object sender, EventArgs e)
        {

            ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.VueloPorAvion.Estadistica_ReservasMes.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            //if(rd_PorMes.Checked && )
        }
    }
}
