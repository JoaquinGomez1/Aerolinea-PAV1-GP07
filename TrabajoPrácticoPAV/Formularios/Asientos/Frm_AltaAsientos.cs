﻿using System;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;
using TrabajoPrácticoPAV.NE_Usuarios;
using System.Runtime.InteropServices;

namespace TrabajoPrácticoPAV.Formularios.Asientos
{
    public partial class Frm_AltaAsientos : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void BarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private NE_Asiento asiento = new NE_Asiento();

        public Frm_AltaAsientos()
        {
            InitializeComponent();
            this.BackColor = Estilo.ColorFondoForms;
            Estilo.FormatearEstilo(this.Controls);
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

            if (Tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto
                 && Tratamiento.Validar(this.panel1.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                for (int i = 0; i < Int32.Parse(mtxt_cantidad.Text); i++)
                {
                    //string sql = Tratamiento.CostructorInsert("Asientos", panel1.Controls);
                    //_BD.Insertar(sql, false);
                    asiento.Insertar(this.Controls);
                    this.Close();
                }
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
    }
}