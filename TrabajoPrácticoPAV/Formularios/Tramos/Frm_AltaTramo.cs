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

namespace TrabajoPrácticoPAV.Formularios.Tramos
{
    public partial class Frm_AltaTramo : Form
    {
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();
        Conexion_DB _BD = new Conexion_DB();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Frm_AltaTramo()
        {
            InitializeComponent();
        }

        private void Frm_AltaTramo_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            cmb_ADestino.CargarCombo();
            cmb_ASalida.CargarCombo();
            
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            if (_TE.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                if (cmb_ADestino.SelectedIndex != cmb_ASalida.SelectedIndex)
                {
                    _TE.Validar(this.Controls);
                    string sql = _TE.CostructorInsert("Tramo", this.Controls);
                    _BD.Insertar(sql, false);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Los aeropuertos de salida y destino no pueden ser el mismo.");
                    cmb_ASalida.Focus();
                }
            }
            else
            {
                return;
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
