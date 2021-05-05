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
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Tramos
{
    public partial class Frm_ConsultaTramo : Form
    {
        public Frm_ConsultaTramo()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        public string codigoASalida { get; set; }
        public string codigoADestino { get; set; }

        NE_Tramos _NE = new NE_Tramos();
        Conexion_DB _BD = new Conexion_DB();
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ConsultaTramo_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            cmb_ADestino.CargarCombo(); cmb_ADestino.SelectedValue = codigoADestino;
            cmb_ASalida.CargarCombo(); cmb_ASalida.SelectedValue = codigoASalida;

            string sql = $"SELECT * FROM Tramo WHERE codigoAeropuertoSalida = '{codigoASalida}' " +
                $"AND codigoAeropuertoDestino = '{codigoADestino}'";

            DataTable tabla = _BD.EjecutarSelect(sql);
            _TE.InsertarDatosEnControles(tabla, this.Controls);
        }

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
