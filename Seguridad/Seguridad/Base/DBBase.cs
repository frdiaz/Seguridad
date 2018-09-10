using System;
using MYR.Core;

namespace Seguridad.Base
{
    public class DBBase : DBCore
    {
        public DBBase()
        {
            this.ConfigureNHibernate(typeof(Models.super_administrador).Assembly);
        }
    }
}
