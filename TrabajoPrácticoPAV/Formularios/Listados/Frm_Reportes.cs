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

namespace TrabajoPrácticoPAV.Formularios.Listados
{
    public partial class Frm_Reportes : Form
    {
        NE_Avion aviones = new NE_Avion();
        public Frm_Reportes()
        {
            InitializeComponent();
        }

        private void Frm_Reportes_Load(object sender, EventArgs e)
        {

            this.Rv_01.RefreshReport();
          
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarAviones();
        }
 
        private void BuscarAviones()
        {
            DataTable tabla = new DataTable();
            if (rbu03.Checked == true)
            {
                tabla = aviones.RecuperarTodosReporte(); // recuperar usuairos sql

                ArmarReporteUsuario01(tabla);
            }
        }

        private void ArmarReporteUsuario01(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
            Rv_01.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Report1.rdlc";
            Rv_01.LocalReport.DataSources.Clear();
            Rv_01.LocalReport.DataSources.Add(PaqueteDatos);
            Rv_01.RefreshReport();
        }

        private void Rv_01_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
