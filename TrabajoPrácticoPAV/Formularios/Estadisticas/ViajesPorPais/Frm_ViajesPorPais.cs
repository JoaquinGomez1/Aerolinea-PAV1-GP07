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
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesPorPais
{
    public partial class Frm_ViajesPorPais : Form
    {
        private NE_Viajes viajes = new NE_Viajes();

        public Frm_ViajesPorPais()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_ViajesPorPais_Load(object sender, EventArgs e)
        {
            this.rv_1.RefreshReport();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (rb_1.Checked == true)
            {
                ArmarReporteUsuario01(viajes.RecuperarViajesPorPais());
            }
            else if (rb_2.Checked == true)
            {
                string letra = txt_letras.Text;
                if (letra.Length == 0)
                {
                    MessageBox.Show("Escriba una letra");
                }
                else
                {
                    ArmarReporteUsuario01(viajes.RecuperarViajesPorPaisFiltro(letra));
                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar Una Opcion");
            }
        }

        private void ArmarReporteUsuario01(DataTable tabla) // Aca hay algo mal
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("Ds_ViajesPorPais", tabla);
            rv_1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesPorPais.ReporteViajesPorPais.rdlc";
            rv_1.LocalReport.DataSources.Clear();
            rv_1.LocalReport.DataSources.Add(PaqueteDatos);
            rv_1.RefreshReport();
        }

        private void textBox_Aerolinea1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}