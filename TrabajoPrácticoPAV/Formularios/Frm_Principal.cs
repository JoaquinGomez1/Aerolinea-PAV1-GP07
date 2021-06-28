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
using TrabajoPrácticoPAV.Formularios.Facturaciones;
using TrabajoPrácticoPAV.Formularios.Listados.Aeropuertos;
using TrabajoPrácticoPAV.Formularios.Listados.Viajes.Tramos;
using TrabajoPrácticoPAV.Formularios.Listados.Avion_Por_Modelo;
using TrabajoPrácticoPAV.Formularios.Listados.Reservas;
using TrabajoPrácticoPAV.Formularios.Listados.Tripulacion_Por_Vuelo;
using TrabajoPrácticoPAV.Formularios.Listados.Pasajeros;
using TrabajoPrácticoPAV.Formularios.Listados.Tripulación;
using TrabajoPrácticoPAV.Formularios.Listados.Viajes;
using TrabajoPrácticoPAV.Formularios.Listados.Asientos;
using TrabajoPrácticoPAV.Formularios.Listados.Tramos_por_viaje;
using TrabajoPrácticoPAV.Formularios.Estadisticas.PasajerosMayores;
using TrabajoPrácticoPAV.Formularios.Estadisticas.PasajerosPorViaje;
using TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesPorMes;
using TrabajoPrácticoPAV.Formularios.Estadisticas.AvionesXModelos;
using TrabajoPrácticoPAV.Formularios.Estadisticas.AvionesXAeropuerto;
using TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesPorSemana;
using TrabajoPrácticoPAV.Formularios.Estadisticas.AeropuertoPais;
using TrabajoPrácticoPAV.Formularios.Estadisticas.TripulacionXcargo;
using TrabajoPrácticoPAV.Formularios.Estadisticas.VueloPorAvion;
using TrabajoPrácticoPAV.Formularios.Estadisticas.VuelosXTripulacion;
using TrabajoPrácticoPAV.Formularios.Estadisticas.VuelosXAeropuerto;
using TrabajoPrácticoPAV.Formularios.Estadisticas.FacturasXPago;
using TrabajoPrácticoPAV.Formularios.Estadisticas.FacturasXMes;
using TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesPorPais;
using TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesXFecha;
using TrabajoPrácticoPAV.Formularios.Listados.FacturasXPasajero;
using TrabajoPrácticoPAV.Formularios.Listados.Factura;
using TrabajoPrácticoPAV.Formularios.Listados;
using TrabajoPrácticoPAV.Formularios.Listados.EquipajeXPasajero;
using TrabajoPrácticoPAV.Formularios.Teléfono;
using TrabajoPrácticoPAV.Formularios.Tripulacion_x_vuelo;


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
            Estilo.FormatearEstilo(this.Controls);
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

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        #endregion Funcionalidades del formulario

        #region Botones del Menu

        #region Abrir Formularios con Botones del Menu

        private void MouseClickButton(object sender, EventArgs e)
        {
            Button_Aerolinea boton = ((Button_Aerolinea)sender);

            // ↓ Permite que se puedan aplicar los cambios de estilo en la configuración incluso si ya fueron abiertos anteriormente
            CerrarTodosLosForms();
            CerrarTodosLosMenuStrip();

            boton.BackColor = Estilo.FormActivo;
            switch (boton.Name.ToString())
            {
                case "Btn_Configuracion":
                    AbrirFormulario<Frm_Configuracion>();
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

                case "Btn_Procesos":
                    if (!menuStrip2.Visible)
                    {
                        menuStrip2.Visible = true;
                        menuStrip2.BringToFront();
                    }
                    break;

                case "Btn_Listado":
                    if (!menuStrip3.Visible)
                    {
                        menuStrip3.Visible = true;
                        menuStrip3.BringToFront();
                    }
                    break;

                case "Btn_Estadistica":
                    if (!menuStrip4.Visible)
                    {
                        menuStrip4.Visible = true;
                        menuStrip4.BringToFront();
                    }
                    break;

                default:
                    MessageBox.Show("Esperando implementación");
                    break;
            }
        }

        private void CerrarTodosLosMenuStrip()
        {
            List<MenuStrip> list = new List<MenuStrip>() { menuStrip1, menuStrip2, menuStrip3, menuStrip4 };

            foreach (MenuStrip menu in list)
            {
                menu.Visible = false;
                menu.SendToBack();
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

        #endregion Abrir Formularios con Botones del Menu

        //Método abrir Form dentro de panel
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            menuStrip1.Visible = false; //<- Previene que el menu strip quede abierto al abrir un formulario
            //RestaurarColorBoton(Btn_ABM);
            Form formulario;
            formulario = PanelFormularios.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelFormularios.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(FormCerrado);
            }
            else
            {
                formulario.BringToFront();
            }
        }

        //Regresa a su color original el botón de un Form cerrado
        private void FormCerrado(object sender, FormClosedEventArgs e)
        {
            RestaurarBotones();

            if (Application.OpenForms["Frm_Configuracion"] == null)
            {
                if (Estilo.EstiloDebeActualizar)
                {
                    Estilo.FormatearEstilo(this.Controls);
                    Estilo.EstiloDebeActualizar = false;
                }
            }
        }

        private void RestaurarBotones()
        {
            foreach (Button_Aerolinea boton in PanelMenu.Controls)
            {
                boton.BackColor = Estilo.ColorBoton;
            }
        }

        #endregion Botones del Menu

        // Eventos de los items del menuStrip
        // El que tenga tiempo vea si lo puede dejar un poco mejor

        #region MenuStripABM

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
            Estilo.FormatearEstilo(this.Controls);
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

        #endregion MenuStripABM

        #region MenuStripListados

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_ABMReservas>();
        }

        //private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    CerrarTodosLosMenuStrip();
        //    AbrirFormulario<Frm_Facturacion>();
        //}

        private void aeropuertoPorPaisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_ReporteAeroPais>();
        }

        private void tramoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_ListadoTramos>();
        }

        private void avionPorModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_AvionPorModelo>();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_Reservas>();
        }

        private void tripulacionPorVueloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_ListadoTripPorVuelo>();
        }

        private void familiaresPorPasajeroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_ReporteFamiliareXPasajero>();
        }

        private void tripulacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_Tripulacion>();
        }

        private void viajesEntreFechaInicialYFechaFinalPorDestinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_ListadoViajes>();
        }

        private void proximosVuelosEnUnAeropuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_ReporteVueloXAeropuerto>();
        }

        private void estadoDeCadaAsientoPorCadaAvionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_ReporteAsientoXAvion>();
        }

        private void tramosPorViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_ReporteViajeXTramo>();
        }

        #endregion MenuStripListados

        private void pasajerosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Formularios.Listados.Pasajeros.Reporte_Pasajeros>();
        }

        private void porcentajeDePasajerosMayoresDeEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_PasajerosMayores>();
        }

        private void porcentajeDeViajesPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_EViajesPorMes>();
        }

        private void porcentajeDeAvionesPorModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_ReporteAvionesXModelos>();
        }

        private void porcentajeDeAvionesPorAeropuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_AvionesXAeropuerto>();
        }

        private void porcentajeDeViajesPorDíaDeSemanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_EViajesPorSemana>();
        }

        private void porcentajeDePasajerosPorVueloEnUnAñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_PasajerosPorViaje>();
        }

        private void cantidadDeAeropuertosPorPaísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_EstadisticaAeroPais>();
        }

        private void porcentajeDeTripulaciónPorCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_TripulacionXcargo>();
        }

        private void cantidadDeVuelosRealizadosPorAviónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_EVueloPorAvion>();
        }

        private void cantidadDeVuelosRealizadosPorTripulaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_VuelosXTripulacion>();
        }

        private void porcentajeDeVuelosPorAeropuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_VuelosXAeropuerto>();
        }

        private void cantidadDeViajesRealizadosPorPaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_ViajesPorPais>();
        }

        private void cantidadDeFacturasPorTipoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_FacturasXPago>();
        }

        private void cantidadFacturadaPorMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_FacturasXMes>();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_Facturacion>();
        }

        private void cantidadDeViajesVendidosPorAeropuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_viajesXFecha>();
        }

        private void facturasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_facturaXPasajero>();
        }

        private void facturaPorPasajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_Reporte_FacturasPorFecha>();
        }

        private void aviónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_Reportes>();
        }

        private void equipajePorPasajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_EquipajeXPasajero>();
        }

        private void teléfonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_ABM_Teléfono>();
        }

        private void tripulaciónPorVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodosLosMenuStrip();
            AbrirFormulario<Frm_ABM_TripulacionxVuelo>();
        }
    }
}