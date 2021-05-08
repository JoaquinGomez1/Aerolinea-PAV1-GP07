using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPrácticoPAV.Clase;

namespace TrabajoPrácticoPAV.NE_Usuarios
{
    class NE_pais
    {
        Tratamientos_Especiales _TE = new Tratamientos_Especiales();

        public bool verificar_seleccion (TextBox_Aerolinea nombre, MaskedTextBox_Aerolinea id, CheckBox todos)
        {
            if (nombre.Text == "" & id.Text == "" & todos.Checked==false)
            {
                MessageBox.Show("Debe ingresar al menos un dato o seleccionar todos");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
