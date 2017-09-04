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
        private List<string> telefonos = new List<string>();
        private int CantMetrosCuadrados;
        #endregion
        #region Constructor
        public Local(string direccion, string razonSocial,int CantMetrosCuadrados) { }
        #endregion
    }
}
