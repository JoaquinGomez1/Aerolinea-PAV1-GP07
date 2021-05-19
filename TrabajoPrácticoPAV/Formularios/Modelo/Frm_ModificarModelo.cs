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

namespace TrabajoPrácticoPAV.Formularios.Modelo
{
    public partial class Frm_ModificarModelo : Form
    {
        NE_Modelo Modelo = new NE_Modelo();
        public string Id_Modelo { get ; set; }
        

        public Frm_ModificarModelo()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Frm_ModificarModelo_Load(object sender, EventArgs e)
        {

            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            
            MostrarDatos(Modelo.RecuperarXId(Id_Modelo));
        }
        private void MostrarDatos(DataTable tabla)
        {
            txt_codigoModelo.Text = tabla.Rows[0]["idModelo"].ToString();
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales Tratamiento = new Tratamientos_Especiales();
            if (Tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                Modelo.Modificar(this.Controls);
                this.Close();
            }
            
            
        }

    }
}
