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
using TrabajoPrácticoPAV.Formularios.Reservas;

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ABMReservas : Form
    {
        private readonly Frm_ModificarReserva modificarReserva = new Frm_ModificarReserva();

        public Frm_ABMReservas()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ABMReservas_Load(object sender, EventArgs e)
        {
            // Cargar la fecha actual
            lbl_currentDate.Text = DateTime.UtcNow.ToString("dd-MM-yyyy");
            cmb_claseAsiento.CargarCombo();
            cmb_tipoDoc.CargarCombo();
            grid_pasajeros.Formatear();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            modificarReserva.ShowDialog();
        }
    }
}
