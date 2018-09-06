using System;
using System.Web;
using System.Web.UI;

namespace Seguridad.Web.Trabajadores
{

    public partial class Cumplimiento : System.Web.UI.Page
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
