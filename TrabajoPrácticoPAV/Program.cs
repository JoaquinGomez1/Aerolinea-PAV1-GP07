using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Formularios;
using TrabajoPrácticoPAV.Formularios.Listados.Aeropuertos;
using TrabajoPrácticoPAV.Formularios.Listados.Pasajeros;
using TrabajoPrácticoPAV.Formularios.Listados.Aviones;
using TrabajoPrácticoPAV.Formularios.Listados.Viajes;
using TrabajoPrácticoPAV.Formularios.Listados;
using TrabajoPrácticoPAV.Formularios.Listados.Reservas;
using TrabajoPrácticoPAV.Formularios.Listados.Tripulacion_Por_Vuelo;
using TrabajoPrácticoPAV.Formularios.Listados.Tripulación;
using TrabajoPrácticoPAV.Formularios.Listados.Avion_Por_Modelo;
using TrabajoPrácticoPAV.Formularios.Listados.Asientos;
using TrabajoPrácticoPAV.Formularios.Listados.Factura;
using TrabajoPrácticoPAV.Formularios.Estadisticas.AeropuertoPais;

namespace TrabajoPrácticoPAV
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Principal());
        }
    }
}