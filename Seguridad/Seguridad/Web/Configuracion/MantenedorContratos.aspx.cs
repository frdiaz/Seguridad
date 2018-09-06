using System;
using System.Web;
using System.Web.UI;
using Seguridad.Models;
using Seguridad.Dao;

namespace Seguridad.Web.Configuracion
{
    public partial class MantenedorContratos : System.Web.UI.Page
    {
        private long p_idEmpresa = 0;

        //public long id
        //{
        //    get
          //  {
            //    if (Request["id"] != null)
              //  {
                //    p_id = ParamUtil.GetParamLong(Request["id"].ToString(), 0);
                //}
                //else
               // {
                //    p_id = ParamUtil.GetParamLong(idactual.Value, 0);
               // }
               // return p_id;
            //}
            //set
           // {
             //   p_id = value;
               // idactual.Value = value.ToString();
            //}
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["id_usuario"] != null)
                {
                    placeholder();
                }
                else
                {
                    Response.Redirect("../../Default.aspx");
                }
            }
        }

        private void placeholder()
        {
            txtRazonSocial.Attributes.Add("placeholder", "Razon Social");
            txtRutEmpresa.Attributes.Add("placeholder", "11.111.111-1");
            txtNombreFantasia.Attributes.Add("placeholder", "Nombre Fantasia");
            txtDireccion.Attributes.Add("placeholder", "Dirección");
            txtComuna.Attributes.Add("placeholder", "Comuna");
            txtCiudad.Attributes.Add("placeholder", "Ciudad");
            txtRegion.Attributes.Add("placeholder", "Region");
            txtTelefonoFijoEmpresa.Attributes.Add("placeholder", "Fono Fijo");
            txtTelefonoCelularEmpresa.Attributes.Add("placeholder", "Fono Celular");
            txtRepesentanteLegal.Attributes.Add("placeholder", "Nombre Representante");
            txtTelefonoFijoRepresentanteLegal.Attributes.Add("placeholder", "Fono Fijo");
            txtTelefonoFijoRepresentanteLegal.Attributes.Add("placeholder", "Fono Celular");
            txtEmailRepresentanteLegal.Attributes.Add("placeholder", "algo@algo.cl");
            txtCodigoActividad.Attributes.Add("placeholder", "Actividad");
            txtEmail.Attributes.Add("placeholder", "algo@algo.cl");
            txtPassword.Attributes.Add("placeholder", "Contraseña");
            txtDuracionContrato.Attributes.Add("placeholder", "Meses");
            txtFechaInicial.Attributes.Add("placeholder", "Fecha Inicial");
            txtFechaTermino.Attributes.Add("placeholder", "Fecha Termino");
            txtCantidadTrabajadores.Attributes.Add("placeholder", "Cantidad de Trabajadores");
            txtCantidadUsuarios.Attributes.Add("placeholder", "Cantidad de Usuarios");
            txtMensualidad.Attributes.Add("placeholder", "Monto $");
            txtTelefonoCelularRepresentanteLegal.Attributes.Add("placeholder", "Fono Celular");
            txtSitioWeb.Attributes.Add("placeholder", "www.misitio.cl");
        }

        private void cargarDatos()
        {
            EmpresasDao empreDao = new EmpresasDao(p_idEmpresa);

            txtRutEmpresa.Text = empreDao.GetEntidad().rut_empresa;
            txtRazonSocial.Text = empreDao.GetEntidad().razon_social;
            txtNombreFantasia.Text = empreDao.GetEntidad().nombre_fantasia;
            txtDireccion.Text = empreDao.GetEntidad().direccion;
            txtCiudad.Text = empreDao.GetEntidad().ciudad;
            txtComuna.Text = empreDao.GetEntidad().comuna;
            txtRegion.Text = empreDao.GetEntidad().region;
            txtTelefonoFijoEmpresa.Text = empreDao.GetEntidad().telefono_fijo_emp;
            txtTelefonoCelularEmpresa.Text = empreDao.GetEntidad().telefono_cel_emp;
            txtEmail.Text = empreDao.GetEntidad().email_emp;
            txtSitioWeb.Text = empreDao.GetEntidad().web;
            txtRepesentanteLegal.Text = empreDao.GetEntidad().representante_legal;
            txtTelefonoFijoRepresentanteLegal.Text = empreDao.GetEntidad().telefono_fijo_rep_legal;
            txtTelefonoCelularRepresentanteLegal.Text = empreDao.GetEntidad().telefono_cel_rep_legal;
            txtEmailRepresentanteLegal.Text = empreDao.GetEntidad().email_rep_legal;
            txtCodigoActividad.Text = empreDao.GetEntidad().codigo_actividad;
            ddlEstado.SelectedValue = empreDao.GetEntidad().estado.ToString();
        }

        protected void btnGuardarContrato_Click(object sender, EventArgs e)
        {
            //INSERT - UPDATE EMPRESA
            EmpresasDao empreDao = new EmpresasDao(p_idEmpresa);
            Empresas empre = new Empresas();

            empre.id_empresa = 0;
            empre.rut_empresa = txtRutEmpresa.Text;
            empre.razon_social = txtRazonSocial.Text;
            empre.nombre_fantasia = txtNombreFantasia.Text;
            empre.direccion = txtDireccion.Text;
            empre.ciudad = txtCiudad.Text;
            empre.comuna = txtComuna.Text;
            empre.region = txtRegion.Text;
            empre.telefono_fijo_emp = txtTelefonoFijoEmpresa.Text;
            empre.telefono_cel_emp = txtTelefonoCelularEmpresa.Text;
            empre.email_emp = txtEmail.Text;
            empre.web = txtSitioWeb.Text;
            empre.representante_legal = txtRepesentanteLegal.Text;
            empre.telefono_fijo_rep_legal = txtTelefonoFijoRepresentanteLegal.Text;
            empre.telefono_cel_rep_legal = txtTelefonoCelularRepresentanteLegal.Text;
            empre.email_rep_legal = txtEmailRepresentanteLegal.Text;
            empre.codigo_actividad = txtCodigoActividad.Text;
            //empre.logo = txtLogo.Text;
            empre.estado = Convert.ToInt32(ddlEstado.SelectedValue);

            empreDao.Update(empre);

            //INSERT - UPDATE USUARIO
            UsuariosDao usrDao = new UsuariosDao();
            Usuarios usr = new Usuarios();

            usr.id_usuario = 0;
            usr.password = txtPassword.Text;
            usr.email = txtEmail.Text;
            usr.usuario = txtEmail.Text;
            usr.estado = Convert.ToInt32(ddlEstado.SelectedValue);

            usrDao.Update(usr);

            //INSERT - UPDATE USUARIO EMPRESA PERFIL
            UsuarioEmpresaPerfilDao uepDao = new UsuarioEmpresaPerfilDao();
            UsuarioEmpresaPerfil uep = new UsuarioEmpresaPerfil();

            uep.id_usuario_empresa = 0;
            uep.rut_empresa = txtRutEmpresa.Text;
            uep.id_perfil = 2;
            uep.estado = Convert.ToInt32(ddlEstado.SelectedValue);

            uepDao.Update(uep);

            //INSERT - UPDATE CONTRATO
            ContratosDMDao conDao = new ContratosDMDao();
            ContratosDM contrato = new ContratosDM();

            contrato.rut_empresa = txtRutEmpresa.Text;
            contrato.duracion_contrato = Convert.ToInt32(txtDuracionContrato.Text);
            contrato.fecha_inic = Convert.ToDateTime(txtFechaInicial.Text);
            contrato.fecha_ter = Convert.ToDateTime(txtFechaTermino.Text);
            contrato.max_trabajadores = Convert.ToInt32(txtCantidadTrabajadores.Text);
            contrato.max_usuarios = Convert.ToInt32(txtCantidadUsuarios.Text);
            contrato.mensualidad = Convert.ToInt32(txtMensualidad.Text);
            contrato.estado = Convert.ToInt32(ddlEstado.SelectedValue);

            conDao.Update(contrato);
        }
    }
}
