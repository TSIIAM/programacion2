using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana4
{
    class Remitente
    {
        #region atributos
        private string nombre; public string Nombre { get { return nombre; } set { nombre = value; } }
        private string direccion; public string Direccion { get { return direccion; } set { direccion = value; } }
        private string telefono; public string Telefono { get { return telefono; } set { telefono = value; } }
        #endregion
        #region Constructor

        public Remitente(string nombre, string direccion, string telefono) {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }
        #endregion
        public void ModificarDatos(string direccion, string nombre)
        {
            this.direccion = direccion;
            this.nombre = nombre;
        }
        public override string ToString()
        {
            return this.nombre + "-" + this.direccion + "-" + this.telefono;
        }
    }
}
