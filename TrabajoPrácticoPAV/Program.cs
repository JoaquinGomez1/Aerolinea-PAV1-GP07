using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Formularios;
using TrabajoPrácticoPAV.Formularios.Grupos_familiares;
using TrabajoPrácticoPAV.Formularios.Pais;

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
            //Application.Run(new Frm_ABMPais());
            Application.Run(new Frm_ABMGrupoFamiliar());

        }
    }
}
