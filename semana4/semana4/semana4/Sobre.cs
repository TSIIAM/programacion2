using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana4
{
    class Sobre : Paquete
    {
        private string tamanio;

        public Sobre(string direccion, Remitente remitente, int peso, string tamanio) : base(remitente, peso, direccion)
        {
            this.tamanio = tamanio;
        }

        public override string ToString()
        {
            return this.tamanio + " " + this.Numero;
        }
    }
}
