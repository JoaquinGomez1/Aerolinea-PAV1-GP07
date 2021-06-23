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

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.VueloPorAvion
{
    public partial class Frm_EVueloPorAvion : Form
    {
        NE_Vuelos vuelo_x_avion = new NE_Vuelos();
        DataTable tabla = new DataTable();

        public Frm_EVueloPorAvion()
        {
            InitializeComponent();
        }

        private void Frm_EVueloPorAvion_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            cmb_NomModelo.CargarCombo();
            
        }
        private void ArmarEstadisticaVueloPorAvion01()
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.VueloPorAvion.Estadistica_VueloPorAvion.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
           

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (rd_PorModelo.Checked && cmb_NomModelo.SelectedIndex != -1)
            {
                tabla = vuelo_x_avion.E_RecuperarPorModelo(cmb_NomModelo.SelectedValue.ToString());
                ArmarEstadisticaVueloPorAvion01();

            }
            else if(rd_PorModelo.Checked && cmb_NomModelo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccionar modelo");
            }

            if (rd_Todos.Checked)
            {
                tabla = vuelo_x_avion.E_RecuperarTodos();
                ArmarEstadisticaVueloPorAvion01();
            }

        }
    }
}
