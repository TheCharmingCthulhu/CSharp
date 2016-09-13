using System;
using System.Xml;

namespace WorldStamper.Sources.Extensions
{
    static class XMLExtensions
    {
        public static T ToValue<T>(this XmlNode node)
        {
            return (T)Convert.ChangeType(node.Value, typeof(T));
        }

        public static bool HasNode(this XmlNodeList nodes, string name)
        {
            return FindNode(nodes, name) != null;
        }

        public static XmlNode FindNode(this XmlNodeList nodes, string name)
        {
            foreach (XmlNode node in nodes)
                if (node.Name.ToLower().Equals(name))
                    return node;

            return null;
        }
    }
}
