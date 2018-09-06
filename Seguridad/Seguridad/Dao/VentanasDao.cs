using System;
using Seguridad.Base;
using Seguridad.Models;
using System.Collections.Generic;

namespace Seguridad.Dao
{
    public class VentanasDao : DBBase
    {
        private long p_id_ventana;
        private Ventanas p_entidad;

        private static readonly VentanasDao p_singleton = new VentanasDao();

        static VentanasDao()
        {
        }

        public static VentanasDao GetInstance()
        {
            return p_singleton;
        }

        public VentanasDao()
        {
            p_id_ventana = 0;
        }

        public VentanasDao(long id)
        {
            p_id_ventana = id;
            p_entidad = null;
        }

        public Ventanas GetEntidad()
        {
            if (p_entidad == null)
            {
                if (p_id_ventana > 0)
                {
                    p_entidad = (Ventanas)Load<Ventanas>(p_id_ventana);
                }
                if (p_entidad == null)
                {
                    p_entidad = new Ventanas();
                }
            }
            return p_entidad;
        }

        public void Update()
        {
            base.Save<Ventanas>(GetEntidad());
        }

        public void Update(Ventanas mEntidad)
        {
            base.Save(mEntidad);
        }

        public IList<Ventanas> ListAll()
        {
            return ListAll<Ventanas>();
        }
    }
}
