using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2Logica
{
    public class VueloCharter : Vuelo
    {
        public VueloCharter(string destino, Compania deCompania, DateTime fechaHoraSalida)
            :base(destino,deCompania,fechaHoraSalida)
        {     }

        public override string ToString()
        {
            return base.ToString() + " sin escalas.";
        }

    }
}

