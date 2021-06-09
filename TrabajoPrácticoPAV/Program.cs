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

namespace TrabajoPrácticoPAV
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Frm_Principal());
            //Application.Run(new Frm_ReporteAeroPais());
            //Application.Run(new Frm_Reportes());
            //Application.Run(new Frm_ReporteFamiliareXPasajero());

            //Application.Run(new Frm_Reservas());
            Application.Run(new Frm_AvionPorModelo());

            //Application.Run(new Frm_Tripulacion());
        }
    }
}