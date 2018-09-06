using System;
using System.Web;
using System.Web.UI;
namespace Sistema.Web.Control
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id_usuario"] != null)
            {
                //lblNombre.Text = Session["username"].ToString();
            }
            else
            {
                Response.Redirect("../../Default.aspx");
            }
        }
    }
}
