using System;
using Seguridad.Base;
using Seguridad.Models;
using System.Collections.Generic;
using NHibernate.Expression;
using NHibernate;
using System.Data;

namespace Seguridad.Dao
{
    public class UsuariosDao : DBBase
    {
        private long p_id;
        private Usuarios p_entidad;

        private static readonly UsuariosDao p_singleton = new UsuariosDao();

        static UsuariosDao()
        {

        }

        public static UsuariosDao GetInstance()
        {
            return p_singleton;
        }

        public UsuariosDao()
        {
            p_id = 0;
        }

        public UsuariosDao(long id)
        {
            p_id = id;
            p_entidad = null;
        }

        public Usuarios GetEntidad()
        {
            if (p_entidad == null)
            {
                if (p_id > 0)
                {
                    p_entidad = (Usuarios)Load<Usuarios>(p_id);
                }
                if (p_entidad == null)
                {
                    p_entidad = new Usuarios();
                }
            }
            return p_entidad;
        }

        public void Update()
        {
            base.Save<Usuarios>(GetEntidad());
        }

        public void Update(Usuarios mEntidad)
        {
            base.Save(mEntidad);
        }

        public IList<Usuarios> ListAll()
        {
            return ListAll<Usuarios>();
        }

        public Usuarios Autenticar(string username, string password)
        {
            Usuarios usuario = new Usuarios();

            using (ISession session = this.CurrentSession())
            {
                ICriteria criteria = session.CreateCriteria(typeof(Usuarios));
                criteria.Add(Expression.Eq("usuario", username));
                criteria.Add(Expression.Eq("password", password));
                criteria.Add(Expression.Eq("estado", 1));
                IList<Usuarios> mList = criteria.List<Usuarios>();

                if (mList.Count > 0)
                {
                    usuario = mList[0];
                }

                mList = null;
            }

            return usuario;
        }

        public DataTable ListarPorFiltros(string username, string rut, string nombre, string apellido, string estado)
        {
            string query = "  SELECT id_usuario, usuario, password, rut_usuario, nombres, apellido_pat, " +
                "apellido_mat, email, telefono_cel, estado " +
                "FROM usuarios WHERE id_usuario > 0 ";

            if (GetParam(username).Length > 0)
            {
                query += " and usuario = '" + username + "'";
            }

            if (GetParam(nombre).Length > 0)
            {
                query += " and nombres like '%" + nombre + "'%";
            }

            if (GetParam(apellido).Length > 0)
            {
                query += " and apellido_pat like '%" + apellido + "%' or apellido_mat like '%" + apellido + "%'";
            }

            if (GetParam(estado).Length > 0 && estado != "-1")
            {
                query += " and estado = '" + estado + "'";
            }

            return GetTable(query);
        }
    }
}
