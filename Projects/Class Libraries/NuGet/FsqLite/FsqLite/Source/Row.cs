using FsqLite.Source.Extensions;
using System;
using System.Reflection;

namespace FsqLite.Source
{
    public class Row
    {
        public Type Type { get; set; }
        public Object Data { get; set; }
        public PropertyInfo[] Fields { get; private set; }

        public static Row Create(object instance, Type type)
        {
            var row = new Row()
            {
                Type = type,
                Data = instance,
                Fields = type.GetPropertiesOfAttribute(typeof(Field))
            };

            return row;
        }

        public T Cast<T>() where T : class
        {
            return Data as T;
        }

        public string[] ToStringArray()
        {
            var items = new string[Fields.Length];

            for (int i = 0; i < Fields.Length; i++)
            {
                var value = typeof(string).ConvertValue(Fields[i].GetValue(Data));

                items[i] = value != null ? value.ToString() : "";
            }

            return items;
        }
    }
}
