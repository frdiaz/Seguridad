using System;
using System.Collections.Generic;
using System.Text;

namespace Seguridad.Models
{
    public class Usuarios
    {
        private long p_id_usuario;

        public long id_usuario
        {
            get { return p_id_usuario; }
            set { p_id_usuario = value; }
        }

        private string p_usuario;

        public string usuario
        {
            get { return p_usuario; }
            set { p_usuario = value; }
        }

        private string p_password;

        public string password
        {
            get { return p_password; }
            set { p_password = value; }
        }

        private string p_rut_usuario;

        public string rut_usuario
        {
            get { return p_rut_usuario; }
            set { p_rut_usuario = value; }
        }

        private string p_nombres;

        public string nombres
        {
            get { return p_nombres; }
            set { p_nombres = value; }
        }

        private string p_apellido_pat;

        public string apellido_pat
        {
            get { return p_apellido_pat; }
            set { p_apellido_pat = value; }
        }

        private string p_apellido_mat;

        public string apellido_mat
        {
            get { return p_apellido_mat; }
            set { p_apellido_mat = value; }
        }

        private string p_email;

        public string email
        {
            get { return p_email; }
            set { p_email = value; }
        }

        private string p_telefono_cel;

        public string telefono_cel
        {
            get { return p_telefono_cel; }
            set { p_telefono_cel = value; }
        }

        private int p_estado;

        public int estado
        {
            get { return p_estado; }
            set { p_estado = value; }
        }

        public Usuarios()
        {
            this.p_id_usuario = 0;
            this.p_usuario = "";
            this.p_password = "";
            this.p_rut_usuario = "";
            this.p_nombres = "";
            this.p_apellido_pat = "";
            this.p_apellido_mat = "";
            this.p_email = "";
            this.p_telefono_cel = "";
            this.p_estado = 0;
        }
    }
}
