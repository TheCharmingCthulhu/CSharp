using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldStamper.Sources.Models
{
    class Sprite
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Frames { get; set; }
        public Bitmap Texture { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Sprite)
            {
                var sprite = obj as Sprite;

                if (sprite.ID == ID) return true;

                return  sprite.Name == Name &&
                        sprite.X == X &&
                        sprite.Y == Y &&
                        sprite.Frames == Frames;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
