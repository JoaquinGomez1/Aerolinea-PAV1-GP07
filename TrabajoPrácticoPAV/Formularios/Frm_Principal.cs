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
using TrabajoPrácticoPAV.Formularios.Pasajeros;
using TrabajoPrácticoPAV.Formularios.Aeropuertos;
using TrabajoPrácticoPAV.Formularios.Tipo_Asientos;
using TrabajoPrácticoPAV.Formularios.Asientos;
using TrabajoPrácticoPAV.Formularios.Modelo;
using TrabajoPrácticoPAV.Formularios.Grupos_familiares;
using TrabajoPrácticoPAV.Formularios.TipoDoc;
using TrabajoPrácticoPAV.Formularios.Pais;
using TrabajoPrácticoPAV.Formularios.Provincia;
using TrabajoPrácticoPAV.Formularios.Ciudad;
using TrabajoPrácticoPAV.Formularios.Tripulacion.Cargo_Tripulacion;
using TrabajoPrácticoPAV.Formularios.Tripulacion;

namespace TrabajoPrácticoPAV
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            DarColor();
            Timer_Expandir.Stop();
            Timer_Contraer.Stop();
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
            boton.BackColor = Estilo.FormActivo;
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
            if (Estilo.MenuLateral == 0)
            {
                PanelMenu.Width = 42;
                Btn_Menu.Enabled = false; Btn_Menu.Visible = false;
                Timer_Contraer.Enabled = true; Timer_Expandir.Enabled = true;
            }
            else if (Estilo.MenuLateral == 1)
            {
                PanelMenu.Width = 202;
                Btn_Menu.Enabled = true; Btn_Menu.Visible = true;
                Timer_Contraer.Enabled = false; Timer_Expandir.Enabled = false;
            }
            else if (Estilo.MenuLateral == 2)
            {
                PanelMenu.Width = 202;
                Btn_Menu.Enabled = false; Btn_Menu.Visible = false;
                Timer_Contraer.Enabled = false; Timer_Expandir.Enabled = false;
            }
            else if (Estilo.MenuLateral == 3)
            {
                PanelMenu.Width = 42;
                Btn_Menu.Enabled = false; Btn_Menu.Visible = false;
                Timer_Contraer.Enabled = false; Timer_Expandir.Enabled = false;
            }
        }

        private void MouseClickButton(object sender, EventArgs e)
        {
            Button_Aerolinea boton = ((Button_Aerolinea)sender);

            // ↓ Permite que se puedan aplicar los cambios de estilo en la configuración incluso si ya fueron abiertos anteriormente
            CerrarTodosLosForms();
            CambiarColorBoton(boton);
            switch (boton.Name.ToString())
            {
                case "Btn_ABMClientes":
                    AbrirFormulario<Frm_ABMPasajeros>();
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
                case "btn_ABM_Aeropuerto":
                    AbrirFormulario<Frm_ABM_Aeropuerto>();
                    break;
                case "Btn_ABM":
                    if (!menuStrip1.Visible)
                    {
                        menuStrip1.Visible = true;
                        menuStrip1.BringToFront();
                        // Nota: El menustrip se hace invisible al abrir un formulario
                        // ver la función Abrir Formulario
                    }
                    break;
                default:
                    MessageBox.Show("Esperando implementación");
                    break;
            }

        }

        private void CerrarTodosLosForms()
        {
            List<Form> openForms = new List<Form>();

            // Determinamos cuales formularios están abiertos y los agregamos a una lista con la que podamos trabajar temporalmente
            foreach (Form form in Application.OpenForms)
                openForms.Add(form);

            foreach (Form form in openForms)
            {
                if (form.Name != "Frm_Principal")
                    form.Close();
            }

        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width >= 150)
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
            menuStrip1.Visible = false; //<- Previene que el menu strip quede abierto al abrir un formulario 
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
                RestaurarColorBoton(Btn_ABM);
            if (Application.OpenForms["Frm_ABMViajes"] == null)
                RestaurarColorBoton(Btn_Procesos);
            if (Application.OpenForms["Frm_ABMVuelo"] == null)
                RestaurarColorBoton(Btn_Listado);
            if (Application.OpenForms["Frm_ABMTramos"] == null)
                RestaurarColorBoton(Btn_Estadistica);

            if (Application.OpenForms["Frm_Configuracion"] == null)
            {
                DarColor();
                RestaurarColorBoton(Btn_Configuracion);
            }
        }


        #endregion

        #region Cosas rotas 
        #endregion

        #region Movimiento automatico
        int DebeContraer = 0;

        private void Timer_Expandir_Tick(object sender, EventArgs e)
        {
            if (PanelMenu.Width > 192)
                Timer_Expandir.Stop();
            else
                PanelMenu.Width += 10;
        }

        private void Timer_Contraer_Tick(object sender, EventArgs e)
        {
            if (DebeContraer >= 5)
            {
                if (PanelMenu.Width <= 42)
                    Timer_Contraer.Stop();
                else
                {
                    Timer_Expandir.Stop();
                    PanelMenu.Width -= 10;
                }
            }
            else
                DebeContraer += 1;
        }

        private void PanelMenu_MouseEnter(object sender, EventArgs e)
        {
            if (Estilo.MenuLateral == 0)
            {
                DebeContraer = 0;
                Timer_Contraer.Stop();
                Timer_Expandir.Start();
            }
        }

        private void MouseSalioDeMenu(object sender, EventArgs e)
        {
            if (Estilo.MenuLateral == 0)
                Timer_Contraer.Start();
        }
        #endregion



        // Eventos de los items del menuStrip
        // El que tenga tiempo vea si lo puede dejar un poco mejor
        private void aeropuertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_ABM_Aeropuerto>();
        }

        private void aviónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_ABMAviones>();
        }

        private void tipoDeAsientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_ABMTipoAsientos>();
        }

        private void asientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_ABMAsientos>();
        }

        private void modeloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_ABMmodelo>();
        }

        private void pasajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_ABMPasajeros>();
        }

        private void grupoFamiliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_ABMGrupoFamiliar>();
        }

        private void tipoDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_ABMTipoDoc>();
        }

        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_ABMPais>();
        }

        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_ABMProvincia>();
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_Ciudad>();
        }

        private void vueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_ABMVuelo>();
        }

        private void tramosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_ABMTramos>();
        }

        private void viajesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_ABMViajes>();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_ABMCargoTripulacion>();
        }

        private void tripulaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Frm_ABMTripulacion>();
        }
    }
}