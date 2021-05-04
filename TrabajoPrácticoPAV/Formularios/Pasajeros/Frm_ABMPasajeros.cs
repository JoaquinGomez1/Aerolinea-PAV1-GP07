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

namespace TrabajoPrácticoPAV.Formularios.Pasajeros
{
    public partial class Frm_ABMPasajeros : Form
    {
        public Frm_ABMPasajeros()
        {
            InitializeComponent();
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            DataTable tabla = new DataTable();
            Tratamientos_Especiales _TE = new Tratamientos_Especiales();
            string join = $" JOIN Tipo_Documento Tipo_Documento ON Pasajero.tipoDoc = Tipo_Documento.tipoDoc ";
            _TE.ConstructorSelect(this.Controls, join);
        }
    }
}
