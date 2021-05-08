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

namespace TrabajoPrácticoPAV.Formularios.Pais
{
    public partial class Frm_ModificarPais : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        Tratamientos_Especiales _TE = new Tratamientos_Especiales();
        Conexion_DB _BD = new Conexion_DB();

        public string id_pais { get; set; }
        public string nombre_pais { get; set; }

        public Frm_ModificarPais()
        {
            InitializeComponent();
        }

        private void Frm_ModificarPais_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            txt_idPais.Text = id_pais;
            txt_nombre.Text = nombre_pais;
        }

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (_TE.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                string sql = _TE.CostructorUpdateDelete("Pais", this.Controls, true);
                _BD.Modificar(sql);
                this.Close();
            }
            
        }
    }
}
