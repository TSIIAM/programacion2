using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2Logica
{
    public class Cliente
    {
        #region atributos
        private string nombre;
        private string apellido;
        private string celular;
        private int pasaporte;
        private List<Pasaje> pasajes = new List<Pasaje>();
        #endregion
        public int Pasaporte
        {
            get { return pasaporte; }

        }
        public Cliente(string nombre, string apellido, string celular, int pasaporte, Pasaje pasaje)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
            this.pasaporte = pasaporte;
            this.pasajes.Add(pasaje);
        }

        public override string ToString()
        {
            string listaPasajes = "";
            for (int i = 0; i < pasajes.Count; i++)
            {

                listaPasajes += pasajes[i].NumAsiento + " de " + pasajes[i].delVuelo.ToString() + "\n";


            }

            return "El Cliente " + this.nombre + " " + this.apellido + " celular  " + this.celular + " pasaporte " + this.pasaporte + "\n"
                                 + " compro pasaje numero de Asiento " + listaPasajes;
        }
    }
}
