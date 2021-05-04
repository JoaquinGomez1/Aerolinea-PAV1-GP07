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
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Formularios;

namespace TrabajoPrácticoPAV
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

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

        private void CambiarColorBoton(Button_Aerolinea boton)
        {
            boton.BackColor = Estilo.ColorBotonPress;
            boton.Pp_Presionado = true;
        }

        private void RestaurarColorBoton(Button_Aerolinea boton)
        {
            boton.BackColor = Estilo.ColorBoton;
            boton.Pp_Presionado = false;
        }

        private void DarColor()
        {
            PanelMenu.BackColor = Estilo.ColorFondo;
            foreach (Button_Aerolinea boton in PanelMenu.Controls)
            {
                if (boton.Pp_Presionado)
                    CambiarColorBoton(boton);
                else
                    RestaurarColorBoton(boton);
            }
            panel1.BackColor = Estilo.ColorBarra;
            Btn_Menu.BackColor = Estilo.ColorBoton;
        }

        private void MouseClickButton(object sender, EventArgs e)
        {
            Button_Aerolinea boton = ((Button_Aerolinea)sender);
            CambiarColorBoton(boton);
            switch (boton.Name.ToString())
            {
                case "Btn_ABMClientes":
                    AbrirFormulario<Frm_ABMClientes>();
                    break;
                case "Btn_ABMReservas":
                    AbrirFormulario<Frm_ABMReservas>();
                    break;
                case "Btn_ABM_Vuelo":
                    AbrirFormulario<Frm_ABMVuelo>();
                    break;
                case "Btn_ABM_Viaje":
                    AbrirFormulario<Frm_ABMViajes>();
                    break;
                case "Btn_ABM_Tramo":
                    AbrirFormulario<Frm_ABMTramos>();
                    break;
                case "Btn_Configuracion":
                    AbrirFormulario<Frm_Configuracion>();
                    break;
                case "Btn_ABMAviones":
                    AbrirFormulario<Frm_ABMAviones>();
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
                formulario.FormClosed += new FormClosedEventHandler(FormCerrado);
                Btn_Menu.BringToFront();

            }
            else
            {
                formulario.BringToFront();
                Btn_Menu.BringToFront();
            }

        }

        //Regresa a su color original el botón de un Form cerrado
        private void FormCerrado(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Frm_ABMClientes"] == null)
                RestaurarColorBoton(Btn_ABMClientes);
            if (Application.OpenForms["Frm_ABMViajes"] == null)
                RestaurarColorBoton(Btn_ABM_Viaje);
            if (Application.OpenForms["Frm_ABMVuelo"] == null)
                RestaurarColorBoton(Btn_ABM_Vuelo);
            if (Application.OpenForms["Frm_ABMTramos"] == null)
                RestaurarColorBoton(Btn_ABM_Tramo);
            if (Application.OpenForms["Frm_ABMAviones"] == null)
                RestaurarColorBoton(Btn_ABMAviones);
            if (Application.OpenForms["Frm_Configuracion"] == null)
            {
                DarColor();
                RestaurarColorBoton(Btn_Configuracion);
            }
        }

        #endregion

        #region Cosas rotas 
        #endregion


    }
}