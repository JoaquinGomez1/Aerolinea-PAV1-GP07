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
using TrabajoPrácticoPAV.Formularios;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ABMVuelo : Form
    {
        public Frm_ABMVuelo()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
            if (tratamientos.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                NE_Vuelos vuelo = new NE_Vuelos();

                //usuario.Pp_apellido = txt_apellido.Text;
                //usuario.Pp_cuil = txt_cuil.Text;
                //usuario.Pp_email = txt_email.Text;
                //usuario.Pp_estado = cmb_estadosUsuarios.SelectedValue.ToString();
                //usuario.Pp_nombres = txt_nombre.Text;
                //usuario.Pp_n_usuario = txt_usuario.Text;
                //usuario.Pp_password = txt_password.Text;
                //usuario.Pp_perfil = cmb_perfiles.SelectedValue.ToString();

                //usuario.Insertar();

                vuelo.Insertar(this.Controls);


            }
        }

        private void Frm_ABMVuelo_Load(object sender, EventArgs e)
        {
            Cmb_Nromodelo.CargarCombo();
            cmb_Nroavion.CargarCombo();
            cmb_Tramo.CargarCombo();
        }
        
    }
}
