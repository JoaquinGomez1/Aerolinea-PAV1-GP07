﻿using System;
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

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ABMClientes : Form
    {
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();

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
            MessageBox.Show(_TE.ConstructorSelect(this.Controls));
        }

        private void Cmb_Provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmb_Ciudad.CargarCombo();
        }
    }
}
