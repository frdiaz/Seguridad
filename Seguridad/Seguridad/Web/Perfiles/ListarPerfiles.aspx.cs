using System;
using System.Web;
using System.Web.UI;
namespace Sistema.Web.Perfiles
{
    public partial class ListarPerfiles : System.Web.UI.Page
    {
		protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idUsuario"] != null)
            {
                //lblTitulo.Text = "Perfiles";
            }
            else
            {
                Response.Redirect("../../Login.aspx");
            }
        }
    }
}
