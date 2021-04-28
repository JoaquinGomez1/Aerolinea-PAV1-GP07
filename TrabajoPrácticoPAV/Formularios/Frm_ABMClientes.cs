using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Formularios;

namespace TrabajoPrácticoPAV.Formularios
{
    public partial class Frm_ABMClientes : Form
    {
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

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Frm_Principal frmPri = new Frm_Principal();
        //    frmPri.FormCerrado("Frm_ABMClientes");
        //    this.Close();
            
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
