using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TrabajoPrácticoPAV.Formularios;
using TrabajoPrácticoPAV.NE_Usuarios;
using TrabajoPrácticoPAV.Clase;

namespace TrabajoPrácticoPAV.Formularios.Aviones
{
    public partial class Frm_Borrar_Avion : Form
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

        public string Id_modelo { get; set; }
        public string Id_numero { get; set; }
        public string Nombre { get; set; }
        public Frm_Borrar_Avion()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

        }
        
        private void Frm_Borrar_Avion_Load_1(object sender, EventArgs e)
        {
            Estilo.FormatearEstilo(this.Controls);
            this.BackColor = Estilo.ColorFondoForms;

            cmb_modelos.CargarCombo();

            NE_Avion avion = new NE_Avion();
            MostrarDatos(avion.Recuperar_x_numero(Id_numero));

        }
        private void MostrarDatos(DataTable tabla)
        {
            if (tabla.Rows.Count > 0)
            {
                txt_numero.Text = tabla.Rows[0]["numeroPorModelo"].ToString();
                cmb_modelos.SelectedItem = tabla.Rows[0]["numeroPorModelo"].ToString();
                txt_idModelo.Text = tabla.Rows[0]["idModelo"].ToString();

            }
            else
            {
                MessageBox.Show("No se encontró un avion con los filtros especificados");
            }
        }

        private void button_Aerolinea2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            NE_Avion avion = new NE_Avion();
            if (MessageBox.Show("¿Está seguro de Borrar el avion?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                avion.Remover_avion(Id_numero, Id_modelo);
                this.Close();
            }
        }
    }
}