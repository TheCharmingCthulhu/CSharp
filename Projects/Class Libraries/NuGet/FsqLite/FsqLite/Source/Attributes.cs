using System;

namespace FsqLite.Source
{
    public class Index : Attribute
    {

    }

    public class Field : Attribute
    {
        public string Type { get; private set; }

        public Field(string type)
        {
            Type = type;
        }
    }
}
