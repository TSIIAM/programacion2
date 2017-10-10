using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoSemana7_Dominio
{
    public class Cliente
    {
        private string razonSocial;
        private string telefono;
        private string direccion;
        private string nombreContacto;
        public string RazonSocial
        {
            get { return razonSocial; }
        }

        public Cliente(string razonSocial, string telefono, string direccion, string nombreContacto)
        {
            this.razonSocial = razonSocial;
            this.telefono = telefono;
            this.direccion = direccion;
            this.nombreContacto = nombreContacto;
        }

        public override string ToString()
        {
            return "Cliente: " + this.razonSocial + "  Telefono:  " + this.telefono + " Nombre de Contacto: " + this.nombreContacto;

        }
    }
}
