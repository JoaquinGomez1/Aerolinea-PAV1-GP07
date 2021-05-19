using System;
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
using TrabajoPrácticoPAV.Backend;
using System.Runtime.InteropServices;

namespace TrabajoPrácticoPAV.Formularios.Asientos
{
    public partial class Frm_BajaAsiento : Form
    {
        public string Id_asiento { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        NE_Asiento asiento = new NE_Asiento();
        public Frm_BajaAsiento()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }
        
        private void Frm_BajaAsiento_Load(object sender, EventArgs e)
        {
            cmb_nombreModelo.CargarCombo();
            cmb_numeroAvion.CargarCombo();
            cmb_clase.CargarCombo();

            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            MostrarDatos(asiento.RecuperarXId(Id_asiento));
        }
        private void MostrarDatos(DataTable tabla)
        {
            txt_idasiento.Text = tabla.Rows[0]["numeroAsiento"].ToString();
            cmb_nombreModelo.SelectedValue = int.Parse(tabla.Rows[0]["idModelo"].ToString());
            cmb_numeroAvion.SelectedValue = int.Parse(tabla.Rows[0]["numeroPorModelo"].ToString());
            txt_estado.Text = tabla.Rows[0]["estado"].ToString();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrarAsiento_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                asiento.Borrar(this.Controls);
                this.Close();

            }
        }

        
    }
}
