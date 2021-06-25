using System;
using System.Data;
using System.Windows.Forms;
using TrabajoPrácticoPAV.NE_Usuarios;
using TrabajoPrácticoPAV.Clase;
using System.Runtime.InteropServices;

namespace TrabajoPrácticoPAV.Formularios.Asientos
{
    public partial class Frm_ModificarAsiento : Form
    {
        private NE_Asiento asiento = new NE_Asiento();
        public string Id_Asiento { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Frm_ModificarAsiento()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void Frm_ModificarAsiento_Load(object sender, EventArgs e)
        {
            cmb_nombreModelo.CargarCombo();
            cmb_numeroAvion.CargarCombo();
            cmb_clase.CargarCombo();

            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            MostrarDatos(asiento.RecuperarXId(Id_Asiento));
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_idasiento.Text = tabla.Rows[0]["numeroAsiento"].ToString();
            cmb_nombreModelo.SelectedValue = int.Parse(tabla.Rows[0]["idModelo"].ToString());
            cmb_numeroAvion.SelectedValue = int.Parse(tabla.Rows[0]["numeroPorModelo"].ToString());
            cmb_clase.SelectedValue = int.Parse(tabla.Rows[0]["tipoAsiento"].ToString());
            txt_estado.Text = tabla.Rows[0]["estado"].ToString();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrarAsiento_Click(object sender, EventArgs e)
        {
            asiento.Modificar(this.Controls);
            this.Close();
        }

        private void cmb_nombreModelo_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            cmb_numeroAvion.SelectedIndex = -1;
            cmb_clase.SelectedIndex = -1;
            string CondicionAvion = @" JOIN Modelo ON Modelo.idModelo " +
                       @"= Avion.idModelo WHERE Avion.idModelo = " + cmb_nombreModelo.SelectedValue;
            cmb_numeroAvion.CargarComboJoin(CondicionAvion);
        }
    }
}