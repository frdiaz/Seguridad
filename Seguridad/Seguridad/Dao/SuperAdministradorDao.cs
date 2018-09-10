using System;
using Seguridad.Base;
using Seguridad.Models;
using System.Collections.Generic;
using NHibernate.Expression;
using NHibernate;
using System.Data;

namespace Seguridad.Dao
{
    public class SuperAdministradorDao : DBBase
    {
        private long p_id_super_administrador;
        private super_administrador p_entidad;

        private static readonly SuperAdministradorDao p_singleton = new SuperAdministradorDao();

        static SuperAdministradorDao()
        {

        }

        public static SuperAdministradorDao GetInstance()
        {
            return p_singleton;
        }

        public SuperAdministradorDao()
        {
            p_id_super_administrador = 0;
        }

        public SuperAdministradorDao(long id)
        {
            p_id_super_administrador = id;
            p_entidad = null;
        }

        public super_administrador GetEntidad()
        {
            if (p_entidad == null)
            {
                if (p_id_super_administrador > 0)
                {
                    p_entidad = (super_administrador)Load<super_administrador>(p_id_super_administrador);
                }
                if (p_entidad == null)
                {
                    p_entidad = new super_administrador();
                }
            }
            return p_entidad;
        }

        public void Update()
        {
            base.Save<super_administrador>(GetEntidad());
        }

        public void Update(super_administrador mEntidad)
        {
            base.Save(mEntidad);
        }

        public IList<super_administrador> ListAll()
        {
            return ListAll<super_administrador>();
        }

        public super_administrador Autenticar(string username, string password)
        {
            super_administrador usr = new super_administrador();

            using (ISession session = this.CurrentSession())
            {
                ICriteria criteria = session.CreateCriteria(typeof(super_administrador));
                criteria.Add(Expression.Eq("username", username));
                criteria.Add(Expression.Eq("password", password));
                IList<super_administrador> mList = criteria.List<super_administrador>();

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
