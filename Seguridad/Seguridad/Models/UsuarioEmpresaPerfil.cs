using System;
using System.Collections.Generic;
using System.Text;

namespace Seguridad.Models
{
    public class UsuarioEmpresaPerfil
    {
        private long p_id_usuario_empresa;

        public long id_usuario_empresa
        {
            get { return p_id_usuario_empresa; }
            set { p_id_usuario_empresa = value; }
        }

        private string p_rut_empresa;

        public string rut_empresa
        {
            get { return p_rut_empresa; }
            set { p_rut_empresa = value; }
        }

        private string p_rut_usuario;

        public string rut_usuario
        {
            get { return p_rut_usuario; }
            set { p_rut_usuario = value; }
        }

        private long p_id_perfil;

        public long id_perfil
        {
            get { return p_id_perfil; }
            set { p_id_perfil = value; }
        }

        private int p_estado;

        public int estado
        {
            get { return p_estado; }
            set { p_estado = value; }
        }

        public UsuarioEmpresaPerfil()
        {
            this.p_id_usuario_empresa = 0;
            this.p_rut_empresa = "";
            this.p_rut_usuario = "";
            this.p_id_perfil = 0;
            this.p_estado = 1;
        }
    }
}
