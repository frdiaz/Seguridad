using System;
using Seguridad.Web.Base;
using Seguridad.Web.Models;
using System.Collections.Generic;

namespace Seguridad.Web.Dao
{
    public class VentanasPerfilesDao : DBBase
    {
        private long p_id_ventanas_perfil;
        private VentanasPerfiles p_entidad;

        private static readonly VentanasPerfilesDao p_singleton = new VentanasPerfilesDao();

        static VentanasPerfilesDao()
        {
        }

        public static VentanasPerfilesDao GetInstance()
        {
            return p_singleton;
        }

        public VentanasPerfilesDao()
        {
            p_id_ventanas_perfil = 0;
        }

        public VentanasPerfilesDao(long id)
        {
            p_id_ventanas_perfil = id;
            p_entidad = null;
        }

        public VentanasPerfiles GetEntidad()
        {
            if (p_entidad == null)
            {
                if (p_id_ventanas_perfil > 0)
                {
                    p_entidad = (VentanasPerfiles)Load<VentanasPerfiles>(p_id_ventanas_perfil);
                }
                if (p_entidad == null)
                {
                    p_entidad = new VentanasPerfiles();
                }
            }
            return p_entidad;
        }

        public void Update()
        {
            base.Save<VentanasPerfiles>(GetEntidad());
        }

        public void Update(VentanasPerfiles mEntidad)
        {
            base.Save(mEntidad);
        }

        public IList<VentanasPerfiles> ListAll()
        {
            return ListAll<VentanasPerfiles>();
        }
    }
}
