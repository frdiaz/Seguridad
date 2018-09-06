using System;
namespace Seguridad.Data.Model
{
    public class Usuario
    {
        private long p_id;

        public long id
        {
            get { return p_id; }
            set { p_id = value; }
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

        public Usuario()
        {
            this.p_id = 0;
            this.username = "";
            this.p_password = "";
        }
    }
}
