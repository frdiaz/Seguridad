using System;
using Seguridad.Web.Base;
using Seguridad.Web.Models;
using System.Collections.Generic;
using NHibernate.Expression;
using NHibernate;
using System.Data;

namespace Seguridad.Web.Dao
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

        public ContratosDM buscarPorRutEmpresa(string rutEmpresa)
        {
            ContratosDM usr = new ContratosDM();

            using (ISession session = this.CurrentSession())
            {
                ICriteria criteria = session.CreateCriteria(typeof(ContratosDM));
                criteria.Add(Expression.Eq("rut_empresa", rutEmpresa));
                IList<ContratosDM> mList = criteria.List<ContratosDM>();

                if (mList.Count > 0)
                {
                    usr = mList[0];
                }

                mList = null;
            }

            return usr;
        }
    }
}
