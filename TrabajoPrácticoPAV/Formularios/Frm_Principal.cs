using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Formularios;

namespace TrabajoPrácticoPAV
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private string FrmActual;

        #region Funcionalidades del formulario
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Está seguro que desea salir?",
                                   "Salir", MessageBoxButtons.OKCancel);
            if (decision == DialogResult.OK)
            {
                Application.Exit();
            }
        }



        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);
        #endregion    }

        #region Botones del Menu

        #region Abrir Formularios con Botones del Menu


        private void MouseEnterButton(object sender, EventArgs e)
        {
            ((Button)sender).BringToFront();
        }

        private void MouseClickButton(object sender, EventArgs e)
        {
            switch (((Button)sender).Name.ToString())
            {
                case "Btn_ABMClientes":
                    AbrirFormulario<Frm_ABMClientes>();
                    break;
                case "Btn_ABMReservas":
                    AbrirFormulario<Frm_ABMReservas>();
                    break;
                case "Btn_ABM_Viaje":
                    AbrirFormulario<Frm_ABMViajes>();
                    break;
                default:
                    MessageBox.Show("Esperando implementación");
                    break;
            }

        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width == 150)
            {
                PanelMenu.Width = 42;
                Btn_Menu.Text = "→";
            }
            else
            {
                PanelMenu.Width = 150;
                Btn_Menu.Text = "←";
            }
        }


        #endregion

        #region Colores de Botones

        public void CambiarColorBoton(Button boton)
        {
            boton.BackColor = Color.FromArgb(228, 195, 123);
        }

        private void PanelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        //Método abrir Form dentro de panel
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelFormularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelFormularios.Controls.Add(formulario);
                PanelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                FrmActual = formulario.Name.ToString();
                formulario.FormClosed += new FormClosedEventHandler(FormCerrado);
                Btn_Menu.BringToFront();

            }
            else
            {
                formulario.BringToFront();
                FrmActual = formulario.Name.ToString();
                Btn_Menu.BringToFront();
            }

        }
        private void FormCerrado(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Frm_ABMClientes"] == null)
            {
                Btn_ABMClientes.BackColor = Color.FromArgb(159, 133, 74);
            }
        }

        #endregion

        #region Cosas rotas 
        //public void FormCerrado(string form)
        //{
        //    switch (form)
        //    {
        //        //case "Frm_ABMClientes": Btn_ABMClientes.BackColor = Color.FromArgb(10, 0, 120) ; break;
        //        //case "Frm_ABMReservas": RestaurarColorBoton(Btn_ABMReservas); break;
        //        default: break;
        //    }
        //}

        //private void RestaurarColorBoton(Button boton, Color color)
        //{
        //    boton.BackColor = Color.FromArgb(10, 0, 120);
        //}
        #endregion


        private void Btn_Configuracion_Click(object sender, EventArgs e)
        {

        }
    }
}