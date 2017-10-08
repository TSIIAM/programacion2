using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2Logica
{
    public class Compania
    {
        private int razonSocial;
        private string telefono;
        private string direccion;

        public int RazonSocial
        {
            get { return razonSocial; }

        }
        public Compania(int razonSocial, string telefono, string direccion)
        {
            this.razonSocial = razonSocial;
            this.telefono = telefono;
            this.direccion = direccion;
             
        }
    }
}
