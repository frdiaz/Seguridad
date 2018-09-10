using System;
using MYR.Core;

namespace Seguridad.Web.Base
{
    public class DBBase : DBCore
    {
        public DBBase()
        {
            this.ConfigureNHibernate(typeof(Seguridad.Web.Models.Usuarios).Assembly);
        }
    }
}
