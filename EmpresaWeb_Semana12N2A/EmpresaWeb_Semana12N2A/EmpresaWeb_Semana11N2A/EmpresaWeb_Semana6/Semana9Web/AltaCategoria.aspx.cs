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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            string descripcion = TxtDescripcion.Text;
            int largo = descripcion.Length;
            if (Empresa.Instancia.AltaCategoria(descripcion))
            {
                LblMensaje.Text = "La categoria se dio de alta correctamente";
                CargarCategorias();
            }
            else
            {
                LblMensaje.Text = "Verifique los datos";
            }
        }
        private void CargarCategorias()
        {
            LstCategorias.DataSource = Empresa.Instancia.Categorias;
            LstCategorias.DataBind();

            GrillaCategorias.DataSource = Empresa.Instancia.Categorias;
            GrillaCategorias.DataBind();
        }
    }
}