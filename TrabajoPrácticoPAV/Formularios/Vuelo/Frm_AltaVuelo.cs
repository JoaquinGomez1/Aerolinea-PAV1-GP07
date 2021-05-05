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
using TrabajoPrácticoPAV.NE_Usuarios;
using TrabajoPrácticoPAV.Backend;

namespace TrabajoPrácticoPAV.Formularios.Vuelo
{
    public partial class Frm_AltaVuelo : Form
    {
        public Frm_AltaVuelo()
        {
            InitializeComponent();
        }

        private void Frm_AltaVuelo_Load(object sender, EventArgs e)
        {
            cmb_numAvion.CargarCombo();
            cmb_nomModelo.CargarCombo();
            cmb_AeropDestino.CargarCombo();
            cmb_AeropSalida.CargarCombo();

        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Tratamientos_Especiales Tratamiento = new Tratamientos_Especiales();
            Conexion_DB _BD = new Conexion_DB();

            if (Tratamiento.Validar(this.Controls) == Tratamientos_Especiales.Resultado.correcto)
            {
                Tratamiento.Validar(this.Controls);
                string sql = Tratamiento.CostructorInsert("Vuelo", this.Controls);
                _BD.Insertar(sql);
            }
            else
            {
                return;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
