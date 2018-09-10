using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seguridad.Web.Models;
using Seguridad.Web.Dao;

namespace Seguridad.Web
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
                UsuariosDao usrDao = new UsuariosDao();
                Usuarios usr = usrDao.Autenticar(txtUsername.Text, txtPassword.Text);

                if (usr.id_usuario > 0 && usr.estado == 1)
                {
                    result = true;
                    Session["id_usuario"] = usr.id_usuario;
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