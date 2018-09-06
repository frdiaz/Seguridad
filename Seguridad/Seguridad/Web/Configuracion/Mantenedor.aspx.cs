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

    public partial class Mantenedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["idUsuario"] != null)
                {
                    placeholderUsuario();
                    placeholderEmpresa();
                    cargarDatosFalsos();
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

        protected void btnLimpiarFiltroEmpresas_Click(object sender, EventArgs e)
        {
            txtFiltroRutEmpresa.Text = "";
            txtFiltroNombreEmpresa.Text = "";
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnBuscarEmpresa_Click(object sender, EventArgs e)
        {
            
        }

        protected void gvTablaUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalUsuario();", true);

            if (e.CommandName == "Actualizar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                Label id = new Label();
                id = (Label)(gvTablaUsuarios.Rows[index].Cells[0].Controls[1]);

                //UsuariosDao usrDao = new UsuariosDao(Convert.ToInt64(id.Text));
                //txtIdUsuario.Text = usrDao.GetEntidad().id_usuario.ToString();
                //txtRut.Text = usrDao.GetEntidad().rut_usuario;
                //txtApellidoPaterno.Text = usrDao.GetEntidad().apellido_pat;
                //txtEmail.Text = usrDao.GetEntidad().email;
                //txtFonoCelular.Text = usrDao.GetEntidad().telefono_cel;
                //txtUsername.Text = usrDao.GetEntidad().usuario;
                //txtNombres.Text = usrDao.GetEntidad().nombres;
                //txtApellidoMaterno.Text = usrDao.GetEntidad().apellido_mat;
                //ddlEstadoUsuario.SelectedValue = usrDao.GetEntidad().estado.ToString();
            }
        }

        protected void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            UsuariosDao usrDao = new UsuariosDao(txtIdUsuario.Text == "" ? 0 : Convert.ToInt64(txtIdUsuario.Text));
            Usuarios usr = new Usuarios();

            usr.id_usuario = usrDao.GetEntidad().id_usuario;
            usr.password = txtPassword.Text != "" ? usrDao.GetEntidad().password : txtPassword.Text;
            usr.rut_usuario = txtRut.Text;
            usr.apellido_pat = txtApellidoPaterno.Text;
            usr.email = txtEmail.Text;
            usr.telefono_cel = txtFonoCelular.Text;
            usr.usuario = txtUsername.Text;
            usr.nombres = txtNombres.Text;
            usr.apellido_mat = txtApellidoMaterno.Text;
            usr.estado = Convert.ToInt32(ddlEstadoUsuario.SelectedValue);

            //usrDao.Update(usr);

            limpiarCamposUsuarios();
        }

        protected void btnGuardarEmpresa_Click(object sender, EventArgs e)
        {
            EmpresasDao empreDao = new EmpresasDao(txtIdEmpresa.Text == "" ? 0 : Convert.ToInt64(txtIdEmpresa.Text));
            Empresas empre = new Empresas();

            empre.id_empresa = empreDao.GetEntidad().id_empresa;
            empre.rut_empresa = txtRutEmpresa.Text;
            empre.razon_social = txtRazonSocial.Text;
            empre.nombre_fantasia = txtNombreFantasia.Text;
            empre.direccion = txtDireccion.Text;
            empre.ciudad = txtCiudad.Text;
            empre.comuna = txtComuna.Text;
            empre.region = txtRegion.Text;
            empre.telefono_fijo_emp = txtTelefonoFijoEmpresa.Text;
            empre.telefono_cel_emp = txtTelefonoCelularEmpresa.Text;
            empre.email_emp = txtEmailEmpresa.Text;
            empre.web = txtSitioWeb.Text;
            empre.representante_legal = txtRepesentanteLegal.Text;
            empre.telefono_fijo_rep_legal = txtTelefonoFijoRepresentanteLegal.Text;
            empre.telefono_cel_rep_legal = txtTelefonoCelularRepresentanteLegal.Text;
            empre.email_rep_legal = txtEmailRepresentanteLegal.Text;
            empre.codigo_actividad = txtCodigoActividad.Text;
            empre.logo = txtLogo.Text;
            empre.estado = Convert.ToInt32(ddlEstadoEmpresa.SelectedValue);

            //empreDao.Update(empre);

            limpiarCamposEmpresa();
        }

        private void limpiarCamposEmpresa()
        {
            txtRutEmpresa.Text = "";
            txtRazonSocial.Text = "";
            txtNombreFantasia.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtComuna.Text = "";
            txtRegion.Text = "";
            txtTelefonoFijoEmpresa.Text = "";
            txtTelefonoCelularEmpresa.Text = "";
            txtEmailEmpresa.Text = "";
            txtSitioWeb.Text = "";
            txtRepesentanteLegal.Text = "";
            txtTelefonoFijoRepresentanteLegal.Text = "";
            txtTelefonoCelularRepresentanteLegal.Text = "";
            txtEmailRepresentanteLegal.Text = "";
            txtCodigoActividad.Text = "";
            txtLogo.Text = "";
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

        private void placeholderEmpresa()
        {
            txtFiltroNombreEmpresa.Attributes.Add("placeholder", "Nombre Empresa");
            txtFiltroRutEmpresa.Attributes.Add("placeholder", "Rut Empresa");
            txtIdEmpresa.Attributes.Add("placeholder", "Nueva Empresa");
            txtRazonSocial.Attributes.Add("placeholder", "Razon Social");
            txtDireccion.Attributes.Add("placeholder", "Dirección");
            txtComuna.Attributes.Add("placeholder", "Comuna");
            txtTelefonoFijoEmpresa.Attributes.Add("placeholder", "Telefono Fijo Empresa");
            txtEmailEmpresa.Attributes.Add("placeholder", "Email Empresa");
            txtRepesentanteLegal.Attributes.Add("placeholder", "Representante Legal");
            txtTelefonoCelularRepresentanteLegal.Attributes.Add("placeholder", "Telefono Celular Representante");
            txtCodigoActividad.Attributes.Add("placeholder", "Codigo Actividad");
            txtRutEmpresa.Attributes.Add("placeholder", "Rut Empresa");
            txtNombreFantasia.Attributes.Add("placeholder", "Nombre Fantasia");
            txtCiudad.Attributes.Add("placeholder", "Ciudad");
            txtRegion.Attributes.Add("placeholder", "Region");
            txtTelefonoCelularEmpresa.Attributes.Add("placeholder", "Felefono Celular Empresa");
            txtSitioWeb.Attributes.Add("placeholder", "Sitio Web");
            txtTelefonoFijoRepresentanteLegal.Attributes.Add("placeholder", "Telefono Fijo Representante");
            txtEmailRepresentanteLegal.Attributes.Add("placeholder", "Email Representante");
            txtLogo.Attributes.Add("placeholder", "Logo");
        }

        private void cargarDatos()
        {
            
        }

        private void cargarDatosFalsos(){
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("rut");
            dt.Columns.Add("nombre");
            dt.Columns.Add("fechaNacimiento");
            dt.Columns.Add("edad");
            dt.Columns.Add("estado");

            DataRow row = dt.NewRow();
            row["id"] = "1";
            row["rut"] = "17226226-0";
            row["nombre"] = "Francisco Javier Diaz Valenzuela";
            row["fechaNacimiento"] = "03-07-1991";
            row["edad"] = 26;
            row["estado"] = "Activo";
            dt.Rows.Add(row);

            #region insert
            row = dt.NewRow();
            row["id"] = "2";
            row["rut"] = "18108695-5";
            row["nombre"] = "Beatriz Eugenia Salazar Segundo";
            row["fechaNacimiento"] = "29-03-1992";
            row["edad"] = 26;
            row["estado"] = "Inactivo";
            dt.Rows.Add(row);

            #endregion

            gvTablaUsuarios.DataSource = dt;
            gvTablaUsuarios.DataBind();

            gvTablaEmpresa.DataSource = dt;
            gvTablaEmpresa.DataBind();
        }

    }
}
