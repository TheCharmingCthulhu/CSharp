using System.Collections.Generic;

namespace WorldStamper.Sources.Models.MapModules
{
    class Entity
    {
        public int ID { get; set; }
        public List<Sprite> Sprite { get; set; } = new List<Models.Sprite>();
    }
}
