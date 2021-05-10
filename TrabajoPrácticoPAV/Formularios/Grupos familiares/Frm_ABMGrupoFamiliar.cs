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
using TrabajoPrácticoPAV.Formularios.Pasajeros;
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

            Cmb_TipoDoc.CargarCombo();
            grid_Familiares.Pp_FormatoGrid = "numeroDocPrimerPasajero,Nombre , 100;" +
                "tipoDocPrimerPasajero, Apellido, 70;" +
                "tipoParentesco, Relación, 100;" +
                "numeroDocSegundoPasajero, Nombre, 100;" +
                "tipoDocSegundoPasajero, Apellido, 70";
            grid_Familiares.Formatear();
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            string sql = _NE.ConstructorSelect(this.Controls);
            _NE.CargarGrilla(sql, grid_Familiares);
            if(grid_Familiares.Rows.Count < 1)
                MessageBox.Show("El pasajero buscado no existe o no pertenece a ningún grupo familiar");
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid_Familiares_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceClickeado = grid_Familiares.CurrentCell.ColumnIndex;

            Frm_MostrarPasajero mostrar = new Frm_MostrarPasajero();

            if(indiceClickeado == 4 || indiceClickeado == 5)
            {
                mostrar.tipoDoc = grid_Familiares.CurrentRow.Cells["tipodoc1"].Value.ToString();
                mostrar.numeroDoc = grid_Familiares.CurrentRow.Cells["numero1"].Value.ToString();
            }
            else if(indiceClickeado == 7 || indiceClickeado == 8)
            {
                mostrar.tipoDoc = grid_Familiares.CurrentRow.Cells["tipodoc2"].Value.ToString();
                mostrar.numeroDoc = grid_Familiares.CurrentRow.Cells["numero2"].Value.ToString();
            }
            else
            {
                return;
            }

            mostrar.ShowDialog();
        }

        private void btn_limpiar1_Click(object sender, EventArgs e)
        {
            Txt_Apellido.Text = "";
            Txt_nombre.Text = "";
            Cmb_TipoDoc.SelectedIndex = -1;
            grid_Familiares.Rows.Clear();
            chk_Todos.Checked = false;
            Msktxt_NumeroDOC.Text = "";
        }

        private void btn_registrar1_Click(object sender, EventArgs e)
        {
            Frm_AltaGrupo alta = new Frm_AltaGrupo();
            alta.ShowDialog();
        }

        private void btn_borrar1_Click(object sender, EventArgs e)
        {
            Frm_EliminarGrupo elim = new Frm_EliminarGrupo();

            elim.tipoDoc1 = grid_Familiares.CurrentRow.Cells["tipodoc1"].Value.ToString();
            elim.numeroDoc1 = grid_Familiares.CurrentRow.Cells["numero1"].Value.ToString();
            elim.tipoDoc2 = grid_Familiares.CurrentRow.Cells["tipodoc2"].Value.ToString();
            elim.numeroDoc2 = grid_Familiares.CurrentRow.Cells["numero2"].Value.ToString();
            elim.relacion = grid_Familiares.CurrentRow.Cells["tipoParentesco"].Value.ToString();

            elim.ShowDialog();
        }

        private void btn_modificar1_Click(object sender, EventArgs e)
        {
            Frm_ModificarGrupo modif = new Frm_ModificarGrupo();

            modif.tipoDoc1 = grid_Familiares.CurrentRow.Cells["tipodoc1"].Value.ToString();
            modif.numeroDoc1 = grid_Familiares.CurrentRow.Cells["numero1"].Value.ToString();
            modif.tipoDoc2 = grid_Familiares.CurrentRow.Cells["tipodoc2"].Value.ToString();
            modif.numeroDoc2 = grid_Familiares.CurrentRow.Cells["numero2"].Value.ToString();
            modif.relacion = grid_Familiares.CurrentRow.Cells["tipoParentesco"].Value.ToString();

            modif.ShowDialog();
        }

        private void grid_Familiares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Btn_Modificar.Enabled = true;
            Btn_Eliminar.Enabled = true;
        }
    }
}
