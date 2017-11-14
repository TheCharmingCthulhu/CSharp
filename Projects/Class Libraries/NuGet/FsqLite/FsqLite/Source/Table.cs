using System;
using System.Collections.Generic;
using System.Reflection;
using FsqLite.Source.Extensions;

namespace FsqLite.Source
{
    public class Table
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public List<Column> Columns { get; private set; } = new List<Column>();
        public List<Row> Rows { get; private set; } = new List<Row>();

        public static Table Create(string name, Type type)
        {
            var table = new Table()
            {
                Name = name,
                Type = type
            };

            var columns = type.GetPropertiesOfAttribute(typeof(Field));

            foreach (PropertyInfo column in columns)
            {
                var attr = new Column(column.Name, column.PropertyType);

                attr.Data["type"] = column.GetCustomAttribute<Field>().Type;
                attr.Data["index"] = column.GetCustomAttribute<Index>() != null ? "PRIMARY KEY" : "";

                table.Columns.Add(attr);
            }

            return table;
        }

        public void Insert<T>(T instance) where T : class
        {
            var row = Row.Create(instance, typeof(T));
            var property = typeof(T).GetPropertiesOfAttribute(typeof(Index))[0];

            foreach (var item in Rows)
                if (property.GetValue(item.Data).GetHashCode() == property.GetValue(instance).GetHashCode())
                    return;

            Rows.Add(row);
        }

        internal string StatementCreate()
        {
            string input = "";

            foreach (Column column in Columns)
                input += string.Format("{0} {1} {2},", column.Name, column.Data["type"], column.Data["index"]);

            input = input.Remove(input.Length - 1);

            return string.Format("CREATE TABLE IF NOT EXISTS {0} ({1})", Name, input);
        }

        internal string StatementInsert(Row row)
        {
            return string.Format("INSERT OR IGNORE INTO {0} VALUES ('{1}')", Name, string.Join("','", row.ToStringArray()));
        }

        internal string StatementSelect(string[] columns = null, string expression = "")
        {
            if (columns == null)
            {
                string input = "";

                foreach (Column column in Columns)
                    input += column.Name + ",";

                input = input.Remove(input.Length - 1);

                return string.Format("SELECT {0} FROM {1}", input, Name);
            }
            else
            {
                if (!string.IsNullOrEmpty(expression))
                    return string.Format("SELECT {0} FROM {1} WHERE {2}", string.Join(",", columns), Name, expression);
                else
                    return string.Format("SELECT {0} FROM {1}", string.Join(",", columns), Name);
            }
        }
    }

    public class Tables
    {
        public delegate void TablesEventHandler(Table table);

        internal event TablesEventHandler Added; 

        List<object> _Tables = new List<object>();

        public Table Get(string name) 
        {
            return _Tables.Find(t => (t as Table).Name.Equals(name)) as Table;
        }

        public bool Contains(Table table) 
        {
            return Get(table.Name) != null;
        }

        public void Add(Table table)
        {
            _Tables.Add(table);

            Added?.Invoke(table);
        }

        public void Create(string name, Type type)
        {
            Add(Table.Create(name, type));
        }
    }
}
