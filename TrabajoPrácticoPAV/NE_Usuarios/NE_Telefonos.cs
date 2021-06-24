using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPrácticoPAV.Backend;
using System.Data;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_Telefonos
    {
        public string Pp_numeroTelefono { get; set; }
        public int Pp_tipoDoc { get; set; }
        public int Pp_numeroDoc { get; set; }
        Conexion_DB _BD = new Conexion_DB();
        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Telefono (numeroTelefono, tipoDoc, numeroDoc)"
                                + " VALUES ("
                                +  "'" + Pp_numeroTelefono + "', "
                                + Pp_tipoDoc + ", "
                                + Pp_numeroDoc + ")";
            _BD.Insertar(sqlInsertar, false);
        }
        public void Modificar()
        {
            string sqlInsertar = @"UPDATE Telefono (numeroTelefono, tipoDoc, numeroDoc)"
                                + " SET ("
                                + "'"+ Pp_numeroTelefono + "', "
                                + Pp_tipoDoc + ", "
                                + Pp_numeroDoc + ")";
            _BD.Insertar(sqlInsertar, false);

        }
        public void Borrar()
        {
            string sqlDelete = "DELETE FROM Telefono WHERE numeroTelefono = '" + Pp_numeroTelefono + "'";
            _BD.Borrar(sqlDelete, false);
        }
        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT * FROM Telefono ";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable Recuperar_x_numero()
        {
            string sql = $"SELECT * FROM Telefono WHERE numeroTelefono = '" + Pp_numeroTelefono + "'";
            return _BD.EjecutarSelect(sql);
        }

    }
}
