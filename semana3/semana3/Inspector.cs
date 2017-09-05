using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana3
{
    class Inspector
    {
        #region Atributos
        private string nombre;
        private string cedula;
        private int codigoFuncionario; /*UNICO*/

        #endregion
        #region Constructor
        public Inspector(string nombre, string cedula, int codigoFuncionario) {
            this.nombre = nombre;
            this.cedula = cedula;
            this.codigoFuncionario = codigoFuncionario;
 
        }
        #endregion
        #region getset CodigoFuncionario
        public int CodigoFuncionario
        {
            get
            {
                return codigoFuncionario;
            }
            set
            {
                codigoFuncionario = value;
            }
        }

        #endregion

    }




}
