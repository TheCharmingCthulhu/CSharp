using System;
using System.Reflection;

namespace FsqLite.Source
{
    class Types
    {
        public static string GetDatabasePath()
        {
            return string.Format("{0}\\{1}.db", Environment.CurrentDirectory, Assembly.GetEntryAssembly().GetName().Name);
        }

        public static string GetConnectionString()
        {
            return string.Format("Data Source={0};", GetDatabasePath());
        }
    }
}
