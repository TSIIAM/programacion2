using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaDominio
{
    public class Usuario
    {
        private string password;
        private string nombreUsuario;

        public Usuario(string password, string nombreUsuario)
        {
            this.password = password;
            this.nombreUsuario = nombreUsuario;
        }
        public string NombreUsuario
        {
            get
            {
                return this.nombreUsuario;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
        }
    }
}
