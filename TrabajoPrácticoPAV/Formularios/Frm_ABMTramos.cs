using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.NE_Usuarios;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ABMTramos : Form
    {
        public Frm_ABMTramos()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ABMTramos_Load(object sender, EventArgs e)
        {
            grid_tramos.Formatear();
            cmb_ADestino.CargarCombo();
            cmb_ASalida.CargarCombo();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            NE_Tramos tramo = new NE_Tramos();
            Conexion_DB _BD = new Conexion_DB();
            Tratamientos_Especiales _TE = new Tratamientos_Especiales();
            MessageBox.Show(_TE.ConstructorSelect(this.Controls));
            //string sql = tramo.Constructor_select(chb_todos_tramo, cmb_ADestino, cmb_ASalida, txt_numero, "Tramo");
            //DataTable tabla = _BD.EjecutarSelect(sql);
            //CargarGrilla(tabla);
            
        }
        
        private void CargarGrilla (DataTable tabla)
        {
            grid_tramos.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_tramos.Rows.Add();
                grid_tramos.Rows[i].Cells[0].Value = tabla.Rows[i]["idTramo"].ToString();
                grid_tramos.Rows[i].Cells[1].Value = tabla.Rows[i]["codigoAeropuertoSalida"].ToString();
                grid_tramos.Rows[i].Cells[2].Value = tabla.Rows[i]["codigoAeropuertodestino"].ToString();
                grid_tramos.Rows[i].Cells[3].Value = tabla.Rows[i]["duracion"].ToString();
                grid_tramos.Rows[i].Cells[4].Value = tabla.Rows[i]["distancia"].ToString();
            }

        }
    }
}
