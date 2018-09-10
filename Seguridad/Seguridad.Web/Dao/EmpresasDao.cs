using System;
using Seguridad.Web.Base;
using Seguridad.Web.Models;
using System.Collections.Generic;
using NHibernate.Expression;
using NHibernate;
using System.Data;

namespace Seguridad.Web.Dao
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
            string query = "SELECT  E.id_empresa as 'idempresa', " +
                            "U.id_usuario as 'idusuario', " +
                            "UEP.id_usuario_empresa as 'idusuarioempresa', " +
                "C.id_contrato as 'idcontrato', " +
                "UEP.id_usuario_empresa as 'idUsuarioEmpresaPerfil', "+
                "E.nombre_fantasia as 'nombreEmpresa', " +
                "E.rut_empresa as 'rutEmpresa', " +
                "C.fecha_inic as 'fechaInicial', " +
                "C.fecha_ter as 'fechaTermino', " +
                "C.max_usuarios as 'maximoUsuarios', " +
                "C.max_trabajadores as 'maximoTrabajadores', " +
                "C.estado as 'estadoContrato' " +
                "FROM empresas E " +
                "INNER JOIN usuarios U ON E.id_usuario_administrador = U.id_usuario " +
                "INNER JOIN usuario_empresa_perfil UEP ON E.id_usuario_administrador = UEP.id_usuario_empresa " +
                "INNER JOIN contratos_dm C ON E.rut_empresa = C.rut_empresa " +
                "WHERE C.estado > 0 ";

            if (GetParam(nombre).Length > 0)
            {
                query += " and E.nombre_fantasia like '%" + nombre + "%'";
            }

            if (GetParam(rut).Length > 0)
            {
                query += " and E.rut_empresa like '%" + rut + "%'";
            }

            if (GetParam(estado).Length > 0 && estado != "-1")
            {
                query += " and E.estado = " + estado + "";
            }

                query += "ORDER BY fechaTermino ASC";
            return GetTable(query);
        }
    }
}
