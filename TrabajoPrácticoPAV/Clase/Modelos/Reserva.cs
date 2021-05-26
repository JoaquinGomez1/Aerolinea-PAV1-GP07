using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPrácticoPAV.Clase.Modelos
{
    class Reserva
    {
        public string numeroDeReserva { get; set; }
        public string fechaDeReserva { get; set; }
        public string fechaDeSalida { get; set; }
        public string confirmacion { get; set; }
        public string numeroDeViaje { get; set; }
        public string numeroDocTitular { get; set; }
        public string tipoDocTitular { get; set; }
        public double precio { get; set; } // <- Si se complica mucho simplificar y cambiarlo a int
    }
}
