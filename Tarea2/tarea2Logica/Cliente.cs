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
        #endregion
        public int Pasaporte
        {
            get { return pasaporte; }
            
        }
        public Cliente(string nombre, string apellido, string celular, int pasaporte)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
            this.pasaporte = pasaporte;
        }
        
    }
}
