using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Formularios;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Aeropuertos
{
    public partial class Frm_Borrar_Aeropuerto : Form
    {
        public string Id_codigo { get; set; }
        public Frm_Borrar_Aeropuerto()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            NE_Aeropuertos aeropuerto = new NE_Aeropuertos() { Pp_Id_aeropuerto = Id_codigo };
            if (MessageBox.Show("¿Está seguro de Borrar el aeropuerto?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                aeropuerto.Borrar();
                this.Close();
            }
        }

        private void Frm_Borrar_Aeropuerto_Load(object sender, EventArgs e)
        {
            cmb_ciudad.CargarCombo();
            NE_Aeropuertos aeropuerto = new NE_Aeropuertos();
            MostrarDatos(aeropuerto.Recuperar_por_Codigo(Id_codigo));
        }
        private void MostrarDatos(DataTable tabla)
        {
            if (tabla.Rows.Count > 0)
            {
                txt_codigo.Text = tabla.Rows[0]["codigo"].ToString();
                txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
                cmb_ciudad.SelectedValue = int.Parse(tabla.Rows[0]["idCiudad"].ToString());
            }
            else
            {
                MessageBox.Show("No se encontró un aeropuerto con los filtros especificados");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
