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
using TrabajoPrácticoPAV.Formularios;
using TrabajoPrácticoPAV.NE_Usuarios;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ABMClientes : Form
    {
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();
        Conexion_DB _BD = new Conexion_DB();

        public Frm_ABMClientes()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cal_fecha_nacimiento_DateChanged(object sender, DateRangeEventArgs e)
        {

            if (((MonthCalendar)sender).SelectionRange.Start > DateTime.Now.Date)
            {
                MessageBox.Show("Fecha inválida seleccione una fecha anterior a la de hoy");
                ((MonthCalendar)sender).Focus();
            }

            MessageBox.Show(((MonthCalendar)sender).SelectionRange.End.ToString());

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales tratamientos = new Tratamientos_Especiales();
            tratamientos.Validar(this.Controls);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_ABMClientes_Load(object sender, EventArgs e)
        {
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
            Cmb_TipoDoc.CargarCombo();
            Cmb_Pais.CargarCombo();
            DGV_Pasajero.Formatear();
        }

        private void Cmb_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmb_Provincia.CargarCombo();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string join = $" JOIN Ciudad Ciudad ON Pasajero.idCiudad = Ciudad.idCiudad JOIN Provincia Provincia ON " +
                $"Provincia.idProvincia = Ciudad.idProvincia JOIN Pais Pais ON Pais.idPais = Provincia.idPais JOIN " +
                $"Tipo_Documento Tipo_Documento ON Pasajero.tipoDoc = Tipo_Documento.tipoDoc JOIN Telefono " +
                $"ON Pasajero.tipoDoc = Telefono.tipoDoc AND Pasajero.numeroDoc = Telefono.numeroDoc ";
            MessageBox.Show(_TE.ConstructorSelect(this.Controls, join));
        }

        private void Cmb_Provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmb_Ciudad.CargarCombo();
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
