using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Pasajeros
{
    public partial class Frm_ABMPasajeros : Form
    {
        NE_Clientes _NE = new NE_Clientes();
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();

        public Frm_ABMPasajeros()
        {
            InitializeComponent();
        }

        private void Frm_ABMPasajeros_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            Cmb_TipoDoc.CargarCombo();
            Grid_Pasajero.Formatear();

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string join = $" JOIN Tipo_Documento ON Pasajero.tipoDoc = Tipo_Documento.tipoDoc ";
            string sql = _TE.ConstructorSelect(this.Controls, join);
            _NE.CargarGrilla(sql, Grid_Pasajero);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Frm_AltaPasajero alta = new Frm_AltaPasajero();
            alta.ShowDialog();
        }
    }
}
