using System;

namespace TrabajoPrácticoPAV.Clase.Modelos
{
    class Pasajero
    {
        // Son todos los campos de tipo string porque no tiene sentido hacer ninguna operación con ningun dato de esta tabla
        // Cuanto mucho se modifican pero no se realizan operaciones con ninguno 
        public string tipoDoc { get; set; }
        public string numeroDoc { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string numeroCalle { get; set; }
        public string calle { get; set; }
        public string idCiudad { get; set; }
        public string fechaNacimiento { get; set; } // El unico campo que se puede llegar a realizar alguna operacion 
        // Si se quiere operar fecha de naciemiento usar el metodo ManejoDeTiempos.ParseTime()
    }
}
