using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using FsqLite.Source.Extensions;
using System.Reflection;

namespace FsqLite.Source
{
    public class Database
    {
        public Tables Tables { get; set; } = new Tables();

        SQLiteConnection Connection { get; set; }

        public Database()
        {
            if (!File.Exists(Types.GetDatabasePath()))
                SQLiteConnection.CreateFile(Types.GetDatabasePath());

            try
            {
                Connection = new SQLiteConnection(Types.GetConnectionString());
                Connection.Open();
            }
            catch (DllNotFoundException)
            {
                throw new Exception("Missing \"System.Data.SQLite\": Package must be referenced \\ installed before using FsqLite! (NuGet: \"System.Data.SQLite.Core\")");
            }

            Tables.Added += Tables_Added;
        }

        private void Tables_Added(Table table)
        {
            Commit(table.StatementCreate());
        }

        private int Commit(string command, CommandType type = CommandType.Text)
        {
            var statement = Connection.CreateCommand();
            statement.CommandText = command;
            statement.CommandType = type;

            return statement.ExecuteNonQuery();
        }

        private SQLiteDataReader Query(string command, CommandType type = CommandType.Text)
        {
            var statement = Connection.CreateCommand();
            statement.CommandText = command;
            statement.CommandType = type;

            return statement.ExecuteReader();
        }

        public bool ExecuteInsert(string tableName) 
        {
            var table = Tables.Get(tableName);
            bool result = true;

            foreach (Row row in table.Rows)
                if (Commit(table.StatementInsert(row)) <= 0)
                    result = false;

            return result;
        }

        public bool ExecuteQuery(string tableName) 
        {
            var table = Tables.Get(tableName);

            table.Rows.Clear();

            using (var reader = Query(table.StatementSelect()))
            {
                var fields = table.Type.GetPropertiesOfAttribute(typeof(Field));

                while (reader.Read())
                {
                    var instance = Activator.CreateInstance(table.Type);

                    for (int i = 0; i < fields.Length; i++)
                        fields[i].SetValue(instance, fields[i].PropertyType.ConvertValue(reader.GetValue(i)));

                    table.Rows.Add(Row.Create(instance, table.Type));
                }

                return table.Rows.Count > 0;
            }
        }
    }
}
