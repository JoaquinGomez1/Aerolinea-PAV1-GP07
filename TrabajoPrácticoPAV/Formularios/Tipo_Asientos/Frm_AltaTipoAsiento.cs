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
using TrabajoPrácticoPAV.Backend;
using System.Runtime.InteropServices;

namespace TrabajoPrácticoPAV.Formularios.Tipo_Asientos
{
    public partial class Frm_AltaTipoAsiento : Form
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

        public Frm_AltaTipoAsiento()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();

        private void Frm_AltaTipoAsiento_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Conexion_DB _BD = new Conexion_DB();

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            string sql = _TE.CostructorInsert("Tipo_Asiento", panel1.Controls);
            _BD.Insertar(sql, false);
            this.Close();
            //MessageBox.Show("Asiento insertado correctamente.");
            
        }

        
    }
}
