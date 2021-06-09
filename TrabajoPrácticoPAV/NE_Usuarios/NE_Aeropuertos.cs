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
            string sql = @"select codigo, nombre,c.nombreCiudad as idCiudad from aeropuerto join ciudad c on c.idCiudad = Aeropuerto.idCiudad ";
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
        public DataTable  Reporte_recuperarXCodigo(string codigo)
        {
            string sql = @"SELECT a.codigo, a.nombre, c.nombreCiudad as idCiudad from Aeropuerto a join ciudad c on c.idCiudad = A.idCiudad "
                        + " WHERE a.codigo = " + "'" + codigo + "'";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Reporte_recuperarXCodigoRango(string codigoDes, string codigoHast)
        {
            if (codigoDes == "")
                codigoDes = "a";
            if (codigoHast == "")
                codigoHast = "Z";

            string sql = @"SELECT a.codigo, a.nombre, c.nombreCiudad as idCiudad from Aeropuerto a join ciudad c on c.idCiudad = A.idCiudad "
                        + " WHERE a.codigo like '[" + codigoDes + "-"+codigoHast + "]%'";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_por_PatronNombre(string patronNombre)
        {
            string sql = @"SELECT a.* FROM Aeropuerto a "
                     + " WHERE a.nombre like '%" + patronNombre.Trim() + "%'";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Reporte_recuperarXNonmbre(string patronNombre)
        {
            string sql = @"SELECT a.codigo, a.nombre, c.nombreCiudad as idCiudad from Aeropuerto a join ciudad c on c.idCiudad = A.idCiudad "
                   + " WHERE a.nombre like '%" + patronNombre.Trim() + "%'";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_por_ciudad(string ciudad)
        {
            string sql = @"SELECT a.* FROM Aeropuerto a "
                     + " WHERE a.idCiudad = " + ciudad;
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Reporte_recuperarXpais(string pais)
        {
            string sql = @"select a.codigo, a.nombre, c.nombreCiudad as idCiudad from Aeropuerto a"+
               " join ciudad c on c.idCiudad = a.idCiudad join Provincia p on c.idProvincia = p.idProvincia "+
                " join pais pa on p.idPais = "+ pais;
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Reporte_recuperarXciudad(string ciudad)
       {
            string sql = @"SELECT a.codigo, a.nombre, c.nombreCiudad as idCiudad from Aeropuerto a join ciudad c on c.idCiudad = A.idCiudad "
                     + " WHERE c.nombreCiudad like '%" + ciudad.Trim() + "%'";
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