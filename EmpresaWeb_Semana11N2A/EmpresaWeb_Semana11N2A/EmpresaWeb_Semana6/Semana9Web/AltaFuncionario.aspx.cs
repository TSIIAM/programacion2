using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpresaDominio;

namespace Semana9Web
{
    public partial class AltaFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PnlContratado.Visible = false;
                PnlPresupuestado.Visible = false;
                DDLCargos.DataSource = Empresa.Instancia.Cargos;
                DDLCargos.DataTextField = "Nombre";
                DDLCargos.DataBind();
            }
        }

        protected void RnbContratado_CheckedChanged(object sender, EventArgs e)
        {
            PnlContratado.Visible = true;
            PnlPresupuestado.Visible = false;
        }

        protected void RbnPresupuestado_CheckedChanged(object sender, EventArgs e)
        {
            PnlContratado.Visible = false;
            PnlPresupuestado.Visible = true;
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            double sueldo = 0;
            double.TryParse(TxtSueldo.Text, out sueldo);
            DateTime fechaNacimiento = DateTime.MinValue;
            DateTime.TryParse(TxtFecNacimiento.Text, out fechaNacimiento);
            int carnetSalud = 0;
            int.TryParse(TxtCarnetSalud.Text, out carnetSalud);
            
            if (RbnPresupuestado.Checked)
            {
                int anioIngreso = 0;
                int.TryParse(TxtAnioIngreso.Text, out anioIngreso);
               if( Empresa.Instancia.AltaFuncionarioPresupuestado(TxtNombre.Text,
                    sueldo, fechaNacimiento, TxtDocumento.Text, carnetSalud, DDLCargos.SelectedValue,
                    anioIngreso))
                    {
                        LblMensaje.Text = "El funcionario se dió de alta correctamente";
                    }
                else
                {
                        LblMensaje.Text = "El funcionario no se dió de alta correctamente";
                    }
                }
            else
            {
                DateTime fechaContrato = DateTime.MinValue;
                DateTime.TryParse(TxtFecContrato.Text, out fechaContrato);
                int duracion = 0;
                int.TryParse(TxtDuracion.Text, out duracion);
                if(Empresa.Instancia.AltaFuncionarioContratado(TxtNombre.Text, sueldo, fechaNacimiento,
                    TxtDocumento.Text, carnetSalud, DDLCargos.SelectedValue, fechaContrato, duracion))
                {
                    LblMensaje.Text="El funcionario se dió de alta correctamente";
                }
                else
                {
                    LblMensaje.Text = "El funcionario no se dió de alta correctamente" ;
                }


            }
        }
    }
}