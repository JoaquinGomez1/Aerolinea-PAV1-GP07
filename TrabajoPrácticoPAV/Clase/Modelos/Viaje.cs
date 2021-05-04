using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPrácticoPAV.Clase.Modelos
{
    class Viaje
    {
        public int NumeroDeViaje { get; set; }
        public string HorarioPresencia { get; set; }
        public string HorarioSalida { get; set; }
        public string HorarioLlegada { get; set; }
        public int DuracionEstimada { get; set; }
    }
}
