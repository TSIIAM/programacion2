using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana4
{
    class Paquete
    {
        #region atributos
        private static int ultimoNumero = 1 ;
        private int numero; public int Numero { get { return numero; }  set { numero = value; } }
        private int peso; public int Peso { get { return peso; }   set { peso = value; } }
        private decimal precioBase; public decimal PrecioBase { get { return precioBase; } set { precioBase = value; } }
        private string direccion; public string Direccion { get { return direccion; } set { direccion = value; } }
        private Remitente remitente; public Remitente Remitente { get { return remitente; } set { remitente = value; } }

        #endregion
        #region constructor
        public Paquete(Remitente remitente, int peso, string direccion, decimal precioBase) {
            this.remitente = remitente;
            this.peso = peso;
            this.direccion = direccion;
            this.precioBase = precioBase;
            this.numero = Paquete.ultimoNumero++;
        }
        #endregion
    }
}
