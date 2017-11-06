using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DBNullClasse
    {
        public static T DefaultDbNull<T>(this Object value, T defaultValue)
        {
            if (value == Convert.DBNull)
                return defaultValue;
            return (T)value;
        }

    }
}
