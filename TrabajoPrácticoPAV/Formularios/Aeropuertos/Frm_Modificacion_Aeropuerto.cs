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

namespace TrabajoPrácticoPAV.Formularios.Aeropuertos
{
    public partial class Frm_Modificación_Aeropuerto : Form
    {
        public string Codigo_aeropuerto { get; set; }
        public Frm_Modificación_Aeropuerto()
        {
            InitializeComponent();
        }


        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales Tratamiento = new Tratamientos_Especiales();
            if(Tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                NE_Aeropuertos aeropuerto = new NE_Aeropuertos();
                aeropuerto.Pp_codigo = txt_codigo.Text;
                aeropuerto.Pp_nombre = txt_nombre.Text;
                aeropuerto.Pp_idCiudad = cmb_ciudades.SelectedValue.ToString();
                aeropuerto.Modificar();
                this.Close();
            }
        }

        private void Frm_Modificación_Aeropuerto_Load(object sender, EventArgs e)
        {
            cmb_ciudades.CargarCombo();
            NE_Aeropuertos aeropuerto = new NE_Aeropuertos();
            MostrarDatos(aeropuerto.Recuperar_por_Codigo(Codigo_aeropuerto));
        }
        private void MostrarDatos(DataTable tabla)
        {
            txt_codigo.Text = tabla.Rows[0]["codigo"].ToString();
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
            cmb_ciudades.SelectedValue = int.Parse(tabla.Rows[0]["idCiudad"].ToString());
        }
    }
}
