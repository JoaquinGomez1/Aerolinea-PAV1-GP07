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
using System.Runtime.InteropServices;

namespace TrabajoPrácticoPAV.Formularios.Aeropuertos
{
    public partial class Frm_Alta_Aeropuerto : Form
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

        public Frm_Alta_Aeropuerto()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }


        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales Tratamiento = new Tratamientos_Especiales();
            if(Tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                NE_Aeropuertos aeropuerto = new NE_Aeropuertos();
                aeropuerto.Pp_codigo = txt_codigo.Text;
                aeropuerto.Pp_nombre = txt_nombre.Text;
                aeropuerto.Pp_idCiudad = cmb_ciudades.SelectedValue.ToString();
                aeropuerto.Insertar();
                this.Close();
            }
        }

        private void Frm_Alta_Aeropuerto_Load(object sender, EventArgs e)
        {
            cmb_ciudades.CargarCombo();
        }

        private void cmb_ciudades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
