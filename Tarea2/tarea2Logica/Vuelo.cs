
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


        public Vuelo(string destino, Compania deCompania, DateTime fechaHoraSalida)
        {
            this.destino = destino;
            this.deCompania = deCompania;
            this.fechaHoraSalida = fechaHoraSalida;
            this.idVuelo = Vuelo.ultimoId++;

        }

    }
}
