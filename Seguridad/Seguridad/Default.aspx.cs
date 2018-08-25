using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Seguridad
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            txtUsername.Attributes.Add("placeholder", "Username...");
            txtPassword.Attributes.Add("placeholder", "Password...");
            metodos();

            //txtUsername.Text = ConfigurationManager.AppSettings["nombreSistema"].ToString();
        }


        private void metodos()
        {
            btnIngresar.Click += BtnIngresar_Click;
        }

        private bool validarLogin()
        {
            lblCredenInco.Visible = false;
            bool result = true;

            if (!string.IsNullOrEmpty(txtUsername.Text) || !string.IsNullOrEmpty(txtPassword.Text))
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }

            if (!result)
            {
                lblCredenInco.Visible = true;
            }
            return result;
        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (validarLogin())
            {
                paramSession();
                Response.Redirect("Web/Control/Index.aspx");
            }
        }

        void paramSession()
        {
            Session["username"] = txtUsername.Text;
            Session["idUsuario"] = 1;
        }
    }
}