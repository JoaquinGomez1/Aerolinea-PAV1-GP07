using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.Formularios.Asientos
{
    public partial class Frm_AltaAsientos : Form
    {
        public Frm_AltaAsientos()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_AltaAsientos_Load(object sender, EventArgs e)
        {
            cmb_nombreModelo.CargarCombo();
            cmb_clase.CargarCombo();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
        }

        private void btn_registrarAsiento_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales Tratamiento = new Tratamientos_Especiales();

            if (Tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                Conexion_DB _BD = new Conexion_DB();
                Tratamiento.Validar(this.Controls);
               // if (cmb_AeropSalida.SelectedIndex != cmb_AeropDestino.SelectedIndex)
                //{
                    string sql = Tratamiento.CostructorInsert("Asientos", this.Controls);
                    _BD.Insertar(sql, false);
                    this.Close();
                //}
                //else
                //{
                //    MessageBox.Show("El aeropuerto de salida no puede ser igual al aeropuerto de destino. Seleccione otro");
                //}
            }
            else
            {
                return;
            }
        }

        private void cmb_nombreModelo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_numeroAvion.SelectedIndex = -1;
            cmb_clase.SelectedIndex = -1;
            string CondicionAvion = @" JOIN Modelo ON Modelo.idModelo " +
                       @"= Avion.idModelo WHERE Modelo.idModelo = " + cmb_nombreModelo.SelectedValue;
            cmb_numeroAvion.CargarComboJoin(CondicionAvion);
        }

        private void cmb_numeroAvion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_clase.SelectedIndex = -1;
            //string condicionClase = @"JOIN Asientos ON Tipo_Asiento.idTipo" +
            //                  @"= Asientos.tipoAsiento WHERE Asientos.numeroPorModelo = " + cmb_numeroAvion.SelectedValue;
            //string condicionClase = @"JOIN Asientos ON Tipo_Asiento.idTipo" +
            //                        @"= Asientos.tipoAsiento WHERE Asientos.numeroPorModelo = " + cmb_numeroAvion.SelectedValue;
            //cmb_clase.CargarComboJoin(condicionClase);
        }
    }
}
