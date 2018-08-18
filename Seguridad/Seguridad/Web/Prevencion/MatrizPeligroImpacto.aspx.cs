using System;
using System.Web;
using System.Web.UI;

namespace Seguridad.Web.Prevencion
{

    public partial class MatrizPeligroImpacto : System.Web.UI.Page
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
