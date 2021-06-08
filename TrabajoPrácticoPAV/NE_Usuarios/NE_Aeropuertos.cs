using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TrabajoPrácticoPAV.Backend;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_Aeropuertos
    {
        public string Pp_codigo { get; set; }
        public string Pp_nombre { get; set; }
        public string Pp_idCiudad { get; set; }
        public string Pp_Id_aeropuerto { get; set; }

        Conexion_DB _BD = new Conexion_DB();

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Aeropuerto (codigo, nombre, idCiudad)"
                                + "VALUES ("
                                + "'" + Pp_codigo + "', "
                                + "'" + Pp_nombre + "', "
                                + Pp_idCiudad + ")";
            _BD.Insertar(sqlInsertar, false);
        }

        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT a.* FROM Aeropuerto a ";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Reporte_recuperarTodos()
        {
            string sql = @"select codigo, nombre,idCiudad from aeropuerto ";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_por_CodigoYNombre(string patronNombre , string codigo)
        {
            string sql = @"SELECT a.* FROM Aeropuerto a "
                        +" WHERE a.codigo = " + "'" + codigo + "'"
                        + " AND a.nombre like '%" + patronNombre.Trim() + "%'";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable Recuperar_por_Codigo(string codigo)
        {
            string sql = @"SELECT a.* FROM Aeropuerto a "
                        +" WHERE a.codigo = " + "'" + codigo + "'";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_por_PatronNombre(string patronNombre)
        {
            string sql = @"SELECT a.* FROM Aeropuerto a "
                     + " WHERE a.nombre like '%" + patronNombre.Trim() + "%'";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable Recuperar_por_ciudad(string ciudad)
        {
            string sql = @"SELECT a.* FROM Aeropuerto a "
                     + " WHERE a.idCiudad = " + ciudad;
            return _BD.EjecutarSelect(sql);
        }

        public void Modificar()
        {
            string sqlModificar = @"UPDATE Aeropuerto SET"
                                  + " nombre = '" + Pp_nombre + "'"
                                  + " , idCiudad = " + Pp_idCiudad
                                  + " WHERE codigo = '" + Pp_Id_aeropuerto + "'";
            _BD.Modificar(sqlModificar, false);
        }
        public void Borrar()
        {
            string sqlDelete = "DELETE FROM Aeropuerto WHERE codigo = '" + Pp_Id_aeropuerto + "'";
            _BD.Borrar(sqlDelete, false);
        }
    }
}