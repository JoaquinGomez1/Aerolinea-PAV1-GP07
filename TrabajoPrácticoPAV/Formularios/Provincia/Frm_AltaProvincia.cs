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
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;

namespace TrabajoPrácticoPAV.Formularios.Provincia
{
    public partial class Frm_AltaProvincia : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        Tratamientos_Especiales _TE = new Tratamientos_Especiales();
        Conexion_DB _BD = new Conexion_DB();

        public Frm_AltaProvincia()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registar_Click(object sender, EventArgs e)
        {
            if (_TE.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                string sql = _TE.CostructorInsert("Provincia", this.Controls);
                _BD.Insertar(sql, false);
                this.Close();
            }
        }

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void Frm_AltaProvincia_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            cmb_Pais.CargarCombo();
        }
    }
}
