using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.NE_Usuarios;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.Formularios.Asientos
{
    public partial class Frm_ModificarAsiento : Form
    {
        Conexion_DB _BD = new Conexion_DB();
        public string Id_Asiento { get; set; }
        public Frm_ModificarAsiento()
        {
            InitializeComponent();
        }
        private void Frm_ModificarAsiento_Load(object sender, EventArgs e)
        {
            cmb_nombreModelo.CargarCombo();
            cmb_numeroAvion.CargarCombo();
            cmb_clase.CargarCombo();

            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            NE_Asiento asiento = new NE_Asiento();
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
            Tratamientos_Especiales Tratamiento = new Tratamientos_Especiales();
         
                string sql = Tratamiento.CostructorUpdateDelete("Asientos", panel1.Controls, true);
                _BD.Modificar(sql, false);
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
