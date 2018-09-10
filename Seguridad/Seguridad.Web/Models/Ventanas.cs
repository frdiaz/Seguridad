using System;
using System.Collections.Generic;
using System.Text;

namespace Seguridad.Web.Models
{
    public class Ventanas
    {
        private long p_id_ventana;

        public long id_ventana
        {
            get { return p_id_ventana; }
            set { p_id_ventana = value; }
        }

        private string p_nombre_ventana;

        public string nombre_ventana
        {
            get { return p_nombre_ventana; }
            set { p_nombre_ventana = value; }
        }

        private string p_descripcion_vent;

        public string descripcion_vent
        {
            get { return p_descripcion_vent; }
            set { p_descripcion_vent = value; }
        }

        private int p_estado;

        public int estado
        {
            get { return p_estado; }
            set { p_estado = value; }
        }

        public Ventanas()
        {
            this.p_id_ventana = 0;
            this.p_nombre_ventana = "";
            this.p_descripcion_vent = "";
            this.estado = 1;
        }
    }
}
