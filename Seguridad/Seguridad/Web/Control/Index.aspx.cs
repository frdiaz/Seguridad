using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Sistema.Web
{
    public partial class Index : System.Web.UI.Page
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
