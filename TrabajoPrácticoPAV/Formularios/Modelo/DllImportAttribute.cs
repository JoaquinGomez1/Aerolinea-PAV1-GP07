using System;

namespace TrabajoPrácticoPAV.Formularios.Modelo
{
    internal class DllImportAttribute : Attribute
    {
        private string v;
        private string EntryPoint;

        public DllImportAttribute(string v, string EntryPoint)
        {
            this.v = v;
            this.EntryPoint = EntryPoint;
        }
    }
}