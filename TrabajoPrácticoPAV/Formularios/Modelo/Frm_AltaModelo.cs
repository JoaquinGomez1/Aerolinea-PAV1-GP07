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
using TrabajoPrácticoPAV.NE_Usuarios;
using TrabajoPrácticoPAV.Backend;


namespace TrabajoPrácticoPAV.Formularios.Modelo
{
    public partial class Frm_AltaModelo : Form
    {
        public Frm_AltaModelo()
        {
            InitializeComponent();
        }

        private void Frm_AltaModelo_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            
            Tratamientos_Especiales Tratamiento = new Tratamientos_Especiales();

            if (Tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                Conexion_DB _BD = new Conexion_DB();
                Tratamiento.Validar(this.Controls);
               
                string sql = Tratamiento.CostructorInsert("Modelo", this.Controls);
                _BD.Insertar(sql, false);
                this.Close();
             
            }
            else
            {
                return;
            }
            
        }
    }
}
