using System;
using System.Web;
using System.Web.UI;

namespace Seguridad.Web.Control
{

    public partial class Indicadores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id_usuario"] != null)
            {

            }
            else
            {
                Response.Redirect("../../Default.aspx");
            }
        }
    }
}
