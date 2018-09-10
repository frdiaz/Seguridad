using System;
using Seguridad.Web.Base;
using Seguridad.Web.Models;
using System.Collections.Generic;

namespace Seguridad.Web.Dao
{
    public class UsuarioEmpresaPerfilDao : DBBase
    {
        private long p_id_usuario_empresa_perfil;
        private UsuarioEmpresaPerfil p_entidad;

        private static readonly UsuarioEmpresaPerfilDao p_singleton = new UsuarioEmpresaPerfilDao();

        static UsuarioEmpresaPerfilDao()
        {

        }

        public static UsuarioEmpresaPerfilDao GetInstance()
        {
            return p_singleton;
        }

        public UsuarioEmpresaPerfilDao()
        {
            p_id_usuario_empresa_perfil = 0;
        }

        public UsuarioEmpresaPerfilDao(long id)
        {
            p_id_usuario_empresa_perfil = id;
            p_entidad = null;
        }

        public UsuarioEmpresaPerfil GetEntidad()
        {
            if (p_entidad == null)
            {
                if (p_id_usuario_empresa_perfil > 0)
                {
                    p_entidad = (UsuarioEmpresaPerfil)Load<UsuarioEmpresaPerfil>(p_id_usuario_empresa_perfil);
                }
                if (p_entidad == null)
                {
                    p_entidad = new UsuarioEmpresaPerfil();
                }
            }
            return p_entidad;
        }

        public void Update()
        {
            base.Save<UsuarioEmpresaPerfil>(GetEntidad());
        }

        public void Update(UsuarioEmpresaPerfil mEntidad)
        {
            base.Save(mEntidad);
        }

        public IList<UsuarioEmpresaPerfil> ListAll()
        {
            return ListAll<UsuarioEmpresaPerfil>();
        }
    }
}
