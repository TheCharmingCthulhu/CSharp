using System;
using System.Linq;
using System.Reflection;

namespace FsqLite.Source.Extensions
{
    public static class TypeHelper
    {
        public static PropertyInfo[] GetPropertiesOfAttribute(this Type type, params Type[] attributes)
        {
            return type.GetProperties().Where(x => {
                foreach (var attribute in attributes)
                    if (x.GetCustomAttribute(attribute) == null)
                        return false;

                return true;
            }).ToArray();
        }

        public static object ConvertValue(this Type type, object value)
        {
            if(type == typeof(string))
                if (value is TimeSpan)
                    return ((TimeSpan)value).TotalSeconds;

            if (type == typeof(TimeSpan))
                if (value is double)
                    return TimeSpan.FromSeconds((double)value);
            
            return Convert.ChangeType(value, type);
        }
    }
}
