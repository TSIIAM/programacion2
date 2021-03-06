﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana3
{
    class Local
    {
        #region Atributos
        private string direccion ;
        private string razonSocial; /*Unico*/
        private List<string> telefonos = new List<string>();
        private decimal CantMetrosCuadrados;
        #endregion
        #region Constructor
        public Local(string direccion, string telefono, string razonSocial, decimal CantMetrosCuadrados) {
            this.direccion = direccion;
            this.razonSocial = razonSocial;
            this.telefonos.Add(telefono);
            this.CantMetrosCuadrados = CantMetrosCuadrados;
        }
        #endregion
        #region getset RazonSocial
        public string RazonSocial {
            get {
                return razonSocial;
            }
            set {
                razonSocial = value;
            }
        }

        #endregion
    }
}
