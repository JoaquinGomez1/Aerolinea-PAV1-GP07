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
using System.Runtime.InteropServices;

namespace TrabajoPrácticoPAV.Formularios.Aeropuertos
{
    
    public partial class Frm_Modificación_Aeropuerto : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public string Id_codigo { get; set; }
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
                NE_Aeropuertos aeropuerto = new NE_Aeropuertos()
                {
                    Pp_codigo = txt_codigo.Text
                    ,
                    Pp_nombre = txt_nombre.Text
                    ,
                    Pp_idCiudad = cmb_ciudades.SelectedValue.ToString()
                    ,
                    Pp_Id_aeropuerto = Id_codigo
                };

                aeropuerto.Modificar();
                this.Close();
            }
        }

        private void Frm_Modificación_Aeropuerto_Load(object sender, EventArgs e)
        {
            cmb_ciudades.CargarCombo();
            NE_Aeropuertos aeropuerto = new NE_Aeropuertos();
            MostrarDatos(aeropuerto.Recuperar_por_Codigo(Id_codigo));
        }
        private void MostrarDatos(DataTable tabla)
        {
            if (tabla.Rows.Count > 0)
            {
                txt_codigo.Text = tabla.Rows[0]["codigo"].ToString();
                txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
                cmb_ciudades.SelectedValue = int.Parse(tabla.Rows[0]["idCiudad"].ToString());
            }
            else
            {
                MessageBox.Show("No se encontró un aeropuerto con los filtros especificados");
            }
        }
    }
}
