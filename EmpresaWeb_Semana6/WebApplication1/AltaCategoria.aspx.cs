﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpresaDominio;


namespace WebApplication1
{
    public partial class AltaCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            string descripcion = TxtDescripcion.Text;
            if (Empresa.Instancia.altaCategoria(descripcion)) {
                lblIf.Text = "Dio Alta";
            }
            
        }
    }
}