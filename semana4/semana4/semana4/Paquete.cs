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
        static decimal precioBase = 10;
        private string direccion; public string Direccion { get { return direccion; } set { direccion = value; } }
        private Remitente remitente; public Remitente Remitente { get { return remitente; } set { remitente = value; } }

        #endregion
        #region Propiedades

        #endregion
        #region constructor
        public Paquete(Remitente remitente, int peso, string direccion) {
            this.remitente = remitente;
            this.peso = peso;
            this.direccion = direccion;
             this.numero = Paquete.ultimoNumero++;
        }
        #endregion
        #region Metodos
        public void ModificarPaquete(int peso, string direccion)
        {
            this.direccion = direccion;
            this.peso = peso;
         }
        public decimal CalcularCosto()
        {
            decimal costo = 0;
            if (peso < 1)
            {
                costo = Paquete.precioBase;
            }
            else if (peso > 1 && peso <= 3)
            {
                costo = Paquete.precioBase * new Decimal(1.10);
            }
            else if (peso > 3)
            {
                costo = Paquete.precioBase * new Decimal(1.20);
            }
            return costo;
        }
        public override string ToString()
        {
            return this.numero + "-" + this.peso + "-" + Paquete.precioBase + "-" + this.direccion;
        }
        #endregion
    }
}
