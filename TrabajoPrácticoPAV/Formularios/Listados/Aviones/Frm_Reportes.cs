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

            this.reportViewer1.RefreshReport();
            cmb_modelos.CargarCombo();
            cmb_modelos.SelectedIndex = -1;
            this.reportViewer1.RefreshReport();
        }
        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            BuscarAviones();
        }
        private void BuscarAviones()
        {
            string id = txt_id.Text;
            string modelo = cmb_modelos.Text;
            DataTable tabla = new DataTable();
            // Busca Por Modelo
            if (rbu01.Checked == true)
            {
                if (cmb_modelos.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un Modelo");
                }
                else
                {

                    ArmarReporteUsuario01(aviones.Recuperar_x_modelo(modelo));
                }
            }
            // Busca Por Id
            if (rbu02.Checked == true)
            {
                if (txt_id.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese un Id valido");
                }
                else
                {
                    ArmarReporteUsuario01(aviones.Recuperar_x_numero(id));
                }
            }
            // Busca Todos
            if (rbu03.Checked == true)
            {
                MessageBox.Show("si");
                tabla = aviones.RecuperarTodosReporte(); // BuscarAviones() anda
                ArmarReporteUsuario01(tabla);
            }
        }

        // Carga Report Viewer
        private void ArmarReporteUsuario01(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Aviones.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }

        private void Rv_01_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_modelos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
