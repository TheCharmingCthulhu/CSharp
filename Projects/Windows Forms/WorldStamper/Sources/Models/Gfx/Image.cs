using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldStamper.Sources.Models
{
    class Image
    {
        public string Name { get; set; }
        public int SpriteWidth { get; set; }
        public int SpriteHeight { get; set; }
        public List<Sprite> Sprites { get; set; } = new List<Sprite>();

        public override string ToString()
        {
            return string.Format("{0} - {1} Sprites", Name, Sprites.Count);
        }
    }
}
