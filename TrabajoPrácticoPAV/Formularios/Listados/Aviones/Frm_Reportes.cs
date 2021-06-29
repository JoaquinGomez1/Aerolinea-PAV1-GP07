﻿using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Listados
{
    public partial class Frm_Reportes : Form
    {
        private NE_Avion aviones = new NE_Avion();

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

        private void BuscarAviones()
        {
            string id = txt_id.Text;
            string modelo = cmb_modelos.Text;
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
                DataTable tabla = aviones.RecuperarTodosReporte(); 
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

        private void button_Aerolinea1_Click(object sender, EventArgs e)
        {
            BuscarAviones();
        }
    }
}