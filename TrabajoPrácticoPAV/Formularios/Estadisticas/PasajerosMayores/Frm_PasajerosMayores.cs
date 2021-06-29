﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.NE_Usuarios;
using TrabajoPrácticoPAV.Clase;
using Microsoft.Reporting.WinForms;

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.PasajerosMayores
{
    public partial class Frm_PasajerosMayores : Form
    {
        Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
        NE_Clientes pasajero = new NE_Clientes();

        public Frm_PasajerosMayores()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_PasajerosMayores_Load(object sender, EventArgs e)
        {
            DataTable tabla = determineDataSet();
            this.rv_pasajerosMayores.RefreshReport();


            if (tabla.Rows.Count != 0)
                CargarEstadisticaPasajeros(tabla);
            else
            {
                rv_pasajerosMayores.LocalReport.DataSources.Clear();
                rv_pasajerosMayores.RefreshReport();
                MessageBox.Show("No se encontraron resultados para la búsqueda");
            }
        }

        public void CargarEstadisticaPasajeros(DataTable tabla)
        {
            ReportDataSource datos = new ReportDataSource("Ds_EstadisticaPasajerosMayores", tabla);
            rv_pasajerosMayores.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.PasajerosMayores.EstadisticaPasajerosMayores.rdlc";
            rv_pasajerosMayores.LocalReport.DataSources.Clear();
            rv_pasajerosMayores.LocalReport.DataSources.Add(datos);
            rv_pasajerosMayores.RefreshReport();
        }

        private DataTable determineDataSet()
        {
            return pasajero.RecuperarTodos();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
