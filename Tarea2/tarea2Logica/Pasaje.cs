using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2Logica
{
    public class Pasaje
    {
        private int numAsiento;
        private Vuelo vuelo;
        private static int ultimoId = 1;
        private int idPasaje;
        private DateTime fechaCompra;
        public int IdPasaje {
            get { return idPasaje; }
        }
        public int NumAsiento
        {
            get { return numAsiento; }
        }
        public Vuelo delVuelo
        {
            get { return vuelo; }
        }
        public DateTime FechaCompra
        {
            get { return fechaCompra; }
        }

        public Pasaje(int numAsiento,Vuelo vuelo, DateTime fechaCompra)
        {
            this.numAsiento = numAsiento;
            this.vuelo = vuelo;
            this.idPasaje = ultimoId++;
            this.fechaCompra = fechaCompra;
        }

        public override string ToString()
        {
            return "El Pasaje numero identificador " + this.idPasaje + " numero de asiento [" + this.numAsiento + "]  fecha de compra " + this.fechaCompra + "\n del vuelo destino " + this.vuelo.Destino + " hora de salida "+ this.vuelo.FechaHoraSalida;
        }
    }
}
