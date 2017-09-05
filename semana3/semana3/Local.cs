using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana3
{
    class Local
    {
        #region Atributos
        private string direccion;
        private string razonSocial; /*Unico*/
        private string telefono;
        private decimal CantMetrosCuadrados;
        #endregion
        #region Constructor
        public Local(string direccion, string telefono, string razonSocial, decimal CantMetrosCuadrados) {
            this.direccion = direccion;
            this.razonSocial = razonSocial;
            this.telefono = telefono;
            this.CantMetrosCuadrados = CantMetrosCuadrados;
        }
        #endregion
    }
}
