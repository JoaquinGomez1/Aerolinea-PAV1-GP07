using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;
using static TrabajoPrácticoPAV.Clase.Tratamientos_Especiales;

namespace TrabajoPrácticoPAV.Formularios.Pasajeros
{
    public partial class Frm_AltaPasajero : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        Tratamientos_Especiales _TE = new Tratamientos_Especiales();
        Conexion_DB _BD = new Conexion_DB();
        NE_Clientes _NE = new NE_Clientes();

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Frm_AltaPasajero()
        {
            InitializeComponent();
        }

        private void Frm_AltaPasajero_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            Cmb_Pais.CargarCombo();
            Cmb_TipoDoc.CargarCombo();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Resultado validacionFecha = _TE.ValidarFecha(txt_Fecha.Text);
            Resultado validacionControles =_TE.Validar(this.Controls);

            if (validacionFecha == Resultado.correcto && validacionControles == Resultado.correcto)
            {
                string sql = _TE.CostructorInsert("Pasajero", this.Controls);
                _BD.Insertar(sql, false);
                _NE.InsertarTelefonos(grid_Telefonos, Msktxt_NumeroDOC.Text, Cmb_TipoDoc.SelectedValue.ToString());
                this.Close();
            }
        }

        private void Cmb_Pais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cmb_Pais.SelectedIndex != -1)
            {
                string joinYCond = $" JOIN Pais ON Pais.idPais = Provincia.idPais WHERE Pais.idPais =" +
                    $" '{Cmb_Pais.SelectedValue}' ";
                Cmb_Provincia.CargarComboJoin(joinYCond);
                Cmb_Provincia.Enabled = true;
            }
        }

        private void Cmb_Provincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cmb_Pais.SelectedIndex != -1)
            {
                string joinYCond = $" JOIN Provincia ON Provincia.idProvincia " +
                    $"= Ciudad.idProvincia WHERE Provincia.idProvincia = '{Cmb_Provincia.SelectedValue}' ";
                Cmb_Ciudad.CargarComboJoin(joinYCond);
                Cmb_Ciudad.Enabled = true;
            }
        }
    }
}
