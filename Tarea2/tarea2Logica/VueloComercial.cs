using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2Logica
{
    public class VueloComercial : Vuelo
    {
        private List<string> listaAeropuertos = new List<string>();


        public VueloComercial(string destino, Compania deCompania, DateTime fechaHoraSalida, params string[] aeropuertos)
            :base(destino,deCompania,fechaHoraSalida)
        {
            for (int i = 0; i < aeropuertos.Length; i++)
            {
                if (!listaAeropuertos.Contains(aeropuertos[i])) {
                   this.listaAeropuertos.Add(aeropuertos[i]);
                }
                
            }
        }
      
    }
}
