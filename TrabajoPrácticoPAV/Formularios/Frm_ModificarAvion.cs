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
using TrabajoPrácticoPAV.Formularios;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.NE_Aviones;


namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ModificarAvion : Form
    {
       
        public string Pp_numero_Modelo 
        { 
            get {return txt_numero_modelo.Text; }
            set { txt_numero_modelo.Text = value;}
        }
        public string Pp_id_Modelo 
        {
            get { return cmb_MOdelo.Text; }
            set { cmb_MOdelo.Text = value; }
        }
        public Frm_ModificarAvion()
        {
            InitializeComponent();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (txt_numero_modelo.Text.Length > 4 | cmb_MOdelo.SelectedIndex == -1 | txt_numero_modelo.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un numero de 4 digitos y seleccionar un modelo de avion");
                return;
            }
            if (txt_numero_modelo.Text == "")
            {
                MessageBox.Show("El número de modelo está vacío.");
                return;
            }
            if (cmb_MOdelo.Text == "" )
            {
                MessageBox.Show("No seleccionó modelo.");
                return;
            }


            NE_Avion avion = new NE_Avion();
            Pp_numero_Modelo = txt_numero_modelo.Text;
            Pp_id_Modelo = cmb_MOdelo.Text;

            avion.Modificar();
           MessageBox.Show("Se cambiaron los datos correctamente");
           this.Close();
            //       Pp_numero_modelo = (txt_Numero.Text)ToString();
            //     Pp_id_modelo = cmb_MOdelo.Text;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MostrarDatos(DataTable tabla)
        {
            txt_numero_modelo.Text = tabla.Rows[0]["numero_modelo"].ToString();
            cmb_MOdelo.SelectedValue = int.Parse(tabla.Rows[0]["id_modelo"].ToString());

        }
        private void Frm_ModificarAvion_Load(object sender, EventArgs e)
        {
            cmb_MOdelo.CargarCombo();
            

            NE_Avion avion = new NE_Avion();
            MostrarDatos(avion.Recuperar_x_numero(Pp_numero_Modelo));
        }
        private void txt_Numero_TextChanged()
        {

        }
        private void cmb_MOdelo_SelectedIndexChanged()
        {

        }

        private void txt_numero_modelo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}