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
    class NE_Modelo
    {
        Conexion_DB _BD = new Conexion_DB();
        Tratamientos_Especiales tratamiento = new Tratamientos_Especiales();
     
        public DataTable RecuperarXId(string id_Modelo)
        {
            string sql = "SELECT * FROM modelo WHERE idModelo =" + id_Modelo;
            return _BD.EjecutarSelect(sql);
        }

        public void Insertar(Control.ControlCollection controles)
        {
            _BD.Insertar(tratamiento.CostructorInsert("Modelo", controles), false);
        }

        public void Modificar(Control.ControlCollection controles)
        {
            _BD.Modificar(tratamiento.CostructorUpdateDelete("Modelo", controles, true), false);
        }
        public void Borrar(Control.ControlCollection controles)
        {
            _BD.Borrar(tratamiento.CostructorUpdateDelete("Modelo", controles, false), false);
        }
        public void Borrar(string id_modelo)
        {
            string sqlDelete = @"DELETE FROM idModelo WHERE idModelo = " + id_modelo;
            _BD.Borrar(sqlDelete, false);
        }


        public void Cargar_grilla_modelos(DataGridView_Aerolinea grilla_modelos, string join, Control.ControlCollection controls)
        {
            string sql = tratamiento.ConstructorSelect(controls, "", "Modelo");
            DataTable tabla = _BD.EjecutarSelect(sql);

            grilla_modelos.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla_modelos.Rows.Add();
                grilla_modelos.Rows[i].Cells[0].Value = tabla.Rows[i]["nombre"].ToString();
                grilla_modelos.Rows[i].Cells[1].Value = tabla.Rows[i]["idModelo"].ToString();
            }
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron Asientos para ese filtro.");
            }

        }
    }
}
