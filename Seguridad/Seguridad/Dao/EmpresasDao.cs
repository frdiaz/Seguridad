using System;
using Seguridad.Base;
using Seguridad.Models;
using System.Collections.Generic;
using NHibernate.Expression;
using NHibernate;
using System.Data;

namespace Seguridad.Dao
{
    public class EmpresasDao : DBBase
    {
        private long p_id_empresa;
        private Empresas p_entidad;

        private static readonly EmpresasDao p_singleton = new EmpresasDao();

        static EmpresasDao()
        {

        }

        public static EmpresasDao GetInstance()
        {
            return p_singleton;
        }

        public EmpresasDao()
        {
            p_id_empresa = 0;
        }

        public EmpresasDao(long id)
        {
            p_id_empresa = id;
            p_entidad = null;
        }

        public Empresas GetEntidad()
        {
            if (p_entidad == null)
            {
                if (p_id_empresa > 0)
                {
                    p_entidad = (Empresas)Load<Empresas>(p_id_empresa);
                }
                if (p_entidad == null)
                {
                    p_entidad = new Empresas();
                }
            }
            return p_entidad;
        }

        public void Update()
        {
            base.Save<Empresas>(GetEntidad());
        }

        public void Update(Empresas mEntidad)
        {
            base.Save(mEntidad);
        }

        public IList<Empresas> ListAll()
        {
            return ListAll<Empresas>();
        }

        public DataTable ListarPorFiltros(string nombre, string rut, string estado)
        {
            string query = "SELECT id_empresa, rut_empresa, razon_social, " +
                        "nombre_fantasia, direccion, telefono_fijo_emp, telefono_cel_emp, " +
                        "email_emp, web, representante_legal, telefono_fijo_rep_legal, " +
                        "telefono_cel_rep_legal, email_rep_legal, codigo_actividad, logo, " +
                        "path_datos, estado, comuna, region, ciudad FROM empresas WHERE id_empresa > 0";

            if (GetParam(nombre).Length > 0)
            {
                query += " and nombre_fantasia like '%" + nombre + "%'";
            }

            if (GetParam(rut).Length > 0)
            {
                query += " and rut_empresa like '%" + rut + "%'";
            }

            if (GetParam(estado).Length > 0 && estado != "-1")
            {
                query += " and estado = " + estado + "";
            }

            return GetTable(query);
        }
    }
}
