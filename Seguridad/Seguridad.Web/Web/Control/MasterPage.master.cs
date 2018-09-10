using System;
using System.Web;
using System.Web.UI;
using Seguridad.Web.Models;
using Seguridad.Web.Dao;

namespace Sistema.Web.Control
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id_usuario"] != null)
            {
                datosUsuario();
            }
            else
            {
                Response.Redirect("../../Default.aspx");
            }
        }

        private void datosUsuario()
        {
            UsuariosDao usrDao = new UsuariosDao(Convert.ToInt64(Session["id_usuario"]));
            lblNombreUsuario.Text = usrDao.GetEntidad().nombres + " " + usrDao.GetEntidad().apellido_pat;
        }
    }
}
