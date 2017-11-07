using System;

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
