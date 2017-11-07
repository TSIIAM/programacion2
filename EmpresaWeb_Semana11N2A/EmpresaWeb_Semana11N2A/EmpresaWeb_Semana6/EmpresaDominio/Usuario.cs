using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaDominio
{
    public class Usuario
    {
        public string Password { get; set; }
        public string NombreUsuario { get; set; }


        public Usuario(string password, string nombreUsuario) {
            this.Password = password;
            this.NombreUsuario = nombreUsuario;
        }
    }
}
