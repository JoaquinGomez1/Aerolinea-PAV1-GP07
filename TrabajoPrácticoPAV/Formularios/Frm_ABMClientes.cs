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

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ABMClientes : Form
    {
        public Frm_ABMClientes()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Frm_Principal frmPri = new Frm_Principal();
        //    frmPri.FormCerrado("Frm_ABMClientes");
        //    this.Close();

        //}



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Cal_fecha_nacimiento_DateChanged(object sender, DateRangeEventArgs e)
        {

            if (((MonthCalendar)sender).SelectionRange.Start > DateTime.Now.Date)
            {
                MessageBox.Show("Fecha inválida seleccione una fecha anterior a la de hoy");
                ((MonthCalendar)sender).Focus();
            }

            MessageBox.Show(((MonthCalendar)sender).SelectionRange.End.ToString());

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
            tratamientos.Validar(this.Controls);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ABMClientes_Load(object sender, EventArgs e)
        {
            Cmb_TipoDoc.CargarCombo();
            Cmb_Pais.CargarCombo();
        }

        private void Cmb_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
