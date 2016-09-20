using System;
using System.Collections.Generic;
using WorldStamper.Sources.Interfaces;

namespace WorldStamper.Sources.Models.Entities
{
    class Template : ICompare
    {
        public string Name { get; set; }
        public List<Layer> Layers { get; set; } = new List<Layer>();

        public bool IsEqual(IResource resource)
        {
            if (resource is Template)
            {
                var template = resource as Template;

                foreach (var layer in template.Layers)
                    if (!Layers.Contains(layer))
                        return false;

                return template.Name.Equals(Name);
            }

            return false;
        }

        public bool HasEqualKey(IResource resource)
        {
            if (resource is Template)
                return (resource as Template).Name.Equals(Name);

            return false;
        }

        public override string ToString()
        {
            return Name;
        }        
    }
}
