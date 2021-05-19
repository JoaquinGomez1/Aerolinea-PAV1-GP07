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

namespace TrabajoPrácticoPAV.Formularios.Grupos_familiares
{
    public partial class Frm_ModificarGrupo : Form
    {
        public Frm_ModificarGrupo()
        {
            InitializeComponent();
        }
        #region Barra y colores
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        public string tipoDoc1 { get; set; }
        public string tipoDoc2 { get; set; }
        public string numeroDoc1 { get; set; }
        public string numeroDoc2 { get; set; }
        public string relacion { get; set; }

        Tratamientos_Especiales _TE = new Tratamientos_Especiales();
        Conexion_DB _BD = new Conexion_DB();

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Frm_ModificarGrupo_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            Cmb_TipoDoc.CargarCombo();
            cmb_TipoDocP2.CargarCombo();

            string sql1 = $"SELECT * FROM Pasajero p JOIN Tipo_Documento td ON p.tipoDoc = td.tipoDoc" +
                $" WHERE p.tipoDoc = {tipoDoc1} AND p.numeroDoc = {numeroDoc1}";
            DataTable tabla = _BD.EjecutarSelect(sql1);
            _TE.InsertarDatosEnControles(tabla, PanelP1.Controls);

            txt_Relacion.Text = relacion;

            string sql2 = $"SELECT * FROM Pasajero p JOIN Tipo_Documento td ON p.tipoDoc = td.tipoDoc" +
                $" WHERE p.tipoDoc = {tipoDoc2} AND p.numeroDoc = {numeroDoc2}";
            tabla = _BD.EjecutarSelect(sql2);
            _TE.InsertarDatosEnControles(tabla, PanelP2.Controls);
        }
        #endregion

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (txt_Relacion.Text != "")
            {
                string sql = $"UPDATE Familiar_X_Pasajero SET tipoParentesco = '{txt_Relacion.Text}' " +
                    $"WHERE numerodocPrimerPasajero = {numeroDoc1} AND" +
                    $" tipoDocPrimerPasajero = {tipoDoc1} AND numerodocSegundoPasajero = {numeroDoc2} AND " +
                    $"tipoDocSegundoPasajero = {tipoDoc2}";
                _BD.Modificar(sql, false);
                this.Close();
            }
            else
                MessageBox.Show("La relación no puede dejarse en blanco");
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
