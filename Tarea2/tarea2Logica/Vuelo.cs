
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2Logica
{
    public class Vuelo
    {
        private static int ultimoId = 1;
        private int idVuelo;
        private string destino;
        private Compania deCompania;
        private DateTime fechaHoraSalida;

        public int IdVuelo
        {
            get { return idVuelo; }

        }
        public string Destino
        {
            get { return destino; }

        }
        public DateTime FechaHoraSalida
        {
            get { return fechaHoraSalida; }

        }


        public Vuelo(string destino, Compania deCompania, DateTime fechaHoraSalida)
        {
            this.destino = destino;
            this.deCompania = deCompania;
            this.fechaHoraSalida = fechaHoraSalida;
            this.idVuelo = Vuelo.ultimoId++;

        }
        public override string ToString()
        {
            return "El vuelo numero [" + this.idVuelo + "] destino " + this.destino + " de la compania es " + this.deCompania.RazonSocial + "\n" + " saldra el Dia " + this.fechaHoraSalida.Day +
                " hora " + this.fechaHoraSalida.Hour + " minuto  " + this.fechaHoraSalida.Minute;
             
        }

    }
}
