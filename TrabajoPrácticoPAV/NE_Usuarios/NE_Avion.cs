using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.NE_Aviones
{
    class NE_Avion
    {
        public int Pp_numero_modelo { get; set; }
        public int Pp_id_modelo { get; set; }

        Conexion_DB _BD = new Conexion_DB();

        //DataTable tabla = new DataTable();

        public DataTable RecuperarTodos()
        {
            // string sql = @"SELECT u.*, p.nombre as n_perfil "
            //               + " FROM usuarios u join perfiles p "
            //               + " on u.id_perfil = p.id_perfil ";

            string sql = @"SELECT Avion.numeroPorModelo,Modelo.nombre from Avion inner join  Modelo on Avion.idModelo = Modelo.idModelo order by Modelo.nombre, Avion.numeroPorModelo";

            return _BD.EjecutarSelect(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Avion (numeroPorModelo, idModelo) " + " VALUES ( " + Pp_numero_modelo + ", " + Pp_id_modelo + ")";
            _BD.Insertar(sqlInsertar);
        }

        // recuperar mixto
        public DataTable Recuperar_Mixto(string numero, int modelo)
        {
            string sql = @"SELECT Avion.numeroPorModelo, Modelo.nombre from Avion "
            + " inner join Modelo on Avion.idModelo = Modelo.idModelo "
            + "  where Avion.numeroPorModelo = " + numero
            + " and Avion.idModelo = " + modelo;
            ;
            return _BD.EjecutarSelect(sql);
        }
    }
}


