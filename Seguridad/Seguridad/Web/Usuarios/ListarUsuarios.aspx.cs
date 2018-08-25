using System;
using System.Web;
using System.Web.UI;
using System.Data;
namespace Sistema.Web.Usuarios
{
	public partial class ListarUsuarios : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (Session["idUsuario"] != null)
            {
                placeholder();
                cargarDatos();
            }
            else
            {
                Response.Redirect("../../Default.aspx");
            }
		}

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFiltroNombre.Text = "";
            txtFiltroApellido.Text = "";
            txtFiltroRut.Text = "";
            txtFiltroUsername.Text = "";

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void placeholder()
        {
            txtFiltroRut.Attributes.Add("placeholder","Rut");
            txtFiltroNombre.Attributes.Add("placeholder", "Nombre");
            txtFiltroApellido.Attributes.Add("placeholder", "Apellido");
            txtFiltroUsername.Attributes.Add("placeholder", "Username");

            txtRut.Attributes.Add("placeholder", "Rut");
            txtNombres.Attributes.Add("placeholder", "Nombres");
            txtApellidoPaterno.Attributes.Add("placeholder", "Apellido Paterno");
            txtApellidoMaterno.Attributes.Add("placeholder", "Apellido Materno");
            txtUsername.Attributes.Add("placeholder", "Nombre de Usuario");
            txtEmail.Attributes.Add("placeholder", "Correo Electronico");
            txtTelefonoFijo.Attributes.Add("placeholder", "Telefono Fijo");
            txtTelefonoMovil.Attributes.Add("placeholder", "Telefono Celular");
            txtDireccion.Attributes.Add("placeholder", "Dirección");

            txtNuevoRut.Attributes.Add("placeholder", "11.111.111-1");
            txtNuevoEmail.Attributes.Add("placeholder", "algo@algo.ccom");
            txtNuevoApellidos.Attributes.Add("placeholder", "Apellidos");
            txtNuevoUsername.Attributes.Add("placeholder", "Nombre de Usuario");
            txtNuevoNombres.Attributes.Add("placeholder", "Nombres");
        }

        private void cargarDatos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("rut");
            dt.Columns.Add("nombre");
            dt.Columns.Add("fechaNacimiento");
            dt.Columns.Add("edad");

            DataRow row = dt.NewRow();
            row["rut"] = "17226226-0";
            row["nombre"] = "Francisco Javier Diaz Valenzuela";
            row["fechaNacimiento"] = "03-07-1991";
            row["edad"] = 26;
            dt.Rows.Add(row);

            #region insert
            row = dt.NewRow();
            row["rut"] = "18108695-5";
            row["nombre"] = "Beatriz Eugenia Salazar Segundo";
            row["fechaNacimiento"] = "29-03-1992";
            row["edad"] = 26;
            dt.Rows.Add(row);

            #endregion

            gvTabla.DataSource = dt;
            gvTabla.DataBind();
        }

        //usuario - rut - nombre - estado - perfil - editar
	}
}
