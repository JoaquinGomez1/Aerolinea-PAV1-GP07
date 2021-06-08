using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Formularios;
using TrabajoPrácticoPAV.Formularios.Provincia;
using TrabajoPrácticoPAV.Formularios.Pais;
using TrabajoPrácticoPAV.Formularios.TipoDoc;
using TrabajoPrácticoPAV.Formularios.Tipo_Asientos;
using TrabajoPrácticoPAV.Formularios.Tripulacion;
using TrabajoPrácticoPAV.Formularios.Ciudad;
using TrabajoPrácticoPAV.Formularios.Asientos;
using TrabajoPrácticoPAV.Formularios.Modelo;
using TrabajoPrácticoPAV.Formularios.Aeropuertos;
using TrabajoPrácticoPAV.Formularios.Listados.Aeropuertos;
using TrabajoPrácticoPAV.Formularios.Listados.Pasajeros;
using TrabajoPrácticoPAV.Formularios.Listados;
using TrabajoPrácticoPAV.Formularios.Listados.Tripulación;

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
            Application.Run(new Frm_Tripulacion());

        }
    }
}