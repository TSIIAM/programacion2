using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2Logica
{
    public class Compania
    {
        private string razonSocial;
        private string telefono;
        private string direccion;

        public string RazonSocial
        {
            get { return razonSocial; }

        }
        public Compania(string razonSocial, string telefono, string direccion)
        {
            this.razonSocial = razonSocial;
            this.telefono = telefono;
            this.direccion = direccion;
             
        }
        public override string ToString()
        {
            return " La compania " + this.razonSocial + " telefono " + this.telefono;
        }
    }
}
