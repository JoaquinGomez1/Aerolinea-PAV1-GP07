using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Aeropuertos
{
    public partial class Frm_Mostrar_Aeropuerto : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public string Id_codigo { get; set; }
        public Frm_Mostrar_Aeropuerto()
        {
            InitializeComponent();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_codigo.Text = tabla.Rows[0]["codigo"].ToString();
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
            cmb_ciudad.SelectedValue = int.Parse(tabla.Rows[0]["idCiudad"].ToString());
        }

        private void Frm_Mostrar_Aeropuerto_Load(object sender, EventArgs e)
        {
            cmb_ciudad.CargarCombo();

            NE_Aeropuertos aeropuerto = new NE_Aeropuertos();
            MostrarDatos(aeropuerto.Recuperar_por_Codigo(Id_codigo));
        }
    }
}
