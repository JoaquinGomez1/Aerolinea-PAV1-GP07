using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Grupos_familiares
{
    public partial class Frm_ABMGrupoFamiliar : Form
    {
        public Frm_ABMGrupoFamiliar()
        {
            InitializeComponent();
        }

        Tratamientos_Especiales _TE = new Tratamientos_Especiales();
        NE_GrupoFamiliar _NE = new NE_GrupoFamiliar();

        private void Frm_ABMGrupoFamiliar_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);

            grid_Familiares.Pp_FormatoGrid = "numeroDocPrimerPasajero, Numero de Documento, 100;" +
                "tipoDocPrimerPasajero, Tipo de Documento, 70;" +
                "tipoParentesco, Relación, 100;" +
                "numeroDocSegundoPasajero, Numero de Documento, 100;" +
                "tipoDocSegundoPasajero, Tipo de Documento, 70";
            grid_Familiares.Formatear();
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            string sql = _TE.ConstructorSelect(this.Controls, "");
            _NE.CargarGrilla(sql, grid_Familiares);

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
