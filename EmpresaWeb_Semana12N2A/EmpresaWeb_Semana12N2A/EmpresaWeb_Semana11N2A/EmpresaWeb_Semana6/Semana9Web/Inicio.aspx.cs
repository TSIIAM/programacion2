using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpresaDominio;


namespace Semana9Web
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if(Empresa.Instancia.ValidarUsuario(Login1.UserName, Login1.Password))
            {
                e.Authenticated = true;
            }
        }
    }
}