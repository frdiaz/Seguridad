using System;
using System.Collections.Generic;
using System.Text;

namespace Seguridad.Web.Models
{
    public class Empresas
    {
        private long p_id_empresa;

        public long id_empresa
        {
            get { return p_id_empresa; }
            set { p_id_empresa = value; }
        }

        private string p_rut_empresa;

        public string rut_empresa
        {
            get { return p_rut_empresa; }
            set { p_rut_empresa = value; }
        }

        private string p_razon_social;

        public string razon_social
        {
            get { return p_razon_social; }
            set { p_razon_social = value; }
        }

        private string p_nombre_fantasia;

        public string nombre_fantasia
        {
            get { return p_nombre_fantasia; }
            set { p_nombre_fantasia = value; }
        }

        private string p_direccion;

        public string direccion
        {
            get { return p_direccion; }
            set { p_direccion = value; }
        }

        private string p_ciudad;

        public string ciudad
        {
            get { return p_ciudad; }
            set { p_ciudad = value; }
        }

        private string p_comuna;

        public string comuna
        {
            get { return p_comuna; }
            set { p_comuna = value; }
        }

        private string p_region;

        public string region
        {
            get { return p_region; }
            set { p_region = value; }
        }

        private string p_telefono_fijo_emp;

        public string telefono_fijo_emp
        {
            get { return p_telefono_fijo_emp; }
            set { p_telefono_fijo_emp = value; }
        }

        private string p_telefono_cel_emp;

        public string telefono_cel_emp
        {
            get { return p_telefono_cel_emp; }
            set { p_telefono_cel_emp = value; }
        }

        private string p_email_emp;

        public string email_emp
        {
            get { return p_email_emp; }
            set { p_email_emp = value; }
        }

        private string p_web;

        public string web
        {
            get { return p_web; }
            set { p_web = value; }
        }

        private string p_representante_legal;

        public string representante_legal
        {
            get { return p_representante_legal; }
            set { p_representante_legal = value; }
        }

        private string p_telefono_fijo_rep_legal;

        public string telefono_fijo_rep_legal
        {
            get { return p_telefono_fijo_rep_legal; }
            set { p_telefono_fijo_rep_legal = value; }
        }

        private string p_telefono_cel_rep_legal;

        public string telefono_cel_rep_legal
        {
            get { return p_telefono_cel_rep_legal; }
            set { p_telefono_cel_rep_legal = value; }
        }

        private string p_email_rep_legal;

        public string email_rep_legal
        {
            get { return p_email_rep_legal; }
            set { p_email_rep_legal = value; }
        }

        private string p_codigo_actividad;

        public string codigo_actividad
        {
            get { return p_codigo_actividad; }
            set { p_codigo_actividad = value; }
        }

        private string p_logo;

        public string logo
        {
            get { return p_logo; }
            set { p_logo = value; }
        }

        private string p_path_datos;

        public string path_datos
        {
            get { return p_path_datos; }
            set { p_path_datos = value; }
        }

        private int p_estado;

        public int estado
        {
            get { return p_estado; }
            set { p_estado = value; }
        }

        private long p_id_usuario_administrador;

        public long id_usuario_administrador
        {
            get { return p_id_usuario_administrador; }
            set { p_id_usuario_administrador = value; }
        }

        public Empresas()
        {
            this.p_id_empresa = 0;
            this.p_rut_empresa = "";
            this.p_razon_social = "";
            this.p_nombre_fantasia = "";
            this.p_direccion = "";
            this.p_telefono_fijo_emp = "";
            this.p_telefono_cel_emp = "";
            this.p_email_emp = "";
            this.p_web = "";
            this.p_representante_legal = "";
            this.p_telefono_cel_rep_legal = "";
            this.p_telefono_fijo_rep_legal = "";
            this.p_email_rep_legal = "";
            this.p_codigo_actividad = "";
            this.p_logo = "";
            this.p_path_datos = "";
            this.p_estado = 0;
            this.p_ciudad = "";
            this.p_comuna = "";
            this.p_region = "";
            this.p_id_usuario_administrador = 0;
        }
    }
}