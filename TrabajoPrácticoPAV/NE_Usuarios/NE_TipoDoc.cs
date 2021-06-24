using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_TipoDoc
    {
        public string Pp_nombre_Tipo_Doc { get; set; }
        public object Pp_id_TipoDoc { get; set; }

        Conexion_DB _BD = new Conexion_DB();

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Tipo_Documento (nombreTipoDoc) " + " VALUES ( '" + Pp_nombre_Tipo_Doc + "');";
            _BD.Insertar(sqlInsertar, false);
        }

        public void Borrar()
        {
            string sql = @"delete from Tipo_Documento where tipoDoc = " + Pp_id_TipoDoc;
            _BD.Borrar(sql, false);
        }

        public void Editar()
        {
            string sql = @"update Tipo_Documento set nombreTipoDoc = '" + Pp_nombre_Tipo_Doc + "' where tipoDoc = " + Pp_id_TipoDoc;
            _BD.Modificar(sql, false);
        }
    }
}
