using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FsqLite.Source
{
    public class Column
    {
        public string Name { get; private set; }
        public Type Type { get; private set; }
        public Dictionary<string, string> Data { get; set; } = new Dictionary<string, string>();

        public Column(string name, Type type)
        {
            Name = name;
            Type = type;
        }
    }
}
