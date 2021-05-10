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
    class NE_Asiento
    {
        Conexion_DB _BD = new Conexion_DB();
        public enum ResultadoValidacion { existe, no_existe }
        //public string BuscarTodos()
        //{
        //    string sql = "SELECT * FROM asientos WHERE idVuelo";
        //    return _BD.EjecutarSelect(sql);
        //}
        public DataTable RecuperarXId(string id_Asiento)
        {
            string sql = "SELECT * FROM Asientos WHERE numeroAsiento =" + id_Asiento;
            return _BD.EjecutarSelect(sql);
        }

        //public DataTable RecuprarXmodelo(string id_modelo)
        //{
        //    string sql = @"SELECT v.*, m.nombre as n_modelo  FROM vuelo v join Modelo m on v.idModelo = m.idModelo"
        //                    + " WHERE m.idModelo = " + id_modelo;
        //    return _BD.EjecutarSelect(sql);
        //}
        //public DataTable RecuperarXavion(string id_avion)
        //{
        //    string sql = @"SELECT v.*, m.nombre as n_modelo  FROM vuelo v join Modelo m on v.idModelo = m.idModelo"
        //                    + "  WHERE v.numeroPorModelo =" + id_avion + 1;
        //    return _BD.EjecutarSelect(sql);
        //}
        //public DataTable Recuperar_Mixto(string avion, string modelo)
        //{
        //    string sql = @"SELECT v.*, m.nombre as n_modelo FROM vuelo v join Modelo m on v.idModelo = m.idModelo"
        //                + " WHERE v.numeroPorModelo = " + avion + " AND m.idModelo = " + modelo;
        //    return _BD.EjecutarSelect(sql);
        //}
        //public void Insertar(Control.ControlCollection controles)
        //{
        //    Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
        //    _BD.Insertar(tratamiento.CostructorInsert("Vuelo", controles), false);
        //}

        //public void Modificar(Control.ControlCollection controles)
        //{
        //    Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
        //    _BD.Modificar(tratamiento.CostructorUpdateDelete("Vuelo", controles, true), false);
        //}
        //public void Borrar(Control.ControlCollection controles)
        //{
        //    Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
        //    _BD.Borrar(tratamiento.CostructorUpdateDelete("Vuelo", controles, false), false);
        //}
        //public void Borrar(string id_vuelo)
        //{
        //    string sqlDelete = @"DELETE FROM vuelo WHERE idVuelo = " + id_vuelo;
        //    _BD.Borrar(sqlDelete, false);
        //}
        public void Borrar(string id_Asiento)
        {
            string sqlDelete = @"DELETE FROM Asientos WHERE numeroAsiento = " + id_Asiento;
            _BD.Borrar(sqlDelete, false);
        }
    }
}
