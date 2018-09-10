using System;
using System.Collections.Generic;
using System.Text;

namespace Seguridad.Web.Models
{
    public class ContratosDM
    {
        private long p_id_contrato;

        public long id_contrato
        {
            get { return p_id_contrato; }
            set { p_id_contrato = value; }
        }

        private string p_rut_empresa;

        public string rut_empresa
        {
            get { return p_rut_empresa; }
            set { p_rut_empresa = value; }
        }

        private int p_duracion_contrato;

        public int duracion_contrato
        {
            get { return p_duracion_contrato; }
            set { p_duracion_contrato = value; }
        }

        private DateTime p_fecha_inic;

        public DateTime fecha_inic
        {
            get { return p_fecha_inic; }
            set { p_fecha_inic = value; }
        }

        private DateTime p_fecha_ter;

        public DateTime fecha_ter
        {
            get { return p_fecha_ter; }
            set { p_fecha_ter = value; }
        }

        private int p_max_usuarios;

        public int max_usuarios
        {
            get { return p_max_usuarios; }
            set { p_max_usuarios = value; }
        }

        private int p_max_trabajadores;

        public int max_trabajadores
        {
            get { return p_max_trabajadores; }
            set { p_max_trabajadores = value; }
        }

        private int p_mensualidad;

        public int mensualidad
        {
            get { return p_mensualidad; }
            set { p_mensualidad = value; }
        }

        private int p_estado;

        public int estado
        {
            get { return p_estado; }
            set { p_estado = value; }
        }

        public ContratosDM()
        {
            this.p_id_contrato = 0;
            this.p_rut_empresa = "";
            this.p_duracion_contrato = 0;
            this.p_fecha_inic = new DateTime(1900,01,01);
            this.p_fecha_ter = new DateTime(1900, 01, 01);
            this.p_max_usuarios = 0;
            this.p_max_trabajadores = 0;
            this.p_mensualidad = 0;
            this.p_estado = 0;
        }
    }
}
