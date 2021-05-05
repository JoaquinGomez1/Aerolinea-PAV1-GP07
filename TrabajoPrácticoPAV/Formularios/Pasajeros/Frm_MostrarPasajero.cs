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

namespace TrabajoPrácticoPAV.Formularios.Pasajeros
{
    public partial class Frm_MostrarPasajero : Form
    {
        Conexion_DB _BD = new Conexion_DB();
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();

        public string tipoDoc { get; set; }
        public string numeroDoc { get; set; }

        #region Movimiento de la barra
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        public Frm_MostrarPasajero()
        {
            InitializeComponent();
        }

        private void Frm_MostrarPasajero_Load(object sender, EventArgs e)
        {
                this.BackColor = Estilo.ColorFondoForms;
                Estilo.FormatearEstilo(this.Controls);

                Cmb_TipoDoc.CargarCombo();
                Cmb_Ciudad.CargarCombo();

                string sql = $"SELECT * FROM Pasajero JOIN Ciudad ON Ciudad.idCiudad = Pasajero.idCiudad" +
                    $" WHERE Pasajero.tipoDoc = '{tipoDoc}' AND Pasajero.numeroDoc = '{numeroDoc}'";

                DataTable tabla = _BD.EjecutarSelect(sql);
                _TE.InsertarDatosEnControles(tabla, this.Controls);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
