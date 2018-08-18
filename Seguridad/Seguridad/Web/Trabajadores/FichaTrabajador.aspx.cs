using System;
using System.Web;
using System.Web.UI;

namespace Seguridad.Web.Trabajadores
{

    public partial class FichaTrabajador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idUsuario"] != null)
            {

            }
            else
            {
                Response.Redirect("../../Login.aspx");
            }
        }
    }
}
