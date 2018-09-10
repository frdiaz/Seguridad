using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seguridad.Models;
using Seguridad.Dao;

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
        }

        private void metodos()
        {
            btnIngresar.Click += BtnIngresar_Click;
        }

        private bool validarLogin()
        {
            bool result = false;

            if (!string.IsNullOrEmpty(txtUsername.Text) || !string.IsNullOrEmpty(txtPassword.Text))
            {
                SuperAdministradorDao supadmdao = new SuperAdministradorDao();
                super_administrador supadm = supadmdao.Autenticar(txtUsername.Text, txtPassword.Text);

                if (supadm.id_super_administrador > 0 && supadm.estado == 1)
                {
                    result = true;
                    Session["id_usuario"] = supadm.id_super_administrador;
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
                Response.Redirect("Web/Control/Index.aspx");
            }
            else
            {
                lblCredenInco.Visible = true;
            }
        }
    }
}