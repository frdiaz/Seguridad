using System;
using System.Globalization;

namespace Seguridad.Util
{
    public class ParamUtil
    {
        public static string GetParamString(Object valor, string valordefault)
        {
            string valueReturn = valordefault;
            if (valor != null)
            {
                valueReturn = valor.ToString();
            }
            else
            {
                valueReturn = valordefault;
            }
            return valueReturn;
        }

        public static long GetParamLong(Object valor, long valordefault)
        {
            long valueReturn = valordefault;
            if (valor != null)
            {
                try
                {
                    valueReturn = Convert.ToInt32(valor);
                }
                catch (Exception ex)
                {
                    valueReturn = valordefault;
                }
            }
            return valueReturn;
        }

        public ParamUtil()
        {
            
        }
    }
}
