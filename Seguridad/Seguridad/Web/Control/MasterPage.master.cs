using System;
using System.Web;
using System.Web.UI;
using Seguridad.Models;
using Seguridad.Dao;

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
            SuperAdministradorDao supadm = new SuperAdministradorDao(Convert.ToInt64(Session["id_usuario"]));
            lblNombreUsuario.Text = supadm.GetEntidad().nombre + " " + supadm.GetEntidad().apellido;
        }
    }
}
