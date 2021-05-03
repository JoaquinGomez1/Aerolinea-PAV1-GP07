using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TrabajoPrácticoPAV.Clase;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_Vuelos
    {

        public string Pp_id_Vuelo { get; set; }
        public string Pp_duracionEst { get; set; }
        public string Pp_numPorModelo { get; set; }
        public string Pp_modelo { get; set; }
        public string Pp_tramo { get; set; }

        public enum ResultadoValidacion { exite, no_existe }
        Conexion_DB _BD = new Conexion_DB();


        //public void Insertar()
        //{
        //    string sqlInsertar = @"INSERT INTO vuelo (idVuelo, duracionEstimada, NumeroPorModelo"
        //                        + ", idModelo, idTramo) "
        //                        + " VALUES ("
        //                        + Pp_id_Vuelo
        //                        + ", '" + Pp_duracionEst + "'"
        //                        + ", '" + Pp_numPorModelo + "'"
        //                        + ", '" + Pp_modelo + "'"
        //                        + ", '" + Pp_tramo + "')";
        //    _BD.Insertar(sqlInsertar);
        //}

        public void Insertar(Control.ControlCollection controles)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
            _BD.Insertar(tratamiento.CostructorInsert("Vuelo", controles));
        }
    }
}
