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

namespace TrabajoPrácticoPAV.Formularios.Tipo_Asientos
{
    public partial class Frm_AltaTipoAsiento : Form
    {
        public Frm_AltaTipoAsiento()
        {
            InitializeComponent();
        }
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();

        private void Frm_AltaTipoAsiento_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Conexion_DB _BD = new Conexion_DB();

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            string sql = _TE.CostructorInsert("Tipo_Asiento", this.Controls);
            _BD.Insertar(sql, false);
            this.Close();
            //MessageBox.Show("Asiento insertado correctamente.");
            
        }
    }
}
