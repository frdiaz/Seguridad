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
    public partial class MantenedorEmpresas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["id_usuario"] != null)
                {
                    placeholderEmpresa();
                    Filtrar();
                }
                else
                {
                    Response.Redirect("../../Default.aspx");
                }
            }
        }

        protected void btnLimpiarFiltroEmpresas_Click(object sender, EventArgs e)
        {
            txtFiltroRutEmpresa.Text = "";
            txtFiltroNombreEmpresa.Text = "";
        }

        protected void btnBuscarEmpresa_Click(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void Filtrar()
        {
            EmpresasDao empDao = new EmpresasDao();
            DataTable dt = empDao.ListarPorFiltros(txtFiltroNombreEmpresa.Text, txtFiltroRutEmpresa.Text, ddlFiltroEstadoEmpresa.SelectedValue);
            gvTablaEmpresa.DataSource = dt;
            gvTablaEmpresa.DataBind();
        }

        protected void gvTablaEmpresas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalEmpresa();", true);

            if (e.CommandName == "Actualizar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                Label id = new Label();
                id = (Label)(gvTablaEmpresa.Rows[index].Cells[0].Controls[1]);

                EmpresasDao empreDao = new EmpresasDao(Convert.ToInt64(id.Text));
                txtRutEmpresa.Text = empreDao.GetEntidad().rut_empresa;
                txtRazonSocial.Text = empreDao.GetEntidad().razon_social;
                txtNombreFantasia.Text = empreDao.GetEntidad().nombre_fantasia;
                txtDireccion.Text = empreDao.GetEntidad().direccion;
                txtCiudad.Text = empreDao.GetEntidad().ciudad;
                txtComuna.Text = empreDao.GetEntidad().comuna;
                txtRegion.Text = empreDao.GetEntidad().region;
                txtTelefonoFijoEmpresa.Text = empreDao.GetEntidad().telefono_fijo_emp;
                txtTelefonoCelularEmpresa.Text = empreDao.GetEntidad().telefono_cel_emp;
                txtEmailEmpresa.Text = empreDao.GetEntidad().email_emp;
                txtSitioWeb.Text = empreDao.GetEntidad().web;
                txtRepesentanteLegal.Text = empreDao.GetEntidad().representante_legal;
                txtTelefonoFijoRepresentanteLegal.Text = empreDao.GetEntidad().telefono_fijo_rep_legal;
                txtTelefonoCelularRepresentanteLegal.Text = empreDao.GetEntidad().telefono_cel_rep_legal;
                txtEmailRepresentanteLegal.Text = empreDao.GetEntidad().email_rep_legal;
                txtCodigoActividad.Text = empreDao.GetEntidad().codigo_actividad;
                txtLogo.Text = empreDao.GetEntidad().logo;
                txtIdEmpresa.Text = empreDao.GetEntidad().id_empresa.ToString();
            }
        }

        protected void btnNuevaEmpresa_Click(object sender, EventArgs e)
        {
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModalEmpresa();", true);
            //limpiarCamposEmpresa();
            Response.Redirect("MantenedorContratos.aspx");
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

            empreDao.Update(empre);

            limpiarCamposEmpresa();

            Response.Redirect("MantenedorEmpresas.aspx");
        }

        private void limpiarCamposEmpresa()
        {
            txtIdEmpresa.Text = "";
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

        private void cargarDatosFalsos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("rut_empresa");
            dt.Columns.Add("nombre_fantasia");
            dt.Columns.Add("edad");
            dt.Columns.Add("estado");

            DataRow row = dt.NewRow();
            row["id"] = "1";
            row["rut_empresa"] = "17226226-0";
            row["nombre_fantasia"] = "Empresa 1";
            row["edad"] = 26;
            row["estado"] = "Activo";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["id"] = "2";
            row["rut_empresa"] = "18108695-5";
            row["nombre_fantasia"] = "Empresa 2";
            row["edad"] = 26;
            row["estado"] = "Inactivo";
            dt.Rows.Add(row);

            gvTablaEmpresa.DataSource = dt;
            gvTablaEmpresa.DataBind();
        }
    }
}
