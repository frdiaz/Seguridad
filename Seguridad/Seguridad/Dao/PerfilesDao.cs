using System;
using Seguridad.Base;
using Seguridad.Models;
using System.Collections.Generic;

namespace Seguridad.Dao
{
    public class PerfilesDao :DBBase
    {
        private long p_id_perfil;
        private Perfiles p_entidad;

        private static readonly PerfilesDao p_singleton = new PerfilesDao();

        static PerfilesDao()
        {

        }

        public static PerfilesDao GetInstance()
        {
            return p_singleton;
        }

        public PerfilesDao()
        {
            p_id_perfil = 0;
        }

        public PerfilesDao(long id)
        {
            p_id_perfil = id;
            p_entidad = null;
        }

        public Perfiles GetEntidad()
        {
            if (p_entidad == null)
            {
                if (p_id_perfil > 0)
                {
                    p_entidad = (Perfiles)Load<Perfiles>(p_id_perfil);
                }
                if (p_entidad == null)
                {
                    p_entidad = new Perfiles();
                }
            }
            return p_entidad;
        }

        public void Update()
        {
            base.Save<Perfiles>(GetEntidad());
        }

        public void Update(Perfiles mEntidad)
        {
            base.Save(mEntidad);
        }

        public IList<Perfiles> ListAll()
        {
            return ListAll<Perfiles>();
        }
    }
}
