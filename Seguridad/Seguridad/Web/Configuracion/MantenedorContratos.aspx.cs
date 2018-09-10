using System;
using System.Web;
using System.Web.UI;
using Seguridad.Models;
using Seguridad.Dao;
using Seguridad.Util;

namespace Seguridad.Web.Configuracion
{
    public partial class MantenedorContratos : System.Web.UI.Page
    {
        private long p_id_empresa = 0;

        public long id
        {
            get
            {
                p_id_empresa = ParamUtil.GetParamLong(Request["id_empresa"], 0);
                if (p_id_empresa > 0)
                {
                    idactual.Value = p_id_empresa.ToString();
                }
                else
                {
                    p_id_empresa = ParamUtil.GetParamLong(idactual.Value, 0);
                }
                return p_id_empresa;
            }
            set
            {
                p_id_empresa = value;
                idactual.Value = value.ToString();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            placeholder();

            if (id > 0)
            {
                cargarDatos(id);
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("MantenedorEmpresas.aspx");
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
            txtRutUsuario.Attributes.Add("placeholder", "11.111.111-1");
        }

        private void cargarDatos(long id_empresa)
        {
            EmpresasDao empreDao = new EmpresasDao(id_empresa);

            txtRutEmpresa.Text = empreDao.GetEntidad().rut_empresa;
            txtRazonSocial.Text = empreDao.GetEntidad().razon_social;
            txtNombreFantasia.Text = empreDao.GetEntidad().nombre_fantasia;
            txtDireccion.Text = empreDao.GetEntidad().direccion;
            txtCiudad.Text = empreDao.GetEntidad().ciudad;
            txtComuna.Text = empreDao.GetEntidad().comuna;
            txtRegion.Text = empreDao.GetEntidad().region;
            txtTelefonoFijoEmpresa.Text = empreDao.GetEntidad().telefono_fijo_emp;
            txtTelefonoCelularEmpresa.Text = empreDao.GetEntidad().telefono_cel_emp;
            txtSitioWeb.Text = empreDao.GetEntidad().web;
            txtRepesentanteLegal.Text = empreDao.GetEntidad().representante_legal;
            txtTelefonoFijoRepresentanteLegal.Text = empreDao.GetEntidad().telefono_fijo_rep_legal;
            txtTelefonoCelularRepresentanteLegal.Text = empreDao.GetEntidad().telefono_cel_rep_legal;
            txtEmailRepresentanteLegal.Text = empreDao.GetEntidad().email_rep_legal;
            txtCodigoActividad.Text = empreDao.GetEntidad().codigo_actividad;
            ddlEstado.SelectedValue = empreDao.GetEntidad().estado.ToString();

            UsuariosDao usr = new UsuariosDao(empreDao.GetEntidad().id_usuario_administrador);
            txtEmail.Text = usr.GetEntidad().email;
            txtRutUsuario.Text = usr.GetEntidad().rut_usuario;
            txtPassword.Text = usr.GetEntidad().password;

            ContratosDMDao conDao = new ContratosDMDao();
            ContratosDM con = conDao.buscarPorRutEmpresa(empreDao.GetEntidad().rut_empresa);
            txtDuracionContrato.Text = con.duracion_contrato.ToString();
            txtFechaInicial.Text = con.fecha_inic.ToShortDateString();
            txtFechaTermino.Text = con.fecha_ter.ToShortDateString();
            txtCantidadTrabajadores.Text = con.max_trabajadores.ToString();
            txtCantidadUsuarios.Text = con.max_usuarios.ToString();
            txtMensualidad.Text = con.mensualidad.ToString();
        }

        protected void btnGuardarContrato_Click(object sender, EventArgs e)
        {
            //INSERT - UPDATE EMPRESA
            EmpresasDao empreDao = new EmpresasDao(p_id_empresa);

            empreDao.GetEntidad().rut_empresa = txtRutEmpresa.Text;
            empreDao.GetEntidad().razon_social = txtRazonSocial.Text;
            empreDao.GetEntidad().nombre_fantasia = txtNombreFantasia.Text;
            empreDao.GetEntidad().direccion = txtDireccion.Text;
            empreDao.GetEntidad().ciudad = txtCiudad.Text;
            empreDao.GetEntidad().comuna = txtComuna.Text;
            empreDao.GetEntidad().region = txtRegion.Text;
            empreDao.GetEntidad().telefono_fijo_emp = txtTelefonoFijoEmpresa.Text;
            empreDao.GetEntidad().telefono_cel_emp = txtTelefonoCelularEmpresa.Text;
            empreDao.GetEntidad().email_emp = txtEmail.Text;
            empreDao.GetEntidad().web = txtSitioWeb.Text;
            empreDao.GetEntidad().representante_legal = txtRepesentanteLegal.Text;
            empreDao.GetEntidad().telefono_fijo_rep_legal = txtTelefonoFijoRepresentanteLegal.Text;
            empreDao.GetEntidad().telefono_cel_rep_legal = txtTelefonoCelularRepresentanteLegal.Text;
            empreDao.GetEntidad().email_rep_legal = txtEmailRepresentanteLegal.Text;
            empreDao.GetEntidad().codigo_actividad = txtCodigoActividad.Text;
            empreDao.GetEntidad().estado = Convert.ToInt32(ddlEstado.SelectedValue);

            if(p_id_empresa > 0)
            {
                UsuariosDao usrDao = new UsuariosDao(empreDao.GetEntidad().id_usuario_administrador);
                usrDao.GetEntidad().email = txtEmail.Text;
                usrDao.GetEntidad().rut_usuario = txtRutUsuario.Text;
                usrDao.GetEntidad().password = txtPassword.Text;
                usrDao.GetEntidad().usuario = txtEmail.Text;
                usrDao.GetEntidad().estado = Convert.ToInt32(ddlEstado.SelectedValue);
                usrDao.Update();
            }
            else
            {
                UsuariosDao usrDao = new UsuariosDao();
                usrDao.GetEntidad().email = txtEmail.Text;
                usrDao.GetEntidad().rut_usuario = txtRutUsuario.Text;
                usrDao.GetEntidad().password = txtPassword.Text;
                usrDao.GetEntidad().usuario = txtEmail.Text;
                usrDao.GetEntidad().estado = Convert.ToInt32(ddlEstado.SelectedValue);
                usrDao.Update();

                UsuarioEmpresaPerfilDao uepDao = new UsuarioEmpresaPerfilDao();

                uepDao.GetEntidad().rut_empresa = txtRutEmpresa.Text;
                uepDao.GetEntidad().id_perfil = 1;
                uepDao.GetEntidad().rut_usuario = txtRutUsuario.Text;
                uepDao.GetEntidad().estado = Convert.ToInt32(ddlEstado.SelectedValue);

                uepDao.Update(); 

                empreDao.GetEntidad().id_usuario_administrador = usrDao.GetEntidad().id_usuario;
            }

            empreDao.Update();

            ContratosDMDao conDao = new ContratosDMDao();
            ContratosDM contrato = conDao.buscarPorRutEmpresa(empreDao.GetEntidad().rut_empresa);

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
