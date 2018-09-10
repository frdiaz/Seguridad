using System;
using System.Web;
using System.Web.UI;
using System.Data;
using Seguridad.Models;
using Seguridad.Dao;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Collections;

namespace Seguridad.Web.Configuracion
{

    public partial class MantenedorUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["id_usuario"] != null)
                {
                    placeholderUsuario();
                    Filtrar();
                }
                else
                {
                    Response.Redirect("../../Default.aspx");
                }
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFiltroNombre.Text = "";
            txtFiltroApellido.Text = "";
            txtFiltroRut.Text = "";
            txtFiltroUsername.Text = "";
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void Filtrar()
        {
            UsuariosDao usrDao = new UsuariosDao();
            DataTable dt = usrDao.ListarPorFiltros(txtFiltroUsername.Text, txtFiltroRut.Text, txtFiltroNombre.Text, txtFiltroApellido.Text, ddlFiltroEstado.SelectedValue);
            gvTablaUsuarios.DataSource = dt;
            gvTablaUsuarios.DataBind();
        }

        protected void gvTablaUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalUsuario();", true);

            if (e.CommandName == "Actualizar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                Label id = new Label();
                id = (Label)(gvTablaUsuarios.Rows[index].Cells[0].Controls[1]);

                UsuariosDao usrDao = new UsuariosDao(Convert.ToInt64(id.Text));
                txtIdUsuario.Text = usrDao.GetEntidad().id_usuario.ToString();
                txtRut.Text = usrDao.GetEntidad().rut_usuario;
                txtApellidoPaterno.Text = usrDao.GetEntidad().apellido_pat;
                txtEmail.Text = usrDao.GetEntidad().email;
                txtFonoCelular.Text = usrDao.GetEntidad().telefono_cel;
                txtUsername.Text = usrDao.GetEntidad().usuario;
                txtNombres.Text = usrDao.GetEntidad().nombres;
                txtApellidoMaterno.Text = usrDao.GetEntidad().apellido_mat;
                txtPassword.Text = usrDao.GetEntidad().password;
                txtRepetirPassword.Text = usrDao.GetEntidad().password;
                ddlEstadoUsuario.SelectedValue = usrDao.GetEntidad().estado.ToString();
            }
        }

        protected void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            UsuariosDao usrDao = new UsuariosDao(txtIdUsuario.Text == "" ? 0 : Convert.ToInt64(txtIdUsuario.Text));
            Usuarios usr = new Usuarios();

            usr.id_usuario = usrDao.GetEntidad().id_usuario;
            usr.password = txtPassword.Text != "" ? txtPassword.Text : usrDao.GetEntidad().password;
            usr.rut_usuario = txtRut.Text;
            usr.apellido_pat = txtApellidoPaterno.Text;
            usr.email = txtEmail.Text;
            usr.telefono_cel = txtFonoCelular.Text;
            usr.usuario = txtUsername.Text;
            usr.nombres = txtNombres.Text;
            usr.apellido_mat = txtApellidoMaterno.Text;
            usr.estado = Convert.ToInt32(ddlEstadoUsuario.SelectedValue);

            usrDao.Update(usr);

            limpiarCamposUsuarios();
            Response.Redirect("MantenedorUsuarios.aspx");
        }

        protected void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalUsuario();", true);
            limpiarCamposUsuarios();
        }

        private void limpiarCamposUsuarios()
        {
            txtIdUsuario.Text = "";
            txtPassword.Text = "";
            txtRut.Text = "";
            txtApellidoPaterno.Text = "";
            txtEmail.Text = "";
            txtFonoCelular.Text = "";
            txtUsername.Text = "";
            txtNombres.Text = "";
            txtApellidoMaterno.Text = "";
            ddlEstadoUsuario.SelectedValue = "1";
        }

        private void cargarCamposUsuarios(long idUsuario)
        {
            UsuariosDao usrDao = new UsuariosDao(idUsuario);

            txtIdUsuario.Text = usrDao.GetEntidad().id_usuario.ToString();
            txtRut.Text = usrDao.GetEntidad().rut_usuario;
            txtApellidoPaterno.Text = usrDao.GetEntidad().apellido_pat;
            txtEmail.Text = usrDao.GetEntidad().email;
            txtFonoCelular.Text = usrDao.GetEntidad().telefono_cel;
            txtUsername.Text = usrDao.GetEntidad().usuario;
            txtNombres.Text = usrDao.GetEntidad().nombres;
            txtApellidoMaterno.Text = usrDao.GetEntidad().apellido_mat;
            txtPassword.Text = usrDao.GetEntidad().password;
            txtRepetirPassword.Text = usrDao.GetEntidad().password;
            ddlEstadoUsuario.SelectedValue = usrDao.GetEntidad().estado == 1 ? "1" : "0";
        }

        private void placeholderUsuario()
        {
            txtFiltroRut.Attributes.Add("placeholder", "Rut");
            txtFiltroNombre.Attributes.Add("placeholder", "Nombre");
            txtFiltroApellido.Attributes.Add("placeholder", "Apellido");
            txtFiltroUsername.Attributes.Add("placeholder", "Username");

            txtIdUsuario.Attributes.Add("placeholder", "Nuevo Usuario");
            txtPassword.Attributes.Add("placeholder", "Contraseña");
            txtRepetirPassword.Attributes.Add("placeholder", "Repetir Contraseña");
            txtRut.Attributes.Add("placeholder", "11.111.111-1");
            txtApellidoPaterno.Attributes.Add("placeholder", "Apellido Paterno");
            txtEmail.Attributes.Add("placeholder", "correo@gmail.com");
            txtFonoCelular.Attributes.Add("placeholder", "+56 978362734");
            txtUsername.Attributes.Add("placeholder", "Nombre de Usuario");
            txtNombres.Attributes.Add("placeholder", "Nombres");
            txtApellidoMaterno.Attributes.Add("placeholder", "Apellido Materno");
        }

        private void cargarDatos()
        {

        }
    }
}
