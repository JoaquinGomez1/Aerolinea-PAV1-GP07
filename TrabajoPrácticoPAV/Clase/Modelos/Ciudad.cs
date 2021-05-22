using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPrácticoPAV.Clase.Modelos
{
    public class CiudadObj
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public int IdPais { get; set; }
        public string Provincia { get; set; }


        public int IdProvincia { get; set; }
    }
}
