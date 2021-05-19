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

namespace TrabajoPrácticoPAV.Formularios.Modelo
{
    public partial class Frm_ConsultaModelo : Form
    {
        public string Id_modelo { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);
        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Frm_ConsultaModelo()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_ConsultaModelo_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            NE_Modelo modelo = new NE_Modelo();
            MostrarDatos(modelo.RecuperarXId(Id_modelo));
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_codigoModelo.Text = tabla.Rows[0]["idModelo"].ToString();
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
