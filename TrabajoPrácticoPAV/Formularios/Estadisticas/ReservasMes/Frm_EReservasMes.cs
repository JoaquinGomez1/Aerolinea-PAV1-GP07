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

namespace TrabajoPrácticoPAV.Formularios.Estadisticas.ReservasMes
{
    public partial class Frm_EReservasMes : Form
    {
        NE_Reserva reservaMes = new NE_Reserva();
        DataTable tabla = new DataTable();

        public Frm_EReservasMes()
        {
            InitializeComponent();
            
        }

        private void Frm_EReservasMes_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
           
        }
        private void ArmarEstadisticaReservaMes(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("Ds_ReservasMes", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.ReservasMes.Estadistica_ReservasMes.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (rd_PorMes.Checked && msk_Mes.Text != " ")
            {
                tabla = reservaMes.E_ResuperarPorMes(msk_Mes.Text.ToString());
                ArmarEstadisticaReservaMes(tabla);
            }
            else if (rd_PorMes.Checked && msk_Mes.Mask == " ")
            {
                MessageBox.Show("Por favor, ingresar una fecha");
            }
            if (rd_Todos.Checked) 
            {
                tabla = reservaMes.ES_RecuperarTodosReservas();
                //MessageBox.Show("1");
                ArmarEstadisticaReservaMes(tabla); 
            }
        }
    }
}
