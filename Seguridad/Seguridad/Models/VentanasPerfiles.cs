using System;
using System.Collections.Generic;
using System.Text;

namespace Seguridad.Models
{
    public class VentanasPerfiles
    {
        private long p_id_ventanas_perfil;

        public long id_ventanas_perfil
        {
            get { return p_id_ventanas_perfil; }
            set { p_id_ventanas_perfil = value; }
        }

        private long p_id_ventana;

        public long id_ventana
        {
            get { return p_id_ventana; }
            set { p_id_ventana = value; }
        }

        private long p_id_perfil;

        public long id_perfil
        {
            get { return p_id_perfil; }
            set { p_id_perfil = value; }
        }

        private int p_ver;

        public int ver
        {
            get { return p_ver; }
            set { p_ver = value; }
        }

        private int p_editar;

        public int editar
        {
            get { return p_editar; }
            set { p_editar = value; }
        }

        private int p_eliminar;

        public int eliminar
        {
            get { return p_eliminar; }
            set { p_eliminar = value; }
        }

        public VentanasPerfiles()
        {
            this.p_id_ventanas_perfil = 0;
            this.p_id_ventana = 0;
            this.p_id_perfil = 0;
            this.p_ver = 0;
            this.p_editar = 0;
            this.p_eliminar = 0;
        }
    }
}
