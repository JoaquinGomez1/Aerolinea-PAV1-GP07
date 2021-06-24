using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Backend;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.Formularios.Pasajeros;
using TrabajoPrácticoPAV.NE_Usuarios;

namespace TrabajoPrácticoPAV.Formularios.Grupos_familiares
{
    public partial class Frm_AltaGrupo : Form
    {
        #region Barra y colores

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Frm_AltaGrupo_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            Panel_Busqueda.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(Panel_Busqueda.Controls);
            Grid_Pasajero.Formatear();
            Cmb_TipoDoc.CargarCombo();
        }

        #endregion Barra y colores

        private int CantFilas = -1;
        private bool agrego2 = true;
        private string tipoDoc = "";
        private string numeroDoc = "";

        private Tratamientos_Especiales _TE = new Tratamientos_Especiales();
        private Conexion_DB _BD = new Conexion_DB();
        private NE_GrupoFamiliar _NE = new NE_GrupoFamiliar();
        private NE_Clientes _NE_Cli = new NE_Clientes();

        public Frm_AltaGrupo()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string join = $" JOIN Tipo_Documento ON Pasajero.tipoDoc = Tipo_Documento.tipoDoc ";
            string sql = _TE.ConstructorSelect(Panel_Busqueda.Controls, join, "Pasajero");
            _NE_Cli.CargarGrilla(sql, Grid_Pasajero);
            Btn_AgregarPrimero.Enabled = false;
            Btn_AgregarSegundo.Enabled = false;
        }

        private void Grid_Pasajero_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Btn_AgregarPrimero.Enabled = true;
            Btn_AgregarSegundo.Enabled = true;
            tipoDoc = _NE_Cli.BuscarIdTipoDoc(Grid_Pasajero.CurrentRow.Cells[2].Value.ToString());
            numeroDoc = Grid_Pasajero.CurrentRow.Cells[3].Value.ToString();
        }

        private void Btn_AgregarPrimero_Click(object sender, EventArgs e)
        {
            if (agrego2)
            {
                CantFilas++;
                Grid_Grupo.Rows.Add();
                Grid_Grupo.Rows[CantFilas].Cells[0].Value = tipoDoc;
                Grid_Grupo.Rows[CantFilas].Cells[1].Value = numeroDoc;
                Grid_Grupo.Rows[CantFilas].Cells[2].Value = _NE.RecuperarNombrePasajero(tipoDoc, numeroDoc);
                Grid_Grupo.Rows[CantFilas].Cells[3].Value = _NE.RecuperarApellidoPasajero(tipoDoc, numeroDoc);
                agrego2 = false;
            }
            else if (!agrego2)
                MessageBox.Show("Primero debe completar la relación existente");
        }

        private void Btn_AgregarSegundo_Click(object sender, EventArgs e)
        {
            if (agrego2)
                MessageBox.Show("Primero debe agregar el primer pasajero de la relación");
            else
            {
                if (Grid_Grupo.Rows[CantFilas].Cells[1].Value.ToString() == numeroDoc && Grid_Grupo.Rows[CantFilas].Cells[0].Value.ToString() == tipoDoc)
                {
                    MessageBox.Show("El primer pasajero y el segundo no pueden ser la misma persona");
                }
                else
                {
                    Grid_Grupo.Rows[CantFilas].Cells[5].Value = tipoDoc;
                    Grid_Grupo.Rows[CantFilas].Cells[6].Value = numeroDoc;
                    Grid_Grupo.Rows[CantFilas].Cells[7].Value = _NE.RecuperarNombrePasajero(tipoDoc, numeroDoc);
                    Grid_Grupo.Rows[CantFilas].Cells[8].Value = _NE.RecuperarApellidoPasajero(tipoDoc, numeroDoc);
                    agrego2 = true;
                }
            }
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            if (ValidarGridGrupo(Grid_Grupo))
                InsertarRelaciones(Grid_Grupo);
            else
                return;
        }

        private void InsertarRelaciones(DataGridView_Aerolinea grid)
        {
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                string tipo1 = grid.Rows[i].Cells[0].Value.ToString();
                string numero1 = grid.Rows[i].Cells[1].Value.ToString();
                string relacion = grid.Rows[i].Cells[4].Value.ToString();
                string tipo2 = grid.Rows[i].Cells[5].Value.ToString();
                string numero2 = grid.Rows[i].Cells[6].Value.ToString();
                string sql = $"INSERT INTO Familiar_X_Pasajero(tipoDocPrimerPasajero,numerodocPrimerPasajero," +
                    $"tipoParentesco,tipoDocSegundoPasajero,numerodocSegundoPasajero) VALUES (" +
                    $"{tipo1}, {numero1}, '{relacion}', {tipo2}, {numero2})";
                try
                {
                    _BD.Insertar(sql, false);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al insertar\n" +
                        "Código del error: " + e.Message);
                }
            }
            this.Close();
        }

        private bool ValidarGridGrupo(DataGridView_Aerolinea grid)
        {
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                if (grid.Rows[i].Cells[4].Value == null)
                {
                    MessageBox.Show("Debe escribir la relación entre estos dos pasajeros");
                    grid.Rows[i].Cells[4].Selected = true;
                    return false;
                }
            }
            return true;
        }

        private void Grid_Pasajero_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_MostrarPasajero mostrar = new Frm_MostrarPasajero();

            mostrar.tipoDoc = tipoDoc;
            mostrar.numeroDoc = numeroDoc;

            mostrar.ShowDialog();
        }

        private void Grid_Grupo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indiceClickeado = Grid_Grupo.CurrentCell.ColumnIndex;
            if (indiceClickeado == 2 || indiceClickeado == 3)
            {
                Frm_MostrarPasajero mostrar = new Frm_MostrarPasajero();

                mostrar.tipoDoc = Grid_Grupo.CurrentRow.Cells[0].Value.ToString();
                mostrar.numeroDoc = Grid_Grupo.CurrentRow.Cells[1].Value.ToString(); ;

                mostrar.ShowDialog();
            }
            else if (indiceClickeado == 7 || indiceClickeado == 8)
            {
                Frm_MostrarPasajero mostrar = new Frm_MostrarPasajero();

                mostrar.tipoDoc = Grid_Grupo.CurrentRow.Cells[5].Value.ToString();
                mostrar.numeroDoc = Grid_Grupo.CurrentRow.Cells[6].Value.ToString(); ;

                mostrar.ShowDialog();
            }
        }
    }
}