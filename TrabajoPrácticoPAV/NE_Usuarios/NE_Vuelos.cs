﻿using System;
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
        public string Pp_id_vuelo { get; set; }

        public enum ResultadoValidacion { exite, no_existe }
        Conexion_DB _BD = new Conexion_DB();

        public DataTable RecuperarXId(string id_vuelo)
        {
            string sql = "SELECT * FROM vuelo WHERE idVuelo =" + id_vuelo;
            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT v.*, m.nombre as n_modelo FROM vuelo v join Modelo m  on v.idModelo = m.idModelo;";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuprarXmodelo(string id_modelo)
        {
            string sql = @"SELECT v.*, m.nombre as n_modelo  FROM vuelo v join Modelo m on v.idModelo = m.idModelo"
                            + " WHERE m.idModelo = " + id_modelo;
            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarXavion(string id_avion)
        {
            string sql = @"SELECT v.*, m.nombre as n_modelo  FROM vuelo v join Modelo m on v.idModelo = m.idModelo"
                            + "  WHERE v.numeroPorModelo =" + id_avion;
            ;
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_Mixto(string avion, string modelo)
        {
            string sql = @"SELECT v.*, m.nombre as n_modelo FROM vuelo v join Modelo m on v.idModelo = m.idModelo"
                        + " WHERE v.numeroPorModelo = " + avion + " AND m.idModelo = " + modelo;
            return _BD.EjecutarSelect(sql);
        }


        public void Insertar(Control.ControlCollection controles)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
            _BD.Insertar(tratamiento.CostructorInsert("Vuelo", controles));
        }

        public void Modificar(Control.ControlCollection controles)
        {
            Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
            _BD.Modificar(tratamiento.CostructorUpdateDelete("Vuelo", controles, true));
        }
        //public void Borrar(Control.ControlCollection controles)
        //{
        //    string sqlDelete = @"DELETE FROM vuelo WHERE idVuelo = " + Pp_id_Vuelo;
        //    _BD.Borrar(sqlDelete);
        //}
        public void Borrar(string id_vuelo)
        {
            string sqlDelete = @"DELETE FROM vuelo WHERE idVuelo = " + id_vuelo;
            _BD.Borrar(sqlDelete);
        }

    }
}
