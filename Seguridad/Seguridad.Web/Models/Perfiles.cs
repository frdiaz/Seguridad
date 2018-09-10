using System;
using System.Collections.Generic;
using System.Text;

namespace Seguridad.Web.Models
{
    public class Perfiles
    {
        private long p_id_perfil;

        public long id_perfil
        {
            get { return p_id_perfil; }
            set { p_id_perfil = value; }
        }

        private string p_nombre_perfil;

        public string nombre_perfil
        {
            get { return p_nombre_perfil; }
            set { p_nombre_perfil = value; }
        }

        private string p_descripcion_perfil;

        public string descripcion_perfil
        {
            get { return p_descripcion_perfil; }
            set { p_descripcion_perfil = value; }
        }

        private int p_estado;

        public int estado
        {
            get { return p_estado; }
            set { p_estado = value; }
        }

        public Perfiles()
        {
            this.p_id_perfil = 0;
            this.p_nombre_perfil = "";
            this.p_descripcion_perfil = "";
            this.p_estado = 0;
        }
    }
}
