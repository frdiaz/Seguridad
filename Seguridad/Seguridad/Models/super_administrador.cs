using System;
using System.Collections.Generic;
using System.Text;

namespace Seguridad.Models
{
    public class super_administrador
    {
        private long p_id_super_administrador;

        public long id_super_administrador
        {
            get { return p_id_super_administrador; }
            set { p_id_super_administrador = value; }
        }

        private string p_username;

        public string username
        {
            get { return p_username; }
            set { p_username = value; }
        }

        private string p_password;

        public string password
        {
            get { return p_password; }
            set { p_password = value; }
        }

        private string p_nombre;

        public string nombre
        {
            get { return p_nombre; }
            set { p_nombre = value; }
        }

        private string p_apellido;

        public string apellido
        {
            get { return p_apellido; }
            set { p_apellido = value; }
        }

        private int p_estado;

        public int estado
        {
            get { return p_estado; }
            set { p_estado = value; }
        }

        public super_administrador()
        {
            this.p_id_super_administrador = 0;
            this.p_username = "";
            this.p_password = "";
            this.p_nombre = "";
            this.p_apellido = "";
        }
    }
}
