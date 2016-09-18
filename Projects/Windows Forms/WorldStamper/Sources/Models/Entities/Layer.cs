using System;
using System.Drawing;
using WorldStamper.Sources.Interfaces;

namespace WorldStamper.Sources.Models.Entities
{
    class Layer : ICompare
    {
        public enum LevelType
        {
            Foreground,
            Background
        }

        public string Name { get; set; }
        public LevelType Level { get; set; }
        public Point Offset { get; set; }

        public bool IsEqual<IResource>(IResource resource)
        { 
            if (resource is Layer)
            {
                var layer = resource as Layer;

                return layer.Name.Equals(Name) &&
                       layer.Level.Equals(Level) &&
                       layer.Offset.Equals(Offset);
            }

            return false;
        }
    }
}
