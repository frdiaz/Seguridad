using System;
using Seguridad.Base;
using Seguridad.Models;
using System.Collections.Generic;

namespace Seguridad.Dao
{
    public class ContratosDMDao : DBBase
    {
        private long p_id_contrato;
        private ContratosDM p_entidad;

        private static readonly ContratosDMDao p_singleton = new ContratosDMDao();

        static ContratosDMDao()
        {

        }

        public static ContratosDMDao GetInstance()
        {
            return p_singleton;
        }

        public ContratosDMDao()
        {
            p_id_contrato = 0;
        }

        public ContratosDMDao(long id)
        {
            p_id_contrato = id;
            p_entidad = null;
        }

        public ContratosDM GetEntidad()
        {
            if (p_entidad == null)
            {
                if (p_id_contrato > 0)
                {
                    p_entidad = (ContratosDM)Load<ContratosDM>(p_id_contrato);
                }
                if (p_entidad == null)
                {
                    p_entidad = new ContratosDM();
                }
            }
            return p_entidad;
        }

        public void Update()
        {
            base.Save<ContratosDM>(GetEntidad());
        }

        public void Update(ContratosDM mEntidad)
        {
            base.Save(mEntidad);
        }

        public IList<ContratosDM> ListAll()
        {
            return ListAll<ContratosDM>();
        }
    }
}
