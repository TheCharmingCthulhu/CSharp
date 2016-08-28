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
        public int X { get; set; }
        public int Y { get; set; }
        public int Frames { get; set; }
        public Bitmap Texture { get; set; }
    }
}
