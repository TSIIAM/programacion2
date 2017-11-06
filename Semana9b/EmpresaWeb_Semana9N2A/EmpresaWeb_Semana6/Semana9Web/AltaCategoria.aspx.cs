using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpresaDominio;

namespace Semana9Web
{
    public partial class AltaCategoria : System.Web.UI.Page
    {
        //private static Empresa emp = new Empresa(12345664789102, "GruposN2AM2C");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            string descripcion = TxtDescripcion.Text;
            int largo = descripcion.Length;
            if (Empresa.Instancia.AltaCategoria(descripcion))
            {
                LblMensaje.Text = "La categoria se dio de alta correctamente";
            }
            else
            {
                LblMensaje.Text = "Verifique los datos";
            }
        }
    }
}