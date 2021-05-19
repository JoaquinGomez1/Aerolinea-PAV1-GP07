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
using TrabajoPrácticoPAV.Backend;
using System.Runtime.InteropServices;

namespace TrabajoPrácticoPAV.Formularios.Modelo
{
    public partial class Frm_AltaModelo : Form
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

        NE_Modelo modelo = new NE_Modelo();
        public Frm_AltaModelo()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }
    
        private void Frm_AltaModelo_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            
            Tratamientos_Especiales Tratamiento = new Tratamientos_Especiales();

            if (Tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                Tratamiento.Validar(this.Controls);
                
                modelo.Insertar(this.Controls);
                this.Close();
             
            }
            else
            {
                return;
            }
            
        }

        
    }
}
