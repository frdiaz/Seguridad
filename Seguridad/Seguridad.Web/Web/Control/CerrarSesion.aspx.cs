using System;
using System.Web;
using System.Web.UI;

namespace Seguridad.Web.Control
{
    public partial class CerrarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("../../Default.aspx");
        }
    }
}
